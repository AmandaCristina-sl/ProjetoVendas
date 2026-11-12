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
        private VendaControle vendaControle;
        private List<Item> carrinho = new List<Item>(); // aqui de fato será a nosta lista de produtos do carrinho.

        public frmCadastroVenda()
        {
            InitializeComponent();
            produtoControle = new ProductController();
            vendaControle = new VendaControle();
        }

        private void carregarProdutos()
        {
            List<Product> lista = produtoControle.ListarProdutos();
            cbxProdutos.DataSource = lista;
            cbxProdutos.DisplayMember = "nome";
            cbxProdutos.ValueMember = "cod_produto";

        }

        private void configurarCarrinho()
        {
            this.dgvCarrinho.AutoGenerateColumns = false;
            this.dgvCarrinho.Columns.Clear();
            this.dgvCarrinho.Columns.Add(
                new DataGridViewTextBoxColumn
                {
                    HeaderText = "Produto",
                    Name = "colunaProduto",
                    DataPropertyName = "nomeProduto",
                });
            this.dgvCarrinho.Columns.Add(
                new DataGridViewTextBoxColumn
                {
                    HeaderText = "Marca",
                    Name = "colunaMarca",
                    DataPropertyName = "marcaProduto",
                });
            this.dgvCarrinho.Columns.Add(
                new DataGridViewTextBoxColumn
                {
                    HeaderText = "Quantidade",
                    Name = "colunaQuantidade",
                    DataPropertyName = "quantidade",
                });
            this.dgvCarrinho.Columns.Add(
                new DataGridViewTextBoxColumn
                {
                    HeaderText = "Preço Unitário",
                    Name = "colunaPreco",
                    DataPropertyName = "precoReal",
                    DefaultCellStyle = new DataGridViewCellStyle
                    {
                        Format = "C2"
                    }
                });
            this.dgvCarrinho.Columns.Add(
                new DataGridViewTextBoxColumn
                {
                    HeaderText = "Sub total",
                    Name = "colunaSubTototal",
                    DataPropertyName = "subTotal",
                    DefaultCellStyle = new DataGridViewCellStyle
                    {
                        Format = "C2"
                    }
                });
        }

        public void atualizarCarrinho()
        {
            this.dgvCarrinho.DataSource = this.carrinho.ToList();
            this.btnCadastrarVenda.Enabled = this.carrinho.Count() > 0;
            decimal total = this.carrinho.Sum(item => item.subTotal);
            this.lblTotalVenda.Text = $"Valor Total: {total:C2}";
        }

        private void frmCadastroVenda_Load(object sender, EventArgs e)
        {
            carregarProdutos();
            configurarCarrinho();
            atualizarCarrinho();
        }


        private void cbxProdutos_SelectedIndexChanged(object sender, EventArgs e)
        {
            Product produto = cbxProdutos.SelectedItem as Product;
            this.lblPreco.Text = $"Preço Unitário: {produto.precoReal:C2}";
            this.lblQuantidade.Text = $"Quantidade disponível: {produto.quantidade}";
            this.numQuantidade.Maximum = produto.quantidade;
            this.numQuantidade.Value = (this.numQuantidade.Maximum > 0) ? 1 : 0; // ternário
        }

        private void btnAdicionarVenda_Click(object sender, EventArgs e)
        {
            Product produto = cbxProdutos.SelectedItem as Product;
            int quantidade = (int)this.numQuantidade.Value;


            Item? itemExistente = this.carrinho.FirstOrDefault(item => item.cod_produto == produto.cod_produto);
            if (itemExistente == null)
            {
                Item novoItem = new Item
                {
                    cod_produto = produto.cod_produto,
                    quantidade = quantidade,
                    preco = produto.preco,
                    nomeProduto = produto.nome,
                    marcaProduto = produto.marca
                };
                this.carrinho.Add(novoItem);
            }
            else
            {
                itemExistente.quantidade += quantidade;
            }
            produto.quantidade -= quantidade;
            this.cbxProdutos.SelectedItem = produto;
            cbxProdutos_SelectedIndexChanged(this, EventArgs.Empty);

            atualizarCarrinho();
        }

        private void btnCadastrarVenda_Click(object sender, EventArgs e)
        {
            decimal total = this.carrinho.Sum(item => item.subTotal);
            DialogResult confirmar = MessageBox.Show(
                $"Deseja confirmar a venda no valor: {total:C2}",
                "CONFIRMAÇÃO DA VENDA",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question
                );
            if ( confirmar == DialogResult.No)
            {
                return;
            }
            // Ao adicionar jogar as informações para o controller (falta)
            try
            {
                bool resposta = vendaControle.cadastrarVenda(this.carrinho);
                if (resposta) 
                {
                    carrinho.Clear();
                    frmCadastroVenda_Load(this, EventArgs.Empty);
                    MessageBox.Show("Venda Cadastrada com sucesso!!");
                }
                else
                {
                    MessageBox.Show("Erro ao Cadastrar venda!", "Erro no Cadastro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro: {ex.Message} ", "Erro no Cadastro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
        }
    }
}
