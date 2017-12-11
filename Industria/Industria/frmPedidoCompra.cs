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
    public partial class frmPedidoCompra : Form
    {
        public frmPedidoCompra()
        {
            InitializeComponent();
        }

        int id_pedido;

        private void Cancelar_Click(object sender, EventArgs e)
        {
            bd bd = new bd();
            try
            {
                if (id_pedido != 0)
                {
                    bd.cancelaPedido(id_pedido);
                    MessageBox.Show("Pedido ID " + id_pedido.ToString() + " cancelado!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            this.Close();
        }

        private void atualizaEstoque()
        {
            bd bd = new bd();
            txtEstoque.Text = bd.pedido_produto_estoque(cmbProduto.Text).ToString();
        }

        private void frmPedidoCompra_Load(object sender, EventArgs e)
        {
            bd bd = new bd();
            id_pedido = 0;
            cmbTipo.DataSource = bd.cmbTipoPedido();
            cmbTipo.DisplayMember = "descricao";

            cmbEntidade.DataSource = bd.cmbPedidoEntidade(1);
            cmbEntidade.DisplayMember = "fantasia";

            cmbProduto.DataSource = bd.cmbProdutoPedido(2, id_pedido);
            cmbProduto.DisplayMember = "descricao";

            btnInserir.Enabled = false;
            cmbProdutoRemover.Enabled = false;
            txtEstoque.Enabled = false;
            btnGravar.Enabled = false;
            btnRemover.Enabled = false;
        }

        private void atualizacmbTipo()
        {
            bd bd = new bd();

            cmbProdutoRemover.DisplayMember = "descricao";
            if (cmbTipo.Text == "Entrada")
            {
                cmbEntidade.DataSource = bd.cmbPedidoEntidade(1);
                cmbProduto.DataSource = bd.cmbProdutoPedido(2, id_pedido);
                cmbProdutoRemover.DataSource = bd.cmbProdutoPedidoRemover(2, id_pedido);
            }
            else
            {
                cmbEntidade.DataSource = bd.cmbPedidoEntidade(2);
                cmbProduto.DataSource = bd.cmbProdutoPedido(1, id_pedido);
                cmbProdutoRemover.DataSource = bd.cmbProdutoPedidoRemover(1, id_pedido);
            }
        }

        private void cmbTipo_TextChanged(object sender, EventArgs e)
        {
            atualizacmbTipo();
        }

        private void txtQtde_TextChanged(object sender, EventArgs e)
        {
            if (txtQtde.TextLength == 0)
            {
                btnInserir.Enabled = false;
            }
            else
            {
                btnInserir.Enabled = true;
            }
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            bd bd = new bd();
            try
            {
                if (dataGridView1.Rows.Count == 0)
                {
                    if (cmbTipo.Text == "Saída")
                    {
                        if (Convert.ToDouble(txtEstoque.Text) > 0 && Convert.ToDouble(txtEstoque.Text) >= Convert.ToDouble(txtQtde.Text))
                        {
                            bd.inserePedido(cmbTipo.Text, cmbEntidade.Text);
                            id_pedido = bd.retorna_idPedido();
                            groupBox1.Text = "Cabeçalho (pedido " + id_pedido.ToString() + ")";
                            cmbTipo.Enabled = false;
                            cmbEntidade.Enabled = false;

                            bd.inserePedidoItem(id_pedido, cmbProduto.Text, Convert.ToDouble(txtQtde.Text));
                            atualizacmbTipo();
                            dataGridView1.DataSource = bd.pedidoItens(id_pedido);
                            txtQtde.Clear();

                            cmbProdutoRemover.Enabled = true;
                            btnRemover.Enabled = true; 
                        }
                        else
                        {
                            MessageBox.Show("Não há estoque suficiente para a operação de saída");
                        }
                    }
                    else
                    {
                        bd.inserePedido(cmbTipo.Text, cmbEntidade.Text);
                        id_pedido = bd.retorna_idPedido();
                        groupBox1.Text = "Cabeçalho (pedido " + id_pedido.ToString() + ")";
                        cmbTipo.Enabled = false;
                        cmbEntidade.Enabled = false;

                        bd.inserePedidoItem(id_pedido, cmbProduto.Text, Convert.ToDouble(txtQtde.Text));
                        atualizacmbTipo();
                        dataGridView1.DataSource = bd.pedidoItens(id_pedido);
                        txtQtde.Clear();

                        cmbProdutoRemover.Enabled = true;
                        btnRemover.Enabled = true;
                    }
                    
                }
                else
                {
                    if (cmbTipo.Text == "Entrada")
                    {
                        bd.inserePedidoItem(id_pedido, cmbProduto.Text, Convert.ToDouble(txtQtde.Text));
                        atualizacmbTipo();
                        dataGridView1.DataSource = bd.pedidoItens(id_pedido);
                        txtQtde.Clear();

                        cmbProdutoRemover.Enabled = true;
                        btnRemover.Enabled = true; 
                    }
                    else
                    {
                        if (Convert.ToDouble(txtEstoque.Text) > 0 && Convert.ToDouble(txtEstoque.Text) >= Convert.ToDouble(txtQtde.Text))
                        {
                            bd.inserePedidoItem(id_pedido, cmbProduto.Text, Convert.ToDouble(txtQtde.Text));
                            atualizacmbTipo();
                            dataGridView1.DataSource = bd.pedidoItens(id_pedido);
                            txtQtde.Clear();

                            cmbProdutoRemover.Enabled = true;
                            btnRemover.Enabled = true;
                        }
                        else
                        {
                            MessageBox.Show("Não há estoque suficiente para a operação de saída");
                        }
                    }
                }
                btnGravar.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            bd bd = new bd();

            try
            {
                bd.removeProdutoItem(id_pedido, cmbProdutoRemover.Text);
                dataGridView1.DataSource = bd.pedidoItens(id_pedido);
                if (dataGridView1.Rows.Count == 0)
                {
                    btnRemover.Enabled = false;
                    cmbProdutoRemover.Enabled = false;
                    btnGravar.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            bd bd = new bd();

            int id_tipo;

            if (cmbTipo.Text == "Entrada")
            {
                id_tipo = 1;
            }
            else
            {
                id_tipo = 2;
            }

            try
            {
                if (id_tipo == 1)
                {
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        foreach (DataGridViewCell cell in row.Cells)
                        {
                            if (cell.ColumnIndex == 0)
                            {
                                bd.pedidoGrava(id_tipo, id_pedido, cell.Value.ToString());
                                //MessageBox.Show(cell.ToString());
                            }
                        }
                    } 
                }
                else
                {
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        foreach (DataGridViewCell cell in row.Cells)
                        {
                            if (cell.ColumnIndex == 0)
                            {
                                bd.pedidoGrava(id_tipo, id_pedido, cell.Value.ToString());
                                //MessageBox.Show(cell.ToString());
                            }
                        }
                    }
                }
                
                MessageBox.Show("Pedido ID " + id_pedido.ToString() + " gravado. Os dados de estoque foram atualizados!");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmbProduto_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbProduto_SelectedIndexChanged(object sender, EventArgs e)
        {
            bd bd = new bd();
            try
            {
                atualizaEstoque();
            }
            catch (Exception ex)
            {
                if (ex.Message.StartsWith("Referência de objeto não definida para uma instância de um objeto"))
                {
                    // EU NAO SEI PQ MAS FUNCIONA
                }
                else
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
