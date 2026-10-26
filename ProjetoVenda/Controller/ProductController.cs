using ProjetoVenda.Model;
using ProjetoVenda.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoVenda.Controller
{
    internal class ProductController
    {
        private ProductRepository repository;

        //MÉTODO CONSTRUTOR
        public ProductController()
        {
            repository = new ProductRepository();
        }

        public bool createProduct(Product product)
        {
            int cod_funcionario = Session.userAuth.cod_funcionario;
            product.cod_funcionario = cod_funcionario;
            // chamar a respository
            repository.createProduct(product);
            return true;
        }

        public List<Product> getAll()
        {
            return repository.getAll();
        }

        public bool atualizar(Product product)
        {
            // falta adicionar regras de validação
            return repository.atualizar(product);
        }

        public bool excluir(Product product)
        {
            // falta adicionar regras de validação
            return repository.excluir(product.cod_produto);
        }


    }
}
