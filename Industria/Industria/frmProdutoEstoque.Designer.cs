namespace Industria
{
    partial class frmProdutoEstoque
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
            this.dtgEstoque = new System.Windows.Forms.DataGridView();
            this.id_produto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estoque = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgEstoque)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgEstoque
            // 
            this.dtgEstoque.AllowUserToAddRows = false;
            this.dtgEstoque.AllowUserToDeleteRows = false;
            this.dtgEstoque.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgEstoque.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_produto,
            this.descricao,
            this.estoque});
            this.dtgEstoque.Location = new System.Drawing.Point(12, 12);
            this.dtgEstoque.Name = "dtgEstoque";
            this.dtgEstoque.ReadOnly = true;
            this.dtgEstoque.RowHeadersVisible = false;
            this.dtgEstoque.Size = new System.Drawing.Size(306, 337);
            this.dtgEstoque.TabIndex = 0;
            // 
            // id_produto
            // 
            this.id_produto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.id_produto.DataPropertyName = "id_produto";
            this.id_produto.HeaderText = "ID";
            this.id_produto.Name = "id_produto";
            this.id_produto.ReadOnly = true;
            this.id_produto.Width = 43;
            // 
            // descricao
            // 
            this.descricao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.descricao.DataPropertyName = "descricao";
            this.descricao.HeaderText = "Descrição";
            this.descricao.Name = "descricao";
            this.descricao.ReadOnly = true;
            // 
            // estoque
            // 
            this.estoque.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.estoque.DataPropertyName = "estoque";
            this.estoque.HeaderText = "Qtde";
            this.estoque.Name = "estoque";
            this.estoque.ReadOnly = true;
            this.estoque.Width = 55;
            // 
            // frmProdutoEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 361);
            this.Controls.Add(this.dtgEstoque);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmProdutoEstoque";
            this.ShowIcon = false;
            this.Text = "frmProdutoEstoque";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmProdutoEstoque_FormClosed);
            this.Load += new System.EventHandler(this.frmProdutoEstoque_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgEstoque)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgEstoque;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_produto;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn estoque;
    }
}