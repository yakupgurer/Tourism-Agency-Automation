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

    public partial class anaEkran : Form
    {

        SqlConnection con;
        SqlCommand komut;
        SqlDataAdapter da;

        public anaEkran()
        {

            InitializeComponent();

        }

        private void anaEkran_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            personeller person = new personeller();
            person.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            yurtdisiSeferler y_disi = new yurtdisiSeferler();
            this.Hide();
            y_disi.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            yurticiSeferler y_ici = new yurticiSeferler();
            this.Hide();
            y_ici.Show();

        }

        private void button11_Click(object sender, EventArgs e)
        {

            aracTakip otobusTakip = new aracTakip();
            if (uyeGiris.KullaniciID == 2 || uyeGiris.KullaniciID == 1)
            {
                this.Hide();
                otobusTakip.Show();
            }
            else
            {
                string sorgu2 = "INSERT INTO degisiklikler(islemTuru,islemBolumu,islemTarihi,userid) VALUES('Erisim Denemesi','Arac Takip Sistemi',@tarih,@userid)";
                komut = new SqlCommand(sorgu2, con);
                komut.Parameters.AddWithValue("@tarih", DateTime.Now);
                komut.Parameters.AddWithValue("userid", uyeGiris.KullaniciID);
                con.Open();
                komut.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Bu alana girmek icin yetkiniz yok.", "Uyarı");

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            musteriler musteriForm = new musteriler();
            this.Hide();
            musteriForm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            otobusler otobusKoltuklari = new otobusler();
            this.Hide();
            otobusKoltuklari.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            yaklasanIsler isler = new yaklasanIsler();
            if (uyeGiris.KullaniciID == 2 || uyeGiris.KullaniciID == 1)
            {
                this.Hide();
                isler.Show();
            }
            else
            {
                string sorgu2 = "INSERT INTO degisiklikler(islemTuru,islemBolumu,islemTarihi,userid) VALUES('Erisim Denemesi','Yaklasan Isler',@tarih,@userid)";
                komut = new SqlCommand(sorgu2, con);
                komut.Parameters.AddWithValue("@tarih", DateTime.Now);
                komut.Parameters.AddWithValue("userid", uyeGiris.KullaniciID);
                con.Open();
                komut.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Bu alana girmek icin yetkiniz yok.", "Uyarı");
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            guvenlik security = new guvenlik();

            if (uyeGiris.KullaniciID == 2 || uyeGiris.KullaniciID == 1)
            {
                this.Hide();
                security.Show();
            }
            else
            {
                string sorgu2 = "INSERT INTO degisiklikler(islemTuru,islemBolumu,islemTarihi,userid) VALUES('Erisim Denemesi','Guvenlik',@tarih,@userid)";
                komut = new SqlCommand(sorgu2, con);
                komut.Parameters.AddWithValue("@tarih", DateTime.Now);
                komut.Parameters.AddWithValue("userid", uyeGiris.KullaniciID);
                con.Open();
                komut.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Bu alana girmek icin yetkiniz yok.", "Uyarı");
            }
        }

       

        private void button9_Click(object sender, EventArgs e)
        {
            ekonomi ekonomi = new ekonomi();
            if (uyeGiris.KullaniciID == 2 || uyeGiris.KullaniciID == 1)
            {
                this.Hide();
                ekonomi.Show();
            }
            else
            {
                string sorgu2 = "INSERT INTO degisiklikler(islemTuru,islemBolumu,islemTarihi,userid) VALUES('Erisim Denemesi','Ekonomi',@tarih,@userid)";
                komut = new SqlCommand(sorgu2, con);
                komut.Parameters.AddWithValue("@tarih", DateTime.Now);
                komut.Parameters.AddWithValue("userid", uyeGiris.KullaniciID);
                con.Open();
                komut.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Bu alana girmek icin yetkiniz yok.", "Uyarı");
            }
        }
    }
}
