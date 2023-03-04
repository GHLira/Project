using System.Data;
using System.Data.SqlClient;
namespace WinFormsApp10
{

    public partial class frmProject : Form
    {
        public static string stringConexao = "" +
            "Data Source=localhost;" +
            "Initial Catalog=N8_Project;" +
            "User ID=sa;" +
            "Password=123456";
        public frmProject()
        {
            InitializeComponent();
        }

        private void lblStatus_Click(object sender, EventArgs e)
        {

        }
        private void testarConexao()
        {
            SqlConnection Conn = new SqlConnection(stringConexao);

            try
            {
                Conn.Open();
                Conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.ToString());
                Application.Exit();
            }
        }
        private void frmProject_Load(object sender, EventArgs e)
        {
            testarConexao();
        }

        private void btoCadastrar_Click(object sender, EventArgs e)
        {
            string sql = "insert into usuario" +
                "(" +
                    "nome_usuario," +
                    "login_usuario," +
                    "senha_usuario," +
                    "cpf_usuario," +
                    "obs_usuario," +
                    "status_usuario" +
                 ")" +
                 "values" +
                 "(" +
                    "'" + txtName.Text + "'," +
                    "'" + txtLogin.Text + "'," +
                    "'" + txtPW.Text + "'," +
                    "'" + mtbCPF.Text + "'," +
                    "'" + txtObs.Text + "'," +
                    "'" + mboStatus.Text + "'" +
                  ")";
            
            SqlConnection Conn = new SqlConnection(stringConexao);
            SqlCommand cmd = new SqlCommand(sql, Conn);
            cmd.CommandType = CommandType.Text;
            Conn.Open();

            try
            {
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Cadastro realizado com sucesso!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.ToString());
                
            }
            finally
            {
                Conn.Close();
            }
        }

        private void btoClean_Click(object sender, EventArgs e)
        {
            txtCOD.Text = "";
            txtName.Text = "";
            txtLogin.Text = "";
            txtObs.Text = "";
            txtPW.Text = "";
            mboStatus.Text = "";
            mtbCPF.Text = "";
            txtName.Focus();
        }

        private void btoDel_Click(object sender, EventArgs e)
        {
            string sql = " delete usuario where id_usuario= " + txtCOD.Text;

            SqlConnection Conn = new SqlConnection(stringConexao);
            SqlCommand cmd = new SqlCommand(sql , Conn);
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
                MessageBox.Show("Erro" + ex.Message);
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

        private void btoAlterar_Click(object sender, EventArgs e)
        {
            string sql = " update usuario set " +
                            "nome_usuario = ' " + txtName.Text + "'," +
                            "login_usuario = ' " + txtLogin.Text + "'," +
                            "senha_usuario = ' " + txtPW.Text + "'," +
                            "cpf_usuario = ' " + mtbCPF.Text + "'," +
                            "obs_usuario = ' " + txtObs.Text + "'," +
                            "status_usuario = ' " + mboStatus.Text + "'" +
                            "Where id_usuario = " + txtCOD.Text;

            SqlConnection Conn = new SqlConnection(stringConexao);
            SqlCommand cmd = new SqlCommand(sql, Conn);
            cmd.CommandType = CommandType.Text;
            Conn.Open();

            try
            {
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Dados alterados com sucesso");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro" + ex.Message);
            }
            finally
            {
                Conn.Close();
            }
        }

        private void btoSearch_Click(object sender, EventArgs e)
        {
            string sql = "select * from usuario where id_usuario= " + txtCOD.Text;

            SqlConnection Conn = new SqlConnection(stringConexao);
            SqlCommand Cmd = new SqlCommand(sql, Conn);
            Cmd.CommandType = CommandType.Text;
            SqlDataReader leitura;
            Conn.Open();

            try
            {
                leitura = Cmd.ExecuteReader();
                if (leitura.Read())
                {
                    txtCOD.Text = leitura[0].ToString();
                    txtName.Text = leitura[1].ToString();
                    txtLogin.Text = leitura[2].ToString();
                    txtPW.Text = leitura[3].ToString();
                    mtbCPF.Text = leitura[4].ToString();
                    txtObs.Text = leitura[5].ToString();
                    mboStatus.Text = leitura[6].ToString();
                }
                else
                {
                    MessageBox.Show("Erro, usuario não encontrado");
                    btoClean.PerformClick();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro" + ex.Message);
            }
            finally
            {
                Conn.Close();
            }
        }

        private void btoCadastrar2_Click(object sender, EventArgs e)
        {
            string sql = "insert into usuario" +
                "(" +
                    "nome_usuario," +
                    "login_usuario," +
                    "senha_usuario," +
                    "cpf_usuario," +
                    "obs_usuario," +
                    "status_usuario" +
                 ")" +
                 "values" +
                 "(" +
                    "'" + txtName.Text + "'," +
                    "'" + txtLogin.Text + "'," +
                    "'" + txtPW.Text + "'," +
                    "'" + mtbCPF.Text + "'," +
                    "'" + txtObs.Text + "'," +
                    "'" + mboStatus.Text + "'" +
                  ") select SCOPE_IDENTITY()";

            SqlConnection Conn = new SqlConnection(stringConexao);
            SqlCommand cmd = new SqlCommand(sql,Conn);
            cmd.CommandType = CommandType.Text;
            SqlDataReader leitura;
            Conn.Open();

            try
            {
                leitura = cmd.ExecuteReader();
                if (leitura.Read())
                {
                    MessageBox.Show("Dados cadastrados com sucesso");
                    btoClean.PerformClick();
                    MessageBox.Show("ID Gerado - " + leitura[0].ToString());
                    txtCOD.Text = leitura[0].ToString();
                    btoSearch.PerformClick();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro" + ex.Message);
            }
            finally
            {
                Conn.Close();
            }
        }
    }
}