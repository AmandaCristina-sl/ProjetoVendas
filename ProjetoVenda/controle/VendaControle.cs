using ProjetoVenda.modelo;
using ProjetoVenda.repositorio;
using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace ProjetoVenda.controle
{
    internal class VendaControle
    {
        FuncionarioControle funcionarioControle;
        VendaRepositorio vendaRepositorio;

        // construtor
        public VendaControle()
        {
            funcionarioControle = new FuncionarioControle();
            vendaRepositorio = new VendaRepositorio();

        }

        public bool cadastrarVenda(List<Item> itens)
        {
            Funcionario? funcionario = funcionarioControle.usuarioAutenticado();
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

            // enviar para a repositorio
            vendaRepositorio.cadastrarVenda(venda);
            return true;
        }

        public List<Venda> listarVendaMes(int mes, int ano)
        {
            if (mes > 12 || mes < 1)
            {
                throw new Exception("MÊS INVÁLIDO, DIGITE UM MÊS VÁLIDO");
            }
            return vendaRepositorio.listarVendaMes(mes, ano);
        }

    }
}
