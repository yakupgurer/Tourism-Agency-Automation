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


namespace Seyahat_Acentasi_Otomasyonu
{
    public partial class personeller : Form
    {
        anaEkran home = new anaEkran();
        SqlConnection con;
        SqlDataAdapter da;
        SqlCommand komut;


        void veriyukle()
        {
            con = new SqlConnection("Data Source=DESKTOP-T4D8TPN\\SQLEXPRESS01;Initial Catalog=SeyahatAcenteOtomasyonuDB;Integrated Security=True");
            con.Open();
            da = new SqlDataAdapter("SELECT * FROM person", con);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            personelGrid.DataSource = tablo;
            con.Close();
            personelGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        void personelPozisyonYukle()
        {
            komut = new SqlCommand("SELECT DISTINCT personelPozisyon From person");
            komut.Connection = con;
            komut.CommandType = CommandType.Text;

            SqlDataReader dr;
            con.Open();
            dr = komut.ExecuteReader();
            while (dr.Read())
            {
                personelPosition.Items.Add(dr["personelPozisyon"]);
            }
            con.Close();


        }
        public personeller()
        {
            InitializeComponent();
            veriyukle();
            personelPozisyonYukle();
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            home.Show();
        }

        private void personeller_Load(object sender, EventArgs e)
        {
            
        }


        private void personelGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void personelGrid_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            personel_id.Text = personelGrid.CurrentRow.Cells[0].Value.ToString();
            personelAd.Text = personelGrid.CurrentRow.Cells[1].Value.ToString();
            personelSoyad.Text = personelGrid.CurrentRow.Cells[2].Value.ToString();
            personelDogumTarihi.Text = personelGrid.CurrentRow.Cells[3].Value.ToString();
            personelPosition.Text = personelGrid.CurrentRow.Cells[4].Value.ToString();
            personelmaas.Text = personelGrid.CurrentRow.Cells[5].Value.ToString();
            personelMail.Text = personelGrid.CurrentRow.Cells[6].Value.ToString();

        }

        private void personelPozisyon_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            DialogResult ekleme = MessageBox.Show("Kayıt veritabanına eklenecektir.Emin misiniz ?", "Kayıt Ekleme", MessageBoxButtons.YesNo);
            if (ekleme == DialogResult.Yes)
            {

                string sorgu = "INSERT INTO person(personelAdi,personelSoyadi,personelDogumTarihi,personelPozisyon,personelMaas,personelMail) VALUES (@ad,@soyad,@dtarih,@pozisyon,@maas,@personelmail)";
                komut = new SqlCommand(sorgu, con);
                komut.Parameters.AddWithValue("@ad", personelAd.Text);
                komut.Parameters.AddWithValue("@soyad", personelSoyad.Text);
                komut.Parameters.AddWithValue("@dtarih", personelDogumTarihi.Value);
                komut.Parameters.AddWithValue("@maas", personelmaas.Text);
                komut.Parameters.AddWithValue("@pozisyon", personelPosition.Text);
                komut.Parameters.AddWithValue("@personelmail", personelMail.Text);
                con.Open();
                komut.ExecuteNonQuery();
                con.Close();

                string sorgu2 = "INSERT INTO degisiklikler(islemTuru,islemBolumu,islemTarihi,userid) VALUES('Ekleme',@bolum,@tarih,@userid)";
                komut = new SqlCommand(sorgu2, con);
                komut.Parameters.AddWithValue("@tarih", DateTime.Now);
                komut.Parameters.AddWithValue("userid", uyeGiris.KullaniciID);
                komut.Parameters.AddWithValue("@bolum", "Personeller:  " + personelAd.Text +" "+ personelSoyad.Text+" "+personelPosition.Text + " "+personelmaas.Text+" "+personelMail.Text+" "+personelDogumTarihi.Text);
                con.Open();
                komut.ExecuteNonQuery();
                con.Close();
                veriyukle();
            }

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            DialogResult silme = MessageBox.Show("Seçili kayıt veritabanından silinecektir.Emin misiniz ?", "Kayıt Silme", MessageBoxButtons.YesNo);
            if (silme == DialogResult.Yes)
            {

                string sorgu = "DELETE FROM person WHERE id=@id";
                komut = new SqlCommand(sorgu, con);
                komut.Parameters.AddWithValue("@id", Convert.ToInt32(personel_id.Text));
                con.Open();
                komut.ExecuteNonQuery();
                con.Close();

                string sorgu2 = "INSERT INTO degisiklikler(islemTuru,islemBolumu,islemTarihi,userid) VALUES('Silme',@bolum,@tarih,@userid)";
                komut = new SqlCommand(sorgu2, con);
                komut.Parameters.AddWithValue("@tarih", DateTime.Now);
                komut.Parameters.AddWithValue("userid", uyeGiris.KullaniciID);
                komut.Parameters.AddWithValue("@bolum", "Personeller:  " + personelAd.Text + " " + personelSoyad.Text + " " + personelPosition.Text + " " + personelmaas.Text + " " + personelMail.Text + " " + personelDogumTarihi.Text);
                con.Open();
                komut.ExecuteNonQuery();
                con.Close();
                
                veriyukle();
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            DialogResult silme = MessageBox.Show("Seçili kayıt veritabanında güncellenecektir.Emin misiniz ?", "Kayıt Güncelleme", MessageBoxButtons.YesNo);
            if (silme == DialogResult.Yes)
            {
                string sorgu = "UPDATE person SET personelAdi=@ad,personelSoyadi=@soyad,personelDogumTarihi=@dt,personelPozisyon=@pozisyon,personelMaas=@maas,personelMail=@personelmail WHERE id=@id";
                komut = new SqlCommand(sorgu, con);
                komut.Parameters.AddWithValue("@id", Convert.ToInt32(personel_id.Text));
                komut.Parameters.AddWithValue("@ad", personelAd.Text);
                komut.Parameters.AddWithValue("@soyad", personelSoyad.Text);
                komut.Parameters.AddWithValue("@dt", personelDogumTarihi.Value);
                komut.Parameters.AddWithValue("@maas", personelmaas.Text);
                komut.Parameters.AddWithValue("@pozisyon", personelPosition.Text);
                komut.Parameters.AddWithValue("@personelmail", personelMail.Text);
                con.Open();
                komut.ExecuteNonQuery();
                con.Close();

                string sorgu2 = "INSERT INTO degisiklikler(islemTuru,islemBolumu,islemTarihi,userid) VALUES('Guncelleme',@bolum,@tarih,@userid)";
                komut = new SqlCommand(sorgu2, con);
                komut.Parameters.AddWithValue("@tarih", DateTime.Now);
                komut.Parameters.AddWithValue("userid", uyeGiris.KullaniciID);
                komut.Parameters.AddWithValue("@bolum", "Personeller:  " + personelAd.Text + " " + personelSoyad.Text + " " + personelPosition.Text + " " + personelmaas.Text + " " + personelMail.Text + " " + personelDogumTarihi.Text);
                con.Open();
                komut.ExecuteNonQuery();
                con.Close();
                
                veriyukle();
            }


        }

        private void personeller_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void personelmaas_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // If you want, you can allow decimal (float) numbers
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
