using BCrypt.Net;
using ProjetoVenda.Model;
using ProjetoVenda.Repository;
using ProjetoVenda.View;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoVenda.Controller
{
    internal class EmployeeController
    {
        private EmployeeRepository repository;
        public EmployeeController()
        {
            repository = new EmployeeRepository();
        }

        public List<Employee> getAll()
        {
            return repository.getAll();
        }

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

        public bool createEmployee(Employee funcionario)
        {
            // fazer verificação se o usuario não existe
            // solicitar ao respository se o usuario existe ou nao
            EmployeeRepository respository = new EmployeeRepository();
            Employee? resp = respository.GetByUsername(funcionario.usuario);

            if (resp != null)
            {
                return false;
            }

            string hash = BCrypt.Net.BCrypt.HashPassword(funcionario.senha);
            funcionario.senha = hash;

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

        public bool usuarioAdministrador()
        {
            if (Session.userAuth == null)
            {
                return false;
            }
            return Session.userAuth.adm;
        }
    }
}
