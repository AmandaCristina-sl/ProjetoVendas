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
            panelProduto = new Panel();
            label5 = new Label();
            label2 = new Label();
            cbxQuantidadeItens = new ComboBox();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            txtQuantidade = new NumericUpDown();
            txtPreco = new TextBox();
            txtMarca = new TextBox();
            btnExcluir = new Button();
            txtNome = new TextBox();
            btnAtualizar = new Button();
            btnCadastroProduto = new Button();
            dgvProdutos = new DataGridView();
            tbpProduto = new TableLayoutPanel();
            panelProdutoBaixo = new Panel();
            btnAnterior = new Button();
            lblPaginas = new Label();
            btnProximo = new Button();
            panelProduto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtQuantidade).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvProdutos).BeginInit();
            tbpProduto.SuspendLayout();
            panelProdutoBaixo.SuspendLayout();
            SuspendLayout();
            // 
            // panelProduto
            // 
            panelProduto.Controls.Add(label5);
            panelProduto.Controls.Add(label2);
            panelProduto.Controls.Add(cbxQuantidadeItens);
            panelProduto.Controls.Add(label4);
            panelProduto.Controls.Add(label3);
            panelProduto.Controls.Add(label1);
            panelProduto.Controls.Add(txtQuantidade);
            panelProduto.Controls.Add(txtPreco);
            panelProduto.Controls.Add(txtMarca);
            panelProduto.Controls.Add(btnExcluir);
            panelProduto.Controls.Add(txtNome);
            panelProduto.Controls.Add(btnAtualizar);
            panelProduto.Controls.Add(btnCadastroProduto);
            panelProduto.Dock = DockStyle.Fill;
            panelProduto.Location = new Point(3, 3);
            panelProduto.Name = "panelProduto";
            panelProduto.Size = new Size(769, 244);
            panelProduto.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Franklin Gothic Heavy", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.DarkSlateBlue;
            label5.Location = new Point(9, 155);
            label5.Name = "label5";
            label5.Size = new Size(95, 20);
            label5.TabIndex = 21;
            label5.Text = "Quantidade:";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left;
            label2.BackColor = Color.DarkSlateBlue;
            label2.Font = new Font("Franklin Gothic Demi", 9.5F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Lavender;
            label2.Location = new Point(9, 199);
            label2.Name = "label2";
            label2.Size = new Size(134, 17);
            label2.TabIndex = 12;
            label2.Text = "Número de linhas:";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // cbxQuantidadeItens
            // 
            cbxQuantidadeItens.Anchor = AnchorStyles.Left;
            cbxQuantidadeItens.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxQuantidadeItens.FormattingEnabled = true;
            cbxQuantidadeItens.Items.AddRange(new object[] { "25", "35", "50", "100" });
            cbxQuantidadeItens.Location = new Point(9, 219);
            cbxQuantidadeItens.Name = "cbxQuantidadeItens";
            cbxQuantidadeItens.Size = new Size(134, 23);
            cbxQuantidadeItens.TabIndex = 11;
            cbxQuantidadeItens.SelectedIndexChanged += cbxQuantidadeItens_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Franklin Gothic Heavy", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.DarkSlateBlue;
            label4.Location = new Point(15, 112);
            label4.Name = "label4";
            label4.Size = new Size(54, 20);
            label4.TabIndex = 22;
            label4.Text = "Preço:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Franklin Gothic Heavy", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.DarkSlateBlue;
            label3.Location = new Point(15, 68);
            label3.Name = "label3";
            label3.Size = new Size(58, 20);
            label3.TabIndex = 23;
            label3.Text = "Marca:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Franklin Gothic Heavy", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkSlateBlue;
            label1.Location = new Point(9, 27);
            label1.Name = "label1";
            label1.Size = new Size(84, 20);
            label1.TabIndex = 24;
            label1.Text = "Descrição:";
            // 
            // txtQuantidade
            // 
            txtQuantidade.Anchor = AnchorStyles.Left;
            txtQuantidade.Font = new Font("Microsoft JhengHei UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtQuantidade.Location = new Point(110, 155);
            txtQuantidade.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            txtQuantidade.Minimum = new decimal(new int[] { 10000, 0, 0, int.MinValue });
            txtQuantidade.Name = "txtQuantidade";
            txtQuantidade.Size = new Size(152, 24);
            txtQuantidade.TabIndex = 17;
            // 
            // txtPreco
            // 
            txtPreco.Anchor = AnchorStyles.Left;
            txtPreco.Font = new Font("Microsoft JhengHei UI", 9.5F);
            txtPreco.Location = new Point(79, 112);
            txtPreco.Name = "txtPreco";
            txtPreco.PlaceholderText = "R$ 000.000,00";
            txtPreco.Size = new Size(152, 24);
            txtPreco.TabIndex = 16;
            // 
            // txtMarca
            // 
            txtMarca.Anchor = AnchorStyles.Left;
            txtMarca.Font = new Font("Microsoft JhengHei UI", 9.5F);
            txtMarca.Location = new Point(79, 68);
            txtMarca.Name = "txtMarca";
            txtMarca.Size = new Size(376, 24);
            txtMarca.TabIndex = 15;
            // 
            // btnExcluir
            // 
            btnExcluir.Anchor = AnchorStyles.Right;
            btnExcluir.Enabled = false;
            btnExcluir.Font = new Font("Franklin Gothic Medium", 11.25F);
            btnExcluir.ForeColor = Color.DarkSlateBlue;
            btnExcluir.Location = new Point(543, 126);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(139, 39);
            btnExcluir.TabIndex = 20;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // txtNome
            // 
            txtNome.Font = new Font("Microsoft JhengHei UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNome.Location = new Point(99, 26);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(376, 24);
            txtNome.TabIndex = 14;
            // 
            // btnAtualizar
            // 
            btnAtualizar.Anchor = AnchorStyles.Right;
            btnAtualizar.Enabled = false;
            btnAtualizar.Font = new Font("Franklin Gothic Medium", 11.25F);
            btnAtualizar.ForeColor = Color.DarkSlateBlue;
            btnAtualizar.Location = new Point(543, 68);
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.Size = new Size(139, 39);
            btnAtualizar.TabIndex = 19;
            btnAtualizar.Text = "Atualizar";
            btnAtualizar.UseMnemonic = false;
            btnAtualizar.UseVisualStyleBackColor = true;
            btnAtualizar.Click += btnAtualizar_Click;
            // 
            // btnCadastroProduto
            // 
            btnCadastroProduto.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCadastroProduto.Font = new Font("Franklin Gothic Medium", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCadastroProduto.ForeColor = Color.DarkSlateBlue;
            btnCadastroProduto.Location = new Point(543, 18);
            btnCadastroProduto.Name = "btnCadastroProduto";
            btnCadastroProduto.Size = new Size(139, 39);
            btnCadastroProduto.TabIndex = 18;
            btnCadastroProduto.Text = "Cadastrar Produto";
            btnCadastroProduto.UseVisualStyleBackColor = true;
            btnCadastroProduto.Click += btnCadastroProduto_Click;
            // 
            // dgvProdutos
            // 
            dgvProdutos.AllowUserToAddRows = false;
            dgvProdutos.AllowUserToDeleteRows = false;
            dgvProdutos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvProdutos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProdutos.BackgroundColor = Color.GhostWhite;
            dgvProdutos.BorderStyle = BorderStyle.Fixed3D;
            dgvProdutos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProdutos.Location = new Point(18, 265);
            dgvProdutos.Margin = new Padding(18, 15, 15, 18);
            dgvProdutos.MultiSelect = false;
            dgvProdutos.Name = "dgvProdutos";
            dgvProdutos.ReadOnly = true;
            dgvProdutos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProdutos.Size = new Size(742, 395);
            dgvProdutos.TabIndex = 6;
            dgvProdutos.CellDoubleClick += dgvProdutos_CellDoubleClick;
            // 
            // tbpProduto
            // 
            tbpProduto.ColumnCount = 1;
            tbpProduto.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tbpProduto.Controls.Add(panelProdutoBaixo, 0, 2);
            tbpProduto.Controls.Add(dgvProdutos, 0, 1);
            tbpProduto.Controls.Add(panelProduto, 0, 0);
            tbpProduto.Dock = DockStyle.Fill;
            tbpProduto.Location = new Point(0, 0);
            tbpProduto.Name = "tbpProduto";
            tbpProduto.RowCount = 3;
            tbpProduto.RowStyles.Add(new RowStyle(SizeType.Absolute, 250F));
            tbpProduto.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tbpProduto.RowStyles.Add(new RowStyle(SizeType.Absolute, 80F));
            tbpProduto.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tbpProduto.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tbpProduto.Size = new Size(775, 758);
            tbpProduto.TabIndex = 13;
            // 
            // panelProdutoBaixo
            // 
            panelProdutoBaixo.BackColor = Color.DarkSlateBlue;
            panelProdutoBaixo.Controls.Add(btnAnterior);
            panelProdutoBaixo.Controls.Add(lblPaginas);
            panelProdutoBaixo.Controls.Add(btnProximo);
            panelProdutoBaixo.Dock = DockStyle.Fill;
            panelProdutoBaixo.Location = new Point(3, 681);
            panelProdutoBaixo.Name = "panelProdutoBaixo";
            panelProdutoBaixo.Size = new Size(769, 74);
            panelProdutoBaixo.TabIndex = 7;
            // 
            // btnAnterior
            // 
            btnAnterior.Font = new Font("Cascadia Code SemiLight", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAnterior.ForeColor = Color.DarkSlateBlue;
            btnAnterior.Location = new Point(15, 22);
            btnAnterior.Name = "btnAnterior";
            btnAnterior.Size = new Size(123, 31);
            btnAnterior.TabIndex = 16;
            btnAnterior.Text = "<- Anterior";
            btnAnterior.UseVisualStyleBackColor = true;
            btnAnterior.Click += btnAnterior_Click;
            // 
            // lblPaginas
            // 
            lblPaginas.Anchor = AnchorStyles.Top;
            lblPaginas.Font = new Font("Cascadia Code SemiLight", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPaginas.ForeColor = Color.Lavender;
            lblPaginas.Location = new Point(206, 20);
            lblPaginas.Name = "lblPaginas";
            lblPaginas.Size = new Size(384, 33);
            lblPaginas.TabIndex = 10;
            lblPaginas.Text = "Página: 1 de 5";
            lblPaginas.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnProximo
            // 
            btnProximo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnProximo.Font = new Font("Cascadia Code SemiLight", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnProximo.ForeColor = Color.DarkSlateBlue;
            btnProximo.Location = new Point(643, 22);
            btnProximo.Name = "btnProximo";
            btnProximo.Size = new Size(123, 31);
            btnProximo.TabIndex = 10;
            btnProximo.Text = "Próximo ->";
            btnProximo.UseVisualStyleBackColor = true;
            btnProximo.Click += btnProximo_Click;
            // 
            // frmCadastroProduto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Lavender;
            ClientSize = new Size(775, 758);
            Controls.Add(tbpProduto);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmCadastroProduto";
            Text = "Cadastro de Produtos";
            Load += frmCadastroProduto_Load;
            panelProduto.ResumeLayout(false);
            panelProduto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txtQuantidade).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvProdutos).EndInit();
            tbpProduto.ResumeLayout(false);
            panelProdutoBaixo.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelProduto;
        private Label label5;
        private Label label2;
        private ComboBox cbxQuantidadeItens;
        private Label label4;
        private Label label3;
        private Label label1;
        private NumericUpDown txtQuantidade;
        private TextBox txtPreco;
        private TextBox txtMarca;
        private Button btnExcluir;
        private TextBox txtNome;
        private Button btnAtualizar;
        private Button btnCadastroProduto;
        private DataGridView dgvProdutos;
        private TableLayoutPanel tbpProduto;
        private Panel panelProdutoBaixo;
        private Button btnAnterior;
        private Label lblPaginas;
        private Button btnProximo;
    }
}