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
    public partial class onaysebebi : Form
    {
        SqlConnection baglan = new SqlConnection("");
        public int onerino;
        public String durum ;
        public String kategori;
        public onaysebebi()
        {
            InitializeComponent();
        }

        private void b_onayla_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                if (durum.Equals("onayla"))
                {

                    try
                    {
                        //teknikonayacıklaması
                        baglan.Open();
                        SqlCommand komut = baglan.CreateCommand();
                        if (kategori.Equals("onerionay"))
                        {
                            komut.CommandText = "Update ok_oneriler set onaydurumu='ONAYLANMIŞ',onayacıklaması='" + textBox1.Text + "',teknikonaydurumu='BEKLEYEN',onaydurumutarihi='" + DateTime.Now.ToString("yyyy-MM-dd") + "' where onerino ='" + onerino + "'";
                            komut.ExecuteNonQuery();
                            baglan.Close();
                            this.Close();
                            genel.F_onerionay.verigetir();
                        }

                        if (kategori.Equals("teknikonay")) { 
                        komut.CommandText = "Update ok_oneriler set  teknikonaydurumu='ONAYLANMIŞ',teknikonayacıklaması='" + textBox1.Text + "',yonetimonaydurumu='BEKLEYEN',teknikonaydurumutarihi='" + DateTime.Now.ToString("yyyy-MM-dd") + "'where onerino ='" + onerino + "'";
                            komut.ExecuteNonQuery();
                            baglan.Close();
                            this.Close();
                            genel.F_teknikonay.verigetir();

                        }
                       

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("" + ex);
                    }
                }
                else
                {
                    try { 
                    baglan.Open();
                    SqlCommand komut = baglan.CreateCommand();
                        if (kategori.Equals("onerionay"))
                        { 
                            komut.CommandText = "Update ok_oneriler set onaydurumu='REDDEDİLMİŞ',onayacıklaması='" + textBox1.Text + "',teknikonaydurumu=NULL,onaydurumutarihi='" + DateTime.Now.ToString("yyyy-MM-dd") + "' where onerino ='" + onerino + "'";
                            komut.ExecuteNonQuery();
                            baglan.Close();
                            this.Close();
                            genel.F_onerionay.verigetir();
                        }
                        if (kategori.Equals("teknikonay"))
                        {
                            komut.CommandText = "Update ok_oneriler set  teknikonaydurumu='REDDEDİLMİŞ',teknikonayacıklaması='" + textBox1.Text + "',yonetimonaydurumu=NULL,teknikonaydurumutarihi='" + DateTime.Now.ToString("yyyy-MM-dd") + "'where onerino ='" + onerino + "'";
                            komut.ExecuteNonQuery();
                            baglan.Close();
                            this.Close();
                            genel.F_teknikonay.verigetir();
                        }
                       
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("" + ex);
                    }
                }

            }
            else
            {
                MessageBox.Show("öneriyi onaylamak için açıklama girmeniz gerekmektedir.");
            }
        }

        private void b_iptal_Click(object sender, EventArgs e)
        {
            this.Close();
            genel.F_onerionay.verigetir();

        }
    }
}
