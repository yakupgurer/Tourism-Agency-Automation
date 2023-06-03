    using GMap.NET.MapProviders;
    using GMap.NET;
    using GMap.NET.WindowsForms;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;
    using GMap.NET.WindowsForms.Markers;
using System.Data.SqlClient;

    namespace Seyahat_Acentasi_Otomasyonu
    {
    public partial class aracTakip : Form
    {
        private GMapOverlay markersOverlay;
        SqlConnection con;
        SqlCommand komut;
        SqlDataAdapter da;
        public aracTakip()
        {
            InitializeComponent();

        }

        void veriyukle()
        {

            con = new SqlConnection("Data Source=DESKTOP-T4D8TPN\\SQLEXPRESS01;Initial Catalog=SeyahatAcenteOtomasyonuDB;Integrated Security=True");

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
                plakalar.Items.Add(dr["plaka"]);
            }
            con.Close();
        }

           

        void latAl()
        {
            
            con.Close();
            komut = new SqlCommand("SELECT l.lat, l.lng FROM otobus o JOIN location l ON o.id = l.id WHERE o.plaka = '" + plakalar.Text + "'");
            komut.Connection = con;
            komut.CommandType = CommandType.Text;
            con.Open();
            komut.ExecuteNonQuery();
            SqlDataReader dr;
            dr = komut.ExecuteReader(); // veri okuma komutu
            while (dr.Read())
            {
                textBox1.Text = dr["lat"].ToString();
            }
            dr.Close();
            con.Close();



        }

        void lngAl()
        {
            con.Close();
            komut = new SqlCommand("SELECT l.lat, l.lng FROM otobus o JOIN location l ON o.id = l.id WHERE o.plaka = '" + plakalar.Text + "'");
            komut.Connection = con;
            komut.CommandType = CommandType.Text;
            con.Open();
            komut.ExecuteNonQuery();
            SqlDataReader dr;
            dr = komut.ExecuteReader(); // veri okuma komutu
            while (dr.Read())
            {
                textBox2.Text = dr["lng"].ToString();
            }
            dr.Close();
            con.Close();

            
        }
        private void aracTakip_Load(object sender, EventArgs e)
            {
            veriyukle();
            plakaveriYukle();
            // Harita sağlayıcısını ayarlayın (OpenStreetMap kullanıldı)
            mapG.MapProvider = GMapProviders.GoogleMap;

            // Haritayı başlangıç konumu ile görüntüleyin
            double defaultLat = 0; // başlangıç enlem değeri
            double defaultLng = 0; // başlangıç boylam değeri
            mapG.Position = new PointLatLng(defaultLat, defaultLng);

            // Marker overlay'ini oluşturun
            markersOverlay = new GMapOverlay("markers");
            mapG.CanDragMap = true;
            mapG.ShowCenter = false;
                                    
        }

            private void BtnGetLocation_Click(object sender, EventArgs e)
            {
            // Lat ve Lng değerlerini al
            latAl();
            lngAl();

            string sorgu2 = "INSERT INTO degisiklikler(islemTuru,islemBolumu,islemTarihi,userid) VALUES('Arac Takip',@bolum,@tarih,@userid)";
            komut = new SqlCommand(sorgu2, con);
            komut.Parameters.AddWithValue("@tarih", DateTime.Now);
            komut.Parameters.AddWithValue("userid", uyeGiris.KullaniciID);
            komut.Parameters.AddWithValue("@bolum", "Arac Takip Sistemi. Arac Takip Plaka: " + plakalar.Text);
            con.Open();
            komut.ExecuteNonQuery();
            con.Close();
            timer1.Enabled = true;
            
        }

        private void mapG_Load(object sender, EventArgs e)
        {
            mapG.DragButton = MouseButtons.Left;
            mapG.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            mapG.MinZoom = 2;
            mapG.MaxZoom = 18;
            mapG.Zoom = 2;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            latAl();
            lngAl();
            double lat, lng;

            if (!double.TryParse(textBox1.Text, out lat) || !double.TryParse(textBox2.Text, out lng))
            {
                MessageBox.Show("Geçersiz enlem veya boylam değeri!");
                return;
            }

            // Marker overlay'ini temizle
            markersOverlay.Markers.Clear();

            // Yeni marker'ı oluştur ve haritaya ekle
            PointLatLng point = new PointLatLng(lat, lng);
            GMarkerGoogle marker = new GMarkerGoogle(point, GMarkerGoogleType.red);
            markersOverlay.Markers.Add(marker);
            mapG.Overlays.Add(markersOverlay);

            // Haritayı güncelle
            //mapG.Position = point;
            //mapG.Zoom = 4; // Yakınlaştırma düzeyini istediğiniz seviyeye ayarlayın
        }

        private void button1_Click(object sender, EventArgs e)
        {
            anaEkran home = new anaEkran();
            this.Hide();
            home.Show();
        }
    }
    }
