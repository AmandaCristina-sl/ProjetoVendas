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
    public partial class frmCadastroProduto : Form
    {
        private ProductController controller;
        private Product? produtoSelecionado;

        public frmCadastroProduto()
        {
            InitializeComponent();
            controller = new ProductController();
        }

        private void btnCadastroProduto_Click(object sender, EventArgs e)
        {
            string nome = this.txtNome.Text;
            string marca = this.txtMarca.Text;
            int preco = Convert.ToInt32(this.txtPreco.Text);
            int quantidade = Convert.ToInt32(this.txtQuantidade.Text);

            // Emcapsulado os dados
            Product product = new Product
            {
                nome = nome,
                marca = marca,
                preco = preco,
                quantidade = quantidade
            };
            // Enviar os dados para Controller
            bool resp = controller.createProduct(product);
            if (resp)

            {
                MessageBox.Show("Produto Cadastrado Com Sucesso",
                    "CADASTRO PRODUTO",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
                LimparCampos();
                carregarProdutos();
            }
            else
            {
                MessageBox.Show("Erro ao Cadastrar Produto",
                    "CADASTRO PRODUTO",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void frmCadastroProduto_Load(object sender, EventArgs e)
        {
            // finalizar a lista de produtos
            carregarProdutos();
        }

        private void carregarProdutos()
        {
            List<Product> list = controller.getAll();
            dgvProdutos.DataSource = list;
            this.dgvProdutos.Columns["cod_funcionario"].Visible = false;


        }

        private void LimparCampos()
        {
            this.txtNome.Clear();
            this.txtMarca.Clear();
            this.txtPreco.Clear();
            this.txtQuantidade.Value = 0;
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            // evento de atualizar
            produtoSelecionado.nome = this.txtNome.Text;
            produtoSelecionado.marca = this.txtMarca.Text;
            produtoSelecionado.preco = Convert.ToInt32(this.txtPreco.Text);
            produtoSelecionado.quantidade = (int)this.txtQuantidade.Value;

            bool resp = controller.atualizar(produtoSelecionado);
            if (resp)
            {
                MessageBox.Show(
                    "Produto Atualizado com sucesso!",
                    "ATUALIZAÇÃO DE PRODUTOS",
                    MessageBoxButtons.OK, MessageBoxIcon.Information
                    );

                LimparCampos();
                carregarProdutos();
                this.btnAtualizar.Enabled = false;
                this.btnExcluir.Enabled = false;
                produtoSelecionado = null;
            }
            else
            {
                MessageBox.Show(
                    "Erro ao atualizar o produto!",
                    "ERRO NA ATUALIZAÇÃO DE PRODUTOS",
                    MessageBoxButtons.OK, MessageBoxIcon.Error
                    );
            }

        }

        //clicou no botão errado (descartar função)
        private void dgvProdutos_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        //botão correto
        private void dgvProdutos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }
            DataGridViewRow linha = this.dgvProdutos.Rows[e.RowIndex];
            Product? produto = linha.DataBoundItem as Product;

            this.txtNome.Text = produto.nome;
            this.txtMarca.Text = produto.marca;
            this.txtPreco.Text = produto.preco.ToString();
            this.txtQuantidade.Value = produto.quantidade;
            produtoSelecionado = produto;
            this.btnAtualizar.Enabled = true;
            this.btnExcluir.Enabled = true;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            bool resp = controller.excluir(produtoSelecionado);
            if (resp)
            {
                MessageBox.Show(
                    "Produto Excluído com sucesso!",
                    "EXCLUSÃO DE PRODUTOS",
                    MessageBoxButtons.OK, MessageBoxIcon.Information
                    );

                LimparCampos();
                carregarProdutos();
                this.btnAtualizar.Enabled = false;
                this.btnExcluir.Enabled = false;
                produtoSelecionado = null;
            }
            else
            {
                MessageBox.Show(
                    "Erro ao Excluir o produto!",
                    "ERRO NA EXCLUSÃO DE PRODUTOS",
                    MessageBoxButtons.OK, MessageBoxIcon.Error
                    );
            }


        }
    }
}
