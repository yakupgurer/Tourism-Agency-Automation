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
    public partial class musteriler : Form
    {

        SqlConnection con;
        SqlCommand komut;
        SqlDataAdapter da;
       
        public musteriler()
        {
            InitializeComponent();
        }

        void veriyukle()
        {
            
            
            con.Open();
            da = new SqlDataAdapter("select * from seferMusteri", con);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            musteriGrid.DataSource = tablo;
            con.Close();
            musteriGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

        }
        void nereyeAl()
        {
            con.Close();
            komut = new SqlCommand("SELECT seferler.id,seferler.nereye, sehirler.sehirler FROM seferler JOIN sehirler ON seferler.nereye = sehirler.id where seferler.id=" + seferBox.Text);
            komut.Connection = con;
            komut.CommandType = CommandType.Text;

            SqlDataReader dr;
            con.Open();
            dr = komut.ExecuteReader();
            while (dr.Read())
            {
                labelnereye.Text = dr["sehirler"].ToString();
            }
            con.Close();
        }

        void neredenAl()
        {
            con.Close();
            komut = new SqlCommand("SELECT seferler.id,seferler.nereden, sehirler.sehirler FROM seferler JOIN sehirler ON seferler.nereden = sehirler.id where seferler.id="+seferBox.Text);
            komut.Connection = con;
            komut.CommandType = CommandType.Text;

            SqlDataReader dr;
            con.Open();
            dr = komut.ExecuteReader();
            while (dr.Read())
            {
                labelnereden.Text = dr["sehirler"].ToString();
            }
            con.Close();
        }
        void seferidAl()
        {
            con.Close();
            komut = new SqlCommand("SELECT DISTINCT id,nereye From seferler");
            komut.Connection = con;
            komut.CommandType = CommandType.Text;

            SqlDataReader dr;
            con.Open();
            dr = komut.ExecuteReader();
            while (dr.Read())
            {
                seferBox.Items.Add(dr["id"]);
            }
            con.Close();
        }
        private void musteriler_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=DESKTOP-T4D8TPN\\SQLEXPRESS01;Initial Catalog=SeyahatAcenteOtomasyonuDB;Integrated Security=True");
            veriyukle();
            seferidAl();
            
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            con.Close();
            DialogResult ekleme = MessageBox.Show("Seçili kayıt veritabanına eklenecektir.Emin misiniz ?", "Kayıt Ekleme", MessageBoxButtons.YesNo);
            if (ekleme == DialogResult.Yes)
            {
                if (!KoltukNoKontrol(koltukBox.Text))
                {
                    string sorgu = "INSERT INTO seferMusteri(musteriAd,musteriSoyad,seferid,musteriKoltukNo) VALUES (@musteriAd,@musteriSoyad,@seferid,@musteriKoltukNo)";
                    komut = new SqlCommand(sorgu, con);
                    komut.Parameters.AddWithValue("@musteriAd", musteriAd.Text);
                    komut.Parameters.AddWithValue("@musteriSoyad", musteriSoyad.Text);
                    komut.Parameters.AddWithValue("@seferid", seferBox.Text);
                    komut.Parameters.AddWithValue("@musteriKoltukNo", koltukBox.Text);
                    con.Open();
                    komut.ExecuteNonQuery();
                    con.Close();

                    string sorgu2 = "INSERT INTO gelirgider(tarih,gelir,gider,aciklama) VALUES(@tarih,@gelir,@gider,'BILET SATISI')";
                    komut = new SqlCommand(sorgu2, con);
                    komut.Parameters.AddWithValue("@tarih", DateTime.Now);
                    komut.Parameters.AddWithValue("@gelir", 250);
                    komut.Parameters.AddWithValue("@gider", 0);
                    con.Open();
                    komut.ExecuteNonQuery();
                    con.Close();

                    string sorgu3 = "INSERT INTO degisiklikler(islemTuru,islemBolumu,islemTarihi,userid) VALUES('Ekleme',@bolum,@tarih,@userid)";
                    komut = new SqlCommand(sorgu3, con);
                    komut.Parameters.AddWithValue("@tarih", DateTime.Now);
                    komut.Parameters.AddWithValue("userid", uyeGiris.KullaniciID);
                    komut.Parameters.AddWithValue("@bolum", "Musteriler:  " + musteriAd.Text + " " + musteriSoyad.Text + " Sefer ID: " + seferBox.Text);
                    con.Open();
                    komut.ExecuteNonQuery();
                    con.Close();

                    
                    
                   

                    
                    try
                    {
                        //seferekleMail();
                    }
                    catch
                    {
                        //MessageBox.Show("Sefer kayıt altına alındı ancak görevli personele bilgilendirici mail gönderilemedi.", "Mail İletilemedi");
                        //veriyukle();
                    }
                    veriyukle();
                    MessageBox.Show("Kayıt başarıyla eklendi.", "Bilgilendirme");
                }
                else
                {
                    MessageBox.Show("Bu koltuk numarası zaten kullanılmaktadır. Lütfen farklı bir koltuk numarası seçin.", "Hata");
                }
            }


        }

       

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            con.Close();
            DialogResult guncelleme = MessageBox.Show("Seçili kayıt veritabanında güncellenecektir.Emin misiniz ?", "Kayıt Güncelleme", MessageBoxButtons.YesNo);
            if (guncelleme == DialogResult.Yes)
            {
                string sorgu = "UPDATE seferMusteri SET musteriAd=@musteriAd,musteriSoyad=@musteriSoyad,seferid=@seferid,musteriKoltukNo=@musteriKoltukNo WHERE musterid=@id";
                komut = new SqlCommand(sorgu, con);
                komut.Parameters.AddWithValue("@id", Convert.ToInt32(labelid.Text));
                komut.Parameters.AddWithValue("@musteriAd", Convert.ToString(musteriAd.Text));
                komut.Parameters.AddWithValue("@musteriSoyad", Convert.ToString(musteriSoyad.Text));
                komut.Parameters.AddWithValue("@seferid", Convert.ToInt32(seferBox.Text));
                komut.Parameters.AddWithValue("@musteriKoltukNo", Convert.ToInt32(koltukBox.Text));
                

                con.Open();
                komut.ExecuteNonQuery();
                con.Close();

                string sorgu2 = "INSERT INTO degisiklikler(islemTuru,islemBolumu,islemTarihi,userid) VALUES('Guncelleme',@bolum,@tarih,@userid)";
                komut = new SqlCommand(sorgu2, con);
                komut.Parameters.AddWithValue("@tarih", DateTime.Now);
                komut.Parameters.AddWithValue("userid", uyeGiris.KullaniciID);
                komut.Parameters.AddWithValue("@bolum", "Musteriler:  " + musteriAd.Text + " " + musteriSoyad.Text + " Sefer ID: " + seferBox.Text);
                con.Open();
                komut.ExecuteNonQuery();
                con.Close();
                
                try
                {
                    //seferguncelleMail();
                }
                catch
                {
                    //MessageBox.Show("Sefer güncellendi ancak görevli personele bilgilendiri mail gönderilemedi.", "Mail İletilemedi");
                    //veriyukle();
                }
                veriyukle();
                MessageBox.Show("Kayıt başarıyla güncellendi.", "Bilgilendirme");
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            con.Close();
            DialogResult silme = MessageBox.Show("Seçili kayıt veritabanından silinecektir.Emin misiniz ?", "Kayıt Silme", MessageBoxButtons.YesNo);
            if (silme == DialogResult.Yes)
            {
                string sorgu = "DELETE FROM seferMusteri WHERE musterid=@id";
                komut = new SqlCommand(sorgu, con);
                komut.Parameters.AddWithValue("@id", Convert.ToInt32(labelid.Text));
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
                komut.Parameters.AddWithValue("@bolum", "Musteriler:  " + musteriAd.Text + " " + musteriSoyad.Text + " Sefer ID: " + seferBox.Text);
                con.Open();
                komut.ExecuteNonQuery();
                con.Close();

               

                try
                {
                    //sefersilMail();
                }
                catch
                {
                    //MessageBox.Show("Sefer silindi ancak görevli personele bilgilendiri mail gönderilemedi.", "Mail İletilemedi");
                    //veriyukle();
                }

                veriyukle();
                MessageBox.Show("Kayıt başarıyla silindi.", "Bilgilendirme");
            }
        }
        private bool KoltukNoKontrol(string koltukNo)
        {
            con.Close(); // Bağlantıyı önceden kapatıyoruz (eğer açıksa) ve yeniden açıyoruz.

            string sorgu = "SELECT COUNT(*) FROM seferMusteri WHERE seferid = @seferid AND musteriKoltukNo = @koltukNo";
            // Veritabanına sorgu göndermek için kullanılacak SQL sorgusu.
            // Bu sorgu, seferid ve musteriKoltukNo değerlerine sahip kayıtları sayacak.

            komut = new SqlCommand(sorgu, con);
            // SqlCommand nesnesi oluşturuluyor ve sorgu ile birlikte bağlantıya atanıyor.

            komut.Parameters.AddWithValue("@seferid", seferBox.Text);
            komut.Parameters.AddWithValue("@koltukNo", koltukNo);
            // Sorgudaki parametreler atanıyor. @seferid ve @koltukNo parametrelerine karşılık gelen değerler seferBox.Text ve koltukNo olarak belirtiliyor.

            con.Open(); // Bağlantı açılıyor.

            int count = (int)komut.ExecuteScalar();
            // Sorguyu veritabanında çalıştırarak, dönen sonuç kümesindeki ilk sütunu ve ilk satırını döndüren ExecuteScalar() metodu kullanılıyor.
            // Bu durumda, COUNT(*) değeri elde edilir, yani aynı seferid ve musteriKoltukNo değerlerine sahip kayıt sayısı.

            con.Close(); // Bağlantı kapatılıyor.

            return count > 0;
            // Kayıt sayısı 0'dan büyükse, aynı koltuk numarasının kullanıldığı anlamına gelir ve true değeri döndürülür.
            // Aksi halde, yani kayıt sayısı 0 veya daha azsa, false değeri döndürülür.
        }

        private void musteriGrid_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            
            labelid.Text = musteriGrid.CurrentRow.Cells[0].Value.ToString();
            musteriAd.Text = musteriGrid.CurrentRow.Cells[1].Value.ToString();
            musteriSoyad.Text = musteriGrid.CurrentRow.Cells[2].Value.ToString();
            seferBox.Text = musteriGrid.CurrentRow.Cells[3].Value.ToString();
            koltukBox.Text = musteriGrid.CurrentRow.Cells[4].Value.ToString();
            
        }

        private void seferBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            neredenAl();
            nereyeAl();
            labelnereden.Visible = true;
            labelnereye.Visible = true;
            label6.Visible = true;
        }

        private void musteriGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            anaEkran home = new anaEkran();
            this.Hide();
            home.Show();
        }

        private void musteriler_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }
    }
    }

