namespace ProjetoVenda.formulario
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
            tableLayoutPanel1 = new TableLayoutPanel();
            dgvFuncionario = new DataGridView();
            panelFundoFunci = new Panel();
            panelDireitoFuncio = new Panel();
            cbxAdm = new ComboBox();
            txtConfirmarSenha = new TextBox();
            btnCadastrar = new Button();
            txtSenha = new TextBox();
            txtUsuario = new TextBox();
            panelEsquerdoFuncio = new Panel();
            lblCepFunci = new Label();
            lblTelefoneFun = new Label();
            lblNomeFuncio = new Label();
            label1 = new Label();
            txtNumero = new TextBox();
            txtComplemento = new TextBox();
            txtCep = new TextBox();
            txtRua = new TextBox();
            txtTelefone = new TextBox();
            txtNome = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvFuncionario).BeginInit();
            panelFundoFunci.SuspendLayout();
            panelDireitoFuncio.SuspendLayout();
            panelEsquerdoFuncio.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(dgvFuncionario, 0, 1);
            tableLayoutPanel1.Controls.Add(panelFundoFunci, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 300F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(760, 719);
            tableLayoutPanel1.TabIndex = 14;
            // 
            // dgvFuncionario
            // 
            dgvFuncionario.AllowUserToAddRows = false;
            dgvFuncionario.AllowUserToDeleteRows = false;
            dgvFuncionario.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvFuncionario.BackgroundColor = Color.GhostWhite;
            dgvFuncionario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFuncionario.Dock = DockStyle.Fill;
            dgvFuncionario.Location = new Point(18, 315);
            dgvFuncionario.Margin = new Padding(18, 15, 18, 15);
            dgvFuncionario.Name = "dgvFuncionario";
            dgvFuncionario.Size = new Size(724, 389);
            dgvFuncionario.TabIndex = 13;
            // 
            // panelFundoFunci
            // 
            panelFundoFunci.Controls.Add(panelDireitoFuncio);
            panelFundoFunci.Controls.Add(panelEsquerdoFuncio);
            panelFundoFunci.Dock = DockStyle.Fill;
            panelFundoFunci.Location = new Point(3, 3);
            panelFundoFunci.Name = "panelFundoFunci";
            panelFundoFunci.Size = new Size(754, 294);
            panelFundoFunci.TabIndex = 0;
            // 
            // panelDireitoFuncio
            // 
            panelDireitoFuncio.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            panelDireitoFuncio.Controls.Add(cbxAdm);
            panelDireitoFuncio.Controls.Add(txtConfirmarSenha);
            panelDireitoFuncio.Controls.Add(label7);
            panelDireitoFuncio.Controls.Add(label6);
            panelDireitoFuncio.Controls.Add(label5);
            panelDireitoFuncio.Controls.Add(btnCadastrar);
            panelDireitoFuncio.Controls.Add(txtSenha);
            panelDireitoFuncio.Controls.Add(txtUsuario);
            panelDireitoFuncio.Location = new Point(381, 0);
            panelDireitoFuncio.Name = "panelDireitoFuncio";
            panelDireitoFuncio.Size = new Size(373, 294);
            panelDireitoFuncio.TabIndex = 1;
            // 
            // cbxAdm
            // 
            cbxAdm.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxAdm.FormattingEnabled = true;
            cbxAdm.Items.AddRange(new object[] { "Funcionário", "Administrador" });
            cbxAdm.Location = new Point(71, 165);
            cbxAdm.Name = "cbxAdm";
            cbxAdm.Size = new Size(232, 23);
            cbxAdm.TabIndex = 18;
            // 
            // txtConfirmarSenha
            // 
            txtConfirmarSenha.AutoCompleteSource = AutoCompleteSource.FileSystem;
            txtConfirmarSenha.Location = new Point(71, 136);
            txtConfirmarSenha.Name = "txtConfirmarSenha";
            txtConfirmarSenha.PasswordChar = '*';
            txtConfirmarSenha.Size = new Size(232, 23);
            txtConfirmarSenha.TabIndex = 16;
            // 
            // btnCadastrar
            // 
            btnCadastrar.Font = new Font("Cascadia Code SemiLight", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCadastrar.ForeColor = Color.DarkSlateBlue;
            btnCadastrar.Location = new Point(113, 209);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(155, 59);
            btnCadastrar.TabIndex = 17;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(71, 93);
            txtSenha.Name = "txtSenha";
            txtSenha.PasswordChar = '*';
            txtSenha.Size = new Size(232, 23);
            txtSenha.TabIndex = 15;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(71, 49);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(232, 23);
            txtUsuario.TabIndex = 14;
            // 
            // panelEsquerdoFuncio
            // 
            panelEsquerdoFuncio.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            panelEsquerdoFuncio.Controls.Add(label4);
            panelEsquerdoFuncio.Controls.Add(label3);
            panelEsquerdoFuncio.Controls.Add(label2);
            panelEsquerdoFuncio.Controls.Add(lblCepFunci);
            panelEsquerdoFuncio.Controls.Add(lblTelefoneFun);
            panelEsquerdoFuncio.Controls.Add(lblNomeFuncio);
            panelEsquerdoFuncio.Controls.Add(label1);
            panelEsquerdoFuncio.Controls.Add(txtNumero);
            panelEsquerdoFuncio.Controls.Add(txtComplemento);
            panelEsquerdoFuncio.Controls.Add(txtCep);
            panelEsquerdoFuncio.Controls.Add(txtRua);
            panelEsquerdoFuncio.Controls.Add(txtTelefone);
            panelEsquerdoFuncio.Controls.Add(txtNome);
            panelEsquerdoFuncio.Location = new Point(0, 0);
            panelEsquerdoFuncio.Name = "panelEsquerdoFuncio";
            panelEsquerdoFuncio.Size = new Size(365, 294);
            panelEsquerdoFuncio.TabIndex = 0;
            // 
            // lblCepFunci
            // 
            lblCepFunci.AutoSize = true;
            lblCepFunci.Font = new Font("Franklin Gothic Medium", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCepFunci.Location = new Point(143, 100);
            lblCepFunci.Name = "lblCepFunci";
            lblCepFunci.Size = new Size(30, 16);
            lblCepFunci.TabIndex = 19;
            lblCepFunci.Text = "CEP:";
            // 
            // lblTelefoneFun
            // 
            lblTelefoneFun.AutoSize = true;
            lblTelefoneFun.Font = new Font("Franklin Gothic Medium", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTelefoneFun.Location = new Point(9, 101);
            lblTelefoneFun.Name = "lblTelefoneFun";
            lblTelefoneFun.Size = new Size(52, 16);
            lblTelefoneFun.TabIndex = 19;
            lblTelefoneFun.Text = "Telefone:";
            // 
            // lblNomeFuncio
            // 
            lblNomeFuncio.AutoSize = true;
            lblNomeFuncio.Font = new Font("Franklin Gothic Medium", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNomeFuncio.Location = new Point(9, 57);
            lblNomeFuncio.Name = "lblNomeFuncio";
            lblNomeFuncio.Size = new Size(89, 16);
            lblNomeFuncio.TabIndex = 19;
            lblNomeFuncio.Text = "Nome Completo:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.DarkSlateBlue;
            label1.Font = new Font("Franklin Gothic Book", 13F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Lavender;
            label1.Location = new Point(30, 18);
            label1.Name = "label1";
            label1.Size = new Size(298, 23);
            label1.TabIndex = 18;
            label1.Text = "INSIRA OS DADOS DE CADASTRO:";
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(252, 116);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(107, 23);
            txtNumero.TabIndex = 15;
            // 
            // txtComplemento
            // 
            txtComplemento.Location = new Point(9, 155);
            txtComplemento.Name = "txtComplemento";
            txtComplemento.Size = new Size(350, 23);
            txtComplemento.TabIndex = 16;
            // 
            // txtCep
            // 
            txtCep.Location = new Point(143, 116);
            txtCep.Name = "txtCep";
            txtCep.Size = new Size(107, 23);
            txtCep.TabIndex = 14;
            // 
            // txtRua
            // 
            txtRua.Location = new Point(9, 200);
            txtRua.Name = "txtRua";
            txtRua.Size = new Size(350, 23);
            txtRua.TabIndex = 17;
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(9, 116);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(128, 23);
            txtTelefone.TabIndex = 13;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(9, 75);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(350, 23);
            txtNome.TabIndex = 12;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Franklin Gothic Medium", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(252, 101);
            label2.Name = "label2";
            label2.Size = new Size(49, 16);
            label2.TabIndex = 19;
            label2.Text = "Número:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Franklin Gothic Medium", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(9, 139);
            label3.Name = "label3";
            label3.Size = new Size(78, 16);
            label3.TabIndex = 19;
            label3.Text = "Complemento:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Franklin Gothic Medium", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(9, 181);
            label4.Name = "label4";
            label4.Size = new Size(30, 16);
            label4.TabIndex = 19;
            label4.Text = "Rua:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Franklin Gothic Medium", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(71, 30);
            label5.Name = "label5";
            label5.Size = new Size(47, 16);
            label5.TabIndex = 19;
            label5.Text = "Usuário:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Franklin Gothic Medium", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(71, 75);
            label6.Name = "label6";
            label6.Size = new Size(41, 16);
            label6.TabIndex = 19;
            label6.Text = "Senha:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Franklin Gothic Medium", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(71, 119);
            label7.Name = "label7";
            label7.Size = new Size(91, 16);
            label7.TabIndex = 19;
            label7.Text = "Confirmar senha:";
            // 
            // frmCadastroFuncionario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Lavender;
            ClientSize = new Size(760, 719);
            Controls.Add(tableLayoutPanel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmCadastroFuncionario";
            Text = "Cadastro Funcionário";
            Load += frmCadastroFuncionario_Load;
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvFuncionario).EndInit();
            panelFundoFunci.ResumeLayout(false);
            panelDireitoFuncio.ResumeLayout(false);
            panelDireitoFuncio.PerformLayout();
            panelEsquerdoFuncio.ResumeLayout(false);
            panelEsquerdoFuncio.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panelFundoFunci;
        private Panel panelDireitoFuncio;
        private Panel panelEsquerdoFuncio;
        private Label label1;
        private TextBox txtNumero;
        private TextBox txtComplemento;
        private TextBox txtCep;
        private TextBox txtRua;
        private TextBox txtTelefone;
        private TextBox txtNome;
        private DataGridView dgvFuncionario;
        private ComboBox cbxAdm;
        private TextBox txtConfirmarSenha;
        private Button btnCadastrar;
        private TextBox txtSenha;
        private TextBox txtUsuario;
        private Label lblNomeFuncio;
        private Label lblCepFunci;
        private Label lblTelefoneFun;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label7;
        private Label label6;
        private Label label5;
    }
}