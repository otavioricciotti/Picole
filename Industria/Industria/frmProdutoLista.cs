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
    public partial class frmProdutoLista : Form
    {
        public frmProdutoLista()
        {
            InitializeComponent();
        }

        private void frmProdutoLista_Load(object sender, EventArgs e)
        {
            cmbMateriaInserir.Enabled = false;
            cmbMateriaRemover.Enabled = false;
            txtQtde.Enabled = false;
            btnInserir.Enabled = false;
            btnRemover.Enabled = false;
        }

        private void atualizaCMB()
        {
            ProdutoLista bd = new ProdutoLista();

            cmbMateriaInserir.DataSource = bd.preenche_cmbMateriaInsere(Convert.ToInt32(txtCodigo.Text));
            cmbMateriaInserir.DisplayMember = "descricao";
            cmbMateriaRemover.DataSource = bd.preenche_cmbMateriaRemove(Convert.ToInt32(txtCodigo.Text));
            cmbMateriaRemover.DisplayMember = "descricao";
        }

        private void atualizaDTG()
        {
            ProdutoLista bd = new ProdutoLista();

            try
            {
                dtgLista.DataSource = bd.lista_tecnica(Convert.ToInt32(txtCodigo.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            ProdutoLista bd = new ProdutoLista();

            try
            {
                atualizaDTG();
                cmbMateriaInserir.Enabled = true;
                cmbMateriaRemover.Enabled = true;
                txtQtde.Enabled = true;
                btnInserir.Enabled = true;
                btnRemover.Enabled = true;
                txtCodigo.Enabled = false;
                btnConsulta.Enabled = false;

                atualizaCMB();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            ProdutoLista bd = new ProdutoLista();

            try
            {
                bd.insere_produto_lista(Convert.ToInt32(txtCodigo.Text), cmbMateriaInserir.Text, Convert.ToInt32(txtQtde.Text));
                atualizaCMB();
                atualizaDTG();
            }
            catch (Exception ex)
            {

                if (txtQtde.TextLength == 0)
                {
                    MessageBox.Show("Insira a quantidade");
                }
                else
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            ProdutoLista bd = new ProdutoLista();

            try
            {
                bd.remove_produto_lista(Convert.ToInt32(txtCodigo.Text), cmbMateriaRemover.Text);
                atualizaCMB();
                atualizaDTG();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
