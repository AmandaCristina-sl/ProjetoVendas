using MySqlConnector;
using ProjetoVenda.bancodedados;
using ProjetoVenda.modelo;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoVenda.repositorio
{
    internal class VendaRepositorio
    {
        public bool cadastrarVenda(Venda venda)
        {
            using MySqlConnection conector = BancoDeDados.conexao();
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
                    using MySqlDataReader cursor = cmdBloqueioProduto.ExecuteReader();
                    if (!cursor.Read())
                    {
                        throw new Exception("Erro no Registro!!");
                    }
                    int quantidade = cursor.GetInt32("quantidade");
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

        public List<Venda> listarVendaMes(int mes, int ano)
        {
            DateTime dataInicial = new DateTime(ano, mes, 1);
            DateTime dataFinal = dataInicial.AddMonths(1);

            string sql = @"SELECT 
	        venda.*,
            funcionario.nome AS nome_funcionario,
            itens.*,
            produto.nome,
            produto.marca
             FROM venda
            JOIN funcionario
            ON funcionario.cod_funcionario = venda.cod_funcionario
            JOIN itens
            ON itens.cod_venda = venda.cod_venda
            JOIN produto
            ON produto.cod_produto = itens.cod_produto
            WHERE venda.data >= @dataInicial AND venda.data < @dataFinal
            ORDER BY venda.data, venda.cod_venda, produto.cod_produto;";
            MySqlConnection conexao = BancoDeDados.conexao();
            MySqlCommand comando = new MySqlCommand(sql, conexao);
            comando.Parameters.AddWithValue("@dataInicial", dataInicial);
            comando.Parameters.AddWithValue("@dataFinal", dataFinal);

            MySqlDataReader cursor = comando.ExecuteReader();
            List<Venda> listaDeVenda = new List<Venda>();


            while (cursor.Read())
            {
                int cod_venda = cursor.GetInt32("cod_venda");
                Venda? venda = listaDeVenda.Find(venda => venda.cod_venda == cod_venda);

                if (venda == null)
                {
                    venda = new Venda
                    {
                        cod_venda = cursor.GetInt32("cod_venda"),
                        cod_funcionario = cursor.GetInt32("cod_funcionario"),
                        data = cursor.GetDateTime("data"),
                        nomeFuncionario = cursor.GetString("nome_funcionario")
                    };
                    listaDeVenda.Add(venda);
                }

                if (!cursor.IsDBNull(cursor.GetOrdinal("cod_itens")))
                {
                    Item item = new Item 
                    { 
                        cod_itens = cursor.GetInt32("cod_itens"),
                        cod_venda = cod_venda,
                        cod_produto = cursor.GetInt32("cod_produto"),
                        quantidade = cursor.GetInt32("quantidade"),
                        preco = cursor.GetInt32("preco"),
                        nomeProduto = cursor.GetString("nome"),
                        marcaProduto = cursor.GetString("marca")
                    };
                    venda.itens.Add(item);
                }
            }
            return listaDeVenda;
           
        }
    }
}
