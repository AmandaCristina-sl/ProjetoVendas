using ProjetoVenda.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProjetoVenda.View
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            //string username = Session.username;
            bool isMaster = Session.isMaster;
            //this.lblUsername.Text = username;

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
            this.DialogResult = DialogResult.Retry;
            this.Dispose();
        }
    }
}
