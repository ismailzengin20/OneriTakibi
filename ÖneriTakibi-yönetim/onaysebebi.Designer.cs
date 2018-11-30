namespace önerikutusu_yonetim
{
    partial class onaysebebi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(onaysebebi));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.b_onayla = new System.Windows.Forms.Button();
            this.b_iptal = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(72, 70);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(315, 146);
            this.textBox1.TabIndex = 0;
            // 
            // b_onayla
            // 
            this.b_onayla.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.b_onayla.Image = ((System.Drawing.Image)(resources.GetObject("b_onayla.Image")));
            this.b_onayla.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.b_onayla.Location = new System.Drawing.Point(287, 237);
            this.b_onayla.Name = "b_onayla";
            this.b_onayla.Size = new System.Drawing.Size(100, 35);
            this.b_onayla.TabIndex = 1;
            this.b_onayla.Text = "      ONAYLA";
            this.b_onayla.UseVisualStyleBackColor = true;
            this.b_onayla.Click += new System.EventHandler(this.b_onayla_Click);
            // 
            // b_iptal
            // 
            this.b_iptal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.b_iptal.Image = ((System.Drawing.Image)(resources.GetObject("b_iptal.Image")));
            this.b_iptal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.b_iptal.Location = new System.Drawing.Point(181, 237);
            this.b_iptal.Name = "b_iptal";
            this.b_iptal.Size = new System.Drawing.Size(100, 35);
            this.b_iptal.TabIndex = 2;
            this.b_iptal.Text = "    İPTAL";
            this.b_iptal.UseVisualStyleBackColor = true;
            this.b_iptal.Click += new System.EventHandler(this.b_iptal_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Crimson;
            this.label14.Location = new System.Drawing.Point(162, 9);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(93, 27);
            this.label14.TabIndex = 35;
            this.label14.Text = "Açıklama";
            // 
            // onaysebebi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 300);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.b_iptal);
            this.Controls.Add(this.b_onayla);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "onaysebebi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "onaysebebi";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button b_onayla;
        private System.Windows.Forms.Button b_iptal;
        private System.Windows.Forms.Label label14;
    }
}