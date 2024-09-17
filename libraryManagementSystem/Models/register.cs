using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace libraryManagementSystem.Models
{
    public class register
    {


        public string username { get; set; }
        public string passwd { get; set; }

        string connectionString = "Server=DESKTOP-MRHPS49\\SQLEXPRESS;Database=kütüphaneDatabase;Integrated Security=true;";
        string query;

        public register() { }
        public register(string username, string passwd)
        {
            this.username = username;
            this.passwd = passwd;
        }


        public void kayıtEkle() {


            using (SqlConnection conn2 = new SqlConnection(connectionString))
            {
                try
                {

                    conn2.Open();
                    
                    if (!string.IsNullOrWhiteSpace(username) && !string.IsNullOrWhiteSpace(passwd))
                    {
                        query = $"insert into tblKullanicilar values ('{username}','{passwd}') ";
                        /*
                         sorguyu farklı şekildede çalıştırcabiliriz.
                         query="INSERT INTO tblKullanicilar (KullaniciAdi, Sifre) VALUES (@KullaniciAdi, @Sifre)";
                         veri tabanında değişken tanımlıyoruz sonrasında 
                         
                        command.Parameters.AddWithValue("@KullaniciAdi", kayitisim);
                         
                        command.Parameters.AddWithValue("@Sifre", kayitsifre);  değerleri giriyoruz.
                         */
                        SqlCommand command = new SqlCommand(query, conn2);
                        int satır = command.ExecuteNonQuery();



                        if (satır > 0)
                        {
                            MessageBox.Show("Kullanıcı başarıyla kaydedildi.");
                            

                        }
                        else
                        {
                            MessageBox.Show("Kayıt işlemi başarısız.");
                            
                        }


                    }
                    else if (string.IsNullOrWhiteSpace(username) && !string.IsNullOrWhiteSpace(passwd))
                    {
                        MessageBox.Show("Lütfen kayıt isminizi boş bırakmayınız!!!");
                    }
                    else if (!string.IsNullOrWhiteSpace(username) && string.IsNullOrWhiteSpace(passwd))
                    {
                        MessageBox.Show("Lütfen kayıt şifrenizi boş bırakmayınız!!!");
                    }
                    else if (string.IsNullOrWhiteSpace(username) && string.IsNullOrWhiteSpace(passwd))
                    {
                        MessageBox.Show("Lütfen kayıt isminizi ve şifrenizi boş bırakmayınız!!!");
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
