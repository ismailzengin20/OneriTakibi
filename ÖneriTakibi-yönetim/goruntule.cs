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
    public partial class görüntüle : Form
    {
        SqlConnection baglan = new SqlConnection("");
        public görüntüle()
        {
            InitializeComponent();
        }
        int index;
        ComboBox combo;
        private void görüntüle_Load(object sender, EventArgs e)
        {     
            cb_durum.Text = "Seçiniz";
          //  onaydurumu
            for(int i=0;i<8;i++)
            dataGridView1.Columns[i].HeaderCell.Style.Font = new Font("Tahoma", 15F, FontStyle.Bold);
            dataGridView1.ColumnHeadersHeight = 35;
            this.dataGridView1.DefaultCellStyle.Font = new Font("Tahoma",10);
            verigetir();  
        }
        private void button1_Click(object sender, EventArgs e)
        {
            genel.F_giris = new giris();
            genel.F_giris.Show();
            this.Hide();
        }

        private void b_konuyagorearama_Click(object sender, EventArgs e)
        {
            
            if (tb_konu.Text.Length > 0)
            {
                dataGridView1.Rows.Clear();
                try
                {
                    baglan.Open();
                    SqlCommand komut = baglan.CreateCommand();
                    komut.CommandText = "select durumu,isim,unvan,tarih, konu,onerino,oneri from ok_personeller as p inner join ok_oneriler as o on  p.kartkodu=o.kartkodu where   konu like '%"+tb_konu.Text+"%'";
                    SqlDataReader dr = komut.ExecuteReader();
                    int a = 0;
                    while (dr.Read())
                    {
                        dataGridView1.Rows.Add(1);
                        if (dr["durumu"].ToString() == "BEKLEYEN")
                            dataGridView1.Rows[a].DefaultCellStyle.BackColor = System.Drawing.Color.LightGoldenrodYellow;
                        else if (dr["durumu"].ToString() == "REDDEDİLMİŞ")
                            dataGridView1.Rows[a].DefaultCellStyle.BackColor = System.Drawing.Color.Red;
                        else
                            dataGridView1.Rows[a].DefaultCellStyle.BackColor = System.Drawing.Color.ForestGreen;
                        dataGridView1.Rows[a].Cells["durum"].Value = dr["durumu"].ToString();
                        dataGridView1.Rows[a].Cells["isim"].Value = dr["isim"].ToString();
                        dataGridView1.Rows[a].Cells["unvan"].Value = dr["unvan"].ToString();
                        dataGridView1.Rows[a].Cells["tarih"].Value = dr["tarih"].ToString();
                        dataGridView1.Rows[a].Cells["konu"].Value = dr["konu"].ToString();
                        dataGridView1.Rows[a].Cells["onerino"].Value = dr["onerino"].ToString();
                        dataGridView1.Rows[a].Cells["oneri"].Value = dr["oneri"].ToString();
                        a++;

                    }
                    baglan.Close();
                    tb_konu.Text = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("sas" + ex);
                }
            }
            else
                MessageBox.Show("Araanacak Konuyu Girip Tekrar Deneyiniz.");
        }

        private void b_durumagoreara_Click(object sender, EventArgs e)
        {
            if (cb_durum.SelectedIndex > -1)
            {
                dataGridView1.Rows.Clear();
                try
                {
                    baglan.Open();
                    SqlCommand komut = baglan.CreateCommand();
                    if(cb_durum.SelectedItem.Equals("BEKLEYEN"))
                    komut.CommandText = "select durumu,isim,unvan,tarih, konu,onerino,oneri from ok_personeller as p inner join ok_oneriler as o on  p.kartkodu=o.kartkodu where   durumu like '%" + cb_durum.Text + "%'";
                    else if (cb_durum.SelectedItem.Equals("REDDEDİLMİŞ"))
                        komut.CommandText = "select durumu,isim,unvan,tarih, konu,onerino,oneri from ok_personeller as p inner join ok_oneriler as o on  p.kartkodu=o.kartkodu where   durumu like '%" + cb_durum.Text + "%'";
                     else 
                        komut.CommandText = "select durumu,isim,unvan,tarih, konu,onerino,oneri from ok_personeller as p inner join ok_oneriler as o on  p.kartkodu=o.kartkodu where   durumu like '%" + cb_durum.Text + "%'";
                    SqlDataReader dr = komut.ExecuteReader();
                    int a = 0;
                    while (dr.Read())
                    {
                        dataGridView1.Rows.Add(1);
                        if (dr["durumu"].ToString() == "BEKLEYEN")
                            dataGridView1.Rows[a].DefaultCellStyle.BackColor = System.Drawing.Color.LightGoldenrodYellow;
                        else if (dr["durumu"].ToString() == "REDDEDİLMİŞ")
                            dataGridView1.Rows[a].DefaultCellStyle.BackColor = System.Drawing.Color.Red;
                        else
                            dataGridView1.Rows[a].DefaultCellStyle.BackColor = System.Drawing.Color.ForestGreen;
                        dataGridView1.Rows[a].Cells["durum"].Value = dr["durumu"].ToString();
                        dataGridView1.Rows[a].Cells["isim"].Value = dr["isim"].ToString();
                        dataGridView1.Rows[a].Cells["unvan"].Value = dr["unvan"].ToString();
                        dataGridView1.Rows[a].Cells["tarih"].Value = dr["tarih"].ToString();
                        dataGridView1.Rows[a].Cells["konu"].Value = dr["konu"].ToString();
                        dataGridView1.Rows[a].Cells["onerino"].Value = dr["onerino"].ToString();
                        dataGridView1.Rows[a].Cells["oneri"].Value = dr["oneri"].ToString();
                        a++;

                    }
                    baglan.Close();
                    cb_durum.Text = "Seciniz";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("sas" + ex);
                }
            }
            else
                MessageBox.Show("Secim Secim Yapıp Tekrar Deneyiniz");
        }

        private void b_tarihegoreara_Click(object sender, EventArgs e)
        {
                dataGridView1.Rows.Clear();
                try
                {
                    baglan.Open();
                    SqlCommand komut = baglan.CreateCommand();
                    komut.CommandText = "select durumu,isim,unvan,tarih, konu,onerino,oneri from ok_personeller as p inner join ok_oneriler as o on  p.kartkodu=o.kartkodu where tarih BETWEEN  '" + dateTimePicker1.Value.ToString("yyyy-MM-dd HH:mm:ss") +"' AND '" +dateTimePicker2.Value.ToString("yyyy-MM-dd HH:mm:ss") + "' ";
                    SqlDataReader dr = komut.ExecuteReader();
                    int a = 0;
                    while (dr.Read())
                    {
                    dataGridView1.Rows.Add(1);
                    if (dr["durumu"].ToString() == "BEKLEYEN")
                        dataGridView1.Rows[a].DefaultCellStyle.BackColor = System.Drawing.Color.LightGoldenrodYellow;
                    else if (dr["durumu"].ToString() == "REDDEDİLMİŞ")
                        dataGridView1.Rows[a].DefaultCellStyle.BackColor = System.Drawing.Color.Red;
                    else
                        dataGridView1.Rows[a].DefaultCellStyle.BackColor = System.Drawing.Color.ForestGreen;
                        dataGridView1.Rows[a].Cells["durum"].Value = dr["durumu"].ToString();                  
                        dataGridView1.Rows[a].Cells["isim"].Value = dr["isim"].ToString();
                        dataGridView1.Rows[a].Cells["unvan"].Value = dr["unvan"].ToString();
                        dataGridView1.Rows[a].Cells["tarih"].Value = dr["tarih"].ToString();
                        dataGridView1.Rows[a].Cells["konu"].Value = dr["konu"].ToString();
                        dataGridView1.Rows[a].Cells["onerino"].Value = dr["onerino"].ToString();
                        dataGridView1.Rows[a].Cells["oneri"].Value = dr["oneri"].ToString();
                        a++;

                    }
                    baglan.Close();
                    tb_konu.Text = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("sas" + ex);
                }
            }

        private void dataGridView1_EditingControlShowing(object sender,
              DataGridViewEditingControlShowingEventArgs e)
        {
           // DataGridViewRow dataGridViewRow = e.Control as DataGridViewRow;
            combo = e.Control as ComboBox;
            if (combo != null)
            {
               
                combo.SelectedIndexChanged -= new EventHandler(combo_SelectedIndexChanged);
                combo.SelectedIndexChanged += combo_SelectedIndexChanged;
            }
        }
        private void combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selected = (sender as ComboBox).SelectedItem.ToString();
            //tb_konu.Text = selected;
            if (selected.Equals("ONAYLA"))
            {
                
                tb_konu.Text = selected+"-"+ dataGridView1.Rows[index].Cells[6].Value; ;
                int onerino;

                if (index > -1)
                {

                    try
                    {                    Int32.TryParse(dataGridView1.Rows[index].Cells[6].Value.ToString() , out onerino);
                        baglan.Open();
                        SqlCommand komut = baglan.CreateCommand();
                        komut.CommandText = "Update ok_oneriler set durumu='ONAYLANMIŞ' where onerino ='"+onerino+"'";
                        komut.ExecuteNonQuery();
                        baglan.Close();
                        verigetir();
                       // baglan.Close();

                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(""+ex);
                    }
                }
                else
                {
                    MessageBox.Show("secimmmm yap.");
                }

            }
            if (selected.Equals("REDDET"))
            {

                tb_konu.Text = selected + "-" + dataGridView1.Rows[index].Cells[6].Value.ToString();
                tb_konu.Text = selected + "-" + dataGridView1.Rows[index].Cells[6].Value; ;
                int onerino;

                if (index > -1)
                {

                    try
                    {
                        Int32.TryParse(dataGridView1.Rows[index].Cells[6].Value.ToString(), out onerino);
                        baglan.Open();
                        SqlCommand komut = baglan.CreateCommand();
                        komut.CommandText = "Update ok_oneriler set durumu='REDDEDİLMİŞ' where onerino ='" + onerino + "'";
                        komut.ExecuteNonQuery();
                        baglan.Close();
                        verigetir();
                        // baglan.Close();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("" + ex);
                    }
                }
                else
                {
                    MessageBox.Show("secimmmm yap.");
                }
            }
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            
            //tb_konu.Text = e.RowIndex+"";
            
        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
           index = e.RowIndex;

        }
        public void verigetir()
        {
            dataGridView1.Rows.Clear();
            try
            {
                baglan.Open();
                SqlCommand komut = baglan.CreateCommand();
                komut.CommandText = "select durumu,isim,unvan,tarih, konu,onerino,oneri from ok_personeller as p inner join ok_oneriler as o on  p.kartkodu=o.kartkodu";
                SqlDataReader dr = komut.ExecuteReader();
                int a = 0;

                while (dr.Read())
                {

                    dataGridView1.Rows.Add(1);
                    if (dr["durumu"].ToString() == "BEKLEYEN")
                        dataGridView1.Rows[a].DefaultCellStyle.BackColor = System.Drawing.Color.LightGoldenrodYellow;
                    else if (dr["durumu"].ToString() == "REDDEDİLMİŞ")
                        dataGridView1.Rows[a].DefaultCellStyle.BackColor = System.Drawing.Color.OrangeRed;
                    else
                        dataGridView1.Rows[a].DefaultCellStyle.BackColor = System.Drawing.Color.ForestGreen;

                    dataGridView1.Rows[a].Cells["durum"].Value = dr["durumu"].ToString();
                    dataGridView1.Rows[a].Cells["isim"].Value = dr["isim"].ToString();
                    dataGridView1.Rows[a].Cells["unvan"].Value = dr["unvan"].ToString();
                    dataGridView1.Rows[a].Cells["tarih"].Value = dr["tarih"].ToString();
                    dataGridView1.Rows[a].Cells["konu"].Value = dr["konu"].ToString();
                    dataGridView1.Rows[a].Cells["onerino"].Value = dr["onerino"].ToString();
                    dataGridView1.Rows[a].Cells["oneri"].Value = dr["oneri"].ToString();
                    a++;

                }

                baglan.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("sas" + ex);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
