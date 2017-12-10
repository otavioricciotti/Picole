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

        // FORM LISTA TÉCNICA DE PRODUTO
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
        public DataTable preenche_cmbMateriaInsere()
        {
            DataTable dados = new DataTable();

            using (SqlConnection conn = new SqlConnection(con))
            {
                string comando = "select descricao from produto where id_tipo_produto = 2";
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

        // FORM RECEITA DE PRODUTO (DEPRECIADO)
        public DataTable preenche_cmbFaseInsere()
        {
            DataTable dados = new DataTable();

            using (SqlConnection conn = new SqlConnection(con))
            {
                string comando = "select descricao from fase";
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
        public DataTable preenche_cmbFaseRemove()
        {
            DataTable dados = new DataTable();

            using (SqlConnection conn = new SqlConnection(con))
            {
                string comando = "select descricao from produto where id_tipo_produto = 2";
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

        // FORM PRODUTO ESTOQUE
        public DataTable produto_estoque()
        {
            DataTable dados = new DataTable();

            using (SqlConnection conn = new SqlConnection(con))
            {
                StringBuilder comando = new StringBuilder();

                comando.Append("select pe.id_produto, p.descricao, pe.estoque ");
                comando.Append("from produto_estoque pe(nolock) ");
                comando.Append("join produto p(nolock) on pe.id_produto = p.id_produto ");

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

        // FORM ENTIDADE CADASTRO
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

        // FORM ENTIDADE CONSULTA
        public DataTable entidadeConsulta(int id)
        {
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
