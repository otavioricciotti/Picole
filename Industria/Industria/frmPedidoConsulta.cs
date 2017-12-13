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
    public partial class frmPedidoConsulta : Form
    {
        public frmPedidoConsulta()
        {
            InitializeComponent();
        }

        private void frmPedidoConsulta_Load(object sender, EventArgs e)
        {
            bd bd = new bd();

            try
            {
                dataGridView1.DataSource = bd.consultapedido();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string id_pedido = dataGridView1[0, e.RowIndex].Value.ToString();

            try
            {
                bd bd = new bd();
                dataGridView2.DataSource = bd.consultapedidoitem(id_pedido);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                bd bd = new bd();
                dataGridView2.DataSource = bd.consultapedidoitem(textBox1.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Pedido não encontrado!");
            }
        }

        private void frmPedidoConsulta_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }
    }
}
