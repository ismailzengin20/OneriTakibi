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
    public partial class öneridüzenle : Form
    {
        SqlConnection baglan = new SqlConnection("Data Source=IBMSERVER;Initial Catalog=ONERITAKIBI;User ID=uretim;Password=Akcelik31");

        public DataGridView dgv;
        public int index;
        
        public öneridüzenle()
        {
            InitializeComponent();
        }

        private void bsayfayıkapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bönerigüncelle_Click(object sender, EventArgs e)
        {
            try
            {
                baglan.Open();
                SqlCommand komut = baglan.CreateCommand();
                komut.CommandText = "update ok_oneriler set oneri=@oneri,konu=@konu where onerino='" + dgv.Rows[index].Cells[5].Value.ToString() + "' ";              
                komut.Parameters.Add("@oneri", tb_oneri.Text);
                komut.Parameters.Add("@konu", tb_konu.Text);
                komut.ExecuteNonQuery();
                baglan.Close();
                MessageBox.Show("öneri basarılı bir sekilde guncellendi.");              
                tb_oneri.Clear();
                tb_konu.Clear();
                //genel.F_personelListele.getir();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex + "");
            }
        }

        private void bverileritemizle_Click(object sender, EventArgs e)
        {
            tb_oneri.Clear();
            tb_konu.Clear();        }

        private void öneridüzenle_Load(object sender, EventArgs e)
        {
            tb_kartkodu.Text = dgv.Rows[index].Cells[0].Value.ToString();
            tb_isim.Text = dgv.Rows[index].Cells[1].Value.ToString();
            tb_konu.Text = dgv.Rows[index].Cells[3].Value.ToString();
            tb_oneri.Text = dgv.Rows[index].Cells[4].Value.ToString();
            tb_ünvan.Text = dgv.Rows[index].Cells[2].Value.ToString();
        }

        private void öneridüzenle_FormClosed(object sender, FormClosedEventArgs e)
        {
            genel.F_önerilistele.getir();
                
                }
    }
    }

