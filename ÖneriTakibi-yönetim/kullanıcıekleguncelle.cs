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
    public partial class kullanıcıekle : Form
    {
        public DataGridView DGV_kullanıcılar;
         SqlConnection baglan = new SqlConnection("");
        //SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-1OFOMHU;Initial Catalog=onerikutusu;Integrated Security=True");
        int index;
        public kullanıcıekle()
        {
            InitializeComponent();
        }
        private void bsayfayıkapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void bpersonelkle_Click(object sender, EventArgs e)
        {
            if (tb_kullanıcıadı.Text.Length > 0 && tb_kartkodu.Text.Length > 0 && tb_şifre.Text.Length > 0 && tb_ceptelefonu.Text.Length > 0 && tb_eposta.Text.Length > 0 && cb_yetkituru.SelectedIndex > -1)
            {
                try
                {
                    baglan.Open();
                    SqlCommand komut = baglan.CreateCommand();
                    komut.CommandText = "insert into ok_kullanicilar values (@kullaniciadi,@sifre,@kartkodu,@yetkituru,@ceptelefonu,@eposta,@aciklama)";
                    komut.Parameters.Add("@kullaniciadi", tb_kullanıcıadı.Text);
                    komut.Parameters.Add("@sifre", tb_şifre.Text);
                    komut.Parameters.Add("@kartkodu", tb_kartkodu.Text);
                    komut.Parameters.Add("@yetkituru", cb_yetkituru.SelectedItem);
                    komut.Parameters.Add("@ceptelefonu", tb_ceptelefonu.Text);
                    komut.Parameters.Add("@eposta", tb_eposta.Text);
                    komut.Parameters.Add("@aciklama", tb_acıklama.Text);                  
                    komut.ExecuteNonQuery();
                    baglan.Close();
                    MessageBox.Show("kullanıcı basarılı bir sekilde kaydedildi.");
                    tb_kullanıcıadı.Clear();
                    tb_şifre.Clear();
                    tb_kartkodu.Clear();
                    cb_yetkituru.SelectedIndex = -1;
                    tb_ceptelefonu.Clear();
                    tb_acıklama.Clear();
                    tb_eposta.Clear();
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex + "");
                }
            }
            else
                MessageBox.Show("gerekli yerleri doldurup tekrar deneyiniz.");
        }
        private void bkullanıcıgüncelle_Click(object sender, EventArgs e)
        {
            string kullanıcıadı=DGV_kullanıcılar.Rows[index].Cells[0].Value.ToString(); 
            if (tb_kullanıcıadı.Text.Length > 0 && tb_kartkodu.Text.Length > 0 && tb_şifre.Text.Length > 0 &&cb_yetkituru.SelectedIndex > -1)
            {
                try
                {
                    baglan.Open();
                    SqlCommand komut = baglan.CreateCommand();
                    komut.CommandText = "update ok_kullanicilar set kullaniciadi=@kullaniciadi,sifre=@sifre,kartkodu=@kartkodu,yetkituru=@yetkituru,ceptelefonu=@ceptelefonu,eposta=@eposta,aciklama=@aciklama where kullaniciadi='"+kullanıcıadı+"' ";
                    komut.Parameters.Add("@kullaniciadi", tb_kullanıcıadı.Text);
                    komut.Parameters.Add("@sifre", tb_şifre.Text);
                    komut.Parameters.Add("@kartkodu", tb_kartkodu.Text);
                    komut.Parameters.Add("@yetkituru", cb_yetkituru.SelectedItem);
                    komut.Parameters.Add("@ceptelefonu", tb_ceptelefonu.Text);
                    komut.Parameters.Add("@eposta", tb_eposta.Text);
                    komut.Parameters.Add("@aciklama", tb_acıklama.Text);
                    komut.ExecuteNonQuery();
                    baglan.Close();
                    MessageBox.Show("kullanıcı basarılı bir sekilde guncellendi.");
                    tb_kullanıcıadı.Clear();
                    tb_şifre.Clear();
                    tb_kartkodu.Clear();
                    cb_yetkituru.SelectedIndex = -1;
                    tb_ceptelefonu.Clear();
                    tb_acıklama.Clear();
                    tb_eposta.Clear();          
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex + "");
                }
            }
            else
                MessageBox.Show("gerekli yerleri doldurup tekrar deneyiniz.");
        }
        private void bverileritemizle_Click(object sender, EventArgs e)
        {
            tb_kullanıcıadı.Clear();
            tb_şifre.Clear();
            tb_kartkodu.Clear();
            cb_yetkituru.SelectedIndex = -1;
            tb_ceptelefonu.Clear();
            tb_acıklama.Clear();
            tb_eposta.Clear();
        }
        private void kullanıcıekle_FormClosed(object sender, FormClosedEventArgs e)
        {
            genel.F_kullanıcılistele.getir();
        }

        private void kullanıcıekle_Load(object sender, EventArgs e)
        {
            if (label8.Text == "ekle")
            {
                bkullanıcıgüncelle.Enabled = false;
            }
            else
            {              
                Int32.TryParse(label9.Text, out index);
                bpersonelkle.Enabled = false;
                bverileritemizle.Enabled = false;
                tb_kullanıcıadı.Text = DGV_kullanıcılar.Rows[index].Cells[0].Value.ToString() ;
                tb_şifre.Text = DGV_kullanıcılar.Rows[index].Cells[1].Value.ToString();
                tb_kartkodu.Text = DGV_kullanıcılar.Rows[index].Cells[2].Value.ToString();
                string yetkituru= DGV_kullanıcılar.Rows[index].Cells[3].Value.ToString();
                if (yetkituru.Equals("önerionay"))
                    cb_yetkituru.Text = "önerionay";
               if(yetkituru == "teknikonay")
                    cb_yetkituru.Text = "teknikonay";
               if(yetkituru == "yönetimonay")
                    cb_yetkituru.Text = "yönetimonay";
                tb_eposta.Text = DGV_kullanıcılar.Rows[index].Cells[4].Value.ToString();
                tb_ceptelefonu.Text = DGV_kullanıcılar.Rows[index].Cells[5].Value.ToString();
                tb_acıklama.Text = DGV_kullanıcılar.Rows[index].Cells[6].Value.ToString();

            }
        }
    }
}
