using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoVenda.Model
{
    internal class Product
    {
        public int cod_produto { get; set; }
        public int cod_funcionario { get; set; }
        public string nome { get; set; }
        public string marca { get; set; }
        public int preco { get; set; }
        public int quantidade { get; set; }
        public DateTime data_registro { get; set; }

        public decimal precoReal => this.preco / 100m;
        // aqui o "maior e igual" estará como se sempre voltasse o valor real, ou seja, fará o "calculo" primeiro e depois voltará o valor que deve ser.
       

        public void validar()
        {
            if (preco <= 0)
            {
                throw new ArgumentException("O Preço não deve ser Zerado ou Negativo!!");
            }
            if (quantidade < 0)
            {
                throw new ArgumentException("A Quantidade não deve ser Negativa!!");
            }
        }
    }
}
