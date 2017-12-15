using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Industria
{
    public class ProdutoCadastro
    {
        string con = Properties.Settings.Default.con;

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
