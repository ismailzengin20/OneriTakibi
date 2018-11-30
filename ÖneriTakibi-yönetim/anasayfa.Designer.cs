namespace önerikutusu_yonetim
{
    partial class anasayfa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(anasayfa));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.genelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkısToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personellerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personelEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personelbulToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.öneriRaporuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.önerilerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kullanıcılarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayarlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.menuStrip1.Font = new System.Drawing.Font("Corbel", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.genelToolStripMenuItem,
            this.personellerToolStripMenuItem,
            this.önerilerToolStripMenuItem,
            this.kullanıcılarToolStripMenuItem,
            this.ayarlarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1370, 40);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // genelToolStripMenuItem
            // 
            this.genelToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.çıkısToolStripMenuItem});
            this.genelToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("genelToolStripMenuItem.Image")));
            this.genelToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.genelToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.genelToolStripMenuItem.Name = "genelToolStripMenuItem";
            this.genelToolStripMenuItem.Size = new System.Drawing.Size(96, 36);
            this.genelToolStripMenuItem.Text = "Genel ";
            // 
            // çıkısToolStripMenuItem
            // 
            this.çıkısToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("çıkısToolStripMenuItem.Image")));
            this.çıkısToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.çıkısToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.çıkısToolStripMenuItem.Name = "çıkısToolStripMenuItem";
            this.çıkısToolStripMenuItem.Size = new System.Drawing.Size(135, 38);
            this.çıkısToolStripMenuItem.Text = "Kapat";
            this.çıkısToolStripMenuItem.Click += new System.EventHandler(this.çıkısToolStripMenuItem_Click);
            // 
            // personellerToolStripMenuItem
            // 
            this.personellerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.personelEkleToolStripMenuItem,
            this.personelbulToolStripMenuItem,
            this.öneriRaporuToolStripMenuItem});
            this.personellerToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("personellerToolStripMenuItem.Image")));
            this.personellerToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.personellerToolStripMenuItem.Name = "personellerToolStripMenuItem";
            this.personellerToolStripMenuItem.Size = new System.Drawing.Size(133, 36);
            this.personellerToolStripMenuItem.Text = "Personeller ";
            // 
            // personelEkleToolStripMenuItem
            // 
            this.personelEkleToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("personelEkleToolStripMenuItem.Image")));
            this.personelEkleToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.personelEkleToolStripMenuItem.Name = "personelEkleToolStripMenuItem";
            this.personelEkleToolStripMenuItem.Size = new System.Drawing.Size(188, 38);
            this.personelEkleToolStripMenuItem.Text = "Personel Ekle ";
            this.personelEkleToolStripMenuItem.Click += new System.EventHandler(this.personelEkleToolStripMenuItem_Click);
            // 
            // personelbulToolStripMenuItem
            // 
            this.personelbulToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.personelbulToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("personelbulToolStripMenuItem.Image")));
            this.personelbulToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.personelbulToolStripMenuItem.Name = "personelbulToolStripMenuItem";
            this.personelbulToolStripMenuItem.Size = new System.Drawing.Size(188, 38);
            this.personelbulToolStripMenuItem.Text = "Personel Bul";
            this.personelbulToolStripMenuItem.Click += new System.EventHandler(this.personelbulToolStripMenuItem_Click);
            // 
            // öneriRaporuToolStripMenuItem
            // 
            this.öneriRaporuToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("öneriRaporuToolStripMenuItem.Image")));
            this.öneriRaporuToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.öneriRaporuToolStripMenuItem.Name = "öneriRaporuToolStripMenuItem";
            this.öneriRaporuToolStripMenuItem.Size = new System.Drawing.Size(188, 38);
            this.öneriRaporuToolStripMenuItem.Text = "Öneri Raporu";
            this.öneriRaporuToolStripMenuItem.Click += new System.EventHandler(this.öneriRaporuToolStripMenuItem_Click);
            // 
            // önerilerToolStripMenuItem
            // 
            this.önerilerToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("önerilerToolStripMenuItem.Image")));
            this.önerilerToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.önerilerToolStripMenuItem.Name = "önerilerToolStripMenuItem";
            this.önerilerToolStripMenuItem.Size = new System.Drawing.Size(109, 36);
            this.önerilerToolStripMenuItem.Text = "Öneriler";
            this.önerilerToolStripMenuItem.Click += new System.EventHandler(this.önerilerToolStripMenuItem_Click);
            // 
            // kullanıcılarToolStripMenuItem
            // 
            this.kullanıcılarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("kullanıcılarToolStripMenuItem.Image")));
            this.kullanıcılarToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.kullanıcılarToolStripMenuItem.Name = "kullanıcılarToolStripMenuItem";
            this.kullanıcılarToolStripMenuItem.Size = new System.Drawing.Size(130, 36);
            this.kullanıcılarToolStripMenuItem.Text = "Kullanıcılar";
            this.kullanıcılarToolStripMenuItem.Click += new System.EventHandler(this.kullanıcılarToolStripMenuItem_Click);
            // 
            // ayarlarToolStripMenuItem
            // 
            this.ayarlarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ayarlarToolStripMenuItem.Image")));
            this.ayarlarToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ayarlarToolStripMenuItem.Name = "ayarlarToolStripMenuItem";
            this.ayarlarToolStripMenuItem.Size = new System.Drawing.Size(104, 36);
            this.ayarlarToolStripMenuItem.Text = "Ayarlar";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(354, 228);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(500, 300);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1026, 562);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(305, 135);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // anasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(230)))), ((int)(((byte)(130)))));
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "anasayfa";
            this.Text = "Öneri Takibi - Yönetim ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem genelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personellerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kullanıcılarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayarlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çıkısToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personelEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personelbulToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem öneriRaporuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem önerilerToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}