using System;
using System.Data.SqlClient;
using System.DirectoryServices.ActiveDirectory;
using System.Windows.Forms;

namespace AppNovo
{
    public partial class Form1 : Form
    {
        readonly SqlConnection cnn;
        public Form1()
        {
            InitializeComponent();
            cnn = new SqlConnection(@"Data Source=172.17.199.15;Initial Catalog=desafio2;
                                      User ID=dupla2;Password=dupla2@2022;Connect Timeout=30;
                                      Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;
                                      MultiSubnetFailover=False");
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
             SqlConnection cnn = new SqlConnection(@"Data Source=172.17.199.15;Initial Catalog=desafio2;
                                      User ID=dupla2;Password=dupla2@2022;Connect Timeout=30;
                                      Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;
                                      MultiSubnetFailover=False");
            SqlCommand com = new SqlCommand();
            com.Connection = cnn;
            cnn.Open();
            string login = "select *from User_New where Usuario ='"+txtUser.Text+"' and Senha = '" + txtPassword.Text + "'";
            com = new SqlCommand(login, cnn);
            SqlDataReader dr = com.ExecuteReader();
             
            if (dr.Read() == true)
            {
                this.Visible = false; //esconde formulario de login
                new MenuRestrito().Show();
            }
            else
            {
                MessageBox.Show("User/Senha estão incorretos","Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUser.Text = "";
                txtPassword.Text = "";
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var cad = new TelaCadastro();
            cad.Show();
        }
    }
}