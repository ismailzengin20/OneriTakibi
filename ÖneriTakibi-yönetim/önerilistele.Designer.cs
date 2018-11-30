namespace önerikutusu_yonetim
{
    partial class önerilistele
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(önerilistele));
            this.label14 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.kartkodu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unvan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.konu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oneri = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.önerino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.silToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.güncelleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bsayfayıkapat = new System.Windows.Forms.Button();
            this.tb_kartkodu = new System.Windows.Forms.TextBox();
            this.tb_isim = new System.Windows.Forms.TextBox();
            this.tb_unvan = new System.Windows.Forms.TextBox();
            this.tb_konu = new System.Windows.Forms.TextBox();
            this.tb_oneri = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.ForeColor = System.Drawing.Color.Crimson;
            this.label14.Location = new System.Drawing.Point(517, 15);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(97, 29);
            this.label14.TabIndex = 35;
            this.label14.Text = "Öneriler";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeight = 35;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kartkodu,
            this.isim,
            this.unvan,
            this.konu,
            this.oneri,
            this.önerino});
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dataGridView1.Location = new System.Drawing.Point(-2, 148);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1227, 536);
            this.dataGridView1.TabIndex = 39;
            this.dataGridView1.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDoubleClick);
            this.dataGridView1.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellMouseEnter);
            this.dataGridView1.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellMouseLeave);
            this.dataGridView1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseDown);
            // 
            // kartkodu
            // 
            this.kartkodu.HeaderText = "Kart Kodu";
            this.kartkodu.Name = "kartkodu";
            this.kartkodu.ReadOnly = true;
            this.kartkodu.Width = 200;
            // 
            // isim
            // 
            this.isim.HeaderText = "İsim";
            this.isim.Name = "isim";
            this.isim.ReadOnly = true;
            this.isim.Width = 150;
            // 
            // unvan
            // 
            this.unvan.HeaderText = "Ünvan";
            this.unvan.Name = "unvan";
            this.unvan.ReadOnly = true;
            this.unvan.Width = 150;
            // 
            // konu
            // 
            this.konu.HeaderText = "Konu";
            this.konu.Name = "konu";
            this.konu.ReadOnly = true;
            this.konu.Width = 170;
            // 
            // oneri
            // 
            this.oneri.HeaderText = "Öneri";
            this.oneri.Name = "oneri";
            this.oneri.ReadOnly = true;
            this.oneri.Width = 545;
            // 
            // önerino
            // 
            this.önerino.HeaderText = "Column1";
            this.önerino.Name = "önerino";
            this.önerino.ReadOnly = true;
            this.önerino.Visible = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.silToolStripMenuItem,
            this.güncelleToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(160, 80);
            // 
            // silToolStripMenuItem
            // 
            this.silToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.silToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("silToolStripMenuItem.Image")));
            this.silToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.silToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.silToolStripMenuItem.Name = "silToolStripMenuItem";
            this.silToolStripMenuItem.Size = new System.Drawing.Size(159, 38);
            this.silToolStripMenuItem.Text = "Sil";
            this.silToolStripMenuItem.Click += new System.EventHandler(this.silToolStripMenuItem_Click);
            // 
            // güncelleToolStripMenuItem
            // 
            this.güncelleToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.güncelleToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.güncelleToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("güncelleToolStripMenuItem.Image")));
            this.güncelleToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.güncelleToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.güncelleToolStripMenuItem.Name = "güncelleToolStripMenuItem";
            this.güncelleToolStripMenuItem.Size = new System.Drawing.Size(159, 38);
            this.güncelleToolStripMenuItem.Text = "güncelle";
            this.güncelleToolStripMenuItem.Click += new System.EventHandler(this.güncelleToolStripMenuItem_Click);
            // 
            // bsayfayıkapat
            // 
            this.bsayfayıkapat.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bsayfayıkapat.Image = ((System.Drawing.Image)(resources.GetObject("bsayfayıkapat.Image")));
            this.bsayfayıkapat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bsayfayıkapat.Location = new System.Drawing.Point(1076, 12);
            this.bsayfayıkapat.Name = "bsayfayıkapat";
            this.bsayfayıkapat.Size = new System.Drawing.Size(118, 55);
            this.bsayfayıkapat.TabIndex = 40;
            this.bsayfayıkapat.Text = "           Sayfayı           Kapat";
            this.bsayfayıkapat.UseVisualStyleBackColor = true;
            this.bsayfayıkapat.Click += new System.EventHandler(this.bsayfayıkapat_Click);
            // 
            // tb_kartkodu
            // 
            this.tb_kartkodu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tb_kartkodu.Location = new System.Drawing.Point(19, 9);
            this.tb_kartkodu.Name = "tb_kartkodu";
            this.tb_kartkodu.Size = new System.Drawing.Size(141, 24);
            this.tb_kartkodu.TabIndex = 54;
            this.tb_kartkodu.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_kartkodu_KeyDown);
            // 
            // tb_isim
            // 
            this.tb_isim.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tb_isim.Location = new System.Drawing.Point(213, 9);
            this.tb_isim.Name = "tb_isim";
            this.tb_isim.Size = new System.Drawing.Size(138, 24);
            this.tb_isim.TabIndex = 55;
            this.tb_isim.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_isim_KeyDown);
            // 
            // tb_unvan
            // 
            this.tb_unvan.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tb_unvan.Location = new System.Drawing.Point(369, 9);
            this.tb_unvan.Name = "tb_unvan";
            this.tb_unvan.Size = new System.Drawing.Size(121, 24);
            this.tb_unvan.TabIndex = 55;
            this.tb_unvan.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_unvan_KeyDown);
            // 
            // tb_konu
            // 
            this.tb_konu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tb_konu.Location = new System.Drawing.Point(514, 9);
            this.tb_konu.Name = "tb_konu";
            this.tb_konu.Size = new System.Drawing.Size(149, 24);
            this.tb_konu.TabIndex = 55;
            this.tb_konu.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_konu_KeyDown);
            // 
            // tb_oneri
            // 
            this.tb_oneri.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tb_oneri.Location = new System.Drawing.Point(683, 9);
            this.tb_oneri.Name = "tb_oneri";
            this.tb_oneri.Size = new System.Drawing.Size(272, 24);
            this.tb_oneri.TabIndex = 56;
            this.tb_oneri.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_oneri_KeyDown);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tb_oneri);
            this.panel1.Controls.Add(this.tb_konu);
            this.panel1.Controls.Add(this.tb_unvan);
            this.panel1.Controls.Add(this.tb_isim);
            this.panel1.Controls.Add(this.tb_kartkodu);
            this.panel1.Location = new System.Drawing.Point(-9, 96);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1234, 42);
            this.panel1.TabIndex = 52;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(1175, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 22);
            this.label2.TabIndex = 57;
            this.label2.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(1070, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 23);
            this.label1.TabIndex = 53;
            this.label1.Text = "Öneri Sayısı :";
            // 
            // önerilistele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1214, 689);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bsayfayıkapat);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label14);
            this.Name = "önerilistele";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Öneri Listesi ";
            this.Load += new System.EventHandler(this.önerilistele_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button bsayfayıkapat;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem silToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem güncelleToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn kartkodu;
        private System.Windows.Forms.DataGridViewTextBoxColumn isim;
        private System.Windows.Forms.DataGridViewTextBoxColumn unvan;
        private System.Windows.Forms.DataGridViewTextBoxColumn konu;
        private System.Windows.Forms.DataGridViewTextBoxColumn oneri;
        private System.Windows.Forms.DataGridViewTextBoxColumn önerino;
        private System.Windows.Forms.TextBox tb_kartkodu;
        private System.Windows.Forms.TextBox tb_isim;
        private System.Windows.Forms.TextBox tb_unvan;
        private System.Windows.Forms.TextBox tb_konu;
        private System.Windows.Forms.TextBox tb_oneri;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}