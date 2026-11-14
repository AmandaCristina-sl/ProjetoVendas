namespace ProjetoVenda.formulario
{
    partial class frmCadastroVenda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastroVenda));
            cbxProdutos = new ComboBox();
            lblPreco = new Label();
            lblQuantidade = new Label();
            btnAdicionarVenda = new Button();
            numQuantidade = new NumericUpDown();
            dgvCarrinho = new DataGridView();
            btnCadastrarVenda = new Button();
            lblTotalVenda = new Label();
            ((System.ComponentModel.ISupportInitialize)numQuantidade).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCarrinho).BeginInit();
            SuspendLayout();
            // 
            // cbxProdutos
            // 
            cbxProdutos.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxProdutos.FormattingEnabled = true;
            cbxProdutos.Location = new Point(38, 28);
            cbxProdutos.Name = "cbxProdutos";
            cbxProdutos.Size = new Size(561, 23);
            cbxProdutos.TabIndex = 0;
            cbxProdutos.SelectedIndexChanged += cbxProdutos_SelectedIndexChanged;
            // 
            // lblPreco
            // 
            lblPreco.AutoSize = true;
            lblPreco.Location = new Point(38, 65);
            lblPreco.Name = "lblPreco";
            lblPreco.Size = new Size(130, 15);
            lblPreco.TabIndex = 1;
            lblPreco.Text = "Preço Unitário: R$ xx, xx";
            // 
            // lblQuantidade
            // 
            lblQuantidade.AutoSize = true;
            lblQuantidade.Location = new Point(38, 86);
            lblQuantidade.Name = "lblQuantidade";
            lblQuantidade.Size = new Size(137, 15);
            lblQuantidade.TabIndex = 2;
            lblQuantidade.Text = "Quantidade disponível: x";
            // 
            // btnAdicionarVenda
            // 
            btnAdicionarVenda.Location = new Point(479, 86);
            btnAdicionarVenda.Name = "btnAdicionarVenda";
            btnAdicionarVenda.Size = new Size(120, 35);
            btnAdicionarVenda.TabIndex = 3;
            btnAdicionarVenda.Text = "Adicionar Item";
            btnAdicionarVenda.UseVisualStyleBackColor = true;
            btnAdicionarVenda.Click += btnAdicionarVenda_Click;
            // 
            // numQuantidade
            // 
            numQuantidade.Location = new Point(479, 57);
            numQuantidade.Name = "numQuantidade";
            numQuantidade.Size = new Size(120, 23);
            numQuantidade.TabIndex = 4;
            // 
            // dgvCarrinho
            // 
            dgvCarrinho.AllowUserToAddRows = false;
            dgvCarrinho.AllowUserToDeleteRows = false;
            dgvCarrinho.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCarrinho.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCarrinho.Location = new Point(22, 136);
            dgvCarrinho.MultiSelect = false;
            dgvCarrinho.Name = "dgvCarrinho";
            dgvCarrinho.ReadOnly = true;
            dgvCarrinho.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCarrinho.Size = new Size(590, 466);
            dgvCarrinho.TabIndex = 5;
            dgvCarrinho.CellContentClick += dgvCarrinho_CellContentClick;
            // 
            // btnCadastrarVenda
            // 
            btnCadastrarVenda.Location = new Point(179, 677);
            btnCadastrarVenda.Name = "btnCadastrarVenda";
            btnCadastrarVenda.Size = new Size(233, 42);
            btnCadastrarVenda.TabIndex = 6;
            btnCadastrarVenda.Text = "Cadastrar Venda";
            btnCadastrarVenda.UseVisualStyleBackColor = true;
            btnCadastrarVenda.Click += btnCadastrarVenda_Click;
            // 
            // lblTotalVenda
            // 
            lblTotalVenda.Font = new Font("Cascadia Code", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotalVenda.Location = new Point(40, 605);
            lblTotalVenda.Name = "lblTotalVenda";
            lblTotalVenda.Size = new Size(561, 59);
            lblTotalVenda.TabIndex = 7;
            lblTotalVenda.Text = "Valor Total: R$ xx,xx";
            lblTotalVenda.TextAlign = ContentAlignment.MiddleRight;
            // 
            // frmCadastroVenda
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(636, 783);
            Controls.Add(lblTotalVenda);
            Controls.Add(btnCadastrarVenda);
            Controls.Add(dgvCarrinho);
            Controls.Add(numQuantidade);
            Controls.Add(btnAdicionarVenda);
            Controls.Add(lblQuantidade);
            Controls.Add(lblPreco);
            Controls.Add(cbxProdutos);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmCadastroVenda";
            Text = "Cadastro Venda";
            Load += frmCadastroVenda_Load;
            ((System.ComponentModel.ISupportInitialize)numQuantidade).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCarrinho).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbxProdutos;
        private Label lblPreco;
        private Label lblQuantidade;
        private Button btnAdicionarVenda;
        private NumericUpDown numQuantidade;
        private DataGridView dgvCarrinho;
        private Button btnCadastrarVenda;
        private Label lblTotalVenda;
    }
}