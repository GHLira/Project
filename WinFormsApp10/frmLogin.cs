using System.Data;
using System.Data.SqlClient;
namespace WinFormsApp10
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        string stringConexao = frmProject.stringConexao;
        private void TestarConexao()
        {
            try
            {
                SqlConnection Conn = new SqlConnection(stringConexao);
                Conn.Open();
                Conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro, " + ex.Message);
                Application.Exit();
            }
        }
        private void btoLog_Click(object sender, EventArgs e)
        {
            //string adm = "Lira";
            //string pass = "321";

            //if (txtLogin.Text.Trim() == "" || txtSenha.Text.Trim() == "")
            //{
            //MessageBox.Show("Erro, Login e Senha devem ser preenchidos");
            //txtLogin.Text = "";
            //txtSenha.Text = "";
            //txtLogin.Focus();
            //return;
            //}

            //if (txtLogin.Text.Trim() == adm || txtSenha.Text.Trim() == pass)
            //{
            //MessageBox.Show("Seja Bem Vindo");
            //MDIProject frm = new MDIProject();
            //frm.Show();
            //this.Hide();
            //}
            //else
            //{
            //MessageBox.Show("Erro, Senha ou Login está escrito errado");
            //}
            string sql = "select * from usuario where " + 
                "login_usuario = '" + txtLogin.Text + "' and " + 
                "senha_usuario = '" + txtSenha.Text + "'";

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
                    MessageBox.Show("Seja Bem Vindo");
                    MDIProject frm = new MDIProject();
                    frm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Usuario ou senha invalido");
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

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void btoExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            TestarConexao();
        }
    }
}