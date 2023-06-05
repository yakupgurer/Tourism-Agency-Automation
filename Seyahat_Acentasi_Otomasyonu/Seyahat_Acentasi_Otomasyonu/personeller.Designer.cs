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
            this.label7 = new System.Windows.Forms.Label();
            this.personelMail = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.personelGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // personelGrid
            // 
            this.personelGrid.AllowUserToAddRows = false;
            this.personelGrid.AllowUserToDeleteRows = false;
            this.personelGrid.AllowUserToResizeColumns = false;
            this.personelGrid.AllowUserToResizeRows = false;
            this.personelGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.personelGrid.Location = new System.Drawing.Point(12, 245);
            this.personelGrid.Name = "personelGrid";
            this.personelGrid.ReadOnly = true;
            this.personelGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.personelGrid.Size = new System.Drawing.Size(880, 302);
            this.personelGrid.TabIndex = 1;
            this.personelGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.personelGrid_CellContentClick);
            this.personelGrid.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.personelGrid_CellEnter);
            // 
            // personel_id
            // 
            this.personel_id.Enabled = false;
            this.personel_id.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.personel_id.Location = new System.Drawing.Point(336, 41);
            this.personel_id.Name = "personel_id";
            this.personel_id.Size = new System.Drawing.Size(168, 21);
            this.personel_id.TabIndex = 2;
            // 
            // personelAd
            // 
            this.personelAd.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.personelAd.Location = new System.Drawing.Point(336, 67);
            this.personelAd.Name = "personelAd";
            this.personelAd.Size = new System.Drawing.Size(168, 21);
            this.personelAd.TabIndex = 3;
            // 
            // personelSoyad
            // 
            this.personelSoyad.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.personelSoyad.Location = new System.Drawing.Point(336, 93);
            this.personelSoyad.Name = "personelSoyad";
            this.personelSoyad.Size = new System.Drawing.Size(168, 21);
            this.personelSoyad.TabIndex = 4;
            // 
            // personelmaas
            // 
            this.personelmaas.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.personelmaas.Location = new System.Drawing.Point(336, 172);
            this.personelmaas.Name = "personelmaas";
            this.personelmaas.Size = new System.Drawing.Size(168, 21);
            this.personelmaas.TabIndex = 6;
            this.personelmaas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.personelmaas_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(303, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "id:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(298, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Ad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(281, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Soyad:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(248, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Doğum Tarihi:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(285, 175);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label5.Size = new System.Drawing.Size(41, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "Maaş:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(269, 153);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "Pozisyon:";
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.Color.LimeGreen;
            this.btnEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEkle.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkle.ForeColor = System.Drawing.Color.White;
            this.btnEkle.Location = new System.Drawing.Point(636, 62);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(99, 39);
            this.btnEkle.TabIndex = 14;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.LimeGreen;
            this.btnSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSil.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.ForeColor = System.Drawing.Color.White;
            this.btnSil.Location = new System.Drawing.Point(636, 107);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(99, 39);
            this.btnSil.TabIndex = 15;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.Color.LimeGreen;
            this.btnGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuncelle.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGuncelle.ForeColor = System.Drawing.Color.White;
            this.btnGuncelle.Location = new System.Drawing.Point(636, 152);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(99, 39);
            this.btnGuncelle.TabIndex = 16;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // personelDogumTarihi
            // 
            this.personelDogumTarihi.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.personelDogumTarihi.Location = new System.Drawing.Point(336, 119);
            this.personelDogumTarihi.Name = "personelDogumTarihi";
            this.personelDogumTarihi.Size = new System.Drawing.Size(168, 21);
            this.personelDogumTarihi.TabIndex = 17;
            // 
            // personelPosition
            // 
            this.personelPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.personelPosition.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.personelPosition.FormattingEnabled = true;
            this.personelPosition.Location = new System.Drawing.Point(336, 145);
            this.personelPosition.Name = "personelPosition";
            this.personelPosition.Size = new System.Drawing.Size(168, 24);
            this.personelPosition.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(291, 201);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label7.Size = new System.Drawing.Size(33, 16);
            this.label7.TabIndex = 12;
            this.label7.Text = "Mail:";
            // 
            // personelMail
            // 
            this.personelMail.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.personelMail.Location = new System.Drawing.Point(336, 201);
            this.personelMail.Name = "personelMail";
            this.personelMail.Size = new System.Drawing.Size(168, 21);
            this.personelMail.TabIndex = 19;
            // 
            // personeller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(904, 559);
            this.Controls.Add(this.personelMail);
            this.Controls.Add(this.personelPosition);
            this.Controls.Add(this.personelDogumTarihi);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
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
            this.Name = "personeller";
            this.Text = "Personeller";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.personeller_FormClosing);
            this.Load += new System.EventHandler(this.personeller_Load);
            ((System.ComponentModel.ISupportInitialize)(this.personelGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox personelMail;
    }
}