using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Industria
{
    public class EntidadeCadastro
    {
        string con = Properties.Settings.Default.con;


        public DataTable preenche_cmbTipoEntidade()
        {
            DataTable dados = new DataTable();

            using (SqlConnection conn = new SqlConnection(con))
            {
                string comando = "select descricao from def_tipo_entidade";
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
        public void insereEntidade(string razao_social, string fantasia, double cnpj, string id_tipo_entidade)
        {
            using (SqlConnection conn = new SqlConnection(con))
            {
                StringBuilder comando = new StringBuilder();

                comando.Append("if not exists (select id_entidade from entidade where cpf_cnpj = @cpf_cnpj) ");
                comando.Append("insert into entidade values ");
                comando.Append("((select max(id_entidade)+1 from entidade), ");
                comando.Append("@razao_social, @fantasia, getdate(), @cpf_cnpj, ");
                comando.Append("(select id_tipo_entidade from def_tipo_entidade where descricao = @id_tipo_entidade), ");
                comando.Append("null, null) ");

                SqlCommand cmd = new SqlCommand(comando.ToString(), conn);
                cmd.Parameters.AddWithValue("@razao_social", razao_social);
                cmd.Parameters.AddWithValue("@fantasia", fantasia);
                cmd.Parameters.AddWithValue("@cpf_cnpj", cnpj);
                cmd.Parameters.AddWithValue("@id_tipo_entidade", id_tipo_entidade);

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
        public int retorna_idEntidade()
        {
            using (SqlConnection conn = new SqlConnection(con))
            {
                int retorno = 0;

                SqlCommand cmd = new SqlCommand("select max(id_entidade) from entidade", conn);
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
