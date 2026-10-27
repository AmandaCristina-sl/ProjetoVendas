namespace ProjetoVenda.View
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
            label1 = new Label();
            dgvProdutos = new DataGridView();
            btnAtualizar = new Button();
            btnExcluir = new Button();
            btnAnterior = new Button();
            btnProximo = new Button();
            lblPaginas = new Label();
            ((System.ComponentModel.ISupportInitialize)txtQuantidade).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvProdutos).BeginInit();
            SuspendLayout();
            // 
            // txtNome
            // 
            txtNome.Location = new Point(33, 71);
            txtNome.Name = "txtNome";
            txtNome.PlaceholderText = "Nome";
            txtNome.Size = new Size(371, 23);
            txtNome.TabIndex = 0;
            // 
            // txtMarca
            // 
            txtMarca.Location = new Point(33, 109);
            txtMarca.Name = "txtMarca";
            txtMarca.PlaceholderText = "Marca";
            txtMarca.Size = new Size(371, 23);
            txtMarca.TabIndex = 1;
            // 
            // txtPreco
            // 
            txtPreco.Location = new Point(56, 148);
            txtPreco.Name = "txtPreco";
            txtPreco.PlaceholderText = "R$ 000.000,00";
            txtPreco.Size = new Size(155, 23);
            txtPreco.TabIndex = 2;
            // 
            // txtQuantidade
            // 
            txtQuantidade.Location = new Point(230, 148);
            txtQuantidade.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            txtQuantidade.Name = "txtQuantidade";
            txtQuantidade.Size = new Size(161, 23);
            txtQuantidade.TabIndex = 3;
            // 
            // btnCadastroProduto
            // 
            btnCadastroProduto.Font = new Font("Cascadia Code SemiLight", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCadastroProduto.ForeColor = Color.DarkSlateBlue;
            btnCadastroProduto.Location = new Point(90, 192);
            btnCadastroProduto.Name = "btnCadastroProduto";
            btnCadastroProduto.Size = new Size(281, 43);
            btnCadastroProduto.TabIndex = 4;
            btnCadastroProduto.Text = "Cadastrar Produto";
            btnCadastroProduto.UseVisualStyleBackColor = true;
            btnCadastroProduto.Click += btnCadastroProduto_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cascadia Code", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Lavender;
            label1.Location = new Point(90, 33);
            label1.Name = "label1";
            label1.Size = new Size(252, 20);
            label1.TabIndex = 5;
            label1.Text = "INSIRA OS DADOS DO PRODUTO:";
            // 
            // dgvProdutos
            // 
            dgvProdutos.AllowUserToAddRows = false;
            dgvProdutos.AllowUserToDeleteRows = false;
            dgvProdutos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProdutos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProdutos.Location = new Point(12, 262);
            dgvProdutos.MultiSelect = false;
            dgvProdutos.Name = "dgvProdutos";
            dgvProdutos.ReadOnly = true;
            dgvProdutos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProdutos.Size = new Size(643, 374);
            dgvProdutos.TabIndex = 5;
            dgvProdutos.CellContentDoubleClick += dgvProdutos_CellContentDoubleClick;
            dgvProdutos.CellDoubleClick += dgvProdutos_CellDoubleClick;
            // 
            // btnAtualizar
            // 
            btnAtualizar.Enabled = false;
            btnAtualizar.Font = new Font("Cascadia Code SemiLight", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAtualizar.Location = new Point(446, 71);
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.Size = new Size(209, 40);
            btnAtualizar.TabIndex = 6;
            btnAtualizar.Text = "Atualizar";
            btnAtualizar.UseMnemonic = false;
            btnAtualizar.UseVisualStyleBackColor = true;
            btnAtualizar.Click += btnAtualizar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.Enabled = false;
            btnExcluir.Font = new Font("Cascadia Code SemiLight", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnExcluir.Location = new Point(446, 136);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(209, 45);
            btnExcluir.TabIndex = 7;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnAnterior
            // 
            btnAnterior.Font = new Font("Cascadia Code SemiLight", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAnterior.ForeColor = Color.DarkSlateBlue;
            btnAnterior.Location = new Point(33, 660);
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
            btnProximo.Location = new Point(529, 660);
            btnProximo.Name = "btnProximo";
            btnProximo.Size = new Size(126, 39);
            btnProximo.TabIndex = 9;
            btnProximo.Text = "Próximo ->";
            btnProximo.UseVisualStyleBackColor = true;
            btnProximo.Click += btnProximo_Click;
            // 
            // lblPaginas
            // 
            lblPaginas.Font = new Font("Cascadia Code SemiLight", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPaginas.ForeColor = Color.Lavender;
            lblPaginas.Location = new Point(183, 666);
            lblPaginas.Name = "lblPaginas";
            lblPaginas.Size = new Size(311, 33);
            lblPaginas.TabIndex = 10;
            lblPaginas.Text = "Página: 1 de 5";
            lblPaginas.TextAlign = ContentAlignment.MiddleCenter;
            lblPaginas.Click += label2_Click;
            // 
            // frmCadastroProduto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateBlue;
            ClientSize = new Size(675, 734);
            Controls.Add(lblPaginas);
            Controls.Add(btnProximo);
            Controls.Add(btnAnterior);
            Controls.Add(btnExcluir);
            Controls.Add(btnAtualizar);
            Controls.Add(dgvProdutos);
            Controls.Add(label1);
            Controls.Add(btnCadastroProduto);
            Controls.Add(txtQuantidade);
            Controls.Add(txtPreco);
            Controls.Add(txtMarca);
            Controls.Add(txtNome);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmCadastroProduto";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro de Produtos";
            Load += frmCadastroProduto_Load;
            ((System.ComponentModel.ISupportInitialize)txtQuantidade).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvProdutos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNome;
        private TextBox txtMarca;
        private TextBox txtPreco;
        private NumericUpDown txtQuantidade;
        private Button btnCadastroProduto;
        private Label label1;
        private DataGridView dgvProdutos;
        private Button btnAtualizar;
        private Button btnExcluir;
        private Button btnAnterior;
        private Button btnProximo;
        private Label lblPaginas;
    }
}