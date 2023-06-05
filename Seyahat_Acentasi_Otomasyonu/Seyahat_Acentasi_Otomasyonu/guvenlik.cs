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
    public partial class guvenlik : Form
    {
        SqlConnection con;
        SqlCommand komut;
        SqlDataAdapter da;
        anaEkran home = new anaEkran();
        public guvenlik()
        {
            InitializeComponent();
        }

        void veriYukle()
        {
            
            con.Open();
            da = new SqlDataAdapter("select * from degisiklikler ORDER BY id DESC", con);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
            con.Close();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }
        private void guvenlik_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=DESKTOP-T4D8TPN\\SQLEXPRESS01;Initial Catalog=SeyahatAcenteOtomasyonuDB;Integrated Security=True");
            veriYukle();
            //uyeGiris.KullaniciID;
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            labelid.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            labelislemTuru.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            labelislemBolumu.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            labelislemTarihi.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            labeluserid.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            
            DialogResult ekleme = MessageBox.Show("Seçili kayıt şüpheli olarak bildirilecektir.Emin misiniz ?", "Şüpheli Kayıt Bildirme", MessageBoxButtons.YesNo);
            if (ekleme == DialogResult.Yes)
            {

               
                    string sorgu = "INSERT INTO yapilacakisler(aciklama,oncelikDuzeyi) VALUES (@aciklama,'3')";
                    komut = new SqlCommand(sorgu, con);
                    komut.Parameters.AddWithValue("@aciklama","ŞÜPHELİ DURUM BİLDİRİSİ ! -----> Islem id: "+labelid.Text+"-----> Islem Turu: "+labelislemTuru.Text+"-----> Islem Bolumu: "+labelislemBolumu.Text+"-----> Islem Tarihi: "+labelislemTarihi.Text+"-----> Islemi Yapan Kullanici ID: "+labeluserid.Text);
                    
                    con.Open();
                    komut.ExecuteNonQuery();
                    con.Close();

                string sorgu2 = "INSERT INTO degisiklikler(islemTuru,islemBolumu,islemTarihi,userid) VALUES('Süpheli Durum Bildirisi',@bolum,@tarih,@userid)";
                komut = new SqlCommand(sorgu2, con);
                komut.Parameters.AddWithValue("@tarih", DateTime.Now);
                komut.Parameters.AddWithValue("userid", uyeGiris.KullaniciID);
                komut.Parameters.AddWithValue("@bolum", "SISTEM Islem ID: " + labelid.Text + " Islem Turu: " + labelislemTuru.Text);
                con.Open();
                komut.ExecuteNonQuery();
                con.Close();

                veriYukle();
                    MessageBox.Show("Kayıt başarıyla şüpheli olarak bildirildi.", "Bilgilendirme");
                

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            home.Show();

        }

        private void guvenlik_FormClosing(object sender, FormClosingEventArgs e)
        {
           
        }
    }
}
