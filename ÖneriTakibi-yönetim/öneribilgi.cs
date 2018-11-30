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
    public partial class öneribilgi : Form
    {
        public DataGridView dgv;
        public int index;

        public öneribilgi()
        {
            InitializeComponent();
        }

        private void öneribilgi_Load(object sender, EventArgs e)
        {
            tb_konu.Text = dgv.Rows[index].Cells[5].Value.ToString();
            tb_oneri.Text = dgv.Rows[index].Cells[7].Value.ToString();

        }
    }
}
