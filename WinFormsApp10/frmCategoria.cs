using System.Data;
using System.Data.SqlClient;
namespace WinFormsApp10
{

    public partial class frmCategoria : Form
    {
        string stringConexao = frmProject.stringConexao;
        private void testarConexao()
        {
            SqlConnection Conn = new SqlConnection (stringConexao);

            try
            {
                Conn.Open();
                Conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
                Application.Exit();
            }
        }
        public frmCategoria()
        {
            InitializeComponent();
        }

        private void btoCad_Click(object sender, EventArgs e)
        {
            string sql = "insert into categoria" +
                "(" +
                    "nome_categoria," +
                    "descricao_categoria," +
                    "obs_categoria," +
                    "status_categoria" +
                    ")" +
                    "values" +
                    "(" +
                       "'" + txtName.Text + "'," +
                       "'" + txtDescription.Text + "'," +
                       "'" + txtObs.Text + "'," +
                       "'" + cboStats.Text + "'" +
                       ") select SCOPE_IDENTITY()";
            
            SqlConnection Conn = new SqlConnection(stringConexao);
            SqlCommand cmd = new SqlCommand(sql, Conn);
            cmd.CommandType = CommandType.Text;
            Conn.Open();

            try
            {
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Cadastro da categoria feito com sucesso");
                }
            }
            catch (Exception ex)
            {
            
                 MessageBox.Show("Erro, " + ex.Message);
            
            }
            finally
            {
                Conn.Close();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            testarConexao();
        }

        private void btoClean_Click(object sender, EventArgs e)
        {
            txtCod.Text = "";
            txtName.Text = "";
            txtDescription.Text = "";
            txtObs.Text = "";
            cboStats.Text = "";
            txtName.Focus();
        }

        private void btoAlter_Click(object sender, EventArgs e)
        {
            string sql = " update categoria set " +
                         "nome_categoria = ' " + txtName.Text + "'," +
                         "descricao_categoria = ' " + txtDescription.Text + "'," +
                         "obs_categoria = ' " + txtObs.Text + "'," +
                         "status_categoria = ' " + cboStats.Text + "'," +
                         "Where id_categoria = " + txtCod.Text;

            SqlConnection Conn = new SqlConnection(stringConexao);
            SqlCommand cmd = new SqlCommand(sql, Conn);
            cmd.CommandType = CommandType.Text;
            Conn.Open();

            try
            {
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Os dados foram alterados com sucesso");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro, " + ex.Message);
            }
            finally
            {
                Conn.Close();
            }
        }

        private void btoExcl_Click(object sender, EventArgs e)
        {
            string sql = " delete categoria where id_categoria ";

            SqlConnection Conn = new SqlConnection(stringConexao);
            SqlCommand cmd = new SqlCommand(sql, Conn);
            cmd.CommandType = CommandType.Text;
            Conn.Open();

            try
            {
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Dados excluidos com sucesso");
                    btoClean.PerformClick();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro, " + ex.Message);
            }
            finally
            {
                Conn.Close();
            }
        }

        private void btoExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btoSearch_Click(object sender, EventArgs e)
        {
            string sql = "select * from categoria where id_categoria= " + txtCod.Text;
            SqlConnection Conn = new SqlConnection(stringConexao);
            SqlCommand cmd = new SqlCommand(sql, Conn);
            cmd.CommandType = CommandType.Text;
            SqlDataReader leitura;
            Conn.Open();

            try
            {
                leitura = cmd.ExecuteReader();
                if (leitura.Read())
                {
                    txtCod.Text = leitura[0].ToString();
                    txtName.Text = leitura[1].ToString();
                    txtDescription.Text = leitura[2].ToString();
                    txtObs.Text = leitura[3].ToString();
                    cboStats.Text = leitura[4].ToString();
                    MessageBox.Show("A categoria procurada foi encontrada");
                }
                else
                {
                    MessageBox.Show("Erro, usuario não encontrado");
                    btoClean.PerformClick();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro, " + ex.Message);
            }
            finally
            {
                Conn.Close();
            }
        }
    }
}