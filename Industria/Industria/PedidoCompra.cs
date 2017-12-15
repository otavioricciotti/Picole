using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Industria
{
    class PedidoCompra
    {
        string con = Properties.Settings.Default.con;

        public DataTable cmbTipoPedido()
        {
            DataTable dados = new DataTable();

            using (SqlConnection conn = new SqlConnection(con))
            {
                string comando = "select descricao from def_tipo_pedido";
                using (SqlDataAdapter da = new SqlDataAdapter(comando, conn))
                {
                    try
                    {
                        da.Fill(dados);
                    }
                    catch (Exception ex)
                    {
                        System.Windows.Forms.MessageBox.Show(ex.Message);
                        //System.Windows.Forms.MessageBox.Show("1");
                    }
                }
            }

            return dados;
        }
        public DataTable cmbPedidoEntidade(int tipo)
        {
            DataTable dados = new DataTable();

            using (SqlConnection conn = new SqlConnection(con))
            {
                string comando = "select fantasia from entidade where id_tipo_entidade = @id";
                using (SqlDataAdapter da = new SqlDataAdapter(comando, conn))
                {
                    da.SelectCommand.Parameters.AddWithValue("@id", tipo);
                    try
                    {
                        da.Fill(dados);
                    }
                    catch (Exception ex)
                    {
                        System.Windows.Forms.MessageBox.Show(ex.Message);
                        //System.Windows.Forms.MessageBox.Show("2");
                    }
                }
            }

            return dados;
        }
        public DataTable cmbProdutoPedido(int tipo, int id_produto)
        {
            DataTable dados = new DataTable();

            using (SqlConnection conn = new SqlConnection(con))
            {
                StringBuilder comando = new StringBuilder();
                comando.Append("select descricao from produto where id_tipo_produto = @id ");
                comando.Append("and id_produto not in (select id_produto from pedido_item where id_pedido = @id_pedido)");

                using (SqlDataAdapter da = new SqlDataAdapter(comando.ToString(), conn))
                {
                    da.SelectCommand.Parameters.AddWithValue("@id", tipo);
                    da.SelectCommand.Parameters.AddWithValue("@id_pedido", id_produto);
                    try
                    {
                        da.Fill(dados);
                    }
                    catch (Exception ex)
                    {
                        System.Windows.Forms.MessageBox.Show(ex.Message);
                        //System.Windows.Forms.MessageBox.Show("3");
                    }
                }
            }

            return dados;
        }
        public string pedido_produto_estoque(string produto)
        {
            using (SqlConnection conn = new SqlConnection(con))
            {
                string retorno = "";

                StringBuilder comando = new StringBuilder();

                comando.Append("select pe.estoque ");
                comando.Append("from produto_estoque pe (nolock) ");
                comando.Append("join produto p (nolock) on pe.id_produto = p.id_produto ");
                comando.Append("where p.descricao = @produto ");

                SqlCommand cmd = new SqlCommand(comando.ToString(), conn);
                cmd.Parameters.AddWithValue("@produto", produto);

                conn.Open();
                retorno = cmd.ExecuteScalar().ToString();
                conn.Close();

                return retorno;
            }
        }
        public void inserePedido(string tipo_pedido, string entidade)
        {
            using (SqlConnection conn = new SqlConnection(con))
            {
                StringBuilder comando = new StringBuilder();

                comando.Append("insert into pedido values ");
                comando.Append("((select max(id_pedido)+1 from pedido), 0, 0, 0, ");
                comando.Append("(select id_tipo_pedido from def_tipo_pedido where descricao = @tipo_pedido), ");
                comando.Append("(select id_entidade from entidade where fantasia = @fantasia)) ");

                SqlCommand cmd = new SqlCommand(comando.ToString(), conn);
                cmd.Parameters.AddWithValue("@tipo_pedido", tipo_pedido);
                cmd.Parameters.AddWithValue("@fantasia", entidade);

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
                catch (Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show(ex.Message);
                    //System.Windows.Forms.MessageBox.Show("5");
                }
            }
        }
        public int retorna_idPedido()
        {
            using (SqlConnection conn = new SqlConnection(con))
            {
                int retorno = 0;

                SqlCommand cmd = new SqlCommand("select max(id_pedido) from pedido", conn);
                try
                {
                    conn.Open();
                    retorno = (int)cmd.ExecuteScalar();
                    conn.Close();
                }
                catch (Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show(ex.Message);
                    //System.Windows.Forms.MessageBox.Show("6");
                }
                return retorno;
            }
        }
        public void inserePedidoItem(int id_pedido, string produto, double quantidade)
        {
            using (SqlConnection conn = new SqlConnection(con))
            {
                StringBuilder comando = new StringBuilder();

                comando.Append("insert into pedido_item values ");
                comando.Append("(@id_pedido, (select id_produto from produto where descricao = @produto), ");
                comando.Append("@quantidade, null) ");
                comando.Append("update pedido set quantidade_total = quantidade_total + @quantidade ");
                comando.Append("where id_pedido = @id_pedido");

                SqlCommand cmd = new SqlCommand(comando.ToString(), conn);
                cmd.Parameters.AddWithValue("@id_pedido", id_pedido);
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
                    //System.Windows.Forms.MessageBox.Show("7");
                }
            }
        }
        public DataTable pedidoItens(int id_pedido)
        {
            DataTable dados = new DataTable();

            using (SqlConnection conn = new SqlConnection(con))
            {
                StringBuilder comando = new StringBuilder();

                comando.Append("select p.descricao, pi.quantidade ");
                comando.Append("from pedido_item pi(nolock) ");
                comando.Append("join produto p(nolock) on pi.id_produto = p.id_produto ");
                comando.Append("where pi.id_pedido = @id_pedido ");

                using (SqlDataAdapter da = new SqlDataAdapter(comando.ToString(), conn))
                {
                    da.SelectCommand.Parameters.AddWithValue("@id_pedido", id_pedido);

                    try
                    {
                        da.Fill(dados);
                    }
                    catch (Exception ex)
                    {
                        System.Windows.Forms.MessageBox.Show(ex.Message);
                        //System.Windows.Forms.MessageBox.Show("8");
                    }
                }
            }

            return dados;
        }
        public DataTable cmbProdutoPedidoRemover(int tipo, int id_produto)
        {
            DataTable dados = new DataTable();

            using (SqlConnection conn = new SqlConnection(con))
            {
                StringBuilder comando = new StringBuilder();
                comando.Append("select descricao from produto where id_tipo_produto = @id ");
                comando.Append("and id_produto in (select id_produto from pedido_item where id_pedido = @id_pedido)");

                using (SqlDataAdapter da = new SqlDataAdapter(comando.ToString(), conn))
                {
                    da.SelectCommand.Parameters.AddWithValue("@id", tipo);
                    da.SelectCommand.Parameters.AddWithValue("@id_pedido", id_produto);
                    try
                    {
                        da.Fill(dados);
                    }
                    catch (Exception ex)
                    {
                        System.Windows.Forms.MessageBox.Show(ex.Message);
                        //System.Windows.Forms.MessageBox.Show("10");
                    }
                }
            }

            return dados;
        }
        public void removeProdutoItem(int id_pedido, string produto)
        {
            using (SqlConnection conn = new SqlConnection(con))
            {
                StringBuilder comando = new StringBuilder();

                comando.Append("delete from pedido_item ");
                comando.Append("where id_pedido = @id_pedido ");
                comando.Append("and id_produto = (select id_produto from produto where descricao = @produto) ");

                SqlCommand cmd = new SqlCommand(comando.ToString(), conn);
                cmd.Parameters.AddWithValue("@id_pedido", id_pedido);
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
                    //System.Windows.Forms.MessageBox.Show("11");
                }
            }
        }
        public void cancelaPedido(int id_pedido)
        {
            using (SqlConnection conn = new SqlConnection(con))
            {
                StringBuilder comando = new StringBuilder();

                comando.Append("delete from pedido_item where id_pedido = @id_pedido ");
                comando.Append("delete from pedido where id_pedido = @id_pedido");

                SqlCommand cmd = new SqlCommand(comando.ToString(), conn);
                cmd.Parameters.AddWithValue("@id_pedido", id_pedido);

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
                catch (Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show(ex.Message);
                    //System.Windows.Forms.MessageBox.Show("12");
                }
            }
        }
        public void gravaPedido(int id_pedido)
        {
            using (SqlConnection conn = new SqlConnection(con))
            {
                string command = "select id_produto from pedido_item where id_pedido = @id_pedido";

                SqlCommand cmd = new SqlCommand(command.ToString());
                cmd.Parameters.AddWithValue("@id_pedido", id_pedido);

                try
                {
                    conn.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        StringBuilder comando = new StringBuilder();
                        comando.Append("update produto_estoque ");
                        comando.Append("set estoque = estoque + ");
                        comando.Append("(select quantidade from pedido_item ");
                        comando.Append("where id_pedido = @id_pedido and id_produto = @id_produto) ");

                        SqlCommand com = new SqlCommand(comando.ToString());

                        while (dr.Read())
                        {
                            var id = dr.GetString(0);

                            com.Parameters.AddWithValue("@id_pedido", id_pedido);
                            com.Parameters.AddWithValue("@id_produto", id);

                            try
                            {
                                conn.Open();
                                com.ExecuteNonQuery();
                                conn.Close();
                            }
                            catch (Exception ex)
                            {
                                System.Windows.Forms.MessageBox.Show(ex.Message);
                                //System.Windows.Forms.MessageBox.Show("13");
                            }
                        }
                    }
                    conn.Close();
                }
                catch (Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show(ex.Message);
                }
            }
        }
        public void pedidoGrava(int id_tipo, int id_pedido, string id_produto)
        {
            using (SqlConnection conn = new SqlConnection(con))
            {
                string operador;
                if (id_tipo == 1)
                {
                    operador = "+";
                }
                else
                {
                    operador = "-";
                }

                StringBuilder comando = new StringBuilder();
                comando.Append("update produto_estoque ");
                comando.Append("set estoque = estoque " + operador + " ");
                comando.Append("(select quantidade from pedido_item ");
                comando.Append("where id_pedido = @id_pedido and id_produto = ");
                comando.Append("(select id_produto from produto where descricao = @id_produto)) ");
                comando.Append("where id_produto = (select id_produto from produto where descricao = @id_produto) ");

                SqlCommand cmd = new SqlCommand(comando.ToString(), conn);
                cmd.Parameters.AddWithValue("@id_pedido", id_pedido);
                cmd.Parameters.AddWithValue("@id_produto", id_produto);

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
                catch (Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show(ex.Message);
                    //System.Windows.Forms.MessageBox.Show("14");
                }
            }
        }
    }
}
