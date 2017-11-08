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

        public void TestaConexao()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = Properties.Settings.Default.conn;

            conn.Open();
        }

        public DataTable tabela(string nome_tabela)
        {
            DataTable dados = new DataTable();

            using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.conn))
            {
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = new SqlCommand("select * from"+nome_tabela, conn);
                da.Fill(dados);
            }
                return dados;
        }



    }
}
