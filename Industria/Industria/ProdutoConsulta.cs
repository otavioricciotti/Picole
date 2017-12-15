using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Industria
{
    public class ProdutoConsulta
    {
        string con = Properties.Settings.Default.con;

        public DataTable consulta_produto(int id_produto)
        {
            DataTable dados = new DataTable();

            using (SqlConnection conn = new SqlConnection(con))
            {
                StringBuilder comando = new StringBuilder();

                comando.Append("select p.id_produto, p.descricao, p.cx_fechada, m.descricao as medida ");
                comando.Append(", dtp.descricao as tipo ");
                comando.Append("from produto p (nolock) ");
                comando.Append("join medida m (nolock) on p.id_medida = m.id_medida ");
                comando.Append("join def_tipo_produto dtp (nolock) on p.id_tipo_produto = dtp.id_tipo_produto ");
                comando.Append("where p.id_produto = @id_produto ");

                comando.Replace("@id_produto", id_produto.ToString());

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
