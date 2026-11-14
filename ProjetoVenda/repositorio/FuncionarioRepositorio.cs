using ProjetoVenda.bancodedados;
using MySqlConnector;
using ProjetoVenda.modelo;
using System;
using System.Collections.Generic;
using System.Text;




namespace ProjetoVenda.repositorio
{
    internal class FuncionarioRepositorio
    {
        private Funcionario mapear(MySqlDataReader cursor)
        {
            return new Funcionario
            {
                cod_funcionario = cursor.GetInt32("cod_funcionario"),
                nome = cursor.GetString("nome"),
                usuario = cursor.GetString("usuario"),
                senha = cursor.GetString("senha"),
                telefone = cursor.GetString("telefone"),
                rua = (cursor.IsDBNull(cursor.GetOrdinal("rua"))) ? null : cursor.GetString("rua"),
                numero = cursor.GetString("numero"),
                complemento = (cursor.IsDBNull(cursor.GetOrdinal("complemento"))) ? null : cursor.GetString("complemento"),
                cep = cursor.GetString("cep"),
                adm = cursor.GetBoolean("adm")
            };
        }


        public Funcionario? pegarPorNomeDeFuncionario(string nomeDoUsuario)
        {
            using MySqlConnection conector = BancoDeDados.conexao();
            string sql = "SELECT * FROM funcionario WHERE usuario = @username";
            using MySqlCommand cmd = new MySqlCommand(sql, conector);
            cmd.Parameters.AddWithValue("@username", nomeDoUsuario); // ele retorna um valor
            using var cursor = cmd.ExecuteReader(); // lê as respostas do banco de dados
            if (cursor.Read())
            {
                return mapear(cursor);
            }
            return null;
        }


        public List<Funcionario> listarFuncionario()
        {
            using MySqlConnection conector = BancoDeDados.conexao();
            string sql = "SELECT * FROM funcionario";
            using MySqlCommand cmd = new MySqlCommand(sql, conector);
            using var cursor = cmd.ExecuteReader();

            List<Funcionario> list = new List<Funcionario>();
            while (cursor.Read())
            {
                list.Add(mapear(cursor));
            }
            return list;
        }

        public int criarFuncionario(Funcionario funcionario)
        {
            using MySqlConnection conector = BancoDeDados.conexao();
            string sql = @"INSERT INTO funcionario
                (nome, usuario, senha, telefone, rua, numero, complemento, cep, adm) 
                VALUES 
                (@nome, @usuario, @senha, @telefone, @rua, @numero, @complemento, @cep, @adm)";
            using MySqlCommand cmd = new MySqlCommand(sql, conector);
            cmd.Parameters.AddWithValue("@nome", funcionario.nome);
            cmd.Parameters.AddWithValue("@usuario", funcionario.usuario);
            cmd.Parameters.AddWithValue("@senha", funcionario.senha);
            cmd.Parameters.AddWithValue("@telefone", funcionario.telefone);
            cmd.Parameters.AddWithValue("@rua", funcionario.rua);
            cmd.Parameters.AddWithValue("@numero", funcionario.numero);
            cmd.Parameters.AddWithValue("@complemento", funcionario.complemento);
            cmd.Parameters.AddWithValue("@cep", funcionario.cep);
            cmd.Parameters.AddWithValue("@adm", funcionario.adm);
            cmd.ExecuteNonQuery();
            return (int)cmd.LastInsertedId;
        }
    }
}
