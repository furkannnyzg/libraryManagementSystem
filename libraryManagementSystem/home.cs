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
    public partial class home : Form
    {
        public home()
        {
            InitializeComponent();
        }

        private void home_Load(object sender, EventArgs e)
        {

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

        private void cıkısYap_Click(object sender, EventArgs e)
        {
            var result=MessageBox.Show("Çıkış Yapmak İstediğinize Emin Misiniz?","Form'dan çıkış yapılıyor.",MessageBoxButtons.YesNo,MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           Members member =new Members();
            member.Show();
            Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Books book = new Books();
            book.Show();
            Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Loan odunc = new Loan(); 
            odunc.Show();
            Hide();
        }
    }
}
