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
    public partial class önerilistele : Form
    {
        SqlConnection baglan = new SqlConnection("Data Source=IBMSERVER;Initial Catalog=ONERITAKIBI;User ID=uretim;Password=Akcelik31");
        int satir;
        public önerilistele()
        {
            InitializeComponent();
        }
        public void getir()
        {
            dataGridView1.Rows.Clear();
            try
            {
                baglan.Open();
                SqlCommand komut = baglan.CreateCommand();              
                komut.CommandText = "select p.kartkodu, isim ,p.unvan, o.konu,o.oneri,o.onerino  from ok_personeller as p inner join ok_oneriler o on o.kartkodu=p.kartkodu ";             
                SqlDataReader dr = komut.ExecuteReader();
                int a = 0;
                if (dr.HasRows){ 
                    dataGridView1.Rows.Clear();
                while (dr.Read())
                {
                    dataGridView1.Rows.Add(1);
                    dataGridView1.Rows[a].Cells["kartkodu"].Value = dr["kartkodu"].ToString();
                    dataGridView1.Rows[a].Cells["isim"].Value = dr["isim"].ToString();
                    dataGridView1.Rows[a].Cells["unvan"].Value = dr["unvan"].ToString();
                    dataGridView1.Rows[a].Cells["konu"].Value = dr["konu"].ToString();
                    dataGridView1.Rows[a].Cells["oneri"].Value = dr["oneri"].ToString();
                    dataGridView1.Rows[a].Cells["önerino"].Value = dr["onerino"].ToString();
                    a++;
                }
                    label2.Text = a + "";
                }
                baglan.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ssa" + ex);
            }
        }
        private void önerilistele_Load(object sender, EventArgs e)
        {
            getir();
        }

        private void bsayfayıkapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        private void dataGridView1_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex ==  0&& e.RowIndex>=0)
            {
                genel.F_öneribilgiekranı = new öneribilgiekranı();
                genel.F_öneribilgiekranı.index = e.RowIndex;
                genel.F_öneribilgiekranı.DGV_öneri = dataGridView1;
                genel.F_öneribilgiekranı.Show();
            }
            }

      

        private void dataGridView1_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0 && e.RowIndex >= 0)
            {
                genel.F_öneribilgiekranı.Close();
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
            genel.F_öneridüzenle = new öneridüzenle();
            genel.F_öneridüzenle.dgv = dataGridView1;
            genel.F_öneridüzenle.index = e.RowIndex;
            genel.F_öneridüzenle.Show();
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
                    komut.CommandText = "delete from ok_oneriler where onerino='" + dataGridView1.Rows[satir].Cells[0].Value.ToString()+"'";
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
            genel.F_öneridüzenle = new öneridüzenle();
            genel.F_öneridüzenle.dgv = dataGridView1;
            genel.F_öneridüzenle.index = satir;
            genel.F_öneridüzenle.Show();

               
        }

        private void tb_kartkodu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                getir1();
            }
        }
        public void getir1()
        {
            
                dataGridView1.Rows.Clear();
                try
                {
                    baglan.Open();
                    SqlCommand komut = baglan.CreateCommand();   
                        komut.CommandText = "select p.kartkodu, isim ,p.unvan, o.konu,o.oneri,o.onerino  from ok_personeller as p inner join ok_oneriler o on o.kartkodu=p.kartkodu  where o.kartkodu like '%"+tb_kartkodu.Text+ "%' and p.isim like '%" + tb_isim.Text + "%' and p.unvan like '%" + tb_unvan.Text + "%' and o.konu like '%" + tb_konu.Text + "%'and o.oneri like '%" + tb_oneri.Text + "%'";
                    SqlDataReader dr = komut.ExecuteReader();
                    int a = 0;
                    if (dr.HasRows)
                    {
                        dataGridView1.Rows.Clear();
                        while (dr.Read())
                        {
                            dataGridView1.Rows.Add(1);
                            dataGridView1.Rows[a].Cells["kartkodu"].Value = dr["kartkodu"].ToString();
                            dataGridView1.Rows[a].Cells["isim"].Value = dr["isim"].ToString();
                            dataGridView1.Rows[a].Cells["unvan"].Value = dr["unvan"].ToString();
                            dataGridView1.Rows[a].Cells["konu"].Value = dr["konu"].ToString();
                            dataGridView1.Rows[a].Cells["oneri"].Value = dr["oneri"].ToString();
                            dataGridView1.Rows[a].Cells["önerino"].Value = dr["onerino"].ToString();
                            a++;
                        }
                  
                    }
                    baglan.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ssa" + ex);
                }
            }

        private void tb_isim_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                getir1();
            }
        }

        private void tb_unvan_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                getir1();
            }
        }

        private void tb_konu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                getir1();
            }
        }

        private void tb_oneri_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                getir1();
            }
        }
    }
    }

