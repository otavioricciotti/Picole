using System;
using System.Windows.Forms;

namespace Industria
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        frmProduto prod = new frmProduto();
        frmProdutoAltera prodA = new frmProdutoAltera();

        private void cadastroToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            prod.MdiParent = this;
            if (prod.Visible == false)
            {
                prod.Show();
            }
        }

        private void alteraToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            prodA.MdiParent = this;
            if (prodA.Visible == false)
            {
                prodA.Show();
            }
        }
    }
}
