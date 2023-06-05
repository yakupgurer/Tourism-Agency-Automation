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
using System.Net.Mail;


namespace Seyahat_Acentasi_Otomasyonu
{
    public partial class yurticiSeferler : Form
    {

        SqlConnection con;
        SqlCommand komut;
        SqlDataAdapter da;
        public yurticiSeferler()
        {
            InitializeComponent();
            con = new SqlConnection("Data Source=DESKTOP-T4D8TPN\\SQLEXPRESS01;Initial Catalog=SeyahatAcenteOtomasyonuDB;Integrated Security=True");
        }

        private void back_Click(object sender, EventArgs e)
        {
            anaEkran home = new anaEkran();
            this.Hide();
            home.Show();
        }

        void veriyukle()
        {


            con.Open();
            da = new SqlDataAdapter("SELECT seferler.id,personelAdi + ' ' + personelSoyadi AS personelADSOYAD, personelPozisyon, seferturu.tur AS seferturu, sefertarihi,neredenSehir.sehirler AS nereden,nereyeSehir.sehirler AS nereye,plaka,marka,model,km,koltuksayisi,personelMail FROM seferler LEFT JOIN sehirler AS neredenSehir ON neredenSehir.id = seferler.nereden LEFT JOIN sehirler AS nereyeSehir ON nereyeSehir.id = seferler.nereye INNER JOIN OTOBUS ON OTOBUS.id = seferler.otobusid INNER JOIN person ON person.id = seferler.sofor INNER JOIN seferturu ON seferturu.id = seferler.seferturu WHERE seferler.seferturu = '0'", con);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            yurticiGrid.DataSource = tablo;
            con.Close();
            yurticiGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        void plakaveriYukle()
        {
            komut = new SqlCommand("SELECT DISTINCT plaka From otobus");
            komut.Connection = con;
            komut.CommandType = CommandType.Text;

            SqlDataReader dr;
            con.Open();
            dr = komut.ExecuteReader();
            while (dr.Read())
            {
                comboPlaka.Items.Add(dr["plaka"]);
            }
            con.Close();
        }

        void soforveriYukle()
        {
            komut = new SqlCommand("SELECT DISTINCT personelAdi + ' ' + personelSoyadi as personelAdiSoyadi From person where personelPozisyon = 'SOFOR'");
            komut.Connection = con;
            komut.CommandType = CommandType.Text;

            SqlDataReader dr;
            con.Open();
            dr = komut.ExecuteReader();
            while (dr.Read())
            {
                comboSofor.Items.Add(dr["personelAdiSoyadi"]);
            }
            con.Close();
        }

        void soforMailEsle()
        {
            con.Close();
            komut = new SqlCommand("SELECT personelMail from person where personelAdi + ' ' + personelSoyadi='" + comboSofor.Text + "'", con);
            con.Open();
            komut.ExecuteNonQuery();
            SqlDataReader dr;
            dr = komut.ExecuteReader(); // veri okuma komutu
            while (dr.Read())
            {
                comboSoforMail.Text = dr["personelMail"].ToString();
            }
            dr.Close();
            con.Close();
        }
        void soforMailYukle()
        {
            komut = new SqlCommand("SELECT DISTINCT personelMail From person");
            komut.Connection = con;
            komut.CommandType = CommandType.Text;

            SqlDataReader dr;
            con.Open();
            dr = komut.ExecuteReader();
            while (dr.Read())
            {
                comboSoforMail.Items.Add(dr["personelMail"]);
            }
            con.Close();
        }
        void seferekleMail()
        {
            MailMessage soformesaj = new MailMessage();
            SmtpClient istemci = new SmtpClient("outlook.com");
            istemci.Credentials = new System.Net.NetworkCredential("uludagturizm_proje@outlook.com", "UludagTurizmProje");
            istemci.Port = 587;
            istemci.Host = "smtp.outlook.com";
            istemci.EnableSsl = true;
            soformesaj.To.Add("yakup.gurer12345@gmail.com");
            soformesaj.From = new MailAddress("uludagturizm_proje@outlook.com");
            soformesaj.Subject = "YENİ SEFER DÜZENLEMESİ";
            soformesaj.Body = "MERHABA SAYIN " + comboSofor.Text + " ! ULUDAĞ TURİZM BÜNYESİNDE ADINIZA YENİ SEFER DÜZENLEMESİ YAPILDI. SEFER BİLGİLERİNİZ : \n" +
                "\nOTOBÜS PLAKA: " + comboPlaka.Text +
                "\nSEFER TARİHİ: " + otobusTarih.Value +
                "\nSEFER KALKIŞ YERİ: " + otobusNereden.Text +
                "\nSEFER GİDİŞ YERİ: " + otobusNereye.Text +
                "\nSEFER TÜRÜ: YURTİÇİ";
            istemci.Send(soformesaj);
        }
        void sefersilMail()
        {
            MailMessage soformesaj = new MailMessage();
            SmtpClient istemci = new SmtpClient("outlook.com");
            istemci.Credentials = new System.Net.NetworkCredential("uludagturizm_proje@outlook.com", "UludagTurizmProje");
            istemci.Port = 587;
            istemci.Host = "smtp.outlook.com";
            istemci.EnableSsl = true;
            soformesaj.To.Add("yakup.gurer12345@gmail.com");
            soformesaj.From = new MailAddress("uludagturizm_proje@outlook.com");
            soformesaj.Subject = "SEFER İPTALİ";
            soformesaj.Body = "MERHABA SAYIN " + comboSofor.Text + " ! ULUDAĞ TURİZM BÜNYESİNDE ADINIZA KAYITLI SEFER İPTAL OLMUŞTUR.İPTAL OLAN SEFER BİLGİLERİNİZ : \n" +
                "\nOTOBÜS PLAKA: " + comboPlaka.Text +
                "\nSEFER TARİHİ: " + otobusTarih.Value +
                "\nSEFER KALKIŞ YERİ: " + otobusNereden.Text +
                "\nSEFER GİDİŞ YERİ: " + otobusNereye.Text +
                "\nSEFER TÜRÜ: YURTİÇİ";
            istemci.Send(soformesaj);
        }

        void seferguncelleMail()
        {
            MailMessage soformesaj = new MailMessage();
            SmtpClient istemci = new SmtpClient("outlook.com");
            istemci.Credentials = new System.Net.NetworkCredential("uludagturizm_proje@outlook.com", "UludagTurizmProje");
            istemci.Port = 587;
            istemci.Host = "smtp.outlook.com";
            istemci.EnableSsl = true;
            soformesaj.To.Add("yakup.gurer12345@gmail.com");
            soformesaj.From = new MailAddress("uludagturizm_proje@outlook.com");
            soformesaj.Subject = "SEFER GÜNCELLEMESİ";
            soformesaj.Body = "MERHABA SAYIN " + comboSofor.Text + " ! ULUDAĞ TURİZM BÜNYESİNDE ADINIZA SEFER GÜNCELLEMESİ YAPILDI. GÜNCELLENEN SEFER BİLGİLERİNİZ : \n" +
                "\nOTOBÜS PLAKA: " + comboPlaka.Text +
                "\nSEFER TARİHİ: " + otobusTarih.Value +
                "\nSEFER KALKIŞ YERİ: " + otobusNereden.Text +
                "\nSEFER GİDİŞ YERİ: " + otobusNereye.Text +
                "\nSEFER TÜRÜ: YURTİÇİ";
            istemci.Send(soformesaj);
        }

        void otobusNeredenVeriYukle()
        {
            komut = new SqlCommand("SELECT DISTINCT sehirler From sehirler");
            komut.Connection = con;
            komut.CommandType = CommandType.Text;

            SqlDataReader dr;
            con.Open();
            dr = komut.ExecuteReader();
            while (dr.Read())
            {
                otobusNereden.Items.Add(dr["sehirler"]);

            }
            con.Close();
        }

        void otobusNereyeVeriYukle()
        {
            komut = new SqlCommand("SELECT DISTINCT sehirler From sehirler where tur='0'");
            komut.Connection = con;
            komut.CommandType = CommandType.Text;

            SqlDataReader dr;
            con.Open();
            dr = komut.ExecuteReader();
            while (dr.Read())
            {

                otobusNereye.Items.Add(dr["sehirler"]);
            }
            con.Close();
        }

        void plakaidAl()
        {
            con.Close();
            komut = new SqlCommand("SELECT id from otobus where plaka='" + comboPlaka.Text.ToString() + "'", con);
            con.Open();
            komut.ExecuteNonQuery();
            SqlDataReader dr;
            dr = komut.ExecuteReader(); // veri okuma komutu
            while (dr.Read())
            {
                labelotobusId.Text = dr["id"].ToString();
            }
            dr.Close();
            con.Close();

        }

        void soforidAl()
        {
            con.Close();
            komut = new SqlCommand("SELECT id from person where personelAdi + ' ' + personelSoyadi='" + comboSofor.Text.ToString() + "'", con);
            con.Open();
            komut.ExecuteNonQuery();
            SqlDataReader dr;
            dr = komut.ExecuteReader(); // veri okuma komutu
            while (dr.Read())
            {
                labelSoforId.Text = dr["id"].ToString();
            }
            dr.Close();
            con.Close();

        }

        void neredenidAl()
        {
            con.Close();
            komut = new SqlCommand("SELECT id from sehirler where sehirler='" + otobusNereden.Text + "'", con);
            con.Open();
            komut.ExecuteNonQuery();
            SqlDataReader dr;
            dr = komut.ExecuteReader(); // veri okuma komutu
            while (dr.Read())
            {
                labelNeredenId.Text = dr["id"].ToString();
            }
            dr.Close();
            con.Close();

        }

        void nereyeidAl()
        {
            con.Close();
            komut = new SqlCommand("SELECT id from sehirler where sehirler='" + otobusNereye.Text + "'", con);
            con.Open();
            komut.ExecuteNonQuery();
            SqlDataReader dr;
            dr = komut.ExecuteReader(); // veri okuma komutu
            while (dr.Read())
            {
                labelNereyeId.Text = dr["id"].ToString();
            }
            dr.Close();
            con.Close();

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            DateTime secilenTarih = otobusTarih.Value;
            DateTime guncelTarih = DateTime.Now.Date;

            DialogResult guncelle = MessageBox.Show("Seçili kayıt veritabanında güncellenecektir.Emin misiniz ?", "Kayıt Güncelleme", MessageBoxButtons.YesNo);
            if (guncelle == DialogResult.Yes)
            {
                if (secilenTarih < guncelTarih)
                {
                    MessageBox.Show("Geçmiş bir tarihe sefer güncellenemez !", "Sefer Hatası");
                }
                else
                {

                    string sorgu = "UPDATE seferler SET nereden=@nereden,nereye=@nereye,sofor=@sofor,otobusid=@otobusid,sefertarihi=@sefertarihi WHERE id=@id";
                    komut = new SqlCommand(sorgu, con);
                    komut.Parameters.AddWithValue("@id", Convert.ToInt32(textSeferId.Text));
                    komut.Parameters.AddWithValue("@nereden", Convert.ToInt32(labelNeredenId.Text));
                    komut.Parameters.AddWithValue("@nereye", Convert.ToInt32(labelNereyeId.Text));
                    komut.Parameters.AddWithValue("@sofor", Convert.ToInt32(labelSoforId.Text));
                    komut.Parameters.AddWithValue("@otobusid", Convert.ToInt32(labelotobusId.Text));
                    komut.Parameters.AddWithValue("@sefertarihi", otobusTarih.Value);

                    con.Open();
                    komut.ExecuteNonQuery();
                    con.Close();

                    string sorgu2 = "INSERT INTO degisiklikler(islemTuru,islemBolumu,islemTarihi,userid) VALUES('Guncelleme',@bolum,@tarih,@userid)";
                    komut = new SqlCommand(sorgu2, con);
                    komut.Parameters.AddWithValue("@tarih", DateTime.Now);
                    komut.Parameters.AddWithValue("userid", uyeGiris.KullaniciID);
                    komut.Parameters.AddWithValue("@bolum", "Yurt Ici Seferler: " + otobusNereden.Text + " - " + otobusNereye.Text + "- Sefer ID: " + textSeferId.Text);
                    con.Open();
                    komut.ExecuteNonQuery();
                    con.Close();
                    veriyukle();
                    try
                    {
                        seferguncelleMail();
                    }
                    catch
                    {
                        MessageBox.Show("Sefer güncellendi ancak görevli personele bilgilendiri mail gönderilemedi.", "Mail İletilemedi");
                        veriyukle();
                    }

                    MessageBox.Show("Kayıt başarıyla güncellendi.", "Bilgilendirme");
                    veriyukle();
                }
            }
        }

        private void yurticiSeferler_Load(object sender, EventArgs e)
        {
            veriyukle();
            plakaveriYukle();
            soforveriYukle();
            otobusNeredenVeriYukle();
            otobusNereyeVeriYukle();
            soforMailYukle();

        }

        private void yurticiGrid_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            comboPlaka.Text = yurticiGrid.CurrentRow.Cells[7].Value.ToString();
            comboSofor.Text = yurticiGrid.CurrentRow.Cells[1].Value.ToString();
            otobusTarih.Text = yurticiGrid.CurrentRow.Cells[4].Value.ToString();
            otobusNereden.Text = yurticiGrid.CurrentRow.Cells[5].Value.ToString();
            otobusNereye.Text = yurticiGrid.CurrentRow.Cells[6].Value.ToString();
            textSeferId.Text = yurticiGrid.CurrentRow.Cells[0].Value.ToString();
            comboSoforMail.Text = yurticiGrid.CurrentRow.Cells[12].Value.ToString();

        }

        private void comboPlaka_SelectedIndexChanged(object sender, EventArgs e)
        {
            plakaidAl();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            DateTime secilenTarih = otobusTarih.Value;
            DateTime guncelTarih = DateTime.Now.Date;

            DialogResult ekle = MessageBox.Show("Seçili kayıt veritabanına eklenecektir.Emin misiniz ?", "Kayıt Ekleme", MessageBoxButtons.YesNo);
            if (ekle == DialogResult.Yes)
            {
                if (secilenTarih < guncelTarih)
                {
                    MessageBox.Show("Geçmiş bir tarihe sefer düzenlenemez !", "Sefer Hatası");
                }
                else {
                    if (labelNeredenId.Text != labelNereyeId.Text)
                    {

                        string sorgu = "INSERT INTO seferler(nereden,nereye,sofor,otobusid,seferturu,sefertarihi) VALUES (@nereden,@nereye,@sofor,@otobusid,@seferturu,@sefertarihi)";
                        komut = new SqlCommand(sorgu, con);
                        komut.Parameters.AddWithValue("@nereden", labelNeredenId.Text);
                        komut.Parameters.AddWithValue("@nereye", labelNereyeId.Text);
                        komut.Parameters.AddWithValue("@sofor", labelSoforId.Text);
                        komut.Parameters.AddWithValue("@otobusid", labelotobusId.Text);
                        komut.Parameters.AddWithValue("@seferturu", "0");
                        komut.Parameters.AddWithValue("@sefertarihi", otobusTarih.Value);
                        con.Open();
                        komut.ExecuteNonQuery();
                        con.Close();

                        string sorgu2 = "INSERT INTO degisiklikler(islemTuru,islemBolumu,islemTarihi,userid) VALUES('Ekleme',@bolum,@tarih,@userid)";
                        komut = new SqlCommand(sorgu2, con);
                        komut.Parameters.AddWithValue("@tarih", DateTime.Now);
                        komut.Parameters.AddWithValue("userid", uyeGiris.KullaniciID);
                        komut.Parameters.AddWithValue("@bolum", "Yurt Ici Seferler: " + otobusNereden.Text + " - " + otobusNereye.Text + "- Sefer ID: " + textSeferId.Text);
                        con.Open();
                        komut.ExecuteNonQuery();
                        con.Close();



                        try
                        {
                            seferekleMail();
                        }
                        catch
                        {
                            MessageBox.Show("Sefer kayıt altına alındı ancak görevli personele bilgilendirici mail gönderilemedi.", "Mail İletilemedi");
                            veriyukle();
                        }

                        MessageBox.Show("Kayıt başarıyla eklendi.", "Bilgilendirme");
                        veriyukle();
                    }
                    else
                    {
                        MessageBox.Show("Otobüsün kalkacağı ve gideceği yer aynı olamaz !", "Sefer Hatası");
                    }
                }
            }
        }
    

        private void comboSofor_SelectedIndexChanged(object sender, EventArgs e)
        {
            soforidAl();
            soforMailEsle();
        }

        private void otobusNereden_SelectedIndexChanged(object sender, EventArgs e)
        {
            neredenidAl();

        }

        private void otobusNereye_SelectedIndexChanged(object sender, EventArgs e)
        {
            nereyeidAl();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            

            DialogResult silme = MessageBox.Show("Seçili kayıt veritabanından silinecektir.Emin misiniz ?", "Kayıt Silme", MessageBoxButtons.YesNo);
            if (silme == DialogResult.Yes)
            {
                string sorgu = "DELETE FROM seferler WHERE id=@id";
                komut = new SqlCommand(sorgu, con);
                komut.Parameters.AddWithValue("@id", Convert.ToInt32(textSeferId.Text));
                con.Open();
                komut.ExecuteNonQuery();
                con.Close();

                string sorgu2 = "INSERT INTO degisiklikler(islemTuru,islemBolumu,islemTarihi,userid) VALUES('Silme',@bolum,@tarih,@userid)";
                komut = new SqlCommand(sorgu2, con);
                komut.Parameters.AddWithValue("@tarih", DateTime.Now);
                komut.Parameters.AddWithValue("userid", uyeGiris.KullaniciID);
                komut.Parameters.AddWithValue("@bolum", "Yurt Ici Seferler: " + otobusNereden.Text + " - " + otobusNereye.Text + "- Sefer ID: " + textSeferId.Text);
                con.Open();
                komut.ExecuteNonQuery();
                con.Close();
                veriyukle();
                try
                {
                    sefersilMail();
                }
                catch
                {
                    MessageBox.Show("Sefer silindi ancak görevli personele bilgilendiri mail gönderilemedi.", "Mail İletilemedi");
                    veriyukle();
                }
                
                MessageBox.Show("Kayıt başarıyla silindi.", "Bilgilendirme");
                veriyukle();

            }
        }

        private void otobusTarih_ValueChanged(object sender, EventArgs e)
        {
            otobusTarih.Format = DateTimePickerFormat.Custom;
            otobusTarih.CustomFormat = "MM/dd/yyyy HH:mm:ss"; // HH 24 saat -> hh 12 saat
        }

        private void yurticiSeferler_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }
    }
}
