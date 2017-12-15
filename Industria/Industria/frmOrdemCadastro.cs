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
    public partial class frmOrdemCadastro : Form
    {
        public frmOrdemCadastro()
        {
            InitializeComponent();
        }

        private void frmOrdemCadastro_Load(object sender, EventArgs e)
        {
            OrdemCadastro bd = new OrdemCadastro();

            try
            {
                comboBox1.DataSource = bd.cmbProdutoAcabado();
                comboBox1.DisplayMember = "descricao";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            OrdemCadastro bd = new OrdemCadastro();

            try
            {
                textBox2.Text = bd.max_producao(comboBox1.Text).ToString();
            }
            catch (Exception ex)
            {
                if (ex.Message.StartsWith("Conver") == true)
                {
                    // NAO SEI PQ MAS FUNFA
                }
                else
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            OrdemCadastro bd = new OrdemCadastro();

            try
            {
                if (textBox1.TextLength > 0)
                {
                    dataGridView1.DataSource = bd.ItensConsumir(Convert.ToInt32(textBox1.Text), comboBox1.Text); 
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OrdemCadastro bd = new OrdemCadastro();

            if (Convert.ToInt32(textBox1.Text) > 0 && Convert.ToInt32(textBox1.Text) <= Convert.ToInt32(textBox2.Text))
            {
                // CONSUMIR MATERIAIS
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    int int_produto = 0;
                    double qtde = 0;

                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        if (cell.ColumnIndex == 0)
                        {
                            int_produto = bd.int_produto(cell.Value.ToString());
                        }
                        else if (cell.ColumnIndex == 1)
                        {
                            qtde = (double)cell.Value;
                        }
                    }

                    bd.ConsumirItens(qtde, int_produto);
                }

                // ENTRAR PRODUTO ACABADO
                try
                {
                    bd.EntraAcabado(Convert.ToInt32(textBox1.Text), bd.int_produto(comboBox1.Text));
                    MessageBox.Show("Dados de estoque atualizados!");
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                } 

            }
            else
            {
                if (Convert.ToInt32(textBox1.Text) > 0 == true)
                {
                    MessageBox.Show("Insira um valor maior que 0 para produção!");
                }
                else
                {
                    MessageBox.Show("Não há matéria-prima suficiente para a quantidade a produzir inserida!");
                }
            }
        }
    }
}
