using libraryManagementSystem.Models;
using System;
using System.Collections;
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
    public partial class Books : Form
    {

        home home;
        string kitapadi, kitapYazar, kitapBaski, kitapyıl;
        kitapveri ktpvr;

        string connectionString = "Server=DESKTOP-MRHPS49\\SQLEXPRESS;Database=kütüphaneDatabase;Integrated Security=true;";
        string query;

        public Books()
        {
            InitializeComponent();
        }

        private void booksGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                try
                {
                    query = "select * from tblKitaplar";
                    SqlDataAdapter sqlDA = new SqlDataAdapter(query, conn);
                    DataTable dtbl = new DataTable();
                    sqlDA.Fill(dtbl);

                    booksGridView.DataSource = dtbl;


                }
                catch (Exception ex)
                {

                    MessageBox.Show("Bir hata oluştu: " + ex.Message);
                }




            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
         kitapadi= bookTitletextBox.Text;
            kitapYazar = bookAuthortextBox.Text;
            kitapBaski=bookGenretextBox.Text;
            kitapyıl=bookYeartextBox.Text;

            ktpvr = new kitapveri(kitapadi,kitapYazar,kitapBaski,kitapyıl);
            ktpvr.kitapEkle();

            bookTitletextBox.Clear();
            bookAuthortextBox.Clear();
            bookGenretextBox.Clear();
            bookYeartextBox.Clear();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            home = new home();
            home.Show();
            Hide();
        }
    }
}
