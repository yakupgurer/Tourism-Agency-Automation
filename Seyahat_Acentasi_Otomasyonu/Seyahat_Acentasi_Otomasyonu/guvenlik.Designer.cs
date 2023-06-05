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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 48);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(683, 483);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEnter);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LimeGreen;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(716, 243);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(176, 55);
            this.button1.TabIndex = 1;
            this.button1.Text = "Şüpheli Durum Olarak Bildir";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labeluserid
            // 
            this.labeluserid.AutoSize = true;
            this.labeluserid.Location = new System.Drawing.Point(811, 208);
            this.labeluserid.Name = "labeluserid";
            this.labeluserid.Size = new System.Drawing.Size(13, 13);
            this.labeluserid.TabIndex = 2;
            this.labeluserid.Text = "0";
            this.labeluserid.Visible = false;
            // 
            // labelid
            // 
            this.labelid.AutoSize = true;
            this.labelid.Location = new System.Drawing.Point(811, 33);
            this.labelid.Name = "labelid";
            this.labelid.Size = new System.Drawing.Size(13, 13);
            this.labelid.TabIndex = 3;
            this.labelid.Text = "0";
            this.labelid.Visible = false;
            // 
            // labelislemTuru
            // 
            this.labelislemTuru.AutoSize = true;
            this.labelislemTuru.Location = new System.Drawing.Point(811, 73);
            this.labelislemTuru.Name = "labelislemTuru";
            this.labelislemTuru.Size = new System.Drawing.Size(13, 13);
            this.labelislemTuru.TabIndex = 4;
            this.labelislemTuru.Text = "0";
            this.labelislemTuru.Visible = false;
            // 
            // labelislemBolumu
            // 
            this.labelislemBolumu.AutoSize = true;
            this.labelislemBolumu.Location = new System.Drawing.Point(811, 112);
            this.labelislemBolumu.Name = "labelislemBolumu";
            this.labelislemBolumu.Size = new System.Drawing.Size(13, 13);
            this.labelislemBolumu.TabIndex = 5;
            this.labelislemBolumu.Text = "0";
            this.labelislemBolumu.Visible = false;
            // 
            // labelislemTarihi
            // 
            this.labelislemTarihi.AutoSize = true;
            this.labelislemTarihi.Location = new System.Drawing.Point(811, 153);
            this.labelislemTarihi.Name = "labelislemTarihi";
            this.labelislemTarihi.Size = new System.Drawing.Size(13, 13);
            this.labelislemTarihi.TabIndex = 6;
            this.labelislemTarihi.Text = "0";
            this.labelislemTarihi.Visible = false;
            // 
            // guvenlik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(904, 559);
            this.Controls.Add(this.labelislemTarihi);
            this.Controls.Add(this.labelislemBolumu);
            this.Controls.Add(this.labelislemTuru);
            this.Controls.Add(this.labelid);
            this.Controls.Add(this.labeluserid);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "guvenlik";
            this.Text = "Güvenlik";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.guvenlik_FormClosing);
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
    }
}