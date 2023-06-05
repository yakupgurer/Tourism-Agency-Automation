using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
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
        private Form activeForm;
        private Random random;
        public anaEkran()
        {

            InitializeComponent();
           
            
            random = new Random();
        }

    
        private void anaEkran_Load(object sender, EventArgs e)
        {
            homeEkran home = new homeEkran();
            OpenChildForm(home, sender);
            con = new SqlConnection("Data Source=DESKTOP-T4D8TPN\\SQLEXPRESS01;Initial Catalog=SeyahatAcenteOtomasyonuDB;Integrated Security=True");
        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
                activeForm.Close();
            
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelForms.Controls.Add(childForm);
            this.panelForms.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            labelTop.Text = childForm.Text;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Color randomColor = GetRandomColor();
            panelRenk.BackColor = randomColor;
            panelRenk.Top = button3.Top;
            panelRenk.Visible = true;
            //this.Hide();
            personeller person = new personeller();
            OpenChildForm(person, sender);
            //person.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            Color randomColor = GetRandomColor();
            panelRenk.BackColor = randomColor;
            panelRenk.Top = button2.Top;
            panelRenk.Visible = true;
            yurtdisiSeferler y_disi = new yurtdisiSeferler();
            OpenChildForm(y_disi, sender);

            //this.Hide();
            //y_disi.Show();

        }
        private Color GetRandomColor()
        {
            return Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Color randomColor = GetRandomColor();
            panelRenk.BackColor = randomColor;
            panelRenk.Top = button1.Top;
            panelRenk.Visible = true;
            yurticiSeferler y_ici = new yurticiSeferler();
            OpenChildForm(y_ici, sender);
            //this.Hide();
            //y_ici.Show();

        }

        private void button11_Click(object sender, EventArgs e)
        {
            Color randomColor = GetRandomColor();
            panelRenk.BackColor = randomColor;
            panelRenk.Top = button11.Top;
            panelRenk.Visible = true;
            aracTakip otobusTakip = new aracTakip();
            if (uyeGiris.KullaniciID == 2 || uyeGiris.KullaniciID == 1)
            {
                //this.Hide();
                //otobusTakip.Show();
                OpenChildForm(otobusTakip, sender);
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
            Color randomColor = GetRandomColor();
            panelRenk.BackColor = randomColor;
            panelRenk.Top = button6.Top;
            panelRenk.Visible = true;
            musteriler musteriForm = new musteriler();
            OpenChildForm(musteriForm, sender);
            //this.Hide();
            //musteriForm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Color randomColor = GetRandomColor();
            panelRenk.BackColor = randomColor;
            panelRenk.Top = button4.Top;
            panelRenk.Visible = true;
            otobusler otobusKoltuklari = new otobusler();
            OpenChildForm(otobusKoltuklari, sender);
            //this.Hide();
            //otobusKoltuklari.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Color randomColor = GetRandomColor();
            panelRenk.BackColor = randomColor;
            panelRenk.Top = button5.Top;
            panelRenk.Visible = true;
            yaklasanIsler isler = new yaklasanIsler();
            if (uyeGiris.KullaniciID == 2 || uyeGiris.KullaniciID == 1)
            {
                //this.Hide();
                //isler.Show();
                OpenChildForm(isler, sender);
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

            Color randomColor = GetRandomColor();
            panelRenk.BackColor = randomColor;
            panelRenk.Top = button8.Top;
            panelRenk.Visible = true;
            guvenlik security = new guvenlik();

            if (uyeGiris.KullaniciID == 2 || uyeGiris.KullaniciID == 1)
            {
                //this.Hide();
                //security.Show();
                OpenChildForm(security, sender);
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
            Color randomColor = GetRandomColor();
            panelRenk.BackColor = randomColor;
            panelRenk.Top = button9.Top;
            panelRenk.Visible = true;
            ekonomi ekonomi = new ekonomi();
            if (uyeGiris.KullaniciID == 2 || uyeGiris.KullaniciID == 1)
            {
                //this.Hide();
                //ekonomi.Show();
                OpenChildForm(ekonomi, sender);
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

        private void anaEkran_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void panelRenk_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            homeEkran home = new homeEkran();
            OpenChildForm(home, sender);
            panelRenk.Visible = false;
        }
    }
}
