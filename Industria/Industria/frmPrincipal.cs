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
            frmProdutoConsulta prodC = new frmProdutoConsulta();
            prodC.MdiParent = this;
            if (prodC.Visible == false)
            {
                prodC.Show();
            }
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            
        }

        private void listaTécnicaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmProdutoLista pdl = new frmProdutoLista();
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
            try
            {
                frmProdutoEstoque pes = new frmProdutoEstoque();
                pes.MdiParent = this;
                if (pes.Visible == false)
                {
                    pes.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void consultaToolStripMenuItem6_Click(object sender, EventArgs e)
        {
            frmEntidadeConsulta feco = new frmEntidadeConsulta();

            feco.MdiParent = this;
            if (feco.Visible == false)
            {
                feco.Show();
            }
        }

        private void cadastroToolStripMenuItem6_Click(object sender, EventArgs e)
        {
            frmPedidoCompra fpc = new frmPedidoCompra();

            fpc.MdiParent = this;

            if (fpc.Visible == false)
            {
                fpc.Show();
            }
        }

        private void consultaToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            frmPedidoConsulta fpc = new frmPedidoConsulta();

            fpc.MdiParent = this;
            if (fpc.Visible == false)
            {
                fpc.Show();
            }
        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void novoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOrdemCadastro foc = new frmOrdemCadastro();

            foc.MdiParent = this;

            if (foc.Visible == false)
            {
                foc.Show();
            }
        }
    }
}
