using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace libraryManagementSystem.Models
{
    public class login
    {

        public string kullaniciusr { get; set; }
        public string kullanicipswd { get; set; }

        public bool dogrumu { get; set; }

        string connectionString = "Server=DESKTOP-MRHPS49\\SQLEXPRESS;Database=kütüphaneDatabase;Integrated Security=true;";
        string query;

        public login() { }
        public login(string username, string passwd)
        {
            this.kullaniciusr = username;
            this.kullanicipswd = passwd;
        }


        public void girisYap()
        {

            using (SqlConnection conn = new SqlConnection(connectionString)) {
                try
                {
                    conn.Open();

                    if (!string.IsNullOrWhiteSpace(kullaniciusr) && !string.IsNullOrWhiteSpace(kullanicipswd))
                    {
                        query = $"select COUNT(*) from tblKullanicilar where KullaniciAdi='{kullaniciusr}' and KullaniciSifre='{kullanicipswd}'";
                        SqlCommand cmd = new SqlCommand(query, conn);

                        int kontrol=(int)cmd.ExecuteScalar();//farklı şekilde okuma türleri var affected kısımlarını bunlardan birisi scalar ilk satırı alıyormuş.  

                        if (kontrol > 0)
                        {
                            MessageBox.Show($"Giriş başarılı. Hoşgeldiniz Sayın {kullaniciusr}");
                            dogrumu = true; 
                        }
                        else {
                            MessageBox.Show("Kullanıcı adı veya şifre Hatalı. Lütfen yeniden deneyiniz.");
                            dogrumu = false;
                        }

                    }
                    else if (string.IsNullOrWhiteSpace(kullaniciusr) && !string.IsNullOrWhiteSpace(kullanicipswd))
                    {
                        MessageBox.Show("Lütfen kayıt isminizi boş bırakmayınız!!!");
                    }
                    else if (!string.IsNullOrWhiteSpace(kullaniciusr) && string.IsNullOrWhiteSpace(kullanicipswd))
                    {
                        MessageBox.Show("Lütfen kayıt şifrenizi boş bırakmayınız!!!");
                    }
                    else if (string.IsNullOrWhiteSpace(kullaniciusr) && string.IsNullOrWhiteSpace(kullanicipswd))
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
