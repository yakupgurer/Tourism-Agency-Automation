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
    public partial class ekonomi : Form
    {
        SqlConnection con;
        SqlDataAdapter da;
        SqlCommand komut;
        public ekonomi()
        {
            InitializeComponent();
        }

        void veriyukle()
        {
            con = new SqlConnection("Data Source=DESKTOP-T4D8TPN\\SQLEXPRESS01;Initial Catalog=SeyahatAcenteOtomasyonuDB;Integrated Security=True");
            con.Open();
            da = new SqlDataAdapter("SELECT * FROM gelirgider", con);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            veriGrid.DataSource = tablo;
            con.Close();
            veriGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }
        private void ekonomi_Load(object sender, EventArgs e)
        {
            veriyukle();
        }

        private void veriGrid_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            labelid.Text = veriGrid.CurrentRow.Cells[0].Value.ToString();
            textGelir.Text = veriGrid.CurrentRow.Cells[2].Value.ToString();
            textGider.Text = veriGrid.CurrentRow.Cells[3].Value.ToString();
            textAciklama.Text = veriGrid.CurrentRow.Cells[4].Value.ToString();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            DialogResult ekleme = MessageBox.Show("Kayıt veritabanına eklenecektir.Emin misiniz ?", "Kayıt Ekleme", MessageBoxButtons.YesNo);
            if (ekleme == DialogResult.Yes)
            {

                string sorgu = "INSERT INTO gelirgider(tarih,gelir,gider,aciklama) VALUES (@tarih,@gelir,@gider,@aciklama)";
                komut = new SqlCommand(sorgu, con);
                komut.Parameters.AddWithValue("@tarih", DateTime.Now);
                komut.Parameters.AddWithValue("@gelir", textGelir.Text);
                komut.Parameters.AddWithValue("@gider", textGider.Text);
                komut.Parameters.AddWithValue("@aciklama", textAciklama.Text);
                
                con.Open();
                komut.ExecuteNonQuery();
                con.Close();

                string sorgu2 = "INSERT INTO degisiklikler(islemTuru,islemBolumu,islemTarihi,userid) VALUES('Ekleme',@bolum,@tarih,@userid)";
                komut = new SqlCommand(sorgu2, con);
                komut.Parameters.AddWithValue("@tarih", DateTime.Now);
                komut.Parameters.AddWithValue("userid", uyeGiris.KullaniciID);
                komut.Parameters.AddWithValue("@bolum", "Gelir-Gider: " + textAciklama.Text + " Gelir: " + textGelir.Text+" Gider: "+textGider.Text);
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

                string sorgu = "DELETE FROM gelirgider WHERE id=@id";
                komut = new SqlCommand(sorgu, con);
                komut.Parameters.AddWithValue("@id", Convert.ToInt32(labelid.Text));
                con.Open();
                komut.ExecuteNonQuery();
                con.Close();

                string sorgu2 = "INSERT INTO degisiklikler(islemTuru,islemBolumu,islemTarihi,userid) VALUES('Silme',@bolum,@tarih,@userid)";
                komut = new SqlCommand(sorgu2, con);
                komut.Parameters.AddWithValue("@tarih", DateTime.Now);
                komut.Parameters.AddWithValue("userid", uyeGiris.KullaniciID);
                komut.Parameters.AddWithValue("@bolum", "Gelir-Gider: " + textAciklama.Text + " Gelir: " + textGelir.Text + " Gider: " + textGider.Text);
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
                string sorgu = "UPDATE gelirgider SET tarih=@tarih,gelir=@gelir,gider=@gider,aciklama=@aciklama WHERE id=@id";
                komut = new SqlCommand(sorgu, con);
                komut.Parameters.AddWithValue("@id", Convert.ToInt32(labelid.Text));
                komut.Parameters.AddWithValue("@tarih", DateTime.Now);
                komut.Parameters.AddWithValue("@gelir", textGelir.Text);
                komut.Parameters.AddWithValue("@gider", textGider.Text);
                komut.Parameters.AddWithValue("@aciklama", textAciklama.Text);
                
                con.Open();
                komut.ExecuteNonQuery();
                con.Close();

                string sorgu2 = "INSERT INTO degisiklikler(islemTuru,islemBolumu,islemTarihi,userid) VALUES('Guncelleme',@bolum,@tarih,@userid)";
                komut = new SqlCommand(sorgu2, con);
                komut.Parameters.AddWithValue("@tarih", DateTime.Now);
                komut.Parameters.AddWithValue("userid", uyeGiris.KullaniciID);
                komut.Parameters.AddWithValue("@bolum", "Gelir-Gider: " + textAciklama.Text + " Gelir: " + textGelir.Text + " Gider: " + textGider.Text);
                con.Open();
                komut.ExecuteNonQuery();
                con.Close();
                veriyukle();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            anaEkran home = new anaEkran();
            this.Hide();
            home.Show();
        }
    }
}
