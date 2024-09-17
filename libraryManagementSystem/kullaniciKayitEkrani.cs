using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using libraryManagementSystem.Models;



namespace libraryManagementSystem
{
    public partial class kullaniciKayitEkrani : Form
    {
        string connectionString = "Server=DESKTOP-MRHPS49\\SQLEXPRESS;Database=kütüphaneDatabase;Integrated Security=true;";
        string query;
        

        public kullaniciKayitEkrani()
        {
            InitializeComponent();
        }

        private void kullaniciKayitEkrani_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            Console.WriteLine("Bağlantı açıldı.");

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            
            frm1.Show();
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

        private void registerBttn_Click(object sender, EventArgs e)
        {
            string kayitisim = kayitusrname.Text;
            string kayitsifre = kayitpasswd.Text;
            register rgstr1 = new register(kayitisim,kayitsifre);
            rgstr1.kayıtEkle();
            kayitusrname.Clear();
            kayitpasswd.Clear();
         


        }
    }
}
