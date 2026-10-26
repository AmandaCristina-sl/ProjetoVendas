namespace ProjetoVenda.View
{
    partial class frmCadastroFuncionario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastroFuncionario));
            txtNome = new TextBox();
            txtUsuario = new TextBox();
            txtSenha = new TextBox();
            txtTelefone = new TextBox();
            txtRua = new TextBox();
            txtCep = new TextBox();
            txtComplemento = new TextBox();
            txtNumero = new TextBox();
            btnCadastrar = new Button();
            txtConfirmarSenha = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // txtNome
            // 
            txtNome.Location = new Point(21, 73);
            txtNome.Name = "txtNome";
            txtNome.PlaceholderText = "Nome";
            txtNome.Size = new Size(354, 23);
            txtNome.TabIndex = 0;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(434, 44);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.PlaceholderText = "Usuário";
            txtUsuario.Size = new Size(192, 23);
            txtUsuario.TabIndex = 6;
            txtUsuario.TextChanged += txtUsuario_TextChanged;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(434, 84);
            txtSenha.Name = "txtSenha";
            txtSenha.PasswordChar = '*';
            txtSenha.PlaceholderText = "Senha";
            txtSenha.Size = new Size(192, 23);
            txtSenha.TabIndex = 7;
            txtSenha.TextChanged += txtSenha_TextChanged;
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(21, 102);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.PlaceholderText = "Telefone";
            txtTelefone.Size = new Size(128, 23);
            txtTelefone.TabIndex = 1;
            txtTelefone.TextChanged += txtTelefone_TextChanged;
            // 
            // txtRua
            // 
            txtRua.Location = new Point(21, 160);
            txtRua.Name = "txtRua";
            txtRua.PlaceholderText = "Rua";
            txtRua.Size = new Size(354, 23);
            txtRua.TabIndex = 5;
            txtRua.TextChanged += textBox5_TextChanged;
            // 
            // txtCep
            // 
            txtCep.Location = new Point(155, 102);
            txtCep.Name = "txtCep";
            txtCep.PlaceholderText = "Cep";
            txtCep.Size = new Size(107, 23);
            txtCep.TabIndex = 2;
            txtCep.TextChanged += txtCep_TextChanged;
            // 
            // txtComplemento
            // 
            txtComplemento.Location = new Point(21, 131);
            txtComplemento.Name = "txtComplemento";
            txtComplemento.PlaceholderText = "Complemento";
            txtComplemento.Size = new Size(354, 23);
            txtComplemento.TabIndex = 4;
            txtComplemento.TextChanged += txtComplemento_TextChanged;
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(268, 102);
            txtNumero.Name = "txtNumero";
            txtNumero.PlaceholderText = "Número";
            txtNumero.Size = new Size(107, 23);
            txtNumero.TabIndex = 3;
            // 
            // btnCadastrar
            // 
            btnCadastrar.Font = new Font("Cascadia Code SemiLight", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCadastrar.ForeColor = Color.DarkSlateBlue;
            btnCadastrar.Location = new Point(453, 160);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(155, 59);
            btnCadastrar.TabIndex = 9;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // txtConfirmarSenha
            // 
            txtConfirmarSenha.AutoCompleteSource = AutoCompleteSource.FileSystem;
            txtConfirmarSenha.Location = new Point(434, 122);
            txtConfirmarSenha.Name = "txtConfirmarSenha";
            txtConfirmarSenha.PasswordChar = '*';
            txtConfirmarSenha.PlaceholderText = "Confirmar senha";
            txtConfirmarSenha.Size = new Size(192, 23);
            txtConfirmarSenha.TabIndex = 8;
            txtConfirmarSenha.TextChanged += txtConfirmarSenha_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cascadia Code", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Lavender;
            label1.Location = new Point(73, 43);
            label1.Name = "label1";
            label1.Size = new Size(261, 20);
            label1.TabIndex = 11;
            label1.Text = "INSIRA OS DADOS DE CADASTRO:";
            label1.Click += label1_Click;
            // 
            // frmCadastroFuncionario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateBlue;
            ClientSize = new Size(675, 266);
            Controls.Add(label1);
            Controls.Add(txtConfirmarSenha);
            Controls.Add(btnCadastrar);
            Controls.Add(txtNumero);
            Controls.Add(txtComplemento);
            Controls.Add(txtCep);
            Controls.Add(txtRua);
            Controls.Add(txtTelefone);
            Controls.Add(txtSenha);
            Controls.Add(txtUsuario);
            Controls.Add(txtNome);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmCadastroFuncionario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro Funcionario";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNome;
        private TextBox txtUsuario;
        private TextBox txtSenha;
        private TextBox txtTelefone;
        private TextBox txtRua;
        private TextBox txtCep;
        private TextBox txtComplemento;
        private TextBox txtNumero;
        private Button btnCadastrar;
        private TextBox txtConfirmarSenha;
        private Label label1;
    }
}