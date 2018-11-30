using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace önerikutusu_yonetim
{
    public partial class öneribilgiekranı : Form
    {
        public int index;
        public DataGridView DGV_öneri;

        public öneribilgiekranı()
        {
            InitializeComponent();
        }

        private void öneribilgiekranı_Load(object sender, EventArgs e)
        {
            tb_kartkodu.Text= DGV_öneri.Rows[index].Cells[0].Value.ToString();
            tb_isim.Text=DGV_öneri.Rows[index].Cells[1].Value.ToString();
            tb_konu.Text= DGV_öneri.Rows[index].Cells[3].Value.ToString();
            tb_oneri.Text= DGV_öneri.Rows[index].Cells[4].Value.ToString();
            tb_ünvan.Text= DGV_öneri.Rows[index].Cells[2].Value.ToString();
        }
    }
}
