namespace Seyahat_Acentasi_Otomasyonu
{
    partial class yurtdisiSeferler
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
            this.yurtdisiGrid = new System.Windows.Forms.DataGridView();
            this.comboNereye = new System.Windows.Forms.ComboBox();
            this.comboNereden = new System.Windows.Forms.ComboBox();
            this.comboPlaka = new System.Windows.Forms.ComboBox();
            this.comboSofor = new System.Windows.Forms.ComboBox();
            this.yurtdisiTarih = new System.Windows.Forms.DateTimePicker();
            this.textSeferId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.labelOtobusId = new System.Windows.Forms.Label();
            this.labelSoforId = new System.Windows.Forms.Label();
            this.labelNeredenId = new System.Windows.Forms.Label();
            this.labelNereyeId = new System.Windows.Forms.Label();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.comboSoforMail = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.yurtdisiGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(161, 12);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(117, 43);
            this.back.TabIndex = 0;
            this.back.Text = "Ana Ekran";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // yurtdisiGrid
            // 
            this.yurtdisiGrid.AllowUserToAddRows = false;
            this.yurtdisiGrid.AllowUserToDeleteRows = false;
            this.yurtdisiGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.yurtdisiGrid.Location = new System.Drawing.Point(12, 391);
            this.yurtdisiGrid.Name = "yurtdisiGrid";
            this.yurtdisiGrid.ReadOnly = true;
            this.yurtdisiGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.yurtdisiGrid.Size = new System.Drawing.Size(959, 364);
            this.yurtdisiGrid.TabIndex = 1;
            this.yurtdisiGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.yurtdisiGrid_CellContentClick);
            this.yurtdisiGrid.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.yurtdisiGrid_CellEnter);
            // 
            // comboNereye
            // 
            this.comboNereye.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboNereye.FormattingEnabled = true;
            this.comboNereye.Location = new System.Drawing.Point(123, 292);
            this.comboNereye.Name = "comboNereye";
            this.comboNereye.Size = new System.Drawing.Size(200, 21);
            this.comboNereye.TabIndex = 2;
            this.comboNereye.SelectedIndexChanged += new System.EventHandler(this.comboNereye_SelectedIndexChanged);
            // 
            // comboNereden
            // 
            this.comboNereden.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboNereden.FormattingEnabled = true;
            this.comboNereden.Location = new System.Drawing.Point(123, 248);
            this.comboNereden.Name = "comboNereden";
            this.comboNereden.Size = new System.Drawing.Size(200, 21);
            this.comboNereden.TabIndex = 3;
            this.comboNereden.SelectedIndexChanged += new System.EventHandler(this.comboNereden_SelectedIndexChanged);
            // 
            // comboPlaka
            // 
            this.comboPlaka.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboPlaka.FormattingEnabled = true;
            this.comboPlaka.Location = new System.Drawing.Point(123, 121);
            this.comboPlaka.Name = "comboPlaka";
            this.comboPlaka.Size = new System.Drawing.Size(200, 21);
            this.comboPlaka.TabIndex = 4;
            this.comboPlaka.SelectedIndexChanged += new System.EventHandler(this.comboPlaka_SelectedIndexChanged);
            // 
            // comboSofor
            // 
            this.comboSofor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboSofor.FormattingEnabled = true;
            this.comboSofor.Location = new System.Drawing.Point(123, 166);
            this.comboSofor.Name = "comboSofor";
            this.comboSofor.Size = new System.Drawing.Size(200, 21);
            this.comboSofor.TabIndex = 5;
            this.comboSofor.SelectedIndexChanged += new System.EventHandler(this.comboSofor_SelectedIndexChanged);
            // 
            // yurtdisiTarih
            // 
            this.yurtdisiTarih.Location = new System.Drawing.Point(123, 210);
            this.yurtdisiTarih.Name = "yurtdisiTarih";
            this.yurtdisiTarih.Size = new System.Drawing.Size(200, 20);
            this.yurtdisiTarih.TabIndex = 6;
            this.yurtdisiTarih.ValueChanged += new System.EventHandler(this.yurtdisiTarih_ValueChanged);
            // 
            // textSeferId
            // 
            this.textSeferId.Enabled = false;
            this.textSeferId.Location = new System.Drawing.Point(123, 84);
            this.textSeferId.Name = "textSeferId";
            this.textSeferId.Size = new System.Drawing.Size(200, 20);
            this.textSeferId.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Sefer id:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Otobüs Plaka:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Otobüs Şoförü:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Sefer Tarihi:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 251);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Sefer Kalkış Yeri:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 292);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Sefer Gidiş Yeri:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(344, 124);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Otobüs id:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(344, 169);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Şoför id:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(344, 251);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Kalkış Yeri id:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(344, 295);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 13);
            this.label10.TabIndex = 8;
            this.label10.Text = "Gidiş Yeri id:";
            // 
            // labelOtobusId
            // 
            this.labelOtobusId.AutoSize = true;
            this.labelOtobusId.Location = new System.Drawing.Point(405, 124);
            this.labelOtobusId.Name = "labelOtobusId";
            this.labelOtobusId.Size = new System.Drawing.Size(13, 13);
            this.labelOtobusId.TabIndex = 9;
            this.labelOtobusId.Text = "0";
            this.labelOtobusId.Click += new System.EventHandler(this.labelOtobusId_Click);
            // 
            // labelSoforId
            // 
            this.labelSoforId.AutoSize = true;
            this.labelSoforId.Location = new System.Drawing.Point(396, 169);
            this.labelSoforId.Name = "labelSoforId";
            this.labelSoforId.Size = new System.Drawing.Size(13, 13);
            this.labelSoforId.TabIndex = 10;
            this.labelSoforId.Text = "0";
            // 
            // labelNeredenId
            // 
            this.labelNeredenId.AutoSize = true;
            this.labelNeredenId.Location = new System.Drawing.Point(420, 248);
            this.labelNeredenId.Name = "labelNeredenId";
            this.labelNeredenId.Size = new System.Drawing.Size(13, 13);
            this.labelNeredenId.TabIndex = 11;
            this.labelNeredenId.Text = "0";
            // 
            // labelNereyeId
            // 
            this.labelNereyeId.AutoSize = true;
            this.labelNereyeId.Location = new System.Drawing.Point(415, 295);
            this.labelNereyeId.Name = "labelNereyeId";
            this.labelNereyeId.Size = new System.Drawing.Size(13, 13);
            this.labelNereyeId.TabIndex = 12;
            this.labelNereyeId.Text = "0";
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(455, 108);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(101, 46);
            this.btnEkle.TabIndex = 13;
            this.btnEkle.Text = "Sefer Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(455, 186);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(101, 44);
            this.btnSil.TabIndex = 14;
            this.btnSil.Text = "Sefer Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(455, 262);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(101, 44);
            this.btnGuncelle.TabIndex = 15;
            this.btnGuncelle.Text = "Sefer Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(25, 334);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(88, 13);
            this.label11.TabIndex = 8;
            this.label11.Text = "Şoför İrtibat Maili:";
            // 
            // comboSoforMail
            // 
            this.comboSoforMail.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboSoforMail.Enabled = false;
            this.comboSoforMail.FormattingEnabled = true;
            this.comboSoforMail.Location = new System.Drawing.Point(123, 331);
            this.comboSoforMail.Name = "comboSoforMail";
            this.comboSoforMail.Size = new System.Drawing.Size(200, 21);
            this.comboSoforMail.TabIndex = 16;
            // 
            // yurtdisiSeferler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 776);
            this.Controls.Add(this.comboSoforMail);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.labelNereyeId);
            this.Controls.Add(this.labelNeredenId);
            this.Controls.Add(this.labelSoforId);
            this.Controls.Add(this.labelOtobusId);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textSeferId);
            this.Controls.Add(this.yurtdisiTarih);
            this.Controls.Add(this.comboSofor);
            this.Controls.Add(this.comboPlaka);
            this.Controls.Add(this.comboNereden);
            this.Controls.Add(this.comboNereye);
            this.Controls.Add(this.yurtdisiGrid);
            this.Controls.Add(this.back);
            this.Name = "yurtdisiSeferler";
            this.Text = "yurtdisiSeferler";
            this.Load += new System.EventHandler(this.yurtdisiSeferler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.yurtdisiGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button back;
        private System.Windows.Forms.DataGridView yurtdisiGrid;
        private System.Windows.Forms.ComboBox comboNereye;
        private System.Windows.Forms.ComboBox comboNereden;
        private System.Windows.Forms.ComboBox comboPlaka;
        private System.Windows.Forms.ComboBox comboSofor;
        private System.Windows.Forms.DateTimePicker yurtdisiTarih;
        private System.Windows.Forms.TextBox textSeferId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label labelOtobusId;
        private System.Windows.Forms.Label labelSoforId;
        private System.Windows.Forms.Label labelNeredenId;
        private System.Windows.Forms.Label labelNereyeId;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox comboSoforMail;
    }
}