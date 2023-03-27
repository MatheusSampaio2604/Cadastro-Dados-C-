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

namespace AppNovo
{
    public partial class FormCreate : Form
    {
        readonly SqlConnection cnn = new SqlConnection(@"Data Source=172.17.199.15;Initial Catalog=desafio2;
                                      User ID=dupla2;Password=dupla2@2022;Connect Timeout=30;
                                      Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;
                                      MultiSubnetFailover=False");
        public FormCreate()
        {
            InitializeComponent();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_InsData_Click(object sender, EventArgs e)
        {
            try
            {


                cnn.Open();



                string Full_Name = textBox2.Text.ToString();
                string Matrícula = textBox3.Text.ToString();
                string Setor = textBox4.Text.ToString();
                string Mail = textBox5.Text.ToString();

                string query = "insert into Reachers values ('" + Full_Name + "','" + Matrícula + "','" + Setor + "','" + Mail + "')";

                SqlCommand sc = new SqlCommand(query, cnn);
                int i = sc.ExecuteNonQuery();

                if (i >= 1)
                {
                    MessageBox.Show(@"Cadastro Efetuado: {0}", Full_Name);
                    cnn.Close();
                }
                else MessageBox.Show("Cadastro Não Efetuado!");


                
            }
            catch (Exception err)
            {
                MessageBox.Show("Erro: ", err.ToString());
            }
            cnn.Close();
        }


    }
}
            

         

