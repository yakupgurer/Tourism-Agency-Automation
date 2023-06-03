namespace Seyahat_Acentasi_Otomasyonu
{
    partial class guvenlik
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.labeluserid = new System.Windows.Forms.Label();
            this.labelid = new System.Windows.Forms.Label();
            this.labelislemTuru = new System.Windows.Forms.Label();
            this.labelislemBolumu = new System.Windows.Forms.Label();
            this.labelislemTarihi = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(25, 114);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(747, 473);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEnter);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(800, 292);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(172, 48);
            this.button1.TabIndex = 1;
            this.button1.Text = "Şüpheli Durum Olarak Bildir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labeluserid
            // 
            this.labeluserid.AutoSize = true;
            this.labeluserid.Location = new System.Drawing.Point(874, 253);
            this.labeluserid.Name = "labeluserid";
            this.labeluserid.Size = new System.Drawing.Size(13, 13);
            this.labeluserid.TabIndex = 2;
            this.labeluserid.Text = "0";
            this.labeluserid.Visible = false;
            // 
            // labelid
            // 
            this.labelid.AutoSize = true;
            this.labelid.Location = new System.Drawing.Point(874, 78);
            this.labelid.Name = "labelid";
            this.labelid.Size = new System.Drawing.Size(13, 13);
            this.labelid.TabIndex = 3;
            this.labelid.Text = "0";
            this.labelid.Visible = false;
            // 
            // labelislemTuru
            // 
            this.labelislemTuru.AutoSize = true;
            this.labelislemTuru.Location = new System.Drawing.Point(874, 118);
            this.labelislemTuru.Name = "labelislemTuru";
            this.labelislemTuru.Size = new System.Drawing.Size(13, 13);
            this.labelislemTuru.TabIndex = 4;
            this.labelislemTuru.Text = "0";
            this.labelislemTuru.Visible = false;
            // 
            // labelislemBolumu
            // 
            this.labelislemBolumu.AutoSize = true;
            this.labelislemBolumu.Location = new System.Drawing.Point(874, 157);
            this.labelislemBolumu.Name = "labelislemBolumu";
            this.labelislemBolumu.Size = new System.Drawing.Size(13, 13);
            this.labelislemBolumu.TabIndex = 5;
            this.labelislemBolumu.Text = "0";
            this.labelislemBolumu.Visible = false;
            // 
            // labelislemTarihi
            // 
            this.labelislemTarihi.AutoSize = true;
            this.labelislemTarihi.Location = new System.Drawing.Point(874, 198);
            this.labelislemTarihi.Name = "labelislemTarihi";
            this.labelislemTarihi.Size = new System.Drawing.Size(13, 13);
            this.labelislemTarihi.TabIndex = 6;
            this.labelislemTarihi.Text = "0";
            this.labelislemTarihi.Visible = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(354, 40);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(165, 42);
            this.button2.TabIndex = 7;
            this.button2.Text = "Ana Ekran";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // guvenlik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 611);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.labelislemTarihi);
            this.Controls.Add(this.labelislemBolumu);
            this.Controls.Add(this.labelislemTuru);
            this.Controls.Add(this.labelid);
            this.Controls.Add(this.labeluserid);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "guvenlik";
            this.Text = "guvenlik";
            this.Load += new System.EventHandler(this.guvenlik_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labeluserid;
        private System.Windows.Forms.Label labelid;
        private System.Windows.Forms.Label labelislemTuru;
        private System.Windows.Forms.Label labelislemBolumu;
        private System.Windows.Forms.Label labelislemTarihi;
        private System.Windows.Forms.Button button2;
    }
}