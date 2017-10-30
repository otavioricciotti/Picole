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

        private void novoToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void cadastroToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            prod.MdiParent = this;
            if (prod.Visible == false)
            {
                prod.Show();
            }
        }
    }
}
