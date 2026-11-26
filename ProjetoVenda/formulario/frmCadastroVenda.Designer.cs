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
            tableLayoutPanel1 = new TableLayoutPanel();
            dgvCarrinho = new DataGridView();
            panel1 = new Panel();
            numQuantidade = new NumericUpDown();
            btnAdicionarVenda = new Button();
            lblQuantidade = new Label();
            lblPreco = new Label();
            cbxProdutos = new ComboBox();
            panel2 = new Panel();
            lblTotalVenda = new Label();
            btnCadastrarVenda = new Button();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCarrinho).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numQuantidade).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.Lavender;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(dgvCarrinho, 0, 1);
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Controls.Add(panel2, 0, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 180F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 150F));
            tableLayoutPanel1.Size = new Size(699, 783);
            tableLayoutPanel1.TabIndex = 8;
            // 
            // dgvCarrinho
            // 
            dgvCarrinho.AllowUserToAddRows = false;
            dgvCarrinho.AllowUserToDeleteRows = false;
            dgvCarrinho.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvCarrinho.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCarrinho.BackgroundColor = Color.GhostWhite;
            dgvCarrinho.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCarrinho.Location = new Point(18, 195);
            dgvCarrinho.Margin = new Padding(18, 15, 18, 15);
            dgvCarrinho.MultiSelect = false;
            dgvCarrinho.Name = "dgvCarrinho";
            dgvCarrinho.ReadOnly = true;
            dgvCarrinho.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCarrinho.Size = new Size(663, 423);
            dgvCarrinho.TabIndex = 6;
            dgvCarrinho.CellContentClick += dgvCarrinho_CellContentClick;
            // 
            // panel1
            // 
            panel1.Controls.Add(numQuantidade);
            panel1.Controls.Add(btnAdicionarVenda);
            panel1.Controls.Add(lblQuantidade);
            panel1.Controls.Add(lblPreco);
            panel1.Controls.Add(cbxProdutos);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(693, 174);
            panel1.TabIndex = 0;
            // 
            // numQuantidade
            // 
            numQuantidade.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            numQuantidade.Location = new Point(534, 70);
            numQuantidade.Name = "numQuantidade";
            numQuantidade.Size = new Size(120, 23);
            numQuantidade.TabIndex = 9;
            // 
            // btnAdicionarVenda
            // 
            btnAdicionarVenda.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAdicionarVenda.Location = new Point(534, 99);
            btnAdicionarVenda.Name = "btnAdicionarVenda";
            btnAdicionarVenda.Size = new Size(120, 35);
            btnAdicionarVenda.TabIndex = 8;
            btnAdicionarVenda.Text = "Adicionar Item";
            btnAdicionarVenda.UseVisualStyleBackColor = true;
            btnAdicionarVenda.Click += btnAdicionarVenda_Click;
            // 
            // lblQuantidade
            // 
            lblQuantidade.AutoSize = true;
            lblQuantidade.Location = new Point(15, 99);
            lblQuantidade.Name = "lblQuantidade";
            lblQuantidade.Size = new Size(137, 15);
            lblQuantidade.TabIndex = 7;
            lblQuantidade.Text = "Quantidade disponível: x";
            // 
            // lblPreco
            // 
            lblPreco.AutoSize = true;
            lblPreco.Location = new Point(15, 78);
            lblPreco.Name = "lblPreco";
            lblPreco.Size = new Size(130, 15);
            lblPreco.TabIndex = 6;
            lblPreco.Text = "Preço Unitário: R$ xx, xx";
            // 
            // cbxProdutos
            // 
            cbxProdutos.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxProdutos.FormattingEnabled = true;
            cbxProdutos.Location = new Point(15, 41);
            cbxProdutos.Name = "cbxProdutos";
            cbxProdutos.Size = new Size(639, 23);
            cbxProdutos.TabIndex = 5;
            cbxProdutos.Click += cbxProdutos_SelectedIndexChanged;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkSlateBlue;
            panel2.Controls.Add(lblTotalVenda);
            panel2.Controls.Add(btnCadastrarVenda);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(3, 636);
            panel2.Name = "panel2";
            panel2.Size = new Size(693, 144);
            panel2.TabIndex = 1;
            // 
            // lblTotalVenda
            // 
            lblTotalVenda.Anchor = AnchorStyles.Right;
            lblTotalVenda.Font = new Font("Cascadia Code", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotalVenda.ForeColor = Color.Lavender;
            lblTotalVenda.Location = new Point(93, 15);
            lblTotalVenda.Name = "lblTotalVenda";
            lblTotalVenda.Size = new Size(561, 59);
            lblTotalVenda.TabIndex = 9;
            lblTotalVenda.Text = "Valor Total: R$ xx,xx";
            lblTotalVenda.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btnCadastrarVenda
            // 
            btnCadastrarVenda.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCadastrarVenda.Location = new Point(232, 87);
            btnCadastrarVenda.Name = "btnCadastrarVenda";
            btnCadastrarVenda.Size = new Size(233, 42);
            btnCadastrarVenda.TabIndex = 8;
            btnCadastrarVenda.Text = "Cadastrar Venda";
            btnCadastrarVenda.UseVisualStyleBackColor = true;
            btnCadastrarVenda.Click += btnCadastrarVenda_Click;
            // 
            // frmCadastroVenda
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(699, 783);
            Controls.Add(tableLayoutPanel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmCadastroVenda";
            Text = "Cadastro Venda";
            Load += frmCadastroVenda_Load;
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvCarrinho).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numQuantidade).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private Panel panel2;
        private DataGridView dgvCarrinho;
        private NumericUpDown numQuantidade;
        private Button btnAdicionarVenda;
        private Label lblQuantidade;
        private Label lblPreco;
        private ComboBox cbxProdutos;
        private Label lblTotalVenda;
        private Button btnCadastrarVenda;
    }
}