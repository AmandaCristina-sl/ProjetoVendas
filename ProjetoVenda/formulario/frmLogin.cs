using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using ProjetoVenda.controle;

namespace ProjetoVenda.formulario
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
           

            string usuario = this.txtUsuario.Text;
            string senha = this.txtSenha.Text;

            if (FuncionarioControle.autenticar(usuario, senha)) // dialogo
            {
                //rewsultado do dialogo quando da certo:
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show(
                    "Usuário ou senha incorretos", 
                    "ERRO NO LOGIN", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Error
                    );
            }

        }
    }
}
