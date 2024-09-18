using libraryManagementSystem.Models;
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

namespace libraryManagementSystem
{
    public partial class Members : Form
    {



        home home;

        string connectionString = "Server=DESKTOP-MRHPS49\\SQLEXPRESS;Database=kütüphaneDatabase;Integrated Security=true;";
        string query;
        public Members()
        {
            InitializeComponent();
        }

        private void Members_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            home =new home();
            home.Show();
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string isim=memberNametextBox.Text;
            string telno=contactNotextBox.Text;

            memberveri veri=new memberveri(isim,telno);

            veri.uyeekle();

            memberNametextBox.Clear();
            contactNotextBox.Clear();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString)) {
            
                conn.Open();

                try
                {
                    query = "select * from tblUyeler";
                    SqlDataAdapter sqlDA = new SqlDataAdapter(query,conn);
                    DataTable dtbl=new DataTable();
                    sqlDA.Fill(dtbl);

                    memberGridView.DataSource = dtbl;


                }
                catch (Exception ex)
                {

                    MessageBox.Show("Bir hata oluştu: " + ex.Message);
                }
            
            
            
            
            }            
        }
    }
}
