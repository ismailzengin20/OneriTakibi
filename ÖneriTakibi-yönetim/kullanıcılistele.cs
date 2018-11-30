using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace önerikutusu_yonetim
{
    public partial class kullanıcılistele : Form
    {
     SqlConnection baglan = new SqlConnection("");
        //SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-1OFOMHU;Initial Catalog=onerikutusu;Integrated Security=True");
        int satir;
        public kullanıcılistele()
        {
            InitializeComponent();
            getir();
        }

        private void bsayfayıkapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void kullanıcılistele_Load(object sender, EventArgs e)
        {
            getir();
        }
        public void getir()
        {
            try
            {
                baglan.Open();
                SqlCommand komut = baglan.CreateCommand();
                komut.CommandText = "select * from ok_kullanicilar";
                SqlDataReader dr = komut.ExecuteReader();
                int a = 0;
                dataGridView1.Rows.Clear();
                while (dr.Read())
                {
                   dataGridView1.Rows.Add(1);
                    dataGridView1.Rows[a].Cells["kullaniciadi"].Value = dr["kullaniciadi"].ToString();
                    dataGridView1.Rows[a].Cells["sifre"].Value = dr["sifre"].ToString();
                    dataGridView1.Rows[a].Cells["kartkodu"].Value = dr["kartkodu"].ToString();
                    dataGridView1.Rows[a].Cells["yetkituru"].Value = dr["yetkituru"].ToString();
                    dataGridView1.Rows[a].Cells["eposta"].Value = dr["eposta"].ToString();
                    dataGridView1.Rows[a].Cells["ceptelefonu"].Value = dr["ceptelefonu"].ToString();
                    dataGridView1.Rows[a].Cells["aciklama"].Value = dr["aciklama"].ToString();
                    a++;
                }
                baglan.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("ssa"+ex);
            }
        }
        private void bkullanıcıekle_Click(object sender, EventArgs e)
        {
            genel.F_kullanıcıekle = new kullanıcıekle();
            genel.F_kullanıcıekle.label8.Text = "ekle";
            genel.F_kullanıcıekle.Show();
        }
        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if(dataGridView1.SelectedRows.Count>0)
               
                if(e.RowIndex>=0)
                     {
                    
                    genel.F_kullanıcıekle = new kullanıcıekle();
                    genel.F_kullanıcıekle.DGV_kullanıcılar =dataGridView1;
                    genel.F_kullanıcıekle.label8.Text = "guncelle";
                    genel.F_kullanıcıekle.label9.Text = e.RowIndex+"";
                    genel.F_kullanıcıekle.Show();            
                    
                     }
        }
        private void dataGridView1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {

                 satir = dataGridView1.HitTest(e.X, e.Y).RowIndex;
                
                if (satir > -1)
                {
                    dataGridView1.Rows[satir].Selected = true;

                }
            }
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Kullanıcıyı silmek istiyormusunuz ?", "!!! UYARI !!! ", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    baglan.Open();
                    SqlCommand komut = baglan.CreateCommand();
                    komut.CommandText = "delete from ok_kullanicilar where kullaniciadi='" + dataGridView1.Rows[satir].Cells[0].Value.ToString() + "'";
                    komut.ExecuteNonQuery();
                    baglan.Close();
                    getir();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("hata" + ex);
                }
            }
            else if (dialogResult == DialogResult.No)
            {
            }
            
        }
        private void güncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
                if (satir >= 0)
                {
                    genel.F_kullanıcıekle = new kullanıcıekle();
                    genel.F_kullanıcıekle.DGV_kullanıcılar = dataGridView1;
                    genel.F_kullanıcıekle.label8.Text = "guncelle";
                    genel.F_kullanıcıekle.label9.Text = satir +"";
                    genel.F_kullanıcıekle.Show();
                }
        }
    }
}
