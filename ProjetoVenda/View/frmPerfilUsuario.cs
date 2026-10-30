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
    public partial class frmPerfilUsuario : Form
    {

        private EmployeeController controller;
        private Employee funcionario;

        public frmPerfilUsuario()
        {
            InitializeComponent();
            controller = new EmployeeController();
        }

        private void lblDadosFuncionario_Click(object sender, EventArgs e)
        {


        }

        private void txtNomeFuncionario_Click(object sender, EventArgs e)
        {

        }

        private void frmPerfilUsuario_Load(object sender, EventArgs e)
        {
            funcionario = controller.usuarioAutenticado();

            if (funcionario != null )
            {
                carregarDados();
            }
        }

        private void carregarDados()
        {
            txtNome.Text = funcionario.nome;
            txtTelefone.Text = funcionario.telefone;
            txtCep.Text = funcionario.cep;
            txtNumero.Text = funcionario.numero;
            txtComplemento.Text = funcionario.complemento;
            txtRua.Text = funcionario.rua;

            txtUsuario.Text = funcionario.usuario;

        }
    }
}
