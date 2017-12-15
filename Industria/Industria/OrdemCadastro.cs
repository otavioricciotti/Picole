using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Industria
{
    class OrdemCadastro
    {
        string con = Properties.Settings.Default.con;

        public int max_producao(string produto)
        {
            using (SqlConnection conn = new SqlConnection(con))
            {
                int retorno = 0;

                StringBuilder comando = new StringBuilder();

                comando.Append("select cast(min(pe.estoque / pli.quantidade) as int) as min ");
                comando.Append("from produto_lista_item pli (nolock) ");
                comando.Append("join produto_estoque pe (nolock) on pli.id_produto = pe.id_produto ");
                comando.Append("join produto_lista pl (nolock) on pli.id_lista = pl.id_lista ");
                comando.Append("where pl.id_produto = (select id_produto from produto where descricao = @prod) ");

                SqlCommand cmd = new SqlCommand(comando.ToString(), conn);
                cmd.Parameters.AddWithValue("@prod", produto);

                conn.Open();
                retorno = (int)cmd.ExecuteScalar();
                conn.Close();

                return retorno;
            }
        }
        public DataTable cmbProdutoAcabado()
        {
            DataTable dados = new DataTable();

            using (SqlConnection conn = new SqlConnection(con))
            {
                string comando = "select descricao from produto where id_tipo_produto = 1";
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
        public DataTable ItensConsumir(int qtde, string produto)
        {
            DataTable dados = new DataTable();

            using (SqlConnection conn = new SqlConnection(con))
            {
                StringBuilder comando = new StringBuilder();

                comando.Append("select p.descricao, pli.quantidade* @qtde as materia_prima, pe.estoque ");
                comando.Append("from produto_lista_item pli(nolock) ");
                comando.Append("join produto_estoque pe(nolock) on pli.id_produto = pe.id_produto ");
                comando.Append("join produto p(nolock) on pe.id_produto = p.id_produto ");
                comando.Append("join produto_lista pl(nolock) on pli.id_lista = pl.id_lista ");
                comando.Append("where pl.id_produto = (select id_produto from produto where descricao = @produto)");

                using (SqlDataAdapter da = new SqlDataAdapter(comando.ToString(), conn))
                {
                    da.SelectCommand.Parameters.AddWithValue("@qtde", qtde);
                    da.SelectCommand.Parameters.AddWithValue("@produto", produto);

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
        public int int_produto(string produto)
        {
            using (SqlConnection conn = new SqlConnection(con))
            {
                int retorno = 0;
                string comando = "select id_produto from produto where descricao = @prod";

                SqlCommand cmd = new SqlCommand(comando.ToString(), conn);
                cmd.Parameters.AddWithValue("@prod", produto);

                conn.Open();
                retorno = (int)cmd.ExecuteScalar();
                conn.Close();

                return retorno;
            }
        }
        public void ConsumirItens(double qtde, int produto)
        {
            using (SqlConnection conn = new SqlConnection(con))
            {
                StringBuilder comando = new StringBuilder();

                comando.Append("update produto_estoque ");
                comando.Append("set estoque = (estoque - @estoque) ");
                comando.Append("where id_produto = @produto ");

                SqlCommand cmd = new SqlCommand(comando.ToString(), conn);
                cmd.Parameters.AddWithValue("@estoque", qtde);
                cmd.Parameters.AddWithValue("@produto", produto);

                // System.Windows.Forms.MessageBox.Show(comando.ToString());

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
        public void EntraAcabado(double produzido, int prod)
        {
            using (SqlConnection conn = new SqlConnection(con))
            {
                StringBuilder comando = new StringBuilder();

                comando.Append("update produto_estoque ");
                comando.Append("set estoque = (estoque + @produzido) ");
                comando.Append("where id_produto = @id ");

                SqlCommand cmd = new SqlCommand(comando.ToString(), conn);
                cmd.Parameters.AddWithValue("@produzido", produzido);
                cmd.Parameters.AddWithValue("@id", prod);

                // System.Windows.Forms.MessageBox.Show(comando.ToString());

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
    }
}
