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

        frmProdutoCadastro prod = new frmProdutoCadastro();
        frmProdutoConsulta prodC = new frmProdutoConsulta();
        frmProdutoLista pdl = new frmProdutoLista();
        frmProdutoEstoque pes = new frmProdutoEstoque();

        private void cadastroToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmProdutoCadastro prod = new frmProdutoCadastro();
            prod.MdiParent = this;
            if (prod.Visible == false)
            {
                prod.Show();
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
                MessageBox.Show("DEU CERTO!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void listaTécnicaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            pdl.MdiParent = this;
            if (pdl.Visible == false)
            {
                pdl.Show();
            }
        }

        private void novoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmEntidadeCadastro fec = new frmEntidadeCadastro();
            fec.MdiParent = this;
            if (fec.Visible == false)
            {
                fec.Show();
            }
        }

        private void consultaToolStripMenuItem8_Click(object sender, EventArgs e)
        {

        }

        private void estoqueToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            pes.MdiParent = this;
            if (pes.Visible == false)
            {
                pes.Show();
            }
        }
    }
}
