using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Industria
{
    public class ProdutoLista
    {
        string con = Properties.Settings.Default.con;

        public DataTable lista_tecnica(int id_produto)
        {
            DataTable dados = new DataTable();

            using (SqlConnection conn = new SqlConnection(con))
            {
                StringBuilder comando = new StringBuilder();

                comando.Append("select p.descricao, pli.quantidade ");
                comando.Append("from produto_lista_item pli(nolock) ");
                comando.Append("join produto_lista pl(nolock) on pli.id_lista = pl.id_lista ");
                comando.Append("join produto p(nolock) on pli.id_produto = p.id_produto ");
                comando.Append("where pl.id_produto = @id_produto ");

                using (SqlDataAdapter da = new SqlDataAdapter(comando.ToString(), conn))
                {
                    da.SelectCommand.Parameters.AddWithValue("@id_produto", id_produto);

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
        public DataTable preenche_cmbMateriaInsere(int id_produto)
        {
            DataTable dados = new DataTable();

            using (SqlConnection conn = new SqlConnection(con))
            {
                StringBuilder comando = new StringBuilder();

                comando.Append("select p.descricao from produto p where p.id_tipo_produto = 2 ");
                comando.Append("and p.id_produto not in  ");
                comando.Append("(select pli.id_produto from produto_lista_item pli ");
                comando.Append("join produto_lista pl on pli.id_lista = pl.id_lista ");
                comando.Append("where pl.id_produto = @id) ");

                using (SqlDataAdapter da = new SqlDataAdapter(comando.ToString(), conn))
                {
                    da.SelectCommand.Parameters.AddWithValue("@id", id_produto);

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
        public DataTable preenche_cmbMateriaRemove(int id_produto)
        {
            DataTable dados = new DataTable();

            using (SqlConnection conn = new SqlConnection(con))
            {
                StringBuilder comando = new StringBuilder();

                comando.Append("select p.descricao ");
                comando.Append("from produto_lista_item pli(nolock) ");
                comando.Append("join produto_lista pl(nolock) on pli.id_lista = pl.id_lista ");
                comando.Append("join produto p(nolock) on pli.id_produto = p.id_produto ");
                comando.Append("where pl.id_produto = @id_produto ");

                using (SqlDataAdapter da = new SqlDataAdapter(comando.ToString(), conn))
                {
                    da.SelectCommand.Parameters.AddWithValue("@id_produto", id_produto);

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
        public void insere_produto_lista(int id_produto, string produto, int quantidade)
        {
            using (SqlConnection conn = new SqlConnection(con))
            {
                StringBuilder comando = new StringBuilder();

                comando.Append("insert into produto_lista_item values ");
                comando.Append("((select id_lista from produto_lista where id_produto = @id_produto), ");
                comando.Append("(select id_produto from produto where descricao = @produto), ");
                comando.Append("@quantidade) ");

                SqlCommand cmd = new SqlCommand(comando.ToString(), conn);
                cmd.Parameters.AddWithValue("@id_produto", id_produto);
                cmd.Parameters.AddWithValue("@produto", produto);
                cmd.Parameters.AddWithValue("@quantidade", quantidade);

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
        public void remove_produto_lista(int id_produto, string produto)
        {
            using (SqlConnection conn = new SqlConnection(con))
            {
                StringBuilder comando = new StringBuilder();

                comando.Append("delete from produto_lista_item ");
                comando.Append("where id_lista = (select id_lista from produto_lista where id_produto = @id_produto) ");
                comando.Append("and id_produto = (select id_produto from produto where descricao = @produto) ");

                SqlCommand cmd = new SqlCommand(comando.ToString(), conn);
                cmd.Parameters.AddWithValue("@id_produto", id_produto);
                cmd.Parameters.AddWithValue("@produto", produto);

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
