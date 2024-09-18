using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace libraryManagementSystem.Models
{
    public class memberveri
    {

        public string uyeismi { get; set; }
        public string telno { get; set; }


        string connectionString = "Server=DESKTOP-MRHPS49\\SQLEXPRESS;Database=kütüphaneDatabase;Integrated Security=true;";
        string query;

        public memberveri() { } 
        public memberveri(string uyeismi, string telno)
        {
            this.uyeismi = uyeismi;
            this.telno = telno;
        }

        public void uyeekle()
        {
            using (SqlConnection conn=new SqlConnection(connectionString))
            {
                conn.Open();
                try
                {
                    if (!string.IsNullOrWhiteSpace(uyeismi) && !string.IsNullOrWhiteSpace(telno)) {
                        
                    query = $"insert into tblUyeler values ('{uyeismi}','{telno}') ";

                    SqlCommand command= new SqlCommand(query, conn);

                    int satir=command.ExecuteNonQuery();

                    if (satir > 0) {
                        MessageBox.Show("Üye başarıyla eklendi.");
                    }
                    else
                    {
                            MessageBox.Show("Kayıt işlemi başarısız.");

                    }
                    
                    }

                    else if (string.IsNullOrWhiteSpace(uyeismi) && !string.IsNullOrWhiteSpace(telno))
                    {
                        MessageBox.Show("Lütfen üye ismi kısmını boş bırakmayınız!!!");
                    }
                    else if (!string.IsNullOrWhiteSpace(uyeismi) && string.IsNullOrWhiteSpace(telno))
                    {
                        MessageBox.Show("Lütfen telefon no kısmını boş bırakmayınız!!!");
                    }
                    else if (string.IsNullOrWhiteSpace(uyeismi) && string.IsNullOrWhiteSpace(telno))
                    {
                        MessageBox.Show("Lütfen üye ismi kısmını ve telefon no kımını boş bırakmayınız!!!");
                    }

                }
                catch (Exception ex)
                {

                    MessageBox.Show("Bir hata oluştu: " + ex.Message);
                }

            }


        }




    }
}
