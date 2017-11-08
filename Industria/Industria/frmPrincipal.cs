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

        frmProdutoCadastra prod = new frmProdutoCadastra();
        frmProdutoAltera prodA = new frmProdutoAltera();
        frmProdutoConsulta prodC = new frmProdutoConsulta();

        private void cadastroToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmProdutoCadastra prod = new frmProdutoCadastra();
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

        private void consultaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            prodC.MdiParent = this;
            if (prodC.Visible == false)
            {
                prodC.Show();
            }
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            bd bd = new bd();
            try
            {
                bd.TestaConexao();
                MessageBox.Show("DEU CERTO CARAI");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
