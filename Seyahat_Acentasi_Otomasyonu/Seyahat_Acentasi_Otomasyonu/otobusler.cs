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
    public partial class otobusler : Form
    {
        SqlConnection con;
        SqlCommand komut;
        SqlDataAdapter da;

        public string musteriAd;
        public string musteriSoyad;

        void veriYukle()
        {
            
            komut = new SqlCommand("SELECT DISTINCT otobus.plaka FROM seferMusteri JOIN seferler ON seferMusteri.seferid = seferler.id JOIN otobus ON seferler.otobusid = otobus.id;");
            komut.Connection = con;
            komut.CommandType = CommandType.Text;

            SqlDataReader dr;
            con.Open();
            dr = komut.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr["plaka"]);
            }
            con.Close();

            komut = new SqlCommand("SELECT DISTINCT sehirler.sehirler FROM seferler JOIN sehirler ON sehirler.id = seferler.nereye;");
            komut.Connection = con;
            komut.CommandType = CommandType.Text;

            con.Open();
            dr = komut.ExecuteReader();
            while (dr.Read())
            {
                comboBox2.Items.Add(dr["sehirler"]);
            }
            con.Close();


        }
        public otobusler()
        {
            InitializeComponent();
            foreach (Control control in Controls) // sağ tık için
            {
                if (control is Button koltukButton)
                {
                    koltukButton.ContextMenuStrip = new ContextMenuStrip();
                    koltukButton.ContextMenuStrip.Items.Add("Müşteri Bilgilerine Eriş", null, OnMusteriBilgilerineEris);
                    koltukButton.ContextMenuStrip.Items.Add("Müşteriyi Sil", null, OnMusteriSil);
                }
            }
            btnGetir.ContextMenuStrip = new ContextMenuStrip(); // getir butonu sağ tık devre dışı bırakmak için yeni nesne oluşturuyoruz...
        }

        private void otobusler_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=DESKTOP-T4D8TPN\\SQLEXPRESS01;Initial Catalog=SeyahatAcenteOtomasyonuDB;Integrated Security=True");
            veriYukle();
        }

        private void btnGetir_Click(object sender, EventArgs e)
        {
            // butonların arkaplan rengi ayarlama
            foreach (Control control in Controls)
            {
                // butonları belirleme
                if (control is Button koltukButton)
                {
                    // butonların arkaplan rengini beyaz olarak ayarlama
                    koltukButton.BackColor = Color.White;
                }
            }
            btnGetir.BackColor = Color.LimeGreen; // getir buttonunun rengini korumak için

            // ComboBox'lardan seçilen otobüs plakası ve şehir bilgisini alma
            string selectedPlaka = comboBox1.SelectedItem?.ToString();
            string selectedSehir = comboBox2.SelectedItem?.ToString();

            // Her iki seçim de yapıldıysa devam ...
            if (selectedPlaka != null && selectedSehir != null)
            {
                

                
                string sorgu = "SELECT seferMusteri.musteriKoltukNo FROM seferMusteri " +
                               "JOIN seferler ON seferMusteri.seferid = seferler.id " +
                               "JOIN otobus ON seferler.otobusid = otobus.id " +
                               "JOIN sehirler ON seferler.nereye = sehirler.id " +
                               "WHERE otobus.plaka = @plaka AND sehirler.sehirler = @sehir";
                komut = new SqlCommand(sorgu, con);
                komut.Parameters.AddWithValue("@plaka", selectedPlaka);
                komut.Parameters.AddWithValue("@sehir", selectedSehir);

                SqlDataReader dr;
                con.Open();
                dr = komut.ExecuteReader();

                // dbden okunan her bir kayıt için işlemleri gerçekleştirme
                while (dr.Read())
                {
                    // koltuk numarası alma
                    string koltukNo = dr["musteriKoltukNo"].ToString();

                    // koltuk dugmesi bulma ve arkaplan rengini kırmızı olarak ayarlama
                    Control koltukButton = Controls.Find("button" + koltukNo, true).FirstOrDefault();
                    if (koltukButton is Button button)
                    {
                        button.BackColor = Color.Red;
                        button.Enabled = true;

                        // Koltuk düğmesine sağ tık menüsü özelliğini ekleme
                        button.ContextMenuStrip = new ContextMenuStrip();
                        button.ContextMenuStrip.Items.Add("Müşteri Bilgilerine Eriş", null, OnMusteriBilgilerineEris);
                        button.ContextMenuStrip.Items.Add("Müşteriyi Sil", null, OnMusteriSil);
                        button.ContextMenuStrip.Tag = koltukNo; // Koltuk numarasını etikete kaydetme
                    }
                }

                
                con.Close();
            }

        }

        private void OnMusteriBilgilerineEris(object sender, EventArgs e)
        {
            ToolStripMenuItem menuItem = (ToolStripMenuItem)sender;
            ContextMenuStrip menu = (ContextMenuStrip)menuItem.Owner;
            Button koltukButton = (Button)menu.SourceControl;

            // Koltuk numarasını etiketten alın
            string koltukNo = koltukButton.ContextMenuStrip.Tag.ToString();

            try
            {
                // Boş koltuk olduğunu kontrol etmek için SQL sorgusu oluşturun
                string sorgu = "SELECT COUNT(*) FROM seferMusteri WHERE musteriKoltukNo = @koltukNo";
                komut = new SqlCommand(sorgu, con);
                komut.Parameters.AddWithValue("@koltukNo", koltukNo);

                con.Open();
                int count = (int)komut.ExecuteScalar();
                con.Close();

                if (count == 0)
                {
                    MessageBox.Show("Bu koltuk boş.");
                }
                else
                {
                    // Koltuk dolu ise müşteri bilgilerini alın ve MessageBox ile gösterin
                    sorgu = "SELECT musteriAd, musteriSoyad FROM seferMusteri WHERE musteriKoltukNo = @koltukNo";
                    komut = new SqlCommand(sorgu, con);
                    komut.Parameters.AddWithValue("@koltukNo", koltukNo);

                    con.Open();
                    SqlDataReader dr = komut.ExecuteReader();
                    if (dr.Read())
                    {
                        musteriAd = dr["musteriAd"].ToString();
                        musteriSoyad = dr["musteriSoyad"].ToString();
                        MessageBox.Show("Müşteri Adı: " + musteriAd + "\nMüşteri Soyadı: " + musteriSoyad);
                    }
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
            }
        }

        private void OnMusteriSil(object sender, EventArgs e)
        {
            ToolStripMenuItem menuItem = (ToolStripMenuItem)sender;
            ContextMenuStrip menu = (ContextMenuStrip)menuItem.Owner;
            Button koltukButton = (Button)menu.SourceControl;

            // Koltuk numarasını etiketten alın
            string koltukNo = koltukButton.ContextMenuStrip.Tag.ToString();

            try
            {
                // Boş koltuk olduğunu kontrol etmek için SQL sorgusu oluşturun
                string sorgu = "SELECT COUNT(*) FROM seferMusteri WHERE musteriKoltukNo = @koltukNo";
                komut = new SqlCommand(sorgu, con);
                komut.Parameters.AddWithValue("@koltukNo", koltukNo);

                con.Open();
                int count = (int)komut.ExecuteScalar();
                con.Close();

                if (count == 0)
                {
                    MessageBox.Show("Bu koltuk boş.");
                }
                else
                {
                    // Koltuk dolu ise müşteriyi silmek için SQL sorgusu oluşturun
                    sorgu = "DELETE FROM seferMusteri WHERE musteriKoltukNo = @koltukNo";
                    komut = new SqlCommand(sorgu, con);
                    komut.Parameters.AddWithValue("@koltukNo", koltukNo);

                    con.Open();
                    komut.ExecuteNonQuery();
                    con.Close();

                    string sorgu2 = "INSERT INTO gelirgider(tarih,gelir,gider,aciklama) VALUES(@tarih,@gelir,@gider,'BILET IPTALI')";
                    komut = new SqlCommand(sorgu2, con);
                    komut.Parameters.AddWithValue("@tarih", DateTime.Now);
                    komut.Parameters.AddWithValue("@gelir", 0);
                    komut.Parameters.AddWithValue("@gider", 250);
                    con.Open();
                    komut.ExecuteNonQuery();
                    con.Close();

                    string sorgu3 = "INSERT INTO degisiklikler(islemTuru,islemBolumu,islemTarihi,userid) VALUES('Silme',@bolum,@tarih,@userid)";
                    komut = new SqlCommand(sorgu3, con);
                    komut.Parameters.AddWithValue("@tarih", DateTime.Now);
                    komut.Parameters.AddWithValue("userid", uyeGiris.KullaniciID);
                    komut.Parameters.AddWithValue("@bolum", "Otobus-Musteriler: " + musteriAd + " " + musteriSoyad + " " + comboBox2.Text);
                    con.Open();
                    komut.ExecuteNonQuery();
                    con.Close();
                    

                    MessageBox.Show("Müşteri başarıyla silindi.");

                    // Koltuk düğmesinin arkaplan rengini tekrar beyaz yapın
                    koltukButton.BackColor = Color.White;
                    koltukButton.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
            }
        }

        private void button37_Click(object sender, EventArgs e)
        {
            anaEkran home = new anaEkran();
            this.Hide();
            home.Show();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void otobusler_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void button32_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }

}
    
