using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Industria
{
    public partial class frmProdutoEstoque : Form
    {
        public frmProdutoEstoque()
        {
            InitializeComponent();
        }

        private void frmProdutoEstoque_Load(object sender, EventArgs e)
        {
            try
            {
                ProdutoEstoque bd = new ProdutoEstoque();
                dtgEstoque.DataSource = bd.produto_estoque();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmProdutoEstoque_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }
    }
}
