using ProjetoVenda.controle;
using ProjetoVenda.modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProjetoVenda.formulario
{
    public partial class frmPrincipal : Form
    {

        private FuncionarioControle controller;

        public frmPrincipal()
        {
            InitializeComponent();
            controller = new FuncionarioControle();
            Funcionario? funcionario = controller.usuarioAutenticado();
            string nome = (funcionario != null) ? funcionario.nome : "";
            this.Text += $" - {nome}";
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            bool adm = controller.usuarioAdministrador();
            if (!adm)
            {
                this.btnCadFuncionario.Visible = false;
            }

        }

        private void exibirFormulario(Form formulario)
        {
            while (painelPrincipal.Controls.Count > 0)
            {
                painelPrincipal.Controls[0].Dispose();
            }

            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;

            this.lblTitulo.Text = formulario.Text;

            painelPrincipal.Controls.Add(formulario);
            formulario.Show();
        }

        private void btnCadFuncionario_Click(object sender, EventArgs e)
        {
            frmCadastroFuncionario frm = new frmCadastroFuncionario();
            exibirFormulario(frm);

        }

        private void btnCadastrarProduto_Click(object sender, EventArgs e)
        {
            frmCadastroProduto frmProduto = new frmCadastroProduto();
            exibirFormulario(frmProduto);
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            // evento para sair
            controller.deslogar();
            this.DialogResult = DialogResult.Retry;
            this.Dispose();
        }

        private void btnPerfilUsuario_Click(object sender, EventArgs e)
        {
            frmPerfilUsuario frm = new frmPerfilUsuario();
            exibirFormulario(frm);
        }

        private void btnCadastroVenda_Click(object sender, EventArgs e)
        {
            frmCadastroVenda frm = new frmCadastroVenda();
            exibirFormulario(frm);
        }
    }
}
