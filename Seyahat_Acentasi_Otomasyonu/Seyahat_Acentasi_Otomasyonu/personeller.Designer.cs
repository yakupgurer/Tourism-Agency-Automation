namespace Seyahat_Acentasi_Otomasyonu
{
    partial class personeller
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
            this.back = new System.Windows.Forms.Button();
            this.personelGrid = new System.Windows.Forms.DataGridView();
            this.personel_id = new System.Windows.Forms.TextBox();
            this.personelAd = new System.Windows.Forms.TextBox();
            this.personelSoyad = new System.Windows.Forms.TextBox();
            this.personelmaas = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.personelDogumTarihi = new System.Windows.Forms.DateTimePicker();
            this.personelPosition = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.personelGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(230, 12);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(148, 41);
            this.back.TabIndex = 0;
            this.back.Text = "Ana Ekran";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // personelGrid
            // 
            this.personelGrid.AllowUserToAddRows = false;
            this.personelGrid.AllowUserToDeleteRows = false;
            this.personelGrid.AllowUserToResizeColumns = false;
            this.personelGrid.AllowUserToResizeRows = false;
            this.personelGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.personelGrid.Location = new System.Drawing.Point(50, 281);
            this.personelGrid.Name = "personelGrid";
            this.personelGrid.ReadOnly = true;
            this.personelGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.personelGrid.Size = new System.Drawing.Size(546, 303);
            this.personelGrid.TabIndex = 1;
            this.personelGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.personelGrid_CellContentClick);
            this.personelGrid.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.personelGrid_CellEnter);
            // 
            // personel_id
            // 
            this.personel_id.Enabled = false;
            this.personel_id.Location = new System.Drawing.Point(171, 83);
            this.personel_id.Name = "personel_id";
            this.personel_id.Size = new System.Drawing.Size(218, 20);
            this.personel_id.TabIndex = 2;
            // 
            // personelAd
            // 
            this.personelAd.Location = new System.Drawing.Point(171, 109);
            this.personelAd.Name = "personelAd";
            this.personelAd.Size = new System.Drawing.Size(218, 20);
            this.personelAd.TabIndex = 3;
            // 
            // personelSoyad
            // 
            this.personelSoyad.Location = new System.Drawing.Point(171, 135);
            this.personelSoyad.Name = "personelSoyad";
            this.personelSoyad.Size = new System.Drawing.Size(218, 20);
            this.personelSoyad.TabIndex = 4;
            // 
            // personelmaas
            // 
            this.personelmaas.Location = new System.Drawing.Point(171, 222);
            this.personelmaas.Name = "personelmaas";
            this.personelmaas.Size = new System.Drawing.Size(218, 20);
            this.personelmaas.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(135, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "id:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(130, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Ad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(113, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Soyad:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(80, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Doğum Tarihi:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(113, 222);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Maaş:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(101, 193);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Pozisyon:";
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(446, 88);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(121, 43);
            this.btnEkle.TabIndex = 14;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(446, 137);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(121, 44);
            this.btnSil.TabIndex = 15;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(446, 187);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(121, 49);
            this.btnGuncelle.TabIndex = 16;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // personelDogumTarihi
            // 
            this.personelDogumTarihi.Location = new System.Drawing.Point(171, 162);
            this.personelDogumTarihi.Name = "personelDogumTarihi";
            this.personelDogumTarihi.Size = new System.Drawing.Size(218, 20);
            this.personelDogumTarihi.TabIndex = 17;
            // 
            // personelPosition
            // 
            this.personelPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.personelPosition.FormattingEnabled = true;
            this.personelPosition.Location = new System.Drawing.Point(171, 193);
            this.personelPosition.Name = "personelPosition";
            this.personelPosition.Size = new System.Drawing.Size(218, 21);
            this.personelPosition.TabIndex = 18;
            // 
            // personeller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 624);
            this.Controls.Add(this.personelPosition);
            this.Controls.Add(this.personelDogumTarihi);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.personelmaas);
            this.Controls.Add(this.personelSoyad);
            this.Controls.Add(this.personelAd);
            this.Controls.Add(this.personel_id);
            this.Controls.Add(this.personelGrid);
            this.Controls.Add(this.back);
            this.Name = "personeller";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.personeller_Load);
            ((System.ComponentModel.ISupportInitialize)(this.personelGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button back;
        private System.Windows.Forms.DataGridView personelGrid;
        private System.Windows.Forms.TextBox personel_id;
        private System.Windows.Forms.TextBox personelAd;
        private System.Windows.Forms.TextBox personelSoyad;
        private System.Windows.Forms.TextBox personelmaas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.DateTimePicker personelDogumTarihi;
        private System.Windows.Forms.ComboBox personelPosition;
    }
}