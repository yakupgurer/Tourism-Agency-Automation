using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Seyahat_Acentasi_Otomasyonu
{
    public partial class yaklasanIsler : Form
    {

        SqlConnection con;
        SqlCommand komut;
        SqlDataAdapter da;
        public yaklasanIsler()
        {
            InitializeComponent();
        }

        void veriyukle()
        {

            con = new SqlConnection("Data Source=DESKTOP-T4D8TPN\\SQLEXPRESS01;Initial Catalog=SeyahatAcenteOtomasyonuDB;Integrated Security=True");
            con.Open();
            da = new SqlDataAdapter("select * from yapilacakisler", con);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
            con.Close();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            islerid.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textAciklama.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            comboPriority.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
        }

        private void yaklasanIsler_Load(object sender, EventArgs e)
        {
            veriyukle();
        }

        

        private void btnPriority_Click(object sender, EventArgs e)
        {
           
            da = new SqlDataAdapter("Select * from yapilacakisler order by oncelikDuzeyi DESC", con);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
            con.Close();

           
            MessageBox.Show("Yapılacak İşler Öncelik Düzeyine Göre Sıralandı.", "Bilgilendirme");
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            DialogResult ekleme = MessageBox.Show("Seçili kayıt veritabanına eklenecektir.Emin misiniz ?", "Kayıt Ekleme", MessageBoxButtons.YesNo);
            if (ekleme == DialogResult.Yes)
            {

                

                    string sorgu = "INSERT INTO yapilacakisler(aciklama,oncelikDuzeyi) VALUES (@aciklama,@oncelikDuzeyi)";
                    komut = new SqlCommand(sorgu, con);
                    komut.Parameters.AddWithValue("@aciklama", textAciklama.Text);
                    komut.Parameters.AddWithValue("@oncelikDuzeyi", comboPriority.Text);
                    con.Open();
                    komut.ExecuteNonQuery();
                    con.Close();

                    string sorgu2 = "INSERT INTO degisiklikler(islemTuru,islemBolumu,islemTarihi,userid) VALUES('Ekleme',@bolum,@tarih,@userid)";
                    komut = new SqlCommand(sorgu2, con);
                    komut.Parameters.AddWithValue("@tarih", DateTime.Now);
                    komut.Parameters.AddWithValue("userid", uyeGiris.KullaniciID);
                    komut.Parameters.AddWithValue("@bolum", "Yaklasan Isler : " + textAciklama.Text);
                    con.Open();
                    komut.ExecuteNonQuery();
                    con.Close();
                
                veriyukle();
                    MessageBox.Show("Kayıt başarıyla eklendi.", "Bilgilendirme");
                }
                

            }

        private void btnSil_Click(object sender, EventArgs e)
        {
            DialogResult silme = MessageBox.Show("Seçili kayıt veritabanından silinecektir.Emin misiniz ?", "Kayıt Silme", MessageBoxButtons.YesNo);
            if (silme == DialogResult.Yes)
            {
                string sorgu = "DELETE FROM yapilacakisler WHERE id=@id";
                komut = new SqlCommand(sorgu, con);
                komut.Parameters.AddWithValue("@id", Convert.ToInt32(islerid.Text));
                con.Open();
                komut.ExecuteNonQuery();
                con.Close();

                string sorgu2 = "INSERT INTO degisiklikler(islemTuru,islemBolumu,islemTarihi,userid) VALUES('Silme',@bolum,@tarih,@userid)";
                komut = new SqlCommand(sorgu2, con);
                komut.Parameters.AddWithValue("@tarih", DateTime.Now);
                komut.Parameters.AddWithValue("userid", uyeGiris.KullaniciID);
                komut.Parameters.AddWithValue("@bolum", "Yaklasan Isler : " + textAciklama.Text);
                con.Open();
                komut.ExecuteNonQuery();
                con.Close();
                

                veriyukle();
                MessageBox.Show("Kayıt başarıyla silindi.", "Bilgilendirme");
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            DialogResult guncelleme = MessageBox.Show("Seçili kayıt veritabanında güncellenecektir.Emin misiniz ?", "Kayıt Güncelleme", MessageBoxButtons.YesNo);
            if (guncelleme == DialogResult.Yes)
            {
                string sorgu = "UPDATE yapilacakisler SET aciklama=@aciklama,oncelikDuzeyi=@oncelikDuzeyi WHERE id=@id";
                komut = new SqlCommand(sorgu, con);
                komut.Parameters.AddWithValue("@id", Convert.ToInt32(islerid.Text));
                komut.Parameters.AddWithValue("@aciklama", Convert.ToString(textAciklama.Text));
                komut.Parameters.AddWithValue("@oncelikDuzeyi", Convert.ToInt32(comboPriority.Text));
                

                con.Open();
                komut.ExecuteNonQuery();
                con.Close();

                string sorgu2 = "INSERT INTO degisiklikler(islemTuru,islemBolumu,islemTarihi,userid) VALUES('Guncelleme',@bolum,@tarih,@userid)";
                komut = new SqlCommand(sorgu2, con);
                komut.Parameters.AddWithValue("@tarih", DateTime.Now);
                komut.Parameters.AddWithValue("userid", uyeGiris.KullaniciID);
                komut.Parameters.AddWithValue("@bolum", "Yaklasan Isler : " + textAciklama.Text);
                con.Open();
                komut.ExecuteNonQuery();
                con.Close();
                
                veriyukle();
                MessageBox.Show("Kayıt başarıyla güncellendi.", "Bilgilendirme");
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            veriyukle();
            MessageBox.Show("Yapılacak İşler Eski Haline Getirildi.", "Bilgilendirme");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            anaEkran home = new anaEkran();
            this.Hide();
            home.Show();
        }
    }
    }

