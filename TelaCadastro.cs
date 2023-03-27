using System;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AppNovo
{
    public partial class TelaCadastro : Form
    {
        public TelaCadastro()
        {
            InitializeComponent();
        }
        SqlConnection cnn = new SqlConnection(@"Data Source=172.17.199.15;Initial Catalog=desafio2;
                                      User ID=dupla2;Password=dupla2@2022;Connect Timeout=30;
                                      Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;
                                      MultiSubnetFailover=False");
        SqlCommand com = new SqlCommand();
        SqlDataAdapter dataViewer= new SqlDataAdapter();

        private void TelaCadastro_Load(object sender, EventArgs e)
        {

        }

        private void btn_Registrar_Click_1(object sender, EventArgs e)
        {
            

            if (textBox1.Text == "" && textBox2.Text == "")
            {
                MessageBox.Show("Nao pode ser vazio.", "mensagem", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (textBox2.Text == textBox3.Text)
            {
                cnn.Open();
                string REGISTRO = "insert into User_New values('" + textBox1.Text + "','" + textBox2.Text + "')";
                com = new SqlCommand(REGISTRO, cnn);
                com.ExecuteReader();
                cnn.Close();
                textBox1.Text = ""; textBox2.Text = ""; textBox3.Text = "";
                MessageBox.Show("Cadastro efetuado!!!.", "mensagem", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Senhas nao conferem.", "mensagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox2.Text = "";
                textBox3.Text = "";
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }
    }
}
