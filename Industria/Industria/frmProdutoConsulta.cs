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
    public partial class frmProdutoConsulta : Form
    {
        public frmProdutoConsulta()
        {
            InitializeComponent();
        }

        private void frmProdutoConsulta_Load(object sender, EventArgs e)
        {
            this.AcceptButton = button1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bd bd = new bd();

            try
            {
                txtCx.Text = bd.consulta_produto(Convert.ToInt32(txtCodigo.Text)).Rows[0]["cx_fechada"].ToString();
                txtDescricao.Text = bd.consulta_produto(Convert.ToInt32(txtCodigo.Text)).Rows[0]["descricao"].ToString();
                cmbMedida.Text = bd.consulta_produto(Convert.ToInt32(txtCodigo.Text)).Rows[0]["medida"].ToString();
                cmbTipo.Text = bd.consulta_produto(Convert.ToInt32(txtCodigo.Text)).Rows[0]["tipo"].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
