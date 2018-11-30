namespace önerikutusu_yonetim
{
    partial class önerionay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(önerionay));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_durum = new System.Windows.Forms.ComboBox();
            this.b_durumagoreara = new System.Windows.Forms.Button();
            this.b_tarihegoreara = new System.Windows.Forms.Button();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.b_konuyagorearama = new System.Windows.Forms.Button();
            this.tb_konu = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.onaydurumu = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.durum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unvan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tarih = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.konu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.onerino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oneri = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(93, 47);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 38);
            this.button1.TabIndex = 51;
            this.button1.Text = "      ÇIKIŞ YAP";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label3.Location = new System.Drawing.Point(93, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 22);
            this.label3.TabIndex = 62;
            this.label3.Text = "Durumu : ";
            // 
            // cb_durum
            // 
            this.cb_durum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cb_durum.FormattingEnabled = true;
            this.cb_durum.Items.AddRange(new object[] {
            "BEKLEYEN",
            "ONAYLANMIŞ",
            "REDDEDİLMİŞ"});
            this.cb_durum.Location = new System.Drawing.Point(183, 89);
            this.cb_durum.Name = "cb_durum";
            this.cb_durum.Size = new System.Drawing.Size(219, 28);
            this.cb_durum.TabIndex = 61;
            // 
            // b_durumagoreara
            // 
            this.b_durumagoreara.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("b_durumagoreara.BackgroundImage")));
            this.b_durumagoreara.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.b_durumagoreara.Location = new System.Drawing.Point(408, 87);
            this.b_durumagoreara.Name = "b_durumagoreara";
            this.b_durumagoreara.Size = new System.Drawing.Size(63, 33);
            this.b_durumagoreara.TabIndex = 60;
            this.b_durumagoreara.UseVisualStyleBackColor = true;
            this.b_durumagoreara.Click += new System.EventHandler(this.b_durumagoreara_Click);
            // 
            // b_tarihegoreara
            // 
            this.b_tarihegoreara.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("b_tarihegoreara.BackgroundImage")));
            this.b_tarihegoreara.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.b_tarihegoreara.Location = new System.Drawing.Point(408, 133);
            this.b_tarihegoreara.Name = "b_tarihegoreara";
            this.b_tarihegoreara.Size = new System.Drawing.Size(63, 56);
            this.b_tarihegoreara.TabIndex = 56;
            this.b_tarihegoreara.UseVisualStyleBackColor = true;
            this.b_tarihegoreara.Click += new System.EventHandler(this.b_tarihegoreara_Click);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateTimePicker2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateTimePicker2.Location = new System.Drawing.Point(183, 163);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(219, 26);
            this.dateTimePicker2.TabIndex = 55;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateTimePicker1.Location = new System.Drawing.Point(183, 131);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(219, 26);
            this.dateTimePicker1.TabIndex = 54;
            // 
            // b_konuyagorearama
            // 
            this.b_konuyagorearama.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("b_konuyagorearama.BackgroundImage")));
            this.b_konuyagorearama.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.b_konuyagorearama.Location = new System.Drawing.Point(408, 39);
            this.b_konuyagorearama.Name = "b_konuyagorearama";
            this.b_konuyagorearama.Size = new System.Drawing.Size(63, 33);
            this.b_konuyagorearama.TabIndex = 53;
            this.b_konuyagorearama.UseVisualStyleBackColor = true;
            this.b_konuyagorearama.Click += new System.EventHandler(this.b_konuyagorearama_Click);
            // 
            // tb_konu
            // 
            this.tb_konu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tb_konu.Location = new System.Drawing.Point(183, 41);
            this.tb_konu.Name = "tb_konu";
            this.tb_konu.Size = new System.Drawing.Size(219, 26);
            this.tb_konu.TabIndex = 52;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
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
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(-1, 219);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 40;
            this.dataGridView1.Size = new System.Drawing.Size(1371, 515);
            this.dataGridView1.TabIndex = 51;
            this.dataGridView1.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDown);
            this.dataGridView1.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellMouseEnter);
            this.dataGridView1.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellMouseLeave);
            this.dataGridView1.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dataGridView1_EditingControlShowing);
            this.dataGridView1.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_RowEnter);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(61, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(84, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 22);
            this.label1.TabIndex = 33;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(150)))), ((int)(((byte)(120)))));
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Location = new System.Drawing.Point(1129, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(0);
            this.groupBox1.Size = new System.Drawing.Size(224, 88);
            this.groupBox1.TabIndex = 63;
            this.groupBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Trebuchet MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label5.Location = new System.Drawing.Point(78, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 22);
            this.label5.TabIndex = 59;
            this.label5.Text = "Bitiş Tarih :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Trebuchet MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label4.Location = new System.Drawing.Point(41, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 22);
            this.label4.TabIndex = 58;
            this.label4.Text = "Baslangıç Tarih :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label2.Location = new System.Drawing.Point(113, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 22);
            this.label2.TabIndex = 57;
            this.label2.Text = "Konu : ";
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
            // durum
            // 
            this.durum.HeaderText = "Durum ";
            this.durum.Name = "durum";
            this.durum.Width = 95;
            // 
            // isim
            // 
            this.isim.HeaderText = "İsim";
            this.isim.Name = "isim";
            this.isim.Width = 150;
            // 
            // unvan
            // 
            this.unvan.HeaderText = "Ünvan";
            this.unvan.Name = "unvan";
            this.unvan.Width = 125;
            // 
            // tarih
            // 
            this.tarih.HeaderText = "Tarih";
            this.tarih.Name = "tarih";
            this.tarih.Width = 80;
            // 
            // konu
            // 
            this.konu.HeaderText = "Konu";
            this.konu.Name = "konu";
            this.konu.Width = 200;
            // 
            // onerino
            // 
            this.onerino.HeaderText = "Öneri No";
            this.onerino.Name = "onerino";
            this.onerino.Width = 80;
            // 
            // oneri
            // 
            this.oneri.HeaderText = "Öneri";
            this.oneri.Name = "oneri";
            this.oneri.Width = 510;
            // 
            // önerionay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(195)))), ((int)(((byte)(120)))));
            this.ClientSize = new System.Drawing.Size(1366, 690);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cb_durum);
            this.Controls.Add(this.b_durumagoreara);
            this.Controls.Add(this.b_tarihegoreara);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.b_konuyagorearama);
            this.Controls.Add(this.tb_konu);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "önerionay";
            this.Text = "ÖNERİKUTUSU - YÖNETİM ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.önerionay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb_durum;
        private System.Windows.Forms.Button b_durumagoreara;
        private System.Windows.Forms.Button b_tarihegoreara;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button b_konuyagorearama;
        private System.Windows.Forms.TextBox tb_konu;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewComboBoxColumn onaydurumu;
        private System.Windows.Forms.DataGridViewTextBoxColumn durum;
        private System.Windows.Forms.DataGridViewTextBoxColumn isim;
        private System.Windows.Forms.DataGridViewTextBoxColumn unvan;
        private System.Windows.Forms.DataGridViewTextBoxColumn tarih;
        private System.Windows.Forms.DataGridViewTextBoxColumn konu;
        private System.Windows.Forms.DataGridViewTextBoxColumn onerino;
        private System.Windows.Forms.DataGridViewTextBoxColumn oneri;
    }
}