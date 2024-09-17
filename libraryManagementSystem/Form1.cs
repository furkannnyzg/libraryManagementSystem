using libraryManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace libraryManagementSystem
{
    public partial class Form1 : Form
    {

        kullaniciKayitEkrani frm2;
        home formHome;
        

        public Form1()
        {
            InitializeComponent();
            


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm2 = new kullaniciKayitEkrani();
            
            frm2.Show();
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

        private void kapa(object sender, EventArgs e)
        {
            Form1 frm1=new Form1();
            Application.Exit();
        }

        private void rstBttn_Click(object sender, EventArgs e)
        {
            usrnameTextBox.Clear();
            passwdTextBox.Clear();
        }

        private void lgnBttn_Click(object sender, EventArgs e)
        {
            string kullaniciGirisiusr = usrnameTextBox.Text;
            string kullaniciGirisipswd=passwdTextBox.Text;
            login lgn1=new login(kullaniciGirisiusr,kullaniciGirisipswd);

            lgn1.girisYap();

            if (lgn1.dogrumu == true)
            {
                formHome = new home();
                formHome.Show();
                Hide();
            }
            else {
                usrnameTextBox.Clear();
                passwdTextBox.Clear();  
            }

        }
    }
}
