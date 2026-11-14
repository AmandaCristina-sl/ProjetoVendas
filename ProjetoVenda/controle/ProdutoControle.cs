using ProjetoVenda.modelo;
using ProjetoVenda.repositorio;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoVenda.controle
{
    internal class ProdutoControle
    {
        private ProdutoRepositorio repositorio;

        //MÉTODO CONSTRUTOR
        public ProdutoControle()
        {
            repositorio = new ProdutoRepositorio();
        }

        public bool criarProduto(Produto produto)
        {
            int cod_funcionario = Sessao.usuarioAutenticado.cod_funcionario;
            produto.cod_funcionario = cod_funcionario;
            // validação do produto
            produto.validar();
            // chamar a respository
            repositorio.criarProduto(produto);
            return true;
        }

        public List<Produto> ListarProdutos()
        {
            return repositorio.listarProdutos();
        }

        public List<Produto> listarPorPagina(int qtd, int pagina)
        {
            return repositorio.listarPorPagina(qtd, pagina);
        }

        public int quantidadePaginas(int quantidadeItens)
        {
            int quantidadeDeprodutos = repositorio.quantidadeProdutos();
            return (int)Math.Ceiling((decimal)quantidadeDeprodutos / quantidadeItens);

        }

        public bool atualizar(Produto produto)
        {
            // falta adicionar regras de validação
            return repositorio.atualizar(produto);
        }

        public bool excluir(Produto produto)
        {
            // falta adicionar regras de validação
            return repositorio.excluir(produto.cod_produto);
        }


    }
}
