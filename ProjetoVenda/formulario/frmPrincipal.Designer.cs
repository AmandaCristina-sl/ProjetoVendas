namespace ProjetoVenda.formulario
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            lblUsername = new Label();
            btnCadFuncionario = new Button();
            btnCadastrarProduto = new Button();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            btnCadastroVenda = new Button();
            btnPerfilUsuario = new Button();
            btnSair = new Button();
            panel1 = new Panel();
            lblTitulo = new Label();
            painelPrincipal = new Panel();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblUsername
            // 
            lblUsername.BackColor = Color.GhostWhite;
            lblUsername.Font = new Font("Microsoft JhengHei UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUsername.Location = new Point(131, 29);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(168, 19);
            lblUsername.TabIndex = 0;
            lblUsername.Text = "Nome do usuário";
            lblUsername.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnCadFuncionario
            // 
            btnCadFuncionario.BackColor = Color.DarkSlateBlue;
            btnCadFuncionario.FlatAppearance.BorderColor = Color.FromArgb(128, 128, 255);
            btnCadFuncionario.FlatAppearance.BorderSize = 3;
            btnCadFuncionario.FlatStyle = FlatStyle.Flat;
            btnCadFuncionario.Font = new Font("Franklin Gothic Medium", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCadFuncionario.ForeColor = Color.Lavender;
            btnCadFuncionario.Image = Properties.Resources.funcionariosCad;
            btnCadFuncionario.ImageAlign = ContentAlignment.MiddleLeft;
            btnCadFuncionario.Location = new Point(105, 304);
            btnCadFuncionario.Name = "btnCadFuncionario";
            btnCadFuncionario.Size = new Size(213, 50);
            btnCadFuncionario.TabIndex = 2;
            btnCadFuncionario.Text = "Cadastrar Funcionário";
            btnCadFuncionario.TextAlign = ContentAlignment.MiddleRight;
            btnCadFuncionario.UseVisualStyleBackColor = false;
            btnCadFuncionario.Click += btnCadFuncionario_Click;
            // 
            // btnCadastrarProduto
            // 
            btnCadastrarProduto.BackColor = Color.DarkSlateBlue;
            btnCadastrarProduto.BackgroundImageLayout = ImageLayout.Zoom;
            btnCadastrarProduto.FlatAppearance.BorderColor = Color.MediumSlateBlue;
            btnCadastrarProduto.FlatAppearance.BorderSize = 3;
            btnCadastrarProduto.FlatStyle = FlatStyle.Flat;
            btnCadastrarProduto.Font = new Font("Franklin Gothic Medium", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCadastrarProduto.ForeColor = Color.Lavender;
            btnCadastrarProduto.Image = Properties.Resources.Produtos__2_;
            btnCadastrarProduto.ImageAlign = ContentAlignment.MiddleLeft;
            btnCadastrarProduto.Location = new Point(105, 221);
            btnCadastrarProduto.Name = "btnCadastrarProduto";
            btnCadastrarProduto.Size = new Size(213, 49);
            btnCadastrarProduto.TabIndex = 1;
            btnCadastrarProduto.Text = "Cadastrar Produto";
            btnCadastrarProduto.TextAlign = ContentAlignment.MiddleRight;
            btnCadastrarProduto.UseVisualStyleBackColor = false;
            btnCadastrarProduto.Click += btnCadastrarProduto_Click;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(btnCadastroVenda);
            panel2.Controls.Add(btnPerfilUsuario);
            panel2.Controls.Add(btnSair);
            panel2.Controls.Add(btnCadastrarProduto);
            panel2.Controls.Add(btnCadFuncionario);
            panel2.Controls.Add(lblUsername);
            panel2.Dock = DockStyle.Right;
            panel2.ForeColor = SystemColors.ActiveCaptionText;
            panel2.Location = new Point(805, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(379, 961);
            panel2.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.funcionario__2_;
            pictureBox1.Location = new Point(67, 29);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(58, 59);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // btnCadastroVenda
            // 
            btnCadastroVenda.BackColor = Color.DarkSlateBlue;
            btnCadastroVenda.FlatAppearance.BorderColor = Color.FromArgb(128, 128, 255);
            btnCadastroVenda.FlatAppearance.BorderSize = 3;
            btnCadastroVenda.FlatStyle = FlatStyle.Flat;
            btnCadastroVenda.Font = new Font("Franklin Gothic Medium", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCadastroVenda.ForeColor = Color.Lavender;
            btnCadastroVenda.Image = Properties.Resources.vendas;
            btnCadastroVenda.ImageAlign = ContentAlignment.MiddleLeft;
            btnCadastroVenda.Location = new Point(105, 379);
            btnCadastroVenda.Name = "btnCadastroVenda";
            btnCadastroVenda.Size = new Size(213, 50);
            btnCadastroVenda.TabIndex = 3;
            btnCadastroVenda.Text = "Cadastrar Venda";
            btnCadastroVenda.TextAlign = ContentAlignment.MiddleRight;
            btnCadastroVenda.UseVisualStyleBackColor = false;
            btnCadastroVenda.Click += btnCadastroVenda_Click;
            // 
            // btnPerfilUsuario
            // 
            btnPerfilUsuario.Location = new Point(131, 51);
            btnPerfilUsuario.Name = "btnPerfilUsuario";
            btnPerfilUsuario.Size = new Size(168, 37);
            btnPerfilUsuario.TabIndex = 4;
            btnPerfilUsuario.Text = "Perfil do Usuário";
            btnPerfilUsuario.UseVisualStyleBackColor = true;
            btnPerfilUsuario.Click += btnPerfilUsuario_Click;
            // 
            // btnSair
            // 
            btnSair.Image = Properties.Resources.sair;
            btnSair.ImageAlign = ContentAlignment.MiddleLeft;
            btnSair.Location = new Point(131, 873);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(145, 37);
            btnSair.TabIndex = 5;
            btnSair.Text = "Sair do Sistema";
            btnSair.TextAlign = ContentAlignment.MiddleRight;
            btnSair.UseVisualStyleBackColor = true;
            btnSair.Click += btnSair_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(lblTitulo);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(805, 112);
            panel1.TabIndex = 4;
            // 
            // lblTitulo
            // 
            lblTitulo.BackColor = Color.DarkSlateBlue;
            lblTitulo.Dock = DockStyle.Fill;
            lblTitulo.Font = new Font("Microsoft JhengHei UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.Lavender;
            lblTitulo.Location = new Point(0, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(805, 112);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Título da tela";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // painelPrincipal
            // 
            painelPrincipal.Dock = DockStyle.Fill;
            painelPrincipal.Location = new Point(0, 112);
            painelPrincipal.Name = "painelPrincipal";
            painelPrincipal.Size = new Size(805, 849);
            painelPrincipal.TabIndex = 5;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Lavender;
            ClientSize = new Size(1184, 961);
            Controls.Add(painelPrincipal);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(1200, 1000);
            Name = "frmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tela Inicial";
            Load += frmPrincipal_Load;
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label lblUsername;
        private Button btnCadFuncionario;
        private Button btnCadastrarProduto;
        private Panel panel2;
        private Panel panel1;
        private Panel painelPrincipal;
        private Button btnSair;
        private Button btnPerfilUsuario;
        private Button btnCadastroVenda;
        private Label lblTitulo;
        private PictureBox pictureBox1;
    }
}