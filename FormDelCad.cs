using System;
using System.Data;
using System.Data.SqlClient;


namespace AppNovo
{
    public partial class FormDelCad : Form
    {
        readonly SqlConnection cnn = new SqlConnection(@"Data Source=172.17.199.15;Initial Catalog=desafio2;
                                      User ID=dupla2;Password=dupla2@2022;Connect Timeout=30;
                                      Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;
                                      MultiSubnetFailover=False"); 
        public FormDelCad()
        {
            InitializeComponent();
            
        }

        private void FormDelCad_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                cnn.Open();
                
                string Id = textBox1.Text.ToString();
                

                /*                SqlDataAdapter sda = new SqlDataAdapter("select * from Reachers where Id = '" + Id + "'", cnn);
                */
                string query = "delete from Reachers where Id='" + Id + "'";

                SqlCommand sc = new SqlCommand(query, cnn);
                int i = sc.ExecuteNonQuery();

                if (i >= 1)
                {
                    MessageBox.Show("Cadastro Deletado!","Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cnn.Close();
                }
                else MessageBox.Show("Erro ao Deletar!!!");
                
                Close();
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            string query = "select * from Reachers where Id='"+ ((TextBox)sender).Text  +"'";
            SqlDataAdapter sda = new SqlDataAdapter(query, cnn);

            DataTable dt = new DataTable();
            sda.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                textBox2.Text = dr["Full_Name"].ToString();
                textBox3.Text = dr["Matrícula"].ToString();
                textBox4.Text = dr["Setor"].ToString();
                textBox5.Text = dr["Mail"].ToString();
            }

        }
    }
}
