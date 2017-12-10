using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Industria
{
    class bd
    {
        private string con = @"Data Source=192.168.1.248;Initial Catalog=industria;User ID=otavio;Password=ota54321";

        // TESTES GERAIS
        public void TestaConexao()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = con;

            conn.Open();
        }
        public DataTable tabela(string nome_tabela)
        {
            DataTable dados = new DataTable();

            using (SqlConnection conn = new SqlConnection(con))
            {
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = new SqlCommand("select * from" + nome_tabela, conn);
                da.Fill(dados);
            }
            return dados;
        }

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
                //System.Windows.Forms.MessageBox.Show(comando.ToString());

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
