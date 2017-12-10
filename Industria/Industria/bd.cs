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

        // FORM CONSULTA DE PRODUTO
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

        // FORM CADASTRO DE PRODUTO
        public DataTable preenche_cmbTipo()
        {
            DataTable dados = new DataTable();

            using (SqlConnection conn = new SqlConnection(con))
            {
                string comando = "select descricao from def_tipo_produto";
                using (SqlDataAdapter da = new SqlDataAdapter(comando, conn))
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
        public DataTable preenche_cmbMedida()
        {
            DataTable dados = new DataTable();

            using (SqlConnection conn = new SqlConnection(con))
            {
                string comando = "select descricao from medida";
                using (SqlDataAdapter da = new SqlDataAdapter(comando, conn))
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
        public void cadastro_produto(string tipo_produto, string medida, string descricao, int cx_fechada)
        {
            using (SqlConnection conn = new SqlConnection(con))
            {
                StringBuilder comando = new StringBuilder();

                comando.Append("insert into produto values ");
                comando.Append("((select max(id_produto)+1 from produto) ");
                comando.Append(", (select id_tipo_produto from def_tipo_produto where descricao = @tipo_produto) ");
                comando.Append(", (select id_medida from medida where descricao = @medida) ");
                comando.Append(", null ");
                comando.Append(", null ");
                comando.Append(", @descricao ");
                comando.Append(", @cx_fechada) ");

                SqlCommand cmd = new SqlCommand(comando.ToString(), conn);
                cmd.Parameters.AddWithValue("@tipo_produto", tipo_produto);
                cmd.Parameters.AddWithValue("@medida", medida);
                cmd.Parameters.AddWithValue("@descricao", descricao);
                cmd.Parameters.AddWithValue("@cx_fechada", cx_fechada);

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
                catch (Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show(ex.Message);
                }
            }
        }
        public int retorno_id_produto()
        {
            using (SqlConnection conn = new SqlConnection(con))
            {
                int retorno = 0;

                SqlCommand cmd = new SqlCommand("select max(id_produto) from produto", conn);
                try
                {
                    conn.Open();
                    retorno = (int)cmd.ExecuteScalar();
                    conn.Close();
                }
                catch (Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show(ex.Message);
                }

                return retorno;
            }
        }

    }
}
