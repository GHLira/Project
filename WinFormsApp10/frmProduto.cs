using System.Data;
using System.Data.SqlClient;
namespace WinFormsApp10
{
    public partial class cboID : Form
    {
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
            }
        }

        public cboID()
        {
            InitializeComponent();
        }
        

        private void btoSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cboID_Load(object sender, EventArgs e)
        {

        }

        private void btoCadastro_Click(object sender, EventArgs e)
        {
            string sql = "insert into produto " +
                "(" +
                    "id_categoria_produto," +
                    "nome_produto," +
                    "qntd_produto," +
                    "peso_produto," +
                    "unidade_produto," +
                    "valorCusto_produto," +
                    "valorVenda_produto," +
                    "obs_produto," +
                    "status_produto" +
                ")values(" +
                    "" + cboIdCategoria.Text + "," +
                    "'" + txtName.Text + "'" +
                    "" + txtQntd.Text + "'" +
                    "" + txtPeso.Text.Replace(",", ".") + "'" +
                    "'" + cboUnidade.Text + "'" +
                    "" + txtVlc.Text.Replace(",", ".") + "'" +
                    "" + txtVlv.Text.Replace(",", ".") + "'" +
                    "'" + txtObs.Text + "'" +
                    "'" + cboStats.Text + "'" +
                ")Select SCOPE_IDENTITY()";

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
                    btoLimpar.PerformClick();
                    MessageBox.Show("Cadastro Realizado com sucesso");
                    txtCod.Text = leitura[0].ToString();
                    btoSearch.PerformClick();
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

        private void btoLimpar_Click(object sender, EventArgs e)
        {
            txtCod.Text = "";
            cboNcID.Text = "";
            txtName.Text = "";
            txtQntd.Text = "";
            txtPeso.Text = "";
            cboUnidade.Text = "";
            txtVlc.Text = "";
            txtVlv.Text = "";
            txtObs.Text = "";
            cboStats.Text = "";
            cboIdCategoria.Text = "";
            txtData.Text = "";
            txtName.Focus();
        }

        private void btoSearch_Click(object sender, EventArgs e)
        {
            string sql = "select * from produto wher id_produto =" + txtCod.Text;

            SqlConnection Conn = new SqlConnection(stringConexao);
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            SqlDataReader leitura;
            Conn.Open();
        }
    }
}