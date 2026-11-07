using ProjetoVenda.Controller;
using ProjetoVenda.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProjetoVenda.View
{
    public partial class frmCadastroVenda : Form
    {

        private ProductController produtoControle;

        public frmCadastroVenda()
        {
            InitializeComponent();
            produtoControle = new ProductController();
        }

        private void carregarProdutos()
        {
            List<Product> lista = produtoControle.ListarProdutos();
            cbxProdutos.DataSource = lista;
            cbxProdutos.DisplayMember = "nome";
            cbxProdutos.ValueMember = "cod_produto";

        }

        private void frmCadastroVenda_Load(object sender, EventArgs e)
        {
            carregarProdutos();
        }

        private void cbxProdutos_SelectedIndexChanged(object sender, EventArgs e)
        {
            Product produto = cbxProdutos.SelectedItem as Product;
            this.lblPreco.Text = $"Preço Unitário: {produto.preco}";
            this.lblQuantidade.Text = $"Quantidade disponível: {produto.quantidade}";
            this.numQuantidade.Maximum = produto.quantidade;
            this.numQuantidade.Value = (this.numQuantidade.Maximum>0)? 1: 0; // ternário
        }
    }
}
