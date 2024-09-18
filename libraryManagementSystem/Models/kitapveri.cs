using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace libraryManagementSystem.Models
{
    public class kitapveri
    {
       public string kitapismi { get; set; }
       public string kitapYazar { get; set; }
        public string kitapBaski { get; set; }
        public string kitapYıl { get; set; }

        string connectionString = "Server=DESKTOP-MRHPS49\\SQLEXPRESS;Database=kütüphaneDatabase;Integrated Security=true;";
        string query;

        public kitapveri() { }

        public kitapveri(string kitapismi, string kitapYazar, string kitapBaski, string kitapYıl) {

            this.kitapismi = kitapismi;
            this.kitapYazar = kitapYazar;
            this.kitapBaski = kitapBaski;
            this.kitapYıl=kitapYıl;

        }



        public void kitapEkle() {

            using (SqlConnection conn = new SqlConnection(connectionString)) {
            
                conn.Open();
                try
                {
                    query=$"insert into tblKitaplar values ('{kitapismi}','{kitapYazar}','{kitapBaski}','{kitapYıl}')";

                    SqlCommand command = new SqlCommand(query, conn);

                    int satir = command.ExecuteNonQuery();

                    if (satir > 0)
                    {
                        MessageBox.Show("Üye başarıyla eklendi.");
                    }
                    else
                    {
                        MessageBox.Show("Kayıt işlemi başarısız.");

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
