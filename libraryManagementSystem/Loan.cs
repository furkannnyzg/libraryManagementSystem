using libraryManagementSystem.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace libraryManagementSystem
{
    public partial class Loan : Form
    {

        loanaddc loan;
        loanaddc loan2;


        string connectionString = "Server=DESKTOP-MRHPS49\\SQLEXPRESS;Database=kütüphaneDatabase;Integrated Security=true;";
        string query;
        public Loan()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmBoxKitapİsmi_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Loan_Load(object sender, EventArgs e)
        {
            loan = new loanaddc();
            List<string> kitaplar = loan.kitaplariGetir();
            cmBoxKitapİsmi.Items.AddRange(kitaplar.ToArray());

            List<string> uyeler = loan.isimlerigetir();
            cmboxÜyeİsmi.Items.AddRange(uyeler.ToArray());
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            home home = new home();
            home.Show();
            Hide();
        }





        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;


        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point diff = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(diff));
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void loanaddBtn_Click(object sender, EventArgs e)
        {
            
            string uyeismi=cmboxÜyeİsmi.SelectedItem.ToString();
            string kitapismi=cmBoxKitapİsmi.SelectedItem.ToString();

            loan2 = new loanaddc(uyeismi,kitapismi);
            loan2.vtEkle();
            
        }

        private void loanshowBtn_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                try
                {
                    query = "select * from tblLoan";
                    SqlDataAdapter sqlDA = new SqlDataAdapter(query, conn);
                    DataTable dtbl = new DataTable();
                    sqlDA.Fill(dtbl);

                    loanGridView.DataSource = dtbl;


                }
                catch (Exception ex)
                {

                    MessageBox.Show("Bir hata oluştu: " + ex.Message);
                }




            }
        }
    }
}
