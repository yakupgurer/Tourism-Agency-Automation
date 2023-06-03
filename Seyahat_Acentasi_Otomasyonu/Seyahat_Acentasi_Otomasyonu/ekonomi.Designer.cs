namespace Seyahat_Acentasi_Otomasyonu
{
    partial class ekonomi
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
            this.veriGrid = new System.Windows.Forms.DataGridView();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.labelid = new System.Windows.Forms.Label();
            this.labeltarih = new System.Windows.Forms.Label();
            this.labelgelir = new System.Windows.Forms.Label();
            this.labelgider = new System.Windows.Forms.Label();
            this.labelaciklama = new System.Windows.Forms.Label();
            this.textGelir = new System.Windows.Forms.TextBox();
            this.textGider = new System.Windows.Forms.TextBox();
            this.textAciklama = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.veriGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // veriGrid
            // 
            this.veriGrid.AllowUserToAddRows = false;
            this.veriGrid.AllowUserToDeleteRows = false;
            this.veriGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.veriGrid.Location = new System.Drawing.Point(8, 86);
            this.veriGrid.Name = "veriGrid";
            this.veriGrid.ReadOnly = true;
            this.veriGrid.Size = new System.Drawing.Size(667, 401);
            this.veriGrid.TabIndex = 0;
            this.veriGrid.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.veriGrid_CellEnter);
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(774, 351);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(103, 30);
            this.btnEkle.TabIndex = 1;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(774, 387);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(103, 30);
            this.btnSil.TabIndex = 3;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(774, 423);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(103, 30);
            this.btnGuncelle.TabIndex = 4;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // labelid
            // 
            this.labelid.AutoSize = true;
            this.labelid.Location = new System.Drawing.Point(705, 15);
            this.labelid.Name = "labelid";
            this.labelid.Size = new System.Drawing.Size(13, 13);
            this.labelid.TabIndex = 5;
            this.labelid.Text = "0";
            this.labelid.Visible = false;
            // 
            // labeltarih
            // 
            this.labeltarih.AutoSize = true;
            this.labeltarih.Location = new System.Drawing.Point(705, 39);
            this.labeltarih.Name = "labeltarih";
            this.labeltarih.Size = new System.Drawing.Size(13, 13);
            this.labeltarih.TabIndex = 6;
            this.labeltarih.Text = "0";
            this.labeltarih.Visible = false;
            // 
            // labelgelir
            // 
            this.labelgelir.AutoSize = true;
            this.labelgelir.Location = new System.Drawing.Point(705, 65);
            this.labelgelir.Name = "labelgelir";
            this.labelgelir.Size = new System.Drawing.Size(13, 13);
            this.labelgelir.TabIndex = 7;
            this.labelgelir.Text = "0";
            this.labelgelir.Visible = false;
            // 
            // labelgider
            // 
            this.labelgider.AutoSize = true;
            this.labelgider.Location = new System.Drawing.Point(705, 91);
            this.labelgider.Name = "labelgider";
            this.labelgider.Size = new System.Drawing.Size(13, 13);
            this.labelgider.TabIndex = 8;
            this.labelgider.Text = "0";
            this.labelgider.Visible = false;
            // 
            // labelaciklama
            // 
            this.labelaciklama.AutoSize = true;
            this.labelaciklama.Location = new System.Drawing.Point(705, 117);
            this.labelaciklama.Name = "labelaciklama";
            this.labelaciklama.Size = new System.Drawing.Size(13, 13);
            this.labelaciklama.TabIndex = 9;
            this.labelaciklama.Text = "0";
            this.labelaciklama.Visible = false;
            // 
            // textGelir
            // 
            this.textGelir.Location = new System.Drawing.Point(745, 125);
            this.textGelir.Name = "textGelir";
            this.textGelir.Size = new System.Drawing.Size(175, 20);
            this.textGelir.TabIndex = 10;
            // 
            // textGider
            // 
            this.textGider.Location = new System.Drawing.Point(745, 160);
            this.textGider.Name = "textGider";
            this.textGider.Size = new System.Drawing.Size(175, 20);
            this.textGider.TabIndex = 11;
            // 
            // textAciklama
            // 
            this.textAciklama.Location = new System.Drawing.Point(745, 187);
            this.textAciklama.MaxLength = 200;
            this.textAciklama.Multiline = true;
            this.textAciklama.Name = "textAciklama";
            this.textAciklama.Size = new System.Drawing.Size(175, 141);
            this.textAciklama.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(687, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Gelir (₺) :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(683, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Gider (₺) :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(683, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Açıklama:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(248, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 42);
            this.button1.TabIndex = 14;
            this.button1.Text = "Ana Ekran";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ekonomi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 499);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textAciklama);
            this.Controls.Add(this.textGider);
            this.Controls.Add(this.textGelir);
            this.Controls.Add(this.labelaciklama);
            this.Controls.Add(this.labelgider);
            this.Controls.Add(this.labelgelir);
            this.Controls.Add(this.labeltarih);
            this.Controls.Add(this.labelid);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.veriGrid);
            this.Name = "ekonomi";
            this.Text = "ekonomi";
            this.Load += new System.EventHandler(this.ekonomi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.veriGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView veriGrid;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Label labelid;
        private System.Windows.Forms.Label labeltarih;
        private System.Windows.Forms.Label labelgelir;
        private System.Windows.Forms.Label labelgider;
        private System.Windows.Forms.Label labelaciklama;
        private System.Windows.Forms.TextBox textGelir;
        private System.Windows.Forms.TextBox textGider;
        private System.Windows.Forms.TextBox textAciklama;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}