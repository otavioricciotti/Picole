namespace Industria
{
    partial class frmProdutoReceita
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
            this.btnRemover = new System.Windows.Forms.Button();
            this.btnInserir = new System.Windows.Forms.Button();
            this.cmbFaseRemover = new System.Windows.Forms.ComboBox();
            this.cmbFaseInserir = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtgReceita = new System.Windows.Forms.DataGridView();
            this.descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.btnConsulta = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgReceita)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRemover
            // 
            this.btnRemover.Location = new System.Drawing.Point(198, 224);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(75, 23);
            this.btnRemover.TabIndex = 24;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = true;
            // 
            // btnInserir
            // 
            this.btnInserir.Location = new System.Drawing.Point(198, 194);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(75, 21);
            this.btnInserir.TabIndex = 23;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.UseVisualStyleBackColor = true;
            // 
            // cmbFaseRemover
            // 
            this.cmbFaseRemover.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFaseRemover.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbFaseRemover.FormattingEnabled = true;
            this.cmbFaseRemover.Location = new System.Drawing.Point(39, 226);
            this.cmbFaseRemover.Name = "cmbFaseRemover";
            this.cmbFaseRemover.Size = new System.Drawing.Size(153, 21);
            this.cmbFaseRemover.TabIndex = 22;
            // 
            // cmbFaseInserir
            // 
            this.cmbFaseInserir.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFaseInserir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbFaseInserir.FormattingEnabled = true;
            this.cmbFaseInserir.Location = new System.Drawing.Point(39, 194);
            this.cmbFaseInserir.Name = "cmbFaseInserir";
            this.cmbFaseInserir.Size = new System.Drawing.Size(153, 21);
            this.cmbFaseInserir.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Fase:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Fase:";
            // 
            // dtgReceita
            // 
            this.dtgReceita.AllowUserToAddRows = false;
            this.dtgReceita.AllowUserToDeleteRows = false;
            this.dtgReceita.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgReceita.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.descricao,
            this.quantidade});
            this.dtgReceita.Location = new System.Drawing.Point(12, 36);
            this.dtgReceita.Name = "dtgReceita";
            this.dtgReceita.ReadOnly = true;
            this.dtgReceita.RowHeadersVisible = false;
            this.dtgReceita.Size = new System.Drawing.Size(261, 152);
            this.dtgReceita.TabIndex = 16;
            // 
            // descricao
            // 
            this.descricao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.descricao.DataPropertyName = "descricao";
            this.descricao.HeaderText = "Matéria";
            this.descricao.Name = "descricao";
            this.descricao.ReadOnly = true;
            // 
            // quantidade
            // 
            this.quantidade.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.quantidade.DataPropertyName = "quantidade";
            this.quantidade.HeaderText = "Qtde";
            this.quantidade.Name = "quantidade";
            this.quantidade.ReadOnly = true;
            this.quantidade.Width = 55;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(62, 8);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(130, 20);
            this.txtCodigo.TabIndex = 15;
            // 
            // btnConsulta
            // 
            this.btnConsulta.Location = new System.Drawing.Point(198, 7);
            this.btnConsulta.Name = "btnConsulta";
            this.btnConsulta.Size = new System.Drawing.Size(75, 23);
            this.btnConsulta.TabIndex = 14;
            this.btnConsulta.Text = "Consulta";
            this.btnConsulta.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Produto:";
            // 
            // frmProdutoReceita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 256);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.btnInserir);
            this.Controls.Add(this.cmbFaseRemover);
            this.Controls.Add(this.cmbFaseInserir);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtgReceita);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.btnConsulta);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmProdutoReceita";
            this.ShowIcon = false;
            this.Text = "frmProdutoReceita";
            this.Load += new System.EventHandler(this.frmProdutoReceita_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgReceita)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.ComboBox cmbFaseRemover;
        private System.Windows.Forms.ComboBox cmbFaseInserir;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dtgReceita;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidade;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Button btnConsulta;
        private System.Windows.Forms.Label label1;
    }
}