using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Industria
{
    class PedidoConsulta
    {
        string con = Properties.Settings.Default.con;

        public DataTable consultapedido()
        {
            DataTable dados = new DataTable();

            using (SqlConnection conn = new SqlConnection(con))
            {
                StringBuilder comando = new StringBuilder();

                comando.Append("select p.id_pedido, e.razao_social, dtp.descricao as tipo_pedido, ");
                comando.Append("count(pi.quantidade) as soma_itens ");
                comando.Append("from pedido p (nolock) ");
                comando.Append("join entidade e (nolock) on p.id_entidade = e.id_entidade ");
                comando.Append("join def_tipo_pedido dtp (nolock) on p.id_tipo_pedido = dtp.id_tipo_pedido ");
                comando.Append("join pedido_item pi (nolock) on p.id_pedido = pi.id_pedido ");
                comando.Append("group by p.id_pedido, e.razao_social, dtp.descricao ");

                using (SqlDataAdapter da = new SqlDataAdapter(comando.ToString(), conn))
                {
                    try
                    {
                        conn.Open();
                        da.Fill(dados);
                        conn.Close();
                    }
                    catch (Exception ex)
                    {
                        System.Windows.Forms.MessageBox.Show(ex.Message);
                    }
                }
            }

            return dados;
        }
        public DataTable consultapedidoitem(string id_pedido)
        {
            DataTable dados = new DataTable();

            using (SqlConnection conn = new SqlConnection(con))
            {
                StringBuilder comando = new StringBuilder();

                comando.Append("select pi.id_produto, p.descricao, pi.quantidade ");
                comando.Append("from pedido_item pi(nolock) ");
                comando.Append("join produto p(nolock) on pi.id_produto = p.id_produto ");
                comando.Append("where id_pedido = @id ");

                using (SqlDataAdapter da = new SqlDataAdapter(comando.ToString(), conn))
                {
                    da.SelectCommand.Parameters.AddWithValue("@id", id_pedido);
                    try
                    {
                        conn.Open();
                        da.Fill(dados);
                        conn.Close();
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
