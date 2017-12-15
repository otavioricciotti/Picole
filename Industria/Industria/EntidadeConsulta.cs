using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Industria
{
    class EntidadeConsulta
    {
        public DataTable entidadeConsulta(int id)
        {
            string con = Properties.Settings.Default.con;

            DataTable dados = new DataTable();

            using (SqlConnection conn = new SqlConnection(con))
            {
                StringBuilder comando = new StringBuilder();

                comando.Append("select e.id_entidade, e.razao_social, e.fantasia, ");
                comando.Append("e.cpf_cnpj, dte.descricao as tipo_entidade ");
                comando.Append("from entidade e (nolock) ");
                comando.Append("join def_tipo_entidade dte (nolock) on e.id_tipo_entidade = dte.id_tipo_entidade ");
                comando.Append("where e.id_entidade = @id ");

                using (SqlDataAdapter da = new SqlDataAdapter(comando.ToString(), conn))
                {
                    da.SelectCommand.Parameters.AddWithValue("@id", id);

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
