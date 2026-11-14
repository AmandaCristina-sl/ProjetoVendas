using ProjetoVenda.controle;
using ProjetoVenda.modelo;
using ProjetoVenda.repositorio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ProjetoVenda.formulario
{
    public partial class frmCadastroFuncionario : Form
    {

        private FuncionarioControle controller;
        private Funcionario funcionario;

        public frmCadastroFuncionario()
        {
            InitializeComponent();
            controller = new FuncionarioControle();
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

            bool adm = (this.cbxAdm.SelectedIndex == 0)? false : true; //ternário

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

            Funcionario funcionario = new Funcionario
            {
                nome = nome,
                telefone = telefone,
                rua = rua,
                numero = numero,
                cep = cep,
                complemento = complemento,
                usuario = usuario,
                senha = senha,
                adm = adm
            };
            
            bool resp = controller.criarFuncionario(funcionario);

            if (resp)

            {
                MessageBox.Show("Funcionário Cadastrado Com Sucesso",
                    "CADASTRO FUNCIONÁRIO",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
                carregarFuncionario();
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

        private void carregarFuncionario()
        {
            List<Funcionario> list = controller.listarFuncionarios();
            dgvFuncionario.DataSource = list;
            this.dgvFuncionario.Columns["senha"].Visible = false;
           
        }

        private void frmCadastroFuncionario_Load(object sender, EventArgs e)
        {
         
              carregarFuncionario();
              this.cbxAdm.SelectedIndex = 0;
            

        }
    }
}
