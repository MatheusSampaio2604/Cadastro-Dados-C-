using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using TextBox = System.Windows.Forms.TextBox;

namespace AppNovo
{
    public partial class FormUpdateData : Form
    {
        SqlConnection cnn = new SqlConnection(@"Data Source=172.17.199.15;Initial Catalog=desafio2;
                                      User ID=dupla2;Password=dupla2@2022;Connect Timeout=30;
                                      Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;
                                      MultiSubnetFailover=False");

        public FormUpdateData()
        {
            InitializeComponent();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void text_ID_Leave(object sender, EventArgs e)
        {
            string query = "select * from Reachers where Id='" + ((TextBox)sender).Text + "'";
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

        private void btn_Update_Click(object sender, EventArgs e)
        {
            {
                cnn.Open();

                string Id = text_ID.Text.ToString();
                string Nome = textBox2.Text.ToString();
                string Matrícula = textBox3.Text.ToString();
                string Setor = textBox4.Text.ToString();
                string Mail = textBox5.Text.ToString();


                string query = "update Reachers set Full_Name='" + Nome + "', Matrícula='" + Matrícula + "', Setor='" + Setor + "', Mail='" + Mail + "' where Id='" + Id + "'";

                SqlCommand sc = new SqlCommand(query, cnn);
                int i = sc.ExecuteNonQuery();

                if (i >= 1)
                {
                    MessageBox.Show("Cadastro Atualizado!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cnn.Close();
                }
                else MessageBox.Show("Erro ao Deletar!!!");

                Close();
            }
        }
    }
}
