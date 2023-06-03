using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.Sql;
using System.Data.SqlClient;
using System.Security.Cryptography;

namespace Seyahat_Acentasi_Otomasyonu
{
    public partial class uyeGiris : Form
    {
        SqlConnection con;
        SqlDataReader dr;
        SqlCommand com;
        
        anaEkran uyefrm = new anaEkran(); // diğer form sayfaları tanımlamaları
        public static int KullaniciID { get; set; }
        public uyeGiris()
        {
            InitializeComponent();

        }
        
       
        private void uyeGiris_Load(object sender, EventArgs e)
        {
            
            
            
        }
        private string HashPassword(string password) // Şifrenin hash değerini hesaplayan fonksiyon
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(password));

                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2")); // Hexadecimal format
                }
                return builder.ToString();
            }
        }
        private void btnGiris_Click(object sender, EventArgs e)
        {
            string user = textBox1.Text;
            string password = textBox2.Text;
            string hashedPassword = HashPassword(password); // Girilen şifrenin hash değerini al
            con = new SqlConnection("Data Source=DESKTOP-T4D8TPN\\SQLEXPRESS01;Initial Catalog=SeyahatAcenteOtomasyonuDB;Integrated Security=True");
            com = new SqlCommand();
            con.Open();
            com.Connection = con;
            com.CommandText = "SELECT * FROM users WHERE kullanici_adi='" + user + "' AND kullanici_pw='" + hashedPassword + "'";
            dr = com.ExecuteReader();
            if (dr.Read())
            {
                MessageBox.Show("Tebrikler Giriş Başarılı");
                KullaniciID = Convert.ToInt32(dr["id"]); // Kullanıcının ID'sini değişkene atayın
                con.Close();
                string sorgu2 = "INSERT INTO degisiklikler(islemTuru,islemBolumu,islemTarihi,userid) VALUES('Uye Girisi',@bolum,@tarih,@userid)";
                com = new SqlCommand(sorgu2, con);
                com.Parameters.AddWithValue("@tarih", DateTime.Now);
                com.Parameters.AddWithValue("userid", uyeGiris.KullaniciID);
                com.Parameters.AddWithValue("@bolum", "SISTEM User : " + user);
                con.Open();
                com.ExecuteNonQuery();
                con.Close();
                

                uyefrm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Kullanıcı Adı veya Şifre");
            }
        }
    }

       
    }

