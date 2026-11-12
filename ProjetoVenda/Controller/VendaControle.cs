using ProjetoVenda.Model;
using ProjetoVenda.Repository;
using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace ProjetoVenda.Controller
{
    internal class VendaControle
    {
        EmployeeController employeeController;
        VendaRepositorio vendaRepositorio;

        // construtor
        public VendaControle()
        {
            employeeController = new EmployeeController();
            vendaRepositorio = new VendaRepositorio();

        }

        public bool cadastrarVenda(List<Item> itens)
        {
            Employee? funcionario = employeeController.usuarioAutenticado();
            if (funcionario == null)
            {
                throw new Exception("Usuário não autenticado!!");
            }
            int cod_funcionario = funcionario.cod_funcionario;
            Venda venda = new Venda 
            {
                cod_funcionario = cod_funcionario,
                itens = itens
            };

            // enviar para a repository
            vendaRepositorio.cadastrarVenda(venda);
            return true;
        }


    }
}
