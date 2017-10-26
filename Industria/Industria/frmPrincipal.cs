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

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mm_cadastro cadastro = new mm_cadastro();
            cadastro.MdiParent = this;
            cadastro.Show();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }

    }
}
