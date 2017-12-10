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
    public partial class frmEntidadeConsulta : Form
    {
        public frmEntidadeConsulta()
        {
            InitializeComponent();
        }

        private void frmEntidadeConsulta_Load(object sender, EventArgs e)
        {
            txtCodigo.Enabled = true;
            txtDOC.Enabled = false;
            txtFantasia.Enabled = false;
            txtRazao.Enabled = false;
            cmbTipo.Enabled = false;
            this.AcceptButton = btnConsultar;
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            bd bd = new bd();
            txtRazao.Text = bd.entidadeConsulta(Convert.ToInt32(txtCodigo.Text)).Rows[0]["razao_social"].ToString();
            txtDOC.Text = bd.entidadeConsulta(Convert.ToInt32(txtCodigo.Text)).Rows[0]["cpf_cnpj"].ToString();
            txtFantasia.Text = bd.entidadeConsulta(Convert.ToInt32(txtCodigo.Text)).Rows[0]["fantasia"].ToString();
            cmbTipo.Text = bd.entidadeConsulta(Convert.ToInt32(txtCodigo.Text)).Rows[0]["tipo_entidade"].ToString();
        }
    }
}
