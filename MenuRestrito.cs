using Microsoft.SqlServer.Server;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AppNovo
{
    public partial class MenuRestrito : Form
    {

        readonly SqlConnection cnn = new SqlConnection(@"Data Source=172.17.199.15;Initial Catalog=desafio2;
                                      User ID=dupla2;Password=dupla2@2022;Connect Timeout=30;
                                      Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;
                                      MultiSubnetFailover=False");
        public MenuRestrito()
        {
            InitializeComponent();
            show(); 
        }
        private void MenuRestrito_Load(object sender, EventArgs e)
        {
            show();
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            Dispose();
            Close();
        }

        private void btn_CadData_Click(object sender, EventArgs e)
        {
            
            new FormCreate().Show();
            show();
            
        }
        private void btn_Delete_Click(object sender, EventArgs e)
        {
            new FormDelCad().Show();
                show();
        }

        private void btn_UpData_Click(object sender, EventArgs e)
        {
            new FormUpdateData().Show();
            show();
        }

        public void show() //mostra dados na dataGrid
        {
            
            SqlDataAdapter sda = new SqlDataAdapter("select * from Reachers", cnn);
            
            DataTable dt = new DataTable();
            sda.Fill(dt);

            dataGridView1.Rows.Clear();
            foreach(DataRow dr in dt.Rows)
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = dr[0].ToString();
                dataGridView1.Rows[n].Cells[1].Value = dr[1].ToString();
                dataGridView1.Rows[n].Cells[2].Value = dr[2].ToString();
                dataGridView1.Rows[n].Cells[3].Value = dr[3].ToString();
                dataGridView1.Rows[n].Cells[4].Value = dr[4].ToString();
            }
            
        }
    }
}
