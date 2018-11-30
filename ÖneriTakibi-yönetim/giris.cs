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
    public partial class giris : Form
    {
        SqlConnection baglan = new SqlConnection("");
        // SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-1OFOMHU;Initial Catalog=onerikutusu;Integrated Security=True");

        public giris()
        {
            InitializeComponent();
        }

        private void bgiriş_Click(object sender, EventArgs e)
        {
            if (tb_kullanıcıadı.Text.Length > 0 && tb_şifre.Text.Length > 0)
            {
                if (tb_kullanıcıadı.Text == "1" && tb_şifre.Text == "1")
                {
                    genel.F_anasayfa = new anasayfa();
                    genel.F_anasayfa.Show();
                    this.Hide();
                }
                else
                {
                    try
                    {
                        baglan.Open();
                        SqlCommand komut = baglan.CreateCommand();
                        komut.CommandText = "select * from ok_kullanicilar where kullaniciadi='" + tb_kullanıcıadı.Text + "' and sifre='" + tb_şifre.Text + "'";
                        SqlDataReader dr = komut.ExecuteReader();
                        if (dr.HasRows)
                        {
                            dr.Read();
                            if (dr["yetkituru"].ToString().Equals("önerionay"))
                            {
                                genel.F_onerionay = new önerionay();
                                genel.F_onerionay.kullanıcıadı = tb_kullanıcıadı.Text;
                                genel.F_onerionay.Show();

                                this.Hide();
                                baglan.Close();
                            }
                            else if (dr["yetkituru"].ToString().Equals("teknikonay"))
                            {
                                genel.F_teknikonay = new teknikonay();
                                genel.F_teknikonay.kullanıcıadı = tb_kullanıcıadı.Text;
                                genel.F_teknikonay.Show();
                                this.Hide();
                                baglan.Close();
                            }
                            else if (dr["yetkituru"].ToString().Equals("yönetimonay"))
                            {
                                genel.F_yonetimonay = new yönetimonay();
                                genel.F_yonetimonay.kullanıcıadı = tb_kullanıcıadı.Text;
                                genel.F_yonetimonay.Show();
                                this.Hide();
                                baglan.Close();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Kullanıcı Adı Şifre Yanlış!!!");
                            baglan.Close();
                            tb_kullanıcıadı.Text = "";
                            tb_şifre.Text = "";
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Kullanıcı Adı Şifre Yanlış!!!" + ex);
                        baglan.Close();
                        tb_kullanıcıadı.Text = "";
                        tb_şifre.Text = "";
                    }
                }
            }
            else
                MessageBox.Show("Boş Alanları Doldurup Tekrar Deneyiniz");       
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }      
    }
}
