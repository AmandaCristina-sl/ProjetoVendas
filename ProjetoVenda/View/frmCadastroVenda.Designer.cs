namespace ProjetoVenda.View
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
            cbxProdutos = new ComboBox();
            lblPreco = new Label();
            lblQuantidade = new Label();
            btnCadastrarVenda = new Button();
            numQuantidade = new NumericUpDown();
            dgvCarrinho = new DataGridView();
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
            // btnCadastrarVenda
            // 
            btnCadastrarVenda.Location = new Point(479, 86);
            btnCadastrarVenda.Name = "btnCadastrarVenda";
            btnCadastrarVenda.Size = new Size(120, 35);
            btnCadastrarVenda.TabIndex = 3;
            btnCadastrarVenda.Text = "Cadastrar";
            btnCadastrarVenda.UseVisualStyleBackColor = true;
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
            dgvCarrinho.Location = new Point(40, 136);
            dgvCarrinho.MultiSelect = false;
            dgvCarrinho.Name = "dgvCarrinho";
            dgvCarrinho.ReadOnly = true;
            dgvCarrinho.SelectionMode = DataGridViewSelectionMode.FullColumnSelect;
            dgvCarrinho.Size = new Size(561, 288);
            dgvCarrinho.TabIndex = 5;
            // 
            // frmCadastroVenda
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(636, 450);
            Controls.Add(dgvCarrinho);
            Controls.Add(numQuantidade);
            Controls.Add(btnCadastrarVenda);
            Controls.Add(lblQuantidade);
            Controls.Add(lblPreco);
            Controls.Add(cbxProdutos);
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
        private Button btnCadastrarVenda;
        private NumericUpDown numQuantidade;
        private DataGridView dgvCarrinho;
    }
}