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

        private void btnCadFuncionario_Click(object sender, EventArgs e)
        {
            frmCadastroFuncionario frm = new frmCadastroFuncionario();
            frm.ShowDialog();

        }

        private void btnCadastrarProduto_Click(object sender, EventArgs e)
        {
            frmCadastroProduto frmProduto = new frmCadastroProduto();
            frmProduto.ShowDialog();
        }
    }
}
