using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace libraryManagementSystem.Models
{
    public class loanaddc
    {

        string connectionString = "Server=DESKTOP-MRHPS49\\SQLEXPRESS;Database=kütüphaneDatabase;Integrated Security=true;";
        string query;
        string query2;
        List<string> list, list2;
        int count;

        public string uyeismi { get; set; }
        public string kitapismi { get; set; }
        

        public loanaddc () { }
        public loanaddc(string isim, string kitap) {
        
        this.uyeismi = isim;
        this.kitapismi = kitap;
        
        }



        public List<string> kitaplariGetir() {

            list = new List<string>();
            
            

            using (SqlConnection conn=new SqlConnection(connectionString))
            {

                conn.Open();

                try { 


                    /*using bloğuyla bu nesneleri kullandığında, işin bittiğinde bu nesnelerin otomatik olarak kapanacağı garanti edilmiş olur.Böylece manuel olarak kapatma gereği ortadan kalkar.*/

                    query = "select KitapIsmi from tblKitaplar";
                   
                    SqlCommand cmd = new SqlCommand(query, conn);

                   //sql için reader diye bir olay var.
                    using (SqlCommand command = new SqlCommand(query, conn))
                    {
                        
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                          
                            while (reader.Read())
                            {
                               
                                list.Add(reader["KitapIsmi"].ToString());
                            }
                        }
                    }






                }
                catch (Exception ex )
                {

                    MessageBox.Show("Böyle bir hatayla karşılaşıldı: "+ex.Message);
                }

            }
        
        return list;
        }

        public List<string> isimlerigetir() {

            list2 = new List<string>();


            using (SqlConnection conn = new SqlConnection(connectionString))
            {

                conn.Open();

                try
                { 
                    query2 = "select UyeIsmi from tblUyeler ";

                    SqlCommand cmd = new SqlCommand(query2, conn);

                    //sql için reader diye bir olay var.
                    using (SqlCommand command = new SqlCommand(query2, conn))
                    {

                        using (SqlDataReader reader = command.ExecuteReader())
                        {

                            while (reader.Read())
                            {

                                list2.Add(reader["UyeIsmi"].ToString());
                            }
                        }
                    }

                }
                catch (Exception ex)
                {

                    MessageBox.Show("Böyle bir hatayla karşılaşıldı: " + ex.Message);
                }

            }

            return list2;

        }



        public void vtEkle() {


            using (SqlConnection conn = new SqlConnection(connectionString)) {
                conn.Open ();

                try
                {
                    query = $"insert into tblLoan values ('{kitapismi}','{uyeismi}') ";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    int satır = cmd.ExecuteNonQuery();



                    if (satır > 0)
                    {
                        MessageBox.Show("Kullanıcı başarıyla kaydedildi.");


                    }
                    else
                    {
                        MessageBox.Show("Kayıt işlemi başarısız.");

                    }


                }
                catch (Exception ex)
                {

                    MessageBox.Show("Alınan hata: " + ex);
                }

            }
        
        
        
        }




    }


    




}
