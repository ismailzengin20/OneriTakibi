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
using System.IO;

namespace önerikutusu_yonetim
{
    public partial class personelekle : Form
    {
      public DataGridView DGV_Personeller;
        SqlConnection baglan = new SqlConnection("");
        //  SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-1OFOMHU;Initial Catalog=onerikutusu;Integrated Security=True");

        public int index;
        public personelekle()
        {
            InitializeComponent();
            bpersonelgüncelle.Enabled = false;
        }
        private void bsayfayıkapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void bverileritemizle_Click(object sender, EventArgs e)
        {
            tb_acıklama.Clear();
            tb_adres.Clear();
            tb_isim.Clear();
            tb_kartkodu.Clear();
            tb_tcnumarası.Clear();
            tb_unvan.Clear();
            tb_adres.Clear();
        }
        private void bpersonelgüncelle_Click(object sender, EventArgs e)
        {
            string kartkodu = DGV_Personeller.Rows[index].Cells[0].Value.ToString();
            if (tb_kartkodu.Text.Length > 0 && tb_isim.Text.Length > 0&&tb_fotograf.Text.Length>0)
            {
                try
                {
                    baglan.Open();

                    SqlCommand komut = baglan.CreateCommand();
                    komut.CommandText = "update  ok_personeller set kartkodu=@kartkodu,tcnumarasi=@tcnumarası,isim=@isim,unvan=@unvan,adres=@adres,eposta=@eposta,aciklama=@aciklama,fotograf=@fotograf where kartkodu='"+kartkodu+"'";
                    komut.Parameters.Add("@kartkodu", tb_kartkodu.Text);
                    komut.Parameters.Add("@tcnumarası", tb_tcnumarası.Text);
                    komut.Parameters.Add("@isim", tb_isim.Text);
                    komut.Parameters.Add("@unvan", tb_unvan.Text);
                    komut.Parameters.Add("@adres", tb_adres.Text);
                    komut.Parameters.Add("@eposta", tb_eposta.Text);
                    komut.Parameters.Add("@aciklama", tb_acıklama.Text);
                    komut.Parameters.Add("@fotograf", tb_fotograf.Text);
                    komut.ExecuteNonQuery();
                    baglan.Close();
                    MessageBox.Show("Güncelleme basarılı..");
                    this.Close();
                    genel.F_personelListele.getir();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("" + ex);
                }
            }
            else
                MessageBox.Show("gerekli yerleri doldurup tekrar deneyiniz.");
        }
        private void bpersonelekle_Click(object sender, EventArgs e)
        {
            if (tb_kartkodu.Text.Length > 0 && tb_isim.Text.Length > 0 && tb_fotograf.Text.Length > 0)
            {
                try
                {
                    baglan.Open();

                    SqlCommand komut = baglan.CreateCommand();
                    komut.CommandText = "insert into ok_personeller values( @kartkodu,@tcnumarası,@isim,@unvan,@fotograf,@adres,@eposta,@aciklama)";
                    komut.Parameters.Add("@kartkodu", tb_kartkodu.Text);
                    komut.Parameters.Add("@tcnumarası", tb_tcnumarası.Text);
                    komut.Parameters.Add("@isim", tb_isim.Text);
                    komut.Parameters.Add("@unvan", tb_unvan.Text);
                    komut.Parameters.Add("@adres", tb_adres.Text);
                    komut.Parameters.Add("@fotograf", tb_fotograf.Text);
                    komut.Parameters.Add("@eposta", tb_eposta.Text);
                    komut.Parameters.Add("@aciklama", tb_acıklama.Text);

                    komut.ExecuteNonQuery();
                    baglan.Close();
                    MessageBox.Show("Ekleme  basarılı..");
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("" + ex);
                }
            }
            else
                MessageBox.Show("gerekli yerleri doldurup tekrar deneyiniz." );
        }

        private void personelekle_Load(object sender, EventArgs e)
        {
            if (label8.Text == "ekle")
            {
                bpersonelgüncelle.Enabled = false;
            }
            else
            {
                Int32.TryParse(label9.Text, out index);
                bpersonelekle.Enabled = false;
                bpersonelgüncelle.Enabled= true;
                bverileritemizle.Enabled = false;

                tb_kartkodu.Text = DGV_Personeller.Rows[index].Cells[0].Value.ToString();
                tb_tcnumarası.Text = DGV_Personeller.Rows[index].Cells[1].Value.ToString();
                tb_isim.Text = DGV_Personeller.Rows[index].Cells[2].Value.ToString();           
                tb_unvan.Text = DGV_Personeller.Rows[index].Cells[3].Value.ToString();
                tb_adres.Text = DGV_Personeller.Rows[index].Cells[4].Value.ToString();
                tb_eposta.Text = DGV_Personeller.Rows[index].Cells[5].Value.ToString();
                tb_acıklama.Text = DGV_Personeller.Rows[index].Cells[6].Value.ToString();
                tb_fotograf.Text = DGV_Personeller.Rows[index].Cells[7].Value.ToString();
                    personelresmi.Image = Image.FromFile(@"\\_Görseller\Uygulama\Üretim Takibi - Yönetim\Personeller\"+ tb_fotograf.Text+"");

            }
        }

        private void bresimsec_Click(object sender, EventArgs e)
        { 
             OpenFileDialog dosya = new OpenFileDialog();
            dosya.Filter = "Resim Dosyası |*.jpg;*.nef;*.png| Video|*.avi| Tüm Dosyalar |*.*";
            dosya.InitialDirectory = @"\\_Görseller\Uygulama\Üretim Takibi - Yönetim\Personeller";
            dosya.Title = "AKÇELİKBORU";
            dosya.ShowDialog();
            string DosyaYolu = dosya.FileName;
           // personelresmi.ImageLocation = DosyaYolu;
            tb_fotograf.Text = Path.GetFileName(dosya.FileName);
            if(tb_fotograf.Text.Length>0)
            personelresmi.Image = Image.FromFile(@"\\_Görseller\Uygulama\Üretim Takibi - Yönetim\Personeller\" +tb_fotograf.Text+ "");
        }

        private void personelekle_FormClosed(object sender, FormClosedEventArgs e)
        {
           
        }
    }
}
