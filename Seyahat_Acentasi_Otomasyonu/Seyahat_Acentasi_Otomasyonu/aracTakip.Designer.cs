namespace Seyahat_Acentasi_Otomasyonu
{
    partial class aracTakip
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
            this.components = new System.ComponentModel.Container();
            this.BtnGetLocation = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.mapG = new GMap.NET.WindowsForms.GMapControl();
            this.plakalar = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // BtnGetLocation
            // 
            this.BtnGetLocation.BackColor = System.Drawing.Color.LimeGreen;
            this.BtnGetLocation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGetLocation.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnGetLocation.ForeColor = System.Drawing.Color.White;
            this.BtnGetLocation.Location = new System.Drawing.Point(739, 354);
            this.BtnGetLocation.Name = "BtnGetLocation";
            this.BtnGetLocation.Size = new System.Drawing.Size(99, 39);
            this.BtnGetLocation.TabIndex = 0;
            this.BtnGetLocation.Text = "Veri Yükle";
            this.BtnGetLocation.UseVisualStyleBackColor = false;
            this.BtnGetLocation.Click += new System.EventHandler(this.BtnGetLocation_Click);
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1.Location = new System.Drawing.Point(709, 188);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(113, 21);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox2.Location = new System.Drawing.Point(709, 230);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(113, 21);
            this.textBox2.TabIndex = 2;
            // 
            // mapG
            // 
            this.mapG.Bearing = 0F;
            this.mapG.CanDragMap = true;
            this.mapG.EmptyTileColor = System.Drawing.Color.Navy;
            this.mapG.GrayScaleMode = false;
            this.mapG.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.mapG.LevelsKeepInMemmory = 5;
            this.mapG.Location = new System.Drawing.Point(21, 12);
            this.mapG.MarkersEnabled = true;
            this.mapG.MaxZoom = 2;
            this.mapG.MinZoom = 2;
            this.mapG.MouseWheelZoomEnabled = true;
            this.mapG.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.mapG.Name = "mapG";
            this.mapG.NegativeMode = false;
            this.mapG.PolygonsEnabled = true;
            this.mapG.RetryLoadTile = 0;
            this.mapG.RoutesEnabled = true;
            this.mapG.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.mapG.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.mapG.ShowTileGridLines = false;
            this.mapG.Size = new System.Drawing.Size(643, 535);
            this.mapG.TabIndex = 3;
            this.mapG.Zoom = 0D;
            this.mapG.Load += new System.EventHandler(this.mapG_Load);
            // 
            // plakalar
            // 
            this.plakalar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.plakalar.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.plakalar.FormattingEnabled = true;
            this.plakalar.Location = new System.Drawing.Point(709, 313);
            this.plakalar.Name = "plakalar";
            this.plakalar.Size = new System.Drawing.Size(169, 24);
            this.plakalar.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(706, 279);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Otobüs Seçiniz:";
            // 
            // timer1
            // 
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // aracTakip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(904, 559);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.plakalar);
            this.Controls.Add(this.mapG);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.BtnGetLocation);
            this.Name = "aracTakip";
            this.Text = "Araç Takip Sistemi";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.aracTakip_FormClosing);
            this.Load += new System.EventHandler(this.aracTakip_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnGetLocation;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private GMap.NET.WindowsForms.GMapControl mapG;
        private System.Windows.Forms.ComboBox plakalar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
    }
}