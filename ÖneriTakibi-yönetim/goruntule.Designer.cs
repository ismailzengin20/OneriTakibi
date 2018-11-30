namespace önerikutusu_yonetim
{
    partial class görüntüle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(görüntüle));
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.oneri = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.onerino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.konu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tarih = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unvan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.durum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.onaydurumu = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tb_konu = new System.Windows.Forms.TextBox();
            this.b_konuyagorearama = new System.Windows.Forms.Button();
            this.b_durumagoreara = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.b_tarihegoreara = new System.Windows.Forms.Button();
            this.cb_durum = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(128, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Konu : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(114, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Durumu : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(70, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Baslangıç Tarih:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(105, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Bitiş Tarih:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1143, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(66, 54);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(1210, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = " İsmail ZENGİN";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(1230, 39);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 33);
            this.button1.TabIndex = 3;
            this.button1.Text = "ÇIKIŞ YAP";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // oneri
            // 
            this.oneri.HeaderText = "Öneri";
            this.oneri.Name = "oneri";
            this.oneri.Width = 500;
            // 
            // onerino
            // 
            this.onerino.HeaderText = "Öneri No";
            this.onerino.Name = "onerino";
            this.onerino.Width = 50;
            // 
            // konu
            // 
            this.konu.HeaderText = "Konu";
            this.konu.Name = "konu";
            this.konu.Width = 200;
            // 
            // tarih
            // 
            this.tarih.HeaderText = "Tarih";
            this.tarih.Name = "tarih";
            this.tarih.Width = 125;
            // 
            // unvan
            // 
            this.unvan.HeaderText = "Ünvan";
            this.unvan.Name = "unvan";
            this.unvan.Width = 125;
            // 
            // isim
            // 
            this.isim.HeaderText = "İsim";
            this.isim.Name = "isim";
            this.isim.Width = 150;
            // 
            // durum
            // 
            this.durum.HeaderText = "Durum ";
            this.durum.Name = "durum";
            // 
            // onaydurumu
            // 
            this.onaydurumu.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.onaydurumu.HeaderText = "ONAY";
            this.onaydurumu.Items.AddRange(new object[] {
            "ONAYLA",
            "REDDET"});
            this.onaydurumu.Name = "onaydurumu";
            this.onaydurumu.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.onaydurumu.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.onaydurumu.Width = 125;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.onaydurumu,
            this.durum,
            this.isim,
            this.unvan,
            this.tarih,
            this.konu,
            this.onerino,
            this.oneri});
            this.dataGridView1.Location = new System.Drawing.Point(12, 183);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1268, 467);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
            this.dataGridView1.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dataGridView1_EditingControlShowing);
            this.dataGridView1.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_RowEnter);
            // 
            // tb_konu
            // 
            this.tb_konu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tb_konu.Location = new System.Drawing.Point(185, 25);
            this.tb_konu.Name = "tb_konu";
            this.tb_konu.Size = new System.Drawing.Size(219, 26);
            this.tb_konu.TabIndex = 6;
            // 
            // b_konuyagorearama
            // 
            this.b_konuyagorearama.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("b_konuyagorearama.BackgroundImage")));
            this.b_konuyagorearama.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.b_konuyagorearama.Location = new System.Drawing.Point(410, 23);
            this.b_konuyagorearama.Name = "b_konuyagorearama";
            this.b_konuyagorearama.Size = new System.Drawing.Size(63, 33);
            this.b_konuyagorearama.TabIndex = 7;
            this.b_konuyagorearama.UseVisualStyleBackColor = true;
            this.b_konuyagorearama.Click += new System.EventHandler(this.b_konuyagorearama_Click);
            // 
            // b_durumagoreara
            // 
            this.b_durumagoreara.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("b_durumagoreara.BackgroundImage")));
            this.b_durumagoreara.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.b_durumagoreara.Location = new System.Drawing.Point(410, 65);
            this.b_durumagoreara.Name = "b_durumagoreara";
            this.b_durumagoreara.Size = new System.Drawing.Size(63, 33);
            this.b_durumagoreara.TabIndex = 10;
            this.b_durumagoreara.UseVisualStyleBackColor = true;
            this.b_durumagoreara.Click += new System.EventHandler(this.b_durumagoreara_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateTimePicker1.Location = new System.Drawing.Point(185, 108);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(219, 26);
            this.dateTimePicker1.TabIndex = 12;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateTimePicker2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateTimePicker2.Location = new System.Drawing.Point(185, 140);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(219, 26);
            this.dateTimePicker2.TabIndex = 14;
            // 
            // b_tarihegoreara
            // 
            this.b_tarihegoreara.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("b_tarihegoreara.BackgroundImage")));
            this.b_tarihegoreara.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.b_tarihegoreara.Location = new System.Drawing.Point(410, 110);
            this.b_tarihegoreara.Name = "b_tarihegoreara";
            this.b_tarihegoreara.Size = new System.Drawing.Size(63, 56);
            this.b_tarihegoreara.TabIndex = 15;
            this.b_tarihegoreara.UseVisualStyleBackColor = true;
            this.b_tarihegoreara.Click += new System.EventHandler(this.b_tarihegoreara_Click);
            // 
            // cb_durum
            // 
            this.cb_durum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cb_durum.FormattingEnabled = true;
            this.cb_durum.Items.AddRange(new object[] {
            "BEKLEYEN",
            "ONAYLANMIŞ",
            "REDDEDİLMİŞ"});
            this.cb_durum.Location = new System.Drawing.Point(185, 67);
            this.cb_durum.Name = "cb_durum";
            this.cb_durum.Size = new System.Drawing.Size(219, 28);
            this.cb_durum.TabIndex = 16;
            // 
            // görüntüle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1366, 690);
            this.Controls.Add(this.cb_durum);
            this.Controls.Add(this.b_tarihegoreara);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.b_durumagoreara);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.b_konuyagorearama);
            this.Controls.Add(this.tb_konu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "görüntüle";
            this.Text = "ÖNERİKUTUSU - YÖNETİM ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.görüntüle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn oneri;
        private System.Windows.Forms.DataGridViewTextBoxColumn onerino;
        private System.Windows.Forms.DataGridViewTextBoxColumn konu;
        private System.Windows.Forms.DataGridViewTextBoxColumn tarih;
        private System.Windows.Forms.DataGridViewTextBoxColumn unvan;
        private System.Windows.Forms.DataGridViewTextBoxColumn isim;
        private System.Windows.Forms.DataGridViewTextBoxColumn durum;
        private System.Windows.Forms.DataGridViewComboBoxColumn onaydurumu;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox tb_konu;
        private System.Windows.Forms.Button b_konuyagorearama;
        private System.Windows.Forms.Button b_durumagoreara;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Button b_tarihegoreara;
        private System.Windows.Forms.ComboBox cb_durum;
    }
}