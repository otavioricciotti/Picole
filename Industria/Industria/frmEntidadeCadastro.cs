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
    public partial class frmEntidadeCadastro : Form
    {
        public frmEntidadeCadastro()
        {
            InitializeComponent();
        }

        private void frmEntidadeCadastro_Load(object sender, EventArgs e)
        {
            txtCodigo.Enabled = false;

            bd bd = new bd();

            cmbTipo.DataSource = bd.preenche_cmbTipoEntidade();
            cmbTipo.DisplayMember = "descricao";
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            bd bd = new bd();

            try
            {
                bd.insereEntidade(txtRazao.Text, txtFantasia.Text, Convert.ToDouble(txtDOC.Text), cmbTipo.Text);
                MessageBox.Show("Entidade código "+bd.retorna_idEntidade().ToString()+" cadastrada!");

                txtDOC.Clear();
                txtFantasia.Clear();
                txtRazao.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
