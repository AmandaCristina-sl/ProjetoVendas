using ProjetoVenda.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ProjetoVenda.View
{
    public partial class frmCadastroFuncionario : Form
    {
        public frmCadastroFuncionario()
        {
            InitializeComponent();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTelefone_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtComplemento_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCep_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtConfirmarSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void limparCampos()
        {
            this.txtNome.Clear();
            this.txtTelefone.Clear();
            this.txtRua.Clear();
            this.txtNumero.Clear();
            this.txtCep.Clear();
            this.txtComplemento.Clear();

            this.txtUsuario.Clear();
            this.txtSenha.Clear();
            this.txtConfirmarSenha.Clear();
        }
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            string nome = this.txtNome.Text;
            string telefone = this.txtTelefone.Text;
            string rua = this.txtRua.Text;
            string numero = this.txtNumero.Text;
            string cep = this.txtCep.Text;
            string complemento = this.txtComplemento.Text;

            string usuario = this.txtUsuario.Text;
            string senha = this.txtSenha.Text;
            string senha1 = this.txtConfirmarSenha.Text;

            if (senha != senha1)
            {
                MessageBox.Show(
                    "Senhas não conferem",
                    "SENHA INCORRETAS",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
                return;
            }
            // chamar o controlador do usuario para cadastro
            EmployeeController controller = new EmployeeController();

            bool resp = controller.createEmployee(nome, telefone, rua, numero, cep, complemento, usuario, senha);
            if (resp)

            {
                MessageBox.Show("Funcionário Cadastrado Com Sucesso",
                    "CADASTRO FUNCIONÁRIO",
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Information
                );
                limparCampos();
            }
            else
            {
                MessageBox.Show("Erro ao Cadastrar Funcionario",
                    "CADASTRO FUNCIONÁRIO",
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Error
                );
            }
        }



       
    }
}
