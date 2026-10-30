namespace ProjetoVenda.View
{
    partial class frmPerfilUsuario
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
            label2 = new Label();
            txtNome = new TextBox();
            pictureBox1 = new PictureBox();
            txtTelefone = new TextBox();
            txtCep = new TextBox();
            txtNumero = new TextBox();
            txtComplemento = new TextBox();
            txtRua = new TextBox();
            lblUsuario = new Label();
            txtUsuario = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.Location = new Point(205, 25);
            label2.Name = "label2";
            label2.Size = new Size(337, 23);
            label2.TabIndex = 1;
            label2.Text = "Dados do Funcionário:";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(205, 62);
            txtNome.Name = "txtNome";
            txtNome.PlaceholderText = "Nome do Funcionário:";
            txtNome.Size = new Size(337, 23);
            txtNome.TabIndex = 2;
            txtNome.Click += txtNomeFuncionario_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Funcionario;
            pictureBox1.Location = new Point(50, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(117, 141);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(205, 91);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(108, 23);
            txtTelefone.TabIndex = 4;
            // 
            // txtCep
            // 
            txtCep.Location = new Point(319, 91);
            txtCep.Name = "txtCep";
            txtCep.Size = new Size(117, 23);
            txtCep.TabIndex = 5;
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(442, 91);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(100, 23);
            txtNumero.TabIndex = 6;
            // 
            // txtComplemento
            // 
            txtComplemento.Location = new Point(206, 123);
            txtComplemento.Name = "txtComplemento";
            txtComplemento.Size = new Size(336, 23);
            txtComplemento.TabIndex = 7;
            // 
            // txtRua
            // 
            txtRua.Location = new Point(206, 152);
            txtRua.Name = "txtRua";
            txtRua.Size = new Size(336, 23);
            txtRua.TabIndex = 8;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Location = new Point(50, 196);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(60, 15);
            lblUsuario.TabIndex = 9;
            lblUsuario.Text = "lblUsuario";
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(50, 214);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(161, 23);
            txtUsuario.TabIndex = 10;
            // 
            // frmPerfilUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(591, 297);
            Controls.Add(txtUsuario);
            Controls.Add(lblUsuario);
            Controls.Add(txtRua);
            Controls.Add(txtComplemento);
            Controls.Add(txtNumero);
            Controls.Add(txtCep);
            Controls.Add(txtTelefone);
            Controls.Add(pictureBox1);
            Controls.Add(txtNome);
            Controls.Add(label2);
            Name = "frmPerfilUsuario";
            Text = "frmPerfilUsuario";
            Load += frmPerfilUsuario_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private TextBox txtNome;
        private PictureBox pictureBox1;
        private TextBox txtTelefone;
        private TextBox txtCep;
        private TextBox txtNumero;
        private TextBox txtComplemento;
        private TextBox txtRua;
        private Label lblUsuario;
        private TextBox txtUsuario;
    }
}