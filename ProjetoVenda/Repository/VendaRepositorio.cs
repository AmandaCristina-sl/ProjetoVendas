using MySqlConnector;
using ProjetoVenda.dataBase;
using ProjetoVenda.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoVenda.Repository
{
    internal class VendaRepositorio
    {
        public bool cadastrarVenda(Venda venda)
        {
            using MySqlConnection conector = DataBase.GetConnection();
            using MySqlTransaction transacao = conector.BeginTransaction();
            try
            {
                // bloqueio dos produtos
                foreach (Item item in venda.itens.OrderBy(item => item.cod_produto))
                {
                    string sqlBloqueioProduto = @"SELECT * FROM produto 
                    WHERE cod_produto = @cod_produto FOR UPDATE";
                    using MySqlCommand cmdBloqueioProduto = new MySqlCommand(sqlBloqueioProduto, conector, transacao);
                    cmdBloqueioProduto.Parameters.AddWithValue("@cod_produto", item.cod_produto);
                    using MySqlDataReader reader = cmdBloqueioProduto.ExecuteReader();
                    if (!reader.Read())
                    {
                        throw new Exception("Erro no Registro!!");
                    }
                    int quantidade = reader.GetInt32("quantidade");
                    if (quantidade < item.quantidade)
                    {
                        throw new Exception($"Quantidade indisponível no Estoque do Produto: {item.nomeProduto}!!");

                    }
                }

                // criar a registração da venda
                string sqlRegistroVenda = @"INSERT INTO venda (cod_funcionario) 
                VALUES (@cod_funcionario)";
                using MySqlCommand cmdRegistroVenda = new MySqlCommand(sqlRegistroVenda, conector, transacao);
                cmdRegistroVenda.Parameters.AddWithValue("@cod_funcionario", venda.cod_funcionario);
                cmdRegistroVenda.ExecuteNonQuery();
                venda.cod_venda = (int)cmdRegistroVenda.LastInsertedId;


                // criar a registração dos itens
                foreach (Item item in venda.itens)
                {
                    string sqlRegistroItem = @"INSERT INTO itens 
                    (cod_venda, cod_produto, quantidade, preco) 
                    VALUES
                    (@cod_venda, @cod_produto, @quantidade, @preco)";
                    using MySqlCommand cmdRegistroItem = new MySqlCommand(sqlRegistroItem, conector, transacao);
                    cmdRegistroItem.Parameters.AddWithValue("@cod_venda", venda.cod_venda);
                    cmdRegistroItem.Parameters.AddWithValue("@cod_produto", item.cod_produto);
                    cmdRegistroItem.Parameters.AddWithValue("@quantidade", item.quantidade);
                    cmdRegistroItem.Parameters.AddWithValue("@preco", item.preco);
                    int linhaAlterada = cmdRegistroItem.ExecuteNonQuery();
                    if (linhaAlterada != 1) 
                    {
                        throw new Exception($"Erro ao Cadastrar o Produto:7 {item.nomeProduto}!!");
                    }

                    // criar a atualização de sáida dos produtos (quantidade)
                    string sqlQuantidadeProduto = @"UPDATE produto SET 
                        quantidade = quantidade - @quantidade
                        WHERE cod_produto = @cod_produto ";
                    using MySqlCommand cmdQuantidadeProduto = new MySqlCommand(sqlQuantidadeProduto, conector, transacao);
                    cmdQuantidadeProduto.Parameters.AddWithValue("@quantidade", item.quantidade);
                    cmdQuantidadeProduto.Parameters.AddWithValue("@cod_produto", item.cod_produto);
                    linhaAlterada = cmdQuantidadeProduto.ExecuteNonQuery();
                    if (linhaAlterada != 1)
                    {
                        throw new Exception($"Erro ao Atualizar a Quantidade do Produto: {item.nomeProduto}!!");
                    }
                }
                // Se der tudo certo, deverá comitar a venda
                transacao.Commit();
                return true;
            }
            catch (Exception ex)
            {
                transacao.Rollback();
                throw ex;
            }
            
        }
    }
}
