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
    public partial class PersonelListele : Form
    {
       SqlConnection baglan = new SqlConnection("");
        // SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-1OFOMHU;Initial Catalog=onerikutusu;Integrated Security=True");

        int satir;
        public PersonelListele()
        {
            InitializeComponent();
        }

        private void PersonelListele_Load(object sender, EventArgs e)
        {
            getir();
        }
        public void getir()
        {
            try
            {
                baglan.Open();
                SqlCommand komut = baglan.CreateCommand();
                komut.CommandText = "select * from ok_personeller";
                SqlDataReader dr = komut.ExecuteReader();
                int a = 0;
                dataGridView1.Rows.Clear();
                while (dr.Read())
                {
                    dataGridView1.Rows.Add(1);
                    dataGridView1.Rows[a].Cells["kartkodu"].Value = dr["kartkodu"].ToString();
                    dataGridView1.Rows[a].Cells["tcnumarası"].Value = dr["tcnumarasi"].ToString();
                    dataGridView1.Rows[a].Cells["isim"].Value = dr["isim"].ToString();
                    dataGridView1.Rows[a].Cells["unvan"].Value = dr["unvan"].ToString();
                    dataGridView1.Rows[a].Cells["adres"].Value = dr["adres"].ToString();
                    dataGridView1.Rows[a].Cells["eposta"].Value = dr["eposta"].ToString();             
                    dataGridView1.Rows[a].Cells["aciklama"].Value = dr["aciklama"].ToString();
                    dataGridView1.Rows[a].Cells["fotograf"].Value = dr["fotograf"].ToString();
                    a++;
                }
                baglan.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ssa" + ex);
            }
        }

        private void bsayfayıkapat_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {

            DialogResult dialogResult = MessageBox.Show("Personeli silmek istiyormusunuz ?  ", " !!! UYARI !!! ", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    baglan.Open();
                    SqlCommand komut = baglan.CreateCommand();
                    komut.CommandText = "delete from ok_personeller where kartkodu='" + dataGridView1.Rows[satir].Cells[0].Value.ToString() + "'";
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
                    genel.F_personelekle = new personelekle();
                    genel.F_personelekle.DGV_Personeller = dataGridView1;
                    genel.F_personelekle.label8.Text = "guncelle";
                    genel.F_personelekle.label9.Text = satir+ "";
                    genel.F_personelekle.Show();
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


        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)

                if (e.RowIndex >= 0)
                {

                    genel.F_personelekle = new personelekle();
                    genel.F_personelekle.DGV_Personeller = dataGridView1;
                    genel.F_personelekle.label8.Text = "guncelle";
                    genel.F_personelekle.label9.Text = e.RowIndex + "";
                    genel.F_personelekle.Show();

                }
        }


        private void tb_kartkodu_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    baglan.Open();
                    SqlCommand komut = baglan.CreateCommand();
                    komut.CommandText = "select * from ok_personeller where kartkodu LIKE '%" + tb_kartkodu.Text + "%'";
                    SqlDataReader dr = komut.ExecuteReader();
                    int a = 0;
                    dataGridView1.Rows.Clear();
                    while (dr.Read())
                    {
                        dataGridView1.Rows.Add(1);
                        dataGridView1.Rows[a].Cells["kartkodu"].Value = dr["kartkodu"].ToString();
                        dataGridView1.Rows[a].Cells["tcnumarası"].Value = dr["tcnumarasi"].ToString();
                        dataGridView1.Rows[a].Cells["isim"].Value = dr["isim"].ToString();
                        dataGridView1.Rows[a].Cells["unvan"].Value = dr["unvan"].ToString();
                        dataGridView1.Rows[a].Cells["adres"].Value = dr["adres"].ToString();
                        dataGridView1.Rows[a].Cells["eposta"].Value = dr["eposta"].ToString();
                        dataGridView1.Rows[a].Cells["aciklama"].Value = dr["aciklama"].ToString();
                        dataGridView1.Rows[a].Cells["fotograf"].Value = dr["fotograf"].ToString();
                        a++;
                    }
                    baglan.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ssa" + ex);
                }
            }
        }

        private void tb_tcnumarası_KeyDown_1(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    baglan.Open();
                    SqlCommand komut = baglan.CreateCommand();
                    komut.CommandText = "select * from ok_personeller where tcnumarasi LIKE '%" + tb_tcnumarası.Text + "%'";
                    SqlDataReader dr = komut.ExecuteReader();
                    int a = 0;
                    dataGridView1.Rows.Clear();
                    while (dr.Read())
                    {
                        dataGridView1.Rows.Add(1);
                        dataGridView1.Rows[a].Cells["kartkodu"].Value = dr["kartkodu"].ToString();
                        dataGridView1.Rows[a].Cells["tcnumarası"].Value = dr["tcnumarasi"].ToString();
                        dataGridView1.Rows[a].Cells["isim"].Value = dr["isim"].ToString();
                        dataGridView1.Rows[a].Cells["unvan"].Value = dr["unvan"].ToString();
                        dataGridView1.Rows[a].Cells["adres"].Value = dr["adres"].ToString();
                        dataGridView1.Rows[a].Cells["eposta"].Value = dr["eposta"].ToString();
                        dataGridView1.Rows[a].Cells["aciklama"].Value = dr["aciklama"].ToString();
                        dataGridView1.Rows[a].Cells["fotograf"].Value = dr["fotograf"].ToString();
                        a++;
                    }
                    baglan.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ssa" + ex);
                }
            }
        }

        private void tb_isim_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    baglan.Open();
                    SqlCommand komut = baglan.CreateCommand();
                    komut.CommandText = "select * from ok_personeller where isim LIKE '%" + tb_isim.Text+"%'";
                    SqlDataReader dr = komut.ExecuteReader();
                    int a = 0;
                    dataGridView1.Rows.Clear();
                    while (dr.Read())
                    {
                        dataGridView1.Rows.Add(1);
                        dataGridView1.Rows[a].Cells["kartkodu"].Value = dr["kartkodu"].ToString();
                        dataGridView1.Rows[a].Cells["tcnumarası"].Value = dr["tcnumarasi"].ToString();
                        dataGridView1.Rows[a].Cells["isim"].Value = dr["isim"].ToString();
                        dataGridView1.Rows[a].Cells["unvan"].Value = dr["unvan"].ToString();
                        dataGridView1.Rows[a].Cells["adres"].Value = dr["adres"].ToString();
                        dataGridView1.Rows[a].Cells["eposta"].Value = dr["eposta"].ToString();
                        dataGridView1.Rows[a].Cells["aciklama"].Value = dr["aciklama"].ToString();
                        dataGridView1.Rows[a].Cells["fotograf"].Value = dr["fotograf"].ToString();
                        a++;
                    }
                    baglan.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ssa" + ex);
                }
            }
            }

       
    }
}
