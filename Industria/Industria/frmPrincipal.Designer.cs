namespace Industria
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.menu = new System.Windows.Forms.MenuStrip();
            this.entidadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaToolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.listaTécnicaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.estoqueToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pedidoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroToolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.produçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaToolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.status = new System.Windows.Forms.StatusStrip();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.entidadeToolStripMenuItem,
            this.arquivoToolStripMenuItem,
            this.pedidoToolStripMenuItem,
            this.produçãoToolStripMenuItem});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menu.Size = new System.Drawing.Size(784, 24);
            this.menu.TabIndex = 1;
            this.menu.Text = "menuStrip1";
            // 
            // entidadeToolStripMenuItem
            // 
            this.entidadeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoToolStripMenuItem1,
            this.consultaToolStripMenuItem6});
            this.entidadeToolStripMenuItem.Name = "entidadeToolStripMenuItem";
            this.entidadeToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.entidadeToolStripMenuItem.Text = "Entidade";
            // 
            // novoToolStripMenuItem1
            // 
            this.novoToolStripMenuItem1.Name = "novoToolStripMenuItem1";
            this.novoToolStripMenuItem1.Size = new System.Drawing.Size(121, 22);
            this.novoToolStripMenuItem1.Text = "Cadastro";
            this.novoToolStripMenuItem1.Click += new System.EventHandler(this.novoToolStripMenuItem1_Click);
            // 
            // consultaToolStripMenuItem6
            // 
            this.consultaToolStripMenuItem6.Name = "consultaToolStripMenuItem6";
            this.consultaToolStripMenuItem6.Size = new System.Drawing.Size(121, 22);
            this.consultaToolStripMenuItem6.Text = "Consulta";
            this.consultaToolStripMenuItem6.Click += new System.EventHandler(this.consultaToolStripMenuItem6_Click);
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroToolStripMenuItem,
            this.listaTécnicaToolStripMenuItem1,
            this.estoqueToolStripMenuItem1});
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.arquivoToolStripMenuItem.Text = "Produto";
            // 
            // cadastroToolStripMenuItem
            // 
            this.cadastroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroToolStripMenuItem2,
            this.consultaToolStripMenuItem1});
            this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.cadastroToolStripMenuItem.Text = "Produto";
            this.cadastroToolStripMenuItem.Click += new System.EventHandler(this.cadastroToolStripMenuItem_Click);
            // 
            // cadastroToolStripMenuItem2
            // 
            this.cadastroToolStripMenuItem2.Name = "cadastroToolStripMenuItem2";
            this.cadastroToolStripMenuItem2.Size = new System.Drawing.Size(121, 22);
            this.cadastroToolStripMenuItem2.Text = "Cadastro";
            this.cadastroToolStripMenuItem2.Click += new System.EventHandler(this.cadastroToolStripMenuItem2_Click);
            // 
            // consultaToolStripMenuItem1
            // 
            this.consultaToolStripMenuItem1.Name = "consultaToolStripMenuItem1";
            this.consultaToolStripMenuItem1.Size = new System.Drawing.Size(121, 22);
            this.consultaToolStripMenuItem1.Text = "Consulta";
            this.consultaToolStripMenuItem1.Click += new System.EventHandler(this.consultaToolStripMenuItem1_Click);
            // 
            // listaTécnicaToolStripMenuItem1
            // 
            this.listaTécnicaToolStripMenuItem1.Name = "listaTécnicaToolStripMenuItem1";
            this.listaTécnicaToolStripMenuItem1.Size = new System.Drawing.Size(139, 22);
            this.listaTécnicaToolStripMenuItem1.Text = "Lista técnica";
            this.listaTécnicaToolStripMenuItem1.Click += new System.EventHandler(this.listaTécnicaToolStripMenuItem1_Click);
            // 
            // estoqueToolStripMenuItem1
            // 
            this.estoqueToolStripMenuItem1.Name = "estoqueToolStripMenuItem1";
            this.estoqueToolStripMenuItem1.Size = new System.Drawing.Size(139, 22);
            this.estoqueToolStripMenuItem1.Text = "Estoque";
            this.estoqueToolStripMenuItem1.Click += new System.EventHandler(this.estoqueToolStripMenuItem1_Click);
            // 
            // pedidoToolStripMenuItem
            // 
            this.pedidoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroToolStripMenuItem6,
            this.consultaToolStripMenuItem4});
            this.pedidoToolStripMenuItem.Name = "pedidoToolStripMenuItem";
            this.pedidoToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.pedidoToolStripMenuItem.Text = "Pedido";
            // 
            // cadastroToolStripMenuItem6
            // 
            this.cadastroToolStripMenuItem6.Name = "cadastroToolStripMenuItem6";
            this.cadastroToolStripMenuItem6.Size = new System.Drawing.Size(121, 22);
            this.cadastroToolStripMenuItem6.Text = "Cadastro";
            this.cadastroToolStripMenuItem6.Click += new System.EventHandler(this.cadastroToolStripMenuItem6_Click);
            // 
            // consultaToolStripMenuItem4
            // 
            this.consultaToolStripMenuItem4.Name = "consultaToolStripMenuItem4";
            this.consultaToolStripMenuItem4.Size = new System.Drawing.Size(121, 22);
            this.consultaToolStripMenuItem4.Text = "Consulta";
            this.consultaToolStripMenuItem4.Click += new System.EventHandler(this.consultaToolStripMenuItem4_Click);
            // 
            // produçãoToolStripMenuItem
            // 
            this.produçãoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoToolStripMenuItem,
            this.consultaToolStripMenuItem7});
            this.produçãoToolStripMenuItem.Name = "produçãoToolStripMenuItem";
            this.produçãoToolStripMenuItem.Size = new System.Drawing.Size(126, 20);
            this.produçãoToolStripMenuItem.Text = "Ordem de Produção";
            // 
            // novoToolStripMenuItem
            // 
            this.novoToolStripMenuItem.Name = "novoToolStripMenuItem";
            this.novoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.novoToolStripMenuItem.Text = "Cadastro";
            this.novoToolStripMenuItem.Click += new System.EventHandler(this.novoToolStripMenuItem_Click);
            // 
            // consultaToolStripMenuItem7
            // 
            this.consultaToolStripMenuItem7.Name = "consultaToolStripMenuItem7";
            this.consultaToolStripMenuItem7.Size = new System.Drawing.Size(152, 22);
            this.consultaToolStripMenuItem7.Text = "Consulta";
            // 
            // status
            // 
            this.status.Location = new System.Drawing.Point(0, 437);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(784, 22);
            this.status.TabIndex = 2;
            this.status.Text = "status";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(784, 459);
            this.Controls.Add(this.status);
            this.Controls.Add(this.menu);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menu;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Indústria de Picolé";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.StatusStrip status;
        private System.Windows.Forms.ToolStripMenuItem produçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem entidadeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem consultaToolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem novoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaToolStripMenuItem7;
        private System.Windows.Forms.ToolStripMenuItem pedidoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem consultaToolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem consultaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem listaTécnicaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem estoqueToolStripMenuItem1;
    }
}

