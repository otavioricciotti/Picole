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
    public partial class frmProdutoCadastro : Form
    {
        public frmProdutoCadastro()
        {
            InitializeComponent();
        }

        private void frmProdutoCadastro_Load(object sender, EventArgs e)
        {
            txtCodigo.Enabled = false;
            cmbTipo.Enabled = true;
            cmbMedida.Enabled = true;
            txtCx.Enabled = true;
            txtDescricao.Enabled = true;

            bd bd = new bd();
            cmbMedida.DataSource = bd.preenche_cmbMedida();
            cmbMedida.DisplayMember = "descricao";
            cmbTipo.DataSource = bd.preenche_cmbTipo();
            cmbTipo.DisplayMember = "descricao";
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            bd bd = new bd();

            try
            {
                bd.cadastro_produto(cmbTipo.Text, cmbMedida.Text, txtDescricao.Text, Convert.ToInt32(txtCx.Text));
                string cod = bd.retorno_id_produto().ToString();
                MessageBox.Show("Produto cadastrado com o código "+cod+"!");

                txtCx.Clear();
                txtDescricao.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
