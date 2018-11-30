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


namespace OneriTakibi
{

    public partial class giris : Form
    {
       // SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-1OFOMHU;Initial Catalog=onerikutusu;Integrated Security=True;");
        SqlConnection baglan = new SqlConnection(" ");


        public giris()
        {
            InitializeComponent();
        }
        

        private void tb_kartkodu_KeyPress_1(object sender, KeyPressEventArgs e)
        {

            if (tb_kartkodu.Text != "" && e.KeyChar == (Char)Keys.Enter)
            {
                try
                {
                    baglan.Open();
                    SqlCommand komut = baglan.CreateCommand();
                    komut.CommandText = "select * from ok_personeller where kartkodu='" + tb_kartkodu.Text + "'";
                    SqlDataReader dr = komut.ExecuteReader();

                    if (dr.HasRows)
                    {
                        dr.Read();
                        Genel.F_öneri = new öneri();
                        Genel.F_öneri.kartkodu = dr["kartkodu"].ToString();
                        Genel.F_öneri.Show();
                        this.Hide();
                       
                    }
                    else
                    {
                        label2.Text = "!!! KAYIT  YOK  !!! ";
                        label3.Text = "KAYIT YAPTIRIP TEKRAR  DENEYİNİZ";
                        tb_kartkodu.Text = "";
                        baglan.Close();

                    }

                    baglan.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("sas" + ex);
                }
            }           
        }
        private void bkapat_Click(object sender, EventArgs e)
        {
            Genel.F_kapatmasifresi = new kapatmasifresi();
            Genel.F_kapatmasifresi.Show();
        }
    }
}
