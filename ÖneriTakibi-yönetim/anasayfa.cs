using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace önerikutusu_yonetim
{
    public partial class anasayfa : Form
    {
        public anasayfa()
        {
            InitializeComponent();
        }

        private void çıkısToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();           
        }

        private void personelEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            genel.F_personelekle = new personelekle();
            genel.F_personelekle.label8.Text = "ekle";
            genel.F_personelekle.Show();

        }

        

        private void personelGüncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void kullanıcılarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            genel.F_kullanıcılistele = new kullanıcılistele();
            genel.F_kullanıcılistele.Show();
         
        }

        private void personelbulToolStripMenuItem_Click(object sender, EventArgs e)
        {
            genel.F_personelListele = new PersonelListele();
            genel.F_personelListele.Show();
        }

        private void öneriRaporuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            genel.F_öneriraporu = new öneriraporu();
            genel.F_öneriraporu.Show();

        }

        private void önerilerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            genel.F_önerilistele = new önerilistele();
            genel.F_önerilistele.Show();
        }
    }
}
