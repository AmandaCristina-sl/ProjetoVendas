using BCrypt.Net;
using ProjetoVenda.Model;
using ProjetoVenda.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoVenda.Controller
{
    internal class EmployeeController
    {


        public static bool login(string username, string password)
        {
            EmployeeRepository respository = new EmployeeRepository();
            Employee? resp = respository.GetByUsername(username);

            if (resp == null)
            {
                return false;
            }

            bool validatePassword;
            try
            {
                validatePassword = BCrypt.Net.BCrypt.Verify(password, resp.senha);
            }catch (Exception ex)
            {
                validatePassword = false;
            }

            if (!validatePassword)
            {
                return false;
            }

            // gravar os dados do usuário logado!!!!!
            Session.userAuth = resp;
            return true;
            
          

        }

        public bool createEmployee(string nome, string telefone, string rua, 
            string numero, string cep, string complemento, 
            string usuario, string senha)
        {
            // fazer verificação se o usuario não existe
            // solicitar ao respository se o usuario existe ou nao
            EmployeeRepository respository = new EmployeeRepository();
            Employee? resp = respository.GetByUsername(usuario);

            if (resp != null)
            {
                return false;
            }

            string hash = BCrypt.Net.BCrypt.HashPassword(senha);
            Employee funcionario = new Employee
            {
                nome = nome,
                telefone = telefone,
                rua = rua,
                numero = numero,
                cep = cep,
                complemento = complemento,
                usuario = usuario,
                senha = hash
            };
            respository.createEmployee(funcionario);
            return true;

        }

        public void deslogar()
        {
            Session.userAuth = null;
        }

        public Employee? usuarioAutenticado()
        {
            return Session.userAuth;
        }
    }
}
