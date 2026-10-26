using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoVenda.dataBase
{

    // classe de conexão
    internal static class DataBase
    {
        private static string stringConnection;
        


        static DataBase()
        {
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder 
            { 
                Server = "localhost",
                Port = 3306,
                Database = "db_vendas",
                UserID = "root",
                Password = ""
            };
            stringConnection = builder.ConnectionString;
        }

   
        public static MySqlConnection GetConnection()
        {
            MySqlConnection connection = new MySqlConnection(stringConnection);
            try
            {
                //tenta fazer algo
                connection.Open();
                return connection;
            }
            catch (MySqlException ex)
            {
                // se deu errado eu faço as coisas
                connection.Dispose();
                throw;

            }
        }
    }
}
