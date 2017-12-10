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
        }
    }
}
