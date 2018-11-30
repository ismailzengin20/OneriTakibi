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
using System.Net.Mail;

namespace OneriTakibi
{
    public partial class öneri : Form
    {
        SqlConnection baglan = new SqlConnection(" ");

        public öneri()
        {
            InitializeComponent();
        }
        public String kartkodu { get; set; }
        String resim;

        private void öneri_Load(object sender, EventArgs e)
        {
            try
            {
                baglan.Open();
                SqlCommand komut = baglan.CreateCommand();
                komut.CommandText = "select *from ok_personeller where kartkodu='"+kartkodu.ToString()+"'";
                SqlDataReader dr = komut.ExecuteReader();
                dr.Read();
                 tb_isim.Text = dr["isim"].ToString();
                 tb_unvan.Text =dr["unvan"].ToString();
                  resim = dr["fotograf"].ToString();
                baglan.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("sasa" + ex);
            }
               pictureBox1.Image = Image.FromFile(
             @"\\\_Görseller\Uygulama\Üretim Takibi - Yönetim\Personeller\"+resim);
        }
        private void b_vazgeç_Click(object sender, EventArgs e)
        {

            Genel.F_giris = new giris();
            Genel.F_giris.Show();
            this.Hide();
        }
        private void b_kaydet_Click(object sender, EventArgs e)
        {
            if (tb_konu.Text.Length > 0 && tb_oneri.Text.Length > 0)
            {
                try
                {
                    baglan.Open();
                    SqlCommand komut = baglan.CreateCommand();
                    komut.CommandText = "insert into ok_oneriler values (@kartkodu,@konu,@oneri,@tarih,@onaydurumu,@onaydurumutarihi,@teknikonaydurumu,@teknikonaydurumutarihi,@yonetimonaydurumu,@yonetimonaydurumutarihi)";
                    komut.Parameters.Add("@kartkodu",kartkodu.ToString());
                    komut.Parameters.Add("@konu", tb_konu.Text.ToString());
                    komut.Parameters.Add("@oneri", tb_oneri.Text.ToString());
                    komut.Parameters.Add("@tarih", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")); //19.03.2018 11:26
                    komut.Parameters.Add("@onaydurumu", "BEKLEYEN");
                    komut.Parameters.Add("@onaydurumutarihi", DBNull.Value);
                    komut.Parameters.Add("@teknikonaydurumu", DBNull.Value);
                    komut.Parameters.Add("@teknikonaydurumutarihi", DBNull.Value);
                    komut.Parameters.Add("@yonetimonaydurumu", DBNull.Value);
                    komut.Parameters.Add("@yonetimonaydurumutarihi", DBNull.Value);
                    komut.ExecuteNonQuery();              
                                   
                        MailMessage ePosta = new MailMessage();
                        ePosta.From = new MailAddress(@"ismailzengin12332@yandex.com");                    
                        ePosta.To.Add(@"zenginismail020@gmail.com");
                        ePosta.Subject = "Ön onay bekleyen yeni öneri";
                        ePosta.Body = DateTime.Now.ToString() +" yapılan öneri ön onayınızı beklemektedir.";
                        SmtpClient smtp = new SmtpClient();
                        smtp.Credentials = new System.Net.NetworkCredential("ismailzengin12332@yandex.com", "02588561032");
                        smtp.Port = 587;
                        smtp.Host = "smtp.yandex.com";
                        smtp.EnableSsl = true;
                        object userState = ePosta;
                        bool kontrol = true;
                        try
                        {
                        smtp.SendAsync(ePosta, (object)ePosta);
                    
                        }
                        catch (SmtpException ex)
                        {                         
                            MessageBox.Show(ex+"Mail Gönderme Hatasi");
                        }
     
                    baglan.Close();
                    Genel.F_giris = new giris();
                    Genel.F_giris.Show();
                    this.Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("sasa"+ex);
                }
             }
        }

        private void b_temizle_Click(object sender, EventArgs e)
        {             
                tb_konu.Text = "";
                tb_oneri.Text = "";              
        }
    } }

    