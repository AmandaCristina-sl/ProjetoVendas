using BCrypt.Net;
using ProjetoVenda.modelo;
using ProjetoVenda.repositorio;
using ProjetoVenda.formulario;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoVenda.controle
{
    internal class FuncionarioControle
    {
        private FuncionarioRepositorio repositorio;
        public FuncionarioControle()
        {
            repositorio = new FuncionarioRepositorio();
        }

        public List<Funcionario> listarFuncionarios()
        {
            return repositorio.listarFuncionario();
        }

        public static bool autenticar(string nomeDoUsuario, string senha)
        {
            FuncionarioRepositorio repositorio = new FuncionarioRepositorio();
            Funcionario? funcionario = repositorio.pegarPorNomeDeFuncionario(nomeDoUsuario);

            if (funcionario == null)
            {
                return false;
            }

            bool validacaoDaSenha;
            try
            {
                validacaoDaSenha = BCrypt.Net.BCrypt.Verify(senha, funcionario.senha);
            }catch (Exception ex)
            {
                validacaoDaSenha = false;
            }

            if (!validacaoDaSenha)
            {
                return false;
            }

            // gravar os dados do usuário logado!!!!!
            Sessao.usuarioAutenticado = funcionario;
            return true;
            
          

        }

        public bool criarFuncionario(Funcionario funcionario)
        {
            // fazer verificação se o usuario não existe
            // solicitar ao repositorio se o usuario existe ou nao
            FuncionarioRepositorio repositorio = new FuncionarioRepositorio();
            Funcionario? resposta = repositorio.pegarPorNomeDeFuncionario(funcionario.usuario);

            if (resposta != null)
            {
                return false;
            }

            string senhaCriptografada = BCrypt.Net.BCrypt.HashPassword(funcionario.senha);
            funcionario.senha = senhaCriptografada;

            repositorio.criarFuncionario(funcionario);
            return true;

        }


        public void deslogar()
        {
            Sessao.usuarioAutenticado = null;
        }

        public Funcionario? usuarioAutenticado()
        {
            return Sessao.usuarioAutenticado;
        }

        public bool usuarioAdministrador()
        {
            if (Sessao.usuarioAutenticado == null)
            {
                return false;
            }
            return Sessao.usuarioAutenticado.adm;
        }
    }
}
