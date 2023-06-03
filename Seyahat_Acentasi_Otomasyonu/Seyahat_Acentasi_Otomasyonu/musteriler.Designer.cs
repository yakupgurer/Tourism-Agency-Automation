namespace Seyahat_Acentasi_Otomasyonu
{
    partial class musteriler
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnEkle = new System.Windows.Forms.Button();
            this.musteriGrid = new System.Windows.Forms.DataGridView();
            this.musteriAd = new System.Windows.Forms.TextBox();
            this.musteriSoyad = new System.Windows.Forms.TextBox();
            this.koltukBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.seferBox = new System.Windows.Forms.ComboBox();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.labelid = new System.Windows.Forms.Label();
            this.labelnereden = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelnereye = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.musteriGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(487, 54);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(95, 39);
            this.btnEkle.TabIndex = 0;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // musteriGrid
            // 
            this.musteriGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.musteriGrid.Location = new System.Drawing.Point(12, 242);
            this.musteriGrid.Name = "musteriGrid";
            this.musteriGrid.Size = new System.Drawing.Size(775, 320);
            this.musteriGrid.TabIndex = 3;
            this.musteriGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.musteriGrid_CellContentClick);
            this.musteriGrid.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.musteriGrid_CellEnter);
            // 
            // musteriAd
            // 
            this.musteriAd.Location = new System.Drawing.Point(301, 51);
            this.musteriAd.Name = "musteriAd";
            this.musteriAd.Size = new System.Drawing.Size(148, 20);
            this.musteriAd.TabIndex = 4;
            // 
            // musteriSoyad
            // 
            this.musteriSoyad.Location = new System.Drawing.Point(301, 81);
            this.musteriSoyad.Name = "musteriSoyad";
            this.musteriSoyad.Size = new System.Drawing.Size(148, 20);
            this.musteriSoyad.TabIndex = 5;
            // 
            // koltukBox
            // 
            this.koltukBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.koltukBox.FormattingEnabled = true;
            this.koltukBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36"});
            this.koltukBox.Location = new System.Drawing.Point(301, 119);
            this.koltukBox.Name = "koltukBox";
            this.koltukBox.Size = new System.Drawing.Size(148, 21);
            this.koltukBox.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(233, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Müşteri Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(216, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Müşteri Soyadı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(260, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Sefer:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(238, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Koltuk No:";
            // 
            // seferBox
            // 
            this.seferBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.seferBox.FormattingEnabled = true;
            this.seferBox.Location = new System.Drawing.Point(301, 148);
            this.seferBox.Name = "seferBox";
            this.seferBox.Size = new System.Drawing.Size(148, 21);
            this.seferBox.TabIndex = 9;
            this.seferBox.SelectedIndexChanged += new System.EventHandler(this.seferBox_SelectedIndexChanged);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(487, 141);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(95, 39);
            this.btnGuncelle.TabIndex = 10;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(487, 97);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(95, 39);
            this.btnSil.TabIndex = 11;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // labelid
            // 
            this.labelid.AutoSize = true;
            this.labelid.Location = new System.Drawing.Point(650, 97);
            this.labelid.Name = "labelid";
            this.labelid.Size = new System.Drawing.Size(13, 13);
            this.labelid.TabIndex = 12;
            this.labelid.Text = "0";
            this.labelid.Visible = false;
            // 
            // labelnereden
            // 
            this.labelnereden.AutoSize = true;
            this.labelnereden.Location = new System.Drawing.Point(313, 183);
            this.labelnereden.Name = "labelnereden";
            this.labelnereden.Size = new System.Drawing.Size(48, 13);
            this.labelnereden.TabIndex = 13;
            this.labelnereden.Text = "Nereden";
            this.labelnereden.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(393, 183);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(10, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "-";
            this.label6.Visible = false;
            // 
            // labelnereye
            // 
            this.labelnereye.AutoSize = true;
            this.labelnereye.Location = new System.Drawing.Point(409, 183);
            this.labelnereye.Name = "labelnereye";
            this.labelnereye.Size = new System.Drawing.Size(41, 13);
            this.labelnereye.TabIndex = 15;
            this.labelnereye.Text = "Nereye";
            this.labelnereye.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(230, 183);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Sefer Türü:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(59, 92);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 43);
            this.button1.TabIndex = 17;
            this.button1.Text = "Ana Ekran";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // musteriler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 574);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.labelnereye);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.labelnereden);
            this.Controls.Add(this.labelid);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.seferBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.koltukBox);
            this.Controls.Add(this.musteriSoyad);
            this.Controls.Add(this.musteriAd);
            this.Controls.Add(this.musteriGrid);
            this.Controls.Add(this.btnEkle);
            this.Name = "musteriler";
            this.Text = "musteriler";
            this.Load += new System.EventHandler(this.musteriler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.musteriGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.DataGridView musteriGrid;
        private System.Windows.Forms.TextBox musteriAd;
        private System.Windows.Forms.TextBox musteriSoyad;
        private System.Windows.Forms.ComboBox koltukBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox seferBox;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Label labelid;
        private System.Windows.Forms.Label labelnereden;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelnereye;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
    }
}