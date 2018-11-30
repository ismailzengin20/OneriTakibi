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
    public partial class yönetimonay : Form
    {
        int satir;
        SqlConnection baglan = new SqlConnection("");
        public yönetimonay()
        {
            InitializeComponent();
        }
        public string kullanıcıadı;
        ComboBox combo;
        int index;
        //************
        //FORM ACILINCA VERİLERİN YUKLENMESİ 
        //************
        private void yönetimonay_Load(object sender, EventArgs e)
        {
            label1.Text = kullanıcıadı;
          //  pictureBox1.Image = Image.FromFile(@"\\_Görseller\Uygulama\Üretim Takibi - Yönetim\abit.jpg ");
            for (int i = 0; i < 8; i++)
            dataGridView1.Columns[i].HeaderCell.Style.Font = new Font("Tahoma", 15F, FontStyle.Bold);
            dataGridView1.ColumnHeadersHeight = 35;
            this.dataGridView1.DefaultCellStyle.Font = new Font("Tahoma", 10);
            verigetir();
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
                    komut.CommandText = "select yonetimonaydurumu,isim,unvan,tarih, konu,onerino,oneri from ok_personeller as p inner join ok_oneriler as o on  p.kartkodu=o.kartkodu where   konu like '%" + tb_konu.Text + "%' and yonetimonaydurumu!='NULL'";
                    SqlDataReader dr = komut.ExecuteReader();
                    int a = 0;
                    while (dr.Read())
                    {
                        dataGridView1.Rows.Add(1);
                        if (dr["yonetimonaydurumu"].ToString() == "BEKLEYEN")
                            dataGridView1.Rows[a].DefaultCellStyle.BackColor = System.Drawing.Color.LightGoldenrodYellow;
                        else if (dr["yonetimonaydurumu"].ToString() == "REDDEDİLMİŞ")
                            dataGridView1.Rows[a].DefaultCellStyle.BackColor = System.Drawing.Color.Red;
                        else
                            dataGridView1.Rows[a].DefaultCellStyle.BackColor = System.Drawing.Color.YellowGreen;
                        dataGridView1.Rows[a].Cells["durum"].Value = dr["yonetimonaydurumu"].ToString();
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
        //************
        // SEÇİLEN İKİ TARİH ARASI ÖNERİLERİ LİSTELEME
        //************
        private void b_tarihegoreara_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            try
            {
                baglan.Open();
                SqlCommand komut = baglan.CreateCommand();
                komut.CommandText = "select yonetimonaydurumu,isim,unvan,tarih, konu,onerino,oneri from ok_personeller as p inner join ok_oneriler as o on  p.kartkodu=o.kartkodu where tarih BETWEEN  '" + dateTimePicker1.Value.ToString("yyyy-MM-dd HH:mm:ss") + "' AND '" + dateTimePicker2.Value.ToString("yyyy-MM-dd HH:mm:ss") + "' and yonetimonaydurumu!='NULL' ";
                SqlDataReader dr = komut.ExecuteReader();
                int a = 0;
                while (dr.Read())
                {
                    dataGridView1.Rows.Add(1);
                    if (dr["yonetimonaydurumu"].ToString() == "BEKLEYEN")
                        dataGridView1.Rows[a].DefaultCellStyle.BackColor = System.Drawing.Color.LightGoldenrodYellow;
                    else if (dr["yonetimonaydurumu"].ToString() == "REDDEDİLMİŞ")
                        dataGridView1.Rows[a].DefaultCellStyle.BackColor = System.Drawing.Color.Red;
                    else
                        dataGridView1.Rows[a].DefaultCellStyle.BackColor = System.Drawing.Color.YellowGreen;
                    dataGridView1.Rows[a].Cells["durum"].Value = dr["yonetimonaydurumu"].ToString();
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
        //************
        //ÖNERİLER TABLOSUNDAKİ ÖNERİLERİ LİSTELEME
        //************
        public void verigetir()
        {
            dataGridView1.Rows.Clear();
            try
            {
                baglan.Open();
                SqlCommand komut = baglan.CreateCommand();
                komut.CommandText = "select yonetimonaydurumu,onaydurumu ,isim,unvan,tarih, konu,onerino,oneri from ok_personeller as p inner join ok_oneriler as o on  p.kartkodu=o.kartkodu where yonetimonaydurumu!='NULL'";
                SqlDataReader dr = komut.ExecuteReader();
                int a = 0;

                while (dr.Read())
                {

                    dataGridView1.Rows.Add(1);
                    if (dr["yonetimonaydurumu"].ToString() == "BEKLEYEN")
                        dataGridView1.Rows[a].DefaultCellStyle.BackColor = System.Drawing.Color.LightGoldenrodYellow;
                    else if (dr["yonetimonaydurumu"].ToString() == "REDDEDİLMİŞ")
                        dataGridView1.Rows[a].DefaultCellStyle.BackColor = System.Drawing.Color.OrangeRed;
                    else if (dr["yonetimonaydurumu"].ToString() == "ONAYLANMIŞ")
                        dataGridView1.Rows[a].DefaultCellStyle.BackColor = System.Drawing.Color.YellowGreen;

                    dataGridView1.Rows[a].Cells["durum"].Value = dr["yonetimonaydurumu"].ToString();
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

        private void dataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            combo = e.Control as ComboBox;
            if (combo != null)
            {

                combo.SelectedIndexChanged -= new EventHandler(combo_SelectedIndexChanged);
                combo.SelectedIndexChanged += combo_SelectedIndexChanged;
            }
        }
        //************
        //DATAGRİDVİEW İÇERİSİNDEKİ İŞLEMLER ONAYLA VEYA REDDET 
        //************
        private void combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selected = (sender as ComboBox).SelectedItem.ToString();
            if (selected.Equals("ONAYLA"))
            {     
                int onerino;
                if (index > -1)
                {
                    try
                    {
                        Int32.TryParse(dataGridView1.Rows[index].Cells[6].Value.ToString(), out onerino);
                        baglan.Open();
                        SqlCommand komut = baglan.CreateCommand();
                        komut.CommandText = "Update ok_oneriler set  yonetimonaydurumu='ONAYLANMIŞ',yonetimonaydurumutarihi='" + DateTime.Now.ToString("yyyy-MM-dd") + "'where onerino ='" + onerino + "'";
                        komut.ExecuteNonQuery();
                        baglan.Close();
                        verigetir();
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
            if (selected.Equals("REDDET"))
            {
                int onerino;

                if (index > -1)
                {
                    try
                    {
                        Int32.TryParse(dataGridView1.Rows[index].Cells[6].Value.ToString(), out onerino);
                        baglan.Open();
                        SqlCommand komut = baglan.CreateCommand();
                        komut.CommandText = "Update ok_oneriler set  yonetimonaydurumu='REDDEDİLMİŞ',yonetimonaydurumutarihi='" + DateTime.Now.ToString("yyyy-MM-dd") + "'where onerino ='" + onerino + "'";
                        komut.ExecuteNonQuery();
                        baglan.Close();
                        verigetir();
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
        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            genel.F_giris = new giris();
            genel.F_giris.Show();
            this.Hide();
        }
        //************
        //SECİLEN ONAY DURUMUNA  YA GÖRE LİSTELEME YAPMA
        //************
        private void b_durumagoreara_Click(object sender, EventArgs e)
        {
            if (cb_durum.SelectedIndex > -1)
            {
                dataGridView1.Rows.Clear();
                try
                {
                    baglan.Open();
                    SqlCommand komut = baglan.CreateCommand();
                    if (cb_durum.SelectedItem.Equals("BEKLEYEN"))
                        komut.CommandText = "select yonetimonaydurumu,isim,unvan,tarih, konu,onerino,oneri from ok_personeller as p inner join ok_oneriler as o on  p.kartkodu=o.kartkodu where   yonetimonaydurumu like '%" + cb_durum.Text + "%' and  yonetimonaydurumu!='NULL'";
                    else if (cb_durum.SelectedItem.Equals("REDDEDİLMİŞ"))
                        komut.CommandText = "select yonetimonaydurumu,isim,unvan,tarih, konu,onerino,oneri from ok_personeller as p inner join ok_oneriler as o on  p.kartkodu=o.kartkodu where   yonetimonaydurumu like '%" + cb_durum.Text + "%' and  yonetimonaydurumu!='NULL'";
                    else
                        komut.CommandText = "select yonetimonaydurumu,isim,unvan,tarih, konu,onerino,oneri from ok_personeller as p inner join ok_oneriler as o on  p.kartkodu=o.kartkodu where   yonetimonaydurumu like '%" + cb_durum.Text + "%' and  yonetimonaydurumu!='NULL'";
                    SqlDataReader dr = komut.ExecuteReader();
                    int a = 0;
                    while (dr.Read())
                    {
                        dataGridView1.Rows.Add(1);
                        if (dr["yonetimonaydurumu"].ToString() == "BEKLEYEN")
                            dataGridView1.Rows[a].DefaultCellStyle.BackColor = System.Drawing.Color.LightGoldenrodYellow;
                        else if (dr["yonetimonaydurumu"].ToString() == "REDDEDİLMİŞ")
                            dataGridView1.Rows[a].DefaultCellStyle.BackColor = System.Drawing.Color.Red;
                        else if (dr["yonetimonaydurumu"].ToString() == "ONAYLANMIŞ")
                            dataGridView1.Rows[a].DefaultCellStyle.BackColor = System.Drawing.Color.YellowGreen;
                        dataGridView1.Rows[a].Cells["durum"].Value = dr["yonetimonaydurumu"].ToString();
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

        private void dataGridView1_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 7 && e.RowIndex >= 0)
            {
                genel.F_öneribilgi = new öneribilgi();
                genel.F_öneribilgi.index = e.RowIndex;
                genel.F_öneribilgi.dgv = dataGridView1;
                genel.F_öneribilgi.Show();
            }
        }

        private void dataGridView1_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 7 && e.RowIndex >= 0)
            {
                genel.F_öneribilgi.Close();
            }
        }

        private void dataGridView1_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
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
    }
}
