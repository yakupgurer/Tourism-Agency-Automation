namespace Seyahat_Acentasi_Otomasyonu
{
    partial class yurticiSeferler
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.comboPlaka = new System.Windows.Forms.ComboBox();
            this.comboSofor = new System.Windows.Forms.ComboBox();
            this.otobusTarih = new System.Windows.Forms.DateTimePicker();
            this.otobusNereden = new System.Windows.Forms.ComboBox();
            this.otobusNereye = new System.Windows.Forms.ComboBox();
            this.yurticiGrid = new System.Windows.Forms.DataGridView();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.labelotobusId = new System.Windows.Forms.Label();
            this.labelSoforId = new System.Windows.Forms.Label();
            this.labelNeredenId = new System.Windows.Forms.Label();
            this.labelNereyeId = new System.Windows.Forms.Label();
            this.textSeferId = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.comboSoforMail = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.yurticiGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(220, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Otobüs Plaka:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(216, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Otobüs Şoförü:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(229, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Sefer Tarihi:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(205, 151);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "Sefer Kalkış Yeri:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(210, 178);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 16);
            this.label7.TabIndex = 7;
            this.label7.Text = "Sefer Gidiş Yeri:";
            // 
            // comboPlaka
            // 
            this.comboPlaka.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboPlaka.FormattingEnabled = true;
            this.comboPlaka.Location = new System.Drawing.Point(305, 68);
            this.comboPlaka.Name = "comboPlaka";
            this.comboPlaka.Size = new System.Drawing.Size(168, 21);
            this.comboPlaka.TabIndex = 9;
            this.comboPlaka.SelectedIndexChanged += new System.EventHandler(this.comboPlaka_SelectedIndexChanged);
            // 
            // comboSofor
            // 
            this.comboSofor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboSofor.FormattingEnabled = true;
            this.comboSofor.Location = new System.Drawing.Point(305, 95);
            this.comboSofor.Name = "comboSofor";
            this.comboSofor.Size = new System.Drawing.Size(168, 21);
            this.comboSofor.TabIndex = 10;
            this.comboSofor.SelectedIndexChanged += new System.EventHandler(this.comboSofor_SelectedIndexChanged);
            // 
            // otobusTarih
            // 
            this.otobusTarih.Location = new System.Drawing.Point(305, 122);
            this.otobusTarih.Name = "otobusTarih";
            this.otobusTarih.Size = new System.Drawing.Size(168, 20);
            this.otobusTarih.TabIndex = 12;
            this.otobusTarih.ValueChanged += new System.EventHandler(this.otobusTarih_ValueChanged);
            // 
            // otobusNereden
            // 
            this.otobusNereden.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.otobusNereden.FormattingEnabled = true;
            this.otobusNereden.Location = new System.Drawing.Point(305, 148);
            this.otobusNereden.Name = "otobusNereden";
            this.otobusNereden.Size = new System.Drawing.Size(168, 21);
            this.otobusNereden.TabIndex = 13;
            this.otobusNereden.SelectedIndexChanged += new System.EventHandler(this.otobusNereden_SelectedIndexChanged);
            // 
            // otobusNereye
            // 
            this.otobusNereye.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.otobusNereye.FormattingEnabled = true;
            this.otobusNereye.Location = new System.Drawing.Point(305, 175);
            this.otobusNereye.Name = "otobusNereye";
            this.otobusNereye.Size = new System.Drawing.Size(168, 21);
            this.otobusNereye.TabIndex = 14;
            this.otobusNereye.SelectedIndexChanged += new System.EventHandler(this.otobusNereye_SelectedIndexChanged);
            // 
            // yurticiGrid
            // 
            this.yurticiGrid.AllowUserToAddRows = false;
            this.yurticiGrid.AllowUserToDeleteRows = false;
            this.yurticiGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.yurticiGrid.Location = new System.Drawing.Point(12, 245);
            this.yurticiGrid.Name = "yurticiGrid";
            this.yurticiGrid.ReadOnly = true;
            this.yurticiGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.yurticiGrid.Size = new System.Drawing.Size(880, 302);
            this.yurticiGrid.TabIndex = 15;
            this.yurticiGrid.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.yurticiGrid_CellEnter);
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.Color.LimeGreen;
            this.btnEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEkle.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEkle.Location = new System.Drawing.Point(636, 62);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(99, 39);
            this.btnEkle.TabIndex = 16;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.LimeGreen;
            this.btnSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSil.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSil.Location = new System.Drawing.Point(636, 107);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(99, 39);
            this.btnSil.TabIndex = 17;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.Color.LimeGreen;
            this.btnGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuncelle.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGuncelle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGuncelle.Location = new System.Drawing.Point(636, 152);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(99, 39);
            this.btnGuncelle.TabIndex = 18;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(506, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Otobüs id:";
            this.label1.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(506, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Sofor id:";
            this.label4.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(506, 157);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Kalkış Yeri id:";
            this.label8.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(506, 187);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Gidiş Yeri id:";
            this.label9.Visible = false;
            // 
            // labelotobusId
            // 
            this.labelotobusId.AutoSize = true;
            this.labelotobusId.Location = new System.Drawing.Point(567, 72);
            this.labelotobusId.Name = "labelotobusId";
            this.labelotobusId.Size = new System.Drawing.Size(13, 13);
            this.labelotobusId.TabIndex = 24;
            this.labelotobusId.Text = "0";
            this.labelotobusId.Visible = false;
            // 
            // labelSoforId
            // 
            this.labelSoforId.AutoSize = true;
            this.labelSoforId.Location = new System.Drawing.Point(560, 96);
            this.labelSoforId.Name = "labelSoforId";
            this.labelSoforId.Size = new System.Drawing.Size(13, 13);
            this.labelSoforId.TabIndex = 25;
            this.labelSoforId.Text = "0";
            this.labelSoforId.Visible = false;
            // 
            // labelNeredenId
            // 
            this.labelNeredenId.AutoSize = true;
            this.labelNeredenId.Location = new System.Drawing.Point(583, 157);
            this.labelNeredenId.Name = "labelNeredenId";
            this.labelNeredenId.Size = new System.Drawing.Size(13, 13);
            this.labelNeredenId.TabIndex = 26;
            this.labelNeredenId.Text = "0";
            this.labelNeredenId.Visible = false;
            // 
            // labelNereyeId
            // 
            this.labelNereyeId.AutoSize = true;
            this.labelNereyeId.Location = new System.Drawing.Point(583, 187);
            this.labelNereyeId.Name = "labelNereyeId";
            this.labelNereyeId.Size = new System.Drawing.Size(13, 13);
            this.labelNereyeId.TabIndex = 27;
            this.labelNereyeId.Text = "0";
            this.labelNereyeId.Visible = false;
            // 
            // textSeferId
            // 
            this.textSeferId.Enabled = false;
            this.textSeferId.Location = new System.Drawing.Point(305, 42);
            this.textSeferId.Name = "textSeferId";
            this.textSeferId.Size = new System.Drawing.Size(168, 20);
            this.textSeferId.TabIndex = 28;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(248, 45);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 16);
            this.label10.TabIndex = 29;
            this.label10.Text = "Sefer id:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(204, 205);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(100, 16);
            this.label11.TabIndex = 30;
            this.label11.Text = "Şoför İrtibat Maili:";
            // 
            // comboSoforMail
            // 
            this.comboSoforMail.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboSoforMail.Enabled = false;
            this.comboSoforMail.FormattingEnabled = true;
            this.comboSoforMail.Location = new System.Drawing.Point(305, 202);
            this.comboSoforMail.Name = "comboSoforMail";
            this.comboSoforMail.Size = new System.Drawing.Size(168, 21);
            this.comboSoforMail.TabIndex = 31;
            // 
            // yurticiSeferler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(904, 559);
            this.Controls.Add(this.comboSoforMail);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textSeferId);
            this.Controls.Add(this.labelNereyeId);
            this.Controls.Add(this.labelNeredenId);
            this.Controls.Add(this.labelSoforId);
            this.Controls.Add(this.labelotobusId);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.yurticiGrid);
            this.Controls.Add(this.otobusNereye);
            this.Controls.Add(this.otobusNereden);
            this.Controls.Add(this.otobusTarih);
            this.Controls.Add(this.comboSofor);
            this.Controls.Add(this.comboPlaka);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "yurticiSeferler";
            this.Text = "Yurt İçi Seferler";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.yurticiSeferler_FormClosing);
            this.Load += new System.EventHandler(this.yurticiSeferler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.yurticiGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboPlaka;
        private System.Windows.Forms.ComboBox comboSofor;
        private System.Windows.Forms.DateTimePicker otobusTarih;
        private System.Windows.Forms.ComboBox otobusNereden;
        private System.Windows.Forms.ComboBox otobusNereye;
        private System.Windows.Forms.DataGridView yurticiGrid;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label labelotobusId;
        private System.Windows.Forms.Label labelSoforId;
        private System.Windows.Forms.Label labelNeredenId;
        private System.Windows.Forms.Label labelNereyeId;
        private System.Windows.Forms.TextBox textSeferId;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox comboSoforMail;
    }
}