namespace ProjetoVenda.View
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
            panel1 = new Panel();
            painelPrincipal = new Panel();
            btnSair = new Button();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.BackColor = SystemColors.ButtonFace;
            lblUsername.Location = new Point(130, 97);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(99, 15);
            lblUsername.TabIndex = 0;
            lblUsername.Text = "Nome do usuário";
            // 
            // btnCadFuncionario
            // 
            btnCadFuncionario.Font = new Font("Cascadia Code SemiLight", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCadFuncionario.Location = new Point(18, 158);
            btnCadFuncionario.Name = "btnCadFuncionario";
            btnCadFuncionario.Size = new Size(328, 83);
            btnCadFuncionario.TabIndex = 1;
            btnCadFuncionario.Text = "Cadastrar Funcionário";
            btnCadFuncionario.UseVisualStyleBackColor = true;
            btnCadFuncionario.Click += btnCadFuncionario_Click;
            // 
            // btnCadastrarProduto
            // 
            btnCadastrarProduto.Font = new Font("Cascadia Code SemiLight", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCadastrarProduto.Location = new Point(12, 297);
            btnCadastrarProduto.Name = "btnCadastrarProduto";
            btnCadastrarProduto.Size = new Size(328, 87);
            btnCadastrarProduto.TabIndex = 2;
            btnCadastrarProduto.Text = "Cadastrar Produto";
            btnCadastrarProduto.UseVisualStyleBackColor = true;
            btnCadastrarProduto.Click += btnCadastrarProduto_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnSair);
            panel2.Controls.Add(btnCadastrarProduto);
            panel2.Controls.Add(btnCadFuncionario);
            panel2.Controls.Add(lblUsername);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(352, 759);
            panel2.TabIndex = 3;
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(352, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(658, 112);
            panel1.TabIndex = 4;
            // 
            // painelPrincipal
            // 
            painelPrincipal.Dock = DockStyle.Right;
            painelPrincipal.Location = new Point(352, 112);
            painelPrincipal.Name = "painelPrincipal";
            painelPrincipal.Size = new Size(658, 647);
            painelPrincipal.TabIndex = 5;
            // 
            // btnSair
            // 
            btnSair.Location = new Point(18, 669);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(301, 63);
            btnSair.TabIndex = 3;
            btnSair.Text = "Sair do Sistema";
            btnSair.UseVisualStyleBackColor = true;
            btnSair.Click += btnSair_Click;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1010, 759);
            Controls.Add(painelPrincipal);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tela Inicial";
            Load += frmPrincipal_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
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
    }
}