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
    public partial class öneriraporu : Form
    {
        SqlConnection baglan = new SqlConnection("");

        public öneriraporu()
        {
            InitializeComponent();
        }
        string[] isimler;
        int önerisayısıı;
       int tekniksayısıı;
        int yonetimsayısı;
        public int a;
        public SqlDataReader dr;

        private void bsayfayıkapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void verigetir()
        {
            isimler = new string[500];
            dataGridView1.Rows.Clear();
           
                try
                {
                    baglan.Open();
                    SqlCommand komut = baglan.CreateCommand();
                    komut.CommandText = "select  distinct isim from ok_personeller as p left join ok_oneriler as o  on p.kartkodu = o.kartkodu  where tarih BETWEEN  '" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + " 00:00:00" + "' AND '" + dateTimePicker2.Value.ToString("yyyy-MM-dd")+ " 23:59:59" + "'";
                    SqlDataReader dr = komut.ExecuteReader();
                    int a = 0;
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {

                            dataGridView1.Rows.Add(1);
                            dataGridView1.Rows[a].Cells["isim"].Value = dr["isim"].ToString();
                            isimler[a] = dr["isim"].ToString();
                            a++;
                        }
                        Array.Resize(ref isimler, a);
                        dr.Close();

                        for (int i = 0; i < isimler.Length; i++)
                        {

                            komut.CommandText = "select  p.kartkodu  from ok_personeller as p left join ok_oneriler as o  on p.kartkodu = o.kartkodu where p.isim='" + isimler[i].ToString() + "'";
                            dr = komut.ExecuteReader();
                            dr.Read();
                            dataGridView1.Rows[i].Cells["kartkodu"].Value = dr["kartkodu"].ToString();
                            dr.Close();

                            int ücret = 0;
                            komut.CommandText = "select  count(isim) as sayı from ok_personeller as p left join ok_oneriler as o  on p.kartkodu = o.kartkodu where p.isim='" + isimler[i].ToString() + "'";
                            dr = komut.ExecuteReader();
                            dr.Read();
                            dataGridView1.Rows[i].Cells["önerisayısı"].Value = dr["sayı"].ToString();
                            dr.Close();


                            komut.CommandText = "select  count(onaydurumu) as sayı from ok_personeller as p left join ok_oneriler as o  on p.kartkodu = o.kartkodu where p.isim='" + isimler[i].ToString() + "' and onaydurumu='ONAYLANMIŞ'";
                            dr = komut.ExecuteReader();
                            dr.Read();
                            dataGridView1.Rows[i].Cells["önonaysayısı"].Value = dr["sayı"].ToString();
                            Int32.TryParse(dr["sayı"].ToString(), out önerisayısıı);
                            ücret = 8 * önerisayısıı;
                            dr.Close();


                            komut.CommandText = "select  count(teknikonaydurumu) as sayı from ok_personeller as p left join ok_oneriler as o  on p.kartkodu = o.kartkodu where p.isim='" + isimler[i].ToString() + "' and teknikonaydurumu='ONAYLANMIŞ'";
                            dr = komut.ExecuteReader();
                            dr.Read();
                            dataGridView1.Rows[i].Cells["teknikonaysayısı"].Value = dr["sayı"].ToString();
                            Int32.TryParse(dr["sayı"].ToString(), out tekniksayısıı);
                            ücret = ücret + 60 * tekniksayısıı;
                            dr.Close();

                            komut.CommandText = "select  count(yonetimonaydurumu) as sayı from ok_personeller as p left join ok_oneriler as o  on p.kartkodu = o.kartkodu where p.isim='" + isimler[i].ToString() + "' and yonetimonaydurumu='ONAYLANMIŞ'";
                            dr = komut.ExecuteReader();
                            dr.Read();
                            dataGridView1.Rows[i].Cells["yönetimonaysayısı"].Value = dr["sayı"].ToString();
                            Int32.TryParse(dr["sayı"].ToString(), out yonetimsayısı);
                            ücret = ücret + 280 * yonetimsayısı;
                            dr.Close();

                            dataGridView1.Rows[i].Cells["ödül"].Value = ücret.ToString() + " TL";
                        }

                        baglan.Close();
                    }
                    baglan.Close();
                }

                catch (Exception ex)
                { MessageBox.Show("" + ex); }


                }
            


           
        private void öneriraporu_Load(object sender, EventArgs e)
        {
            verigetir();
        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            verigetir();
        }
        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            verigetir();

            /*
            isimler = new string[500];
            dataGridView1.Rows.Clear();
            try
            {
                baglan.Open();
                SqlCommand komut = baglan.CreateCommand();
                komut.CommandText = "select  distinct isim from ok_personeller as p left join ok_oneriler as o  on p.kartkodu = o.kartkodu  where tarih BETWEEN  '" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + " 00:00:00" + "' AND '" + dateTimePicker2.Value.ToString("yyyy-MM-dd")+" 23:59:59" + "'";
                SqlDataReader dr = komut.ExecuteReader();
                int a = 0;
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {

                        dataGridView1.Rows.Add(1);
                        dataGridView1.Rows[a].Cells["isim"].Value = dr["isim"].ToString();
                        isimler[a] = dr["isim"].ToString();
                        a++;
                    }
                    Array.Resize(ref isimler, a);
                    dr.Close();

                    for (int i = 0; i < isimler.Length; i++)
                    {

                        komut.CommandText = "select  p.kartkodu  from ok_personeller as p left join ok_oneriler as o  on p.kartkodu = o.kartkodu where p.isim='" + isimler[i].ToString() + "'";
                        dr = komut.ExecuteReader();
                        dr.Read();
                        dataGridView1.Rows[i].Cells["kartkodu"].Value = dr["kartkodu"].ToString();
                        dr.Close();

                        int ücret = 0;
                        komut.CommandText = "select  count(isim) as sayı from ok_personeller as p left join ok_oneriler as o  on p.kartkodu = o.kartkodu where p.isim='" + isimler[i].ToString() + "'";
                        dr = komut.ExecuteReader();
                        dr.Read();
                        dataGridView1.Rows[i].Cells["önerisayısı"].Value = dr["sayı"].ToString();
                        dr.Close();


                        komut.CommandText = "select  count(onaydurumu) as sayı from ok_personeller as p left join ok_oneriler as o  on p.kartkodu = o.kartkodu where p.isim='" + isimler[i].ToString() + "' and onaydurumu='ONAYLANMIŞ'";
                        dr = komut.ExecuteReader();
                        dr.Read();
                        dataGridView1.Rows[i].Cells["önonaysayısı"].Value = dr["sayı"].ToString();
                        Int32.TryParse(dr["sayı"].ToString(), out önerisayısıı);
                        ücret = 8 * önerisayısıı;
                        dr.Close();


                        komut.CommandText = "select  count(teknikonaydurumu) as sayı from ok_personeller as p left join ok_oneriler as o  on p.kartkodu = o.kartkodu where p.isim='" + isimler[i].ToString() + "' and teknikonaydurumu='ONAYLANMIŞ'";
                        dr = komut.ExecuteReader();
                        dr.Read();
                        dataGridView1.Rows[i].Cells["teknikonaysayısı"].Value = dr["sayı"].ToString();
                        Int32.TryParse(dr["sayı"].ToString(), out tekniksayısıı);
                        ücret = ücret + 60 * tekniksayısıı;
                        dr.Close();

                        komut.CommandText = "select  count(yonetimonaydurumu) as sayı from ok_personeller as p left join ok_oneriler as o  on p.kartkodu = o.kartkodu where p.isim='" + isimler[i].ToString() + "' and yonetimonaydurumu='ONAYLANMIŞ'";
                        dr = komut.ExecuteReader();
                        dr.Read();
                        dataGridView1.Rows[i].Cells["yönetimonaysayısı"].Value = dr["sayı"].ToString();
                        Int32.TryParse(dr["sayı"].ToString(), out yonetimsayısı);
                        ücret = ücret + 280 * yonetimsayısı;
                        dr.Close();

                        dataGridView1.Rows[i].Cells["ödül"].Value = ücret.ToString() + " TL";
                    }

                    baglan.Close();
                }
                baglan.Close();
            }

            catch (Exception ex)
            { MessageBox.Show("" + ex); }*/
        }
    }
}
