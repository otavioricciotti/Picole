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
        /*---------------------------------------------------------------*/
        private string conexao = "Data Source=192.168.1.248;" +
                                 "Initial Catalog=industria;" +
                                 "User id=otavio;" +
                                 "Password=ota54321;";
        /*---------------------------------------------------------------*/

        public void TestaConexao()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = conexao;

            conn.Open();
        }

        public DataTable tabela(string nome_tabela)
        {
            DataTable dados = new DataTable();

            using (SqlConnection conn = new SqlConnection(conexao))
            {
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = new SqlCommand("select * from"+nome_tabela, conn);
                da.Fill(dados);
            }
                return dados;
        }



    }
}
