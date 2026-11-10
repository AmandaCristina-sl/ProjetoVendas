using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoVenda.Model
{
    internal class Item
    {

        public int cod_itens {  get; set; }
        public int cod_produto { get; set; }
        public int cod_venda { get; set; }
        public int quantidade { get; set; }
        public int preco { get; set; }
        // informações a mais por conta do carrinho, são os nossos extras.
        public string nomeProduto { get; set; }
        public string marcaProduto {  get; set; }

        public decimal precoReal => preco / 100m;
        public decimal subTotal => precoReal * quantidade;
    }
}
