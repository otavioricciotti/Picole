using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Industria
{
    public class ProdutoEstoque
    {
        public DataTable produto_estoque()
        {
            string con = Properties.Settings.Default.con;

            DataTable dados = new DataTable();

            using (SqlConnection conn = new SqlConnection(con))
            {
                StringBuilder comando = new StringBuilder();

                comando.Append("select pe.id_produto, p.descricao, pe.estoque ");
                comando.Append("from produto_estoque pe(nolock) ");
                comando.Append("join produto p(nolock) on pe.id_produto = p.id_produto ");

                using (SqlDataAdapter da = new SqlDataAdapter(comando.ToString(), conn))
                {
                    try
                    {
                        da.Fill(dados);
                    }
                    catch (Exception ex)
                    {
                        System.Windows.Forms.MessageBox.Show(ex.Message);
                    }
                }
            }

            return dados;
        }

    }
}
