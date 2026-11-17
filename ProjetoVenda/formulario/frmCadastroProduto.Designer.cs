namespace ProjetoVenda.formulario
{
    partial class frmCadastroProduto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastroProduto));
            txtNome = new TextBox();
            txtMarca = new TextBox();
            txtPreco = new TextBox();
            txtQuantidade = new NumericUpDown();
            btnCadastroProduto = new Button();
            dgvProdutos = new DataGridView();
            btnAtualizar = new Button();
            btnExcluir = new Button();
            btnAnterior = new Button();
            btnProximo = new Button();
            lblPaginas = new Label();
            cbxQuantidadeItens = new ComboBox();
            label2 = new Label();
            groupBox1 = new GroupBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)txtQuantidade).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvProdutos).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // txtNome
            // 
            txtNome.Font = new Font("Microsoft JhengHei UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNome.Location = new Point(9, 41);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(383, 24);
            txtNome.TabIndex = 0;
            // 
            // txtMarca
            // 
            txtMarca.Font = new Font("Microsoft JhengHei UI", 9.5F);
            txtMarca.Location = new Point(9, 94);
            txtMarca.Name = "txtMarca";
            txtMarca.Size = new Size(383, 24);
            txtMarca.TabIndex = 1;
            // 
            // txtPreco
            // 
            txtPreco.Font = new Font("Microsoft JhengHei UI", 9.5F);
            txtPreco.Location = new Point(9, 149);
            txtPreco.Name = "txtPreco";
            txtPreco.PlaceholderText = "R$ 000.000,00";
            txtPreco.Size = new Size(159, 24);
            txtPreco.TabIndex = 2;
            // 
            // txtQuantidade
            // 
            txtQuantidade.Font = new Font("Microsoft JhengHei UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtQuantidade.Location = new Point(9, 209);
            txtQuantidade.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            txtQuantidade.Minimum = new decimal(new int[] { 10000, 0, 0, int.MinValue });
            txtQuantidade.Name = "txtQuantidade";
            txtQuantidade.Size = new Size(159, 24);
            txtQuantidade.TabIndex = 3;
            // 
            // btnCadastroProduto
            // 
            btnCadastroProduto.Font = new Font("Franklin Gothic Medium", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCadastroProduto.ForeColor = Color.DarkSlateBlue;
            btnCadastroProduto.Location = new Point(540, 36);
            btnCadastroProduto.Name = "btnCadastroProduto";
            btnCadastroProduto.Size = new Size(123, 55);
            btnCadastroProduto.TabIndex = 4;
            btnCadastroProduto.Text = "Cadastrar Produto";
            btnCadastroProduto.UseVisualStyleBackColor = true;
            btnCadastroProduto.Click += btnCadastroProduto_Click;
            // 
            // dgvProdutos
            // 
            dgvProdutos.AllowUserToAddRows = false;
            dgvProdutos.AllowUserToDeleteRows = false;
            dgvProdutos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProdutos.BackgroundColor = SystemColors.WindowFrame;
            dgvProdutos.BorderStyle = BorderStyle.Fixed3D;
            dgvProdutos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProdutos.Location = new Point(22, 312);
            dgvProdutos.MultiSelect = false;
            dgvProdutos.Name = "dgvProdutos";
            dgvProdutos.ReadOnly = true;
            dgvProdutos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProdutos.Size = new Size(633, 374);
            dgvProdutos.TabIndex = 5;
            dgvProdutos.CellContentDoubleClick += dgvProdutos_CellContentDoubleClick;
            dgvProdutos.CellDoubleClick += dgvProdutos_CellDoubleClick;
            // 
            // btnAtualizar
            // 
            btnAtualizar.Enabled = false;
            btnAtualizar.Font = new Font("Franklin Gothic Medium", 11.25F);
            btnAtualizar.ForeColor = Color.DarkSlateBlue;
            btnAtualizar.Location = new Point(540, 106);
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.Size = new Size(123, 52);
            btnAtualizar.TabIndex = 6;
            btnAtualizar.Text = "Atualizar";
            btnAtualizar.UseMnemonic = false;
            btnAtualizar.UseVisualStyleBackColor = true;
            btnAtualizar.Click += btnAtualizar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.Enabled = false;
            btnExcluir.Font = new Font("Franklin Gothic Medium", 11.25F);
            btnExcluir.ForeColor = Color.DarkSlateBlue;
            btnExcluir.Location = new Point(540, 170);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(123, 52);
            btnExcluir.TabIndex = 7;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnAnterior
            // 
            btnAnterior.Font = new Font("Cascadia Code SemiLight", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAnterior.ForeColor = Color.DarkSlateBlue;
            btnAnterior.Location = new Point(22, 698);
            btnAnterior.Name = "btnAnterior";
            btnAnterior.Size = new Size(117, 39);
            btnAnterior.TabIndex = 8;
            btnAnterior.Text = "<- Anterior";
            btnAnterior.UseVisualStyleBackColor = true;
            btnAnterior.Click += btnAnterior_Click;
            // 
            // btnProximo
            // 
            btnProximo.Font = new Font("Cascadia Code SemiLight", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnProximo.ForeColor = Color.DarkSlateBlue;
            btnProximo.Location = new Point(538, 698);
            btnProximo.Name = "btnProximo";
            btnProximo.Size = new Size(117, 39);
            btnProximo.TabIndex = 9;
            btnProximo.Text = "Próximo ->";
            btnProximo.UseVisualStyleBackColor = true;
            btnProximo.Click += btnProximo_Click;
            // 
            // lblPaginas
            // 
            lblPaginas.Font = new Font("Cascadia Code SemiLight", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPaginas.ForeColor = Color.DarkSlateBlue;
            lblPaginas.Location = new Point(154, 700);
            lblPaginas.Name = "lblPaginas";
            lblPaginas.Size = new Size(358, 33);
            lblPaginas.TabIndex = 10;
            lblPaginas.Text = "Página: 1 de 5";
            lblPaginas.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cbxQuantidadeItens
            // 
            cbxQuantidadeItens.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxQuantidadeItens.FormattingEnabled = true;
            cbxQuantidadeItens.Items.AddRange(new object[] { "25", "35", "50", "100" });
            cbxQuantidadeItens.Location = new Point(22, 283);
            cbxQuantidadeItens.Name = "cbxQuantidadeItens";
            cbxQuantidadeItens.Size = new Size(126, 23);
            cbxQuantidadeItens.TabIndex = 11;
            cbxQuantidadeItens.SelectedIndexChanged += cbxQuantidadeItens_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.Font = new Font("Cascadia Code SemiLight", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.DarkSlateBlue;
            label2.Location = new Point(22, 264);
            label2.Name = "label2";
            label2.Size = new Size(126, 16);
            label2.TabIndex = 12;
            label2.Text = "Número de linhas:";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtQuantidade);
            groupBox1.Controls.Add(txtPreco);
            groupBox1.Controls.Add(txtMarca);
            groupBox1.Controls.Add(txtNome);
            groupBox1.ForeColor = SystemColors.ActiveCaptionText;
            groupBox1.Location = new Point(22, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(501, 249);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Franklin Gothic Demi", 9.75F, FontStyle.Italic);
            label5.ForeColor = Color.DarkSlateBlue;
            label5.Location = new Point(9, 187);
            label5.Name = "label5";
            label5.Size = new Size(74, 17);
            label5.TabIndex = 13;
            label5.Text = "Quantidade";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Franklin Gothic Demi", 9.75F, FontStyle.Italic);
            label4.ForeColor = Color.DarkSlateBlue;
            label4.Location = new Point(9, 129);
            label4.Name = "label4";
            label4.Size = new Size(45, 17);
            label4.TabIndex = 13;
            label4.Text = "Preço:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Franklin Gothic Demi", 9.75F, FontStyle.Italic);
            label3.ForeColor = Color.DarkSlateBlue;
            label3.Location = new Point(9, 74);
            label3.Name = "label3";
            label3.Size = new Size(48, 17);
            label3.TabIndex = 13;
            label3.Text = "Marca:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Franklin Gothic Demi", 9.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkSlateBlue;
            label1.Location = new Point(9, 21);
            label1.Name = "label1";
            label1.Size = new Size(69, 17);
            label1.TabIndex = 13;
            label1.Text = "Descrição:";
            // 
            // frmCadastroProduto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Lavender;
            ClientSize = new Size(681, 758);
            Controls.Add(label2);
            Controls.Add(cbxQuantidadeItens);
            Controls.Add(lblPaginas);
            Controls.Add(btnProximo);
            Controls.Add(btnAnterior);
            Controls.Add(btnExcluir);
            Controls.Add(btnAtualizar);
            Controls.Add(dgvProdutos);
            Controls.Add(btnCadastroProduto);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmCadastroProduto";
            Text = "Cadastro de Produtos";
            Load += frmCadastroProduto_Load;
            ((System.ComponentModel.ISupportInitialize)txtQuantidade).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvProdutos).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtNome;
        private TextBox txtMarca;
        private TextBox txtPreco;
        private NumericUpDown txtQuantidade;
        private Button btnCadastroProduto;
        private DataGridView dgvProdutos;
        private Button btnAtualizar;
        private Button btnExcluir;
        private Button btnAnterior;
        private Button btnProximo;
        private Label lblPaginas;
        private ComboBox cbxQuantidadeItens;
        private Label label2;
        private GroupBox groupBox1;
        private Label label4;
        private Label label3;
        private Label label1;
        private Label label5;
    }
}