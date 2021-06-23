using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QUANLIKTX.VIEW;
using DAOKTX;
using BUSKTX.BUSQLKT;

namespace QUANLIKTX.VIEW
{
    public partial class HOADONPHONG : Form
    {
        public HOADONPHONG()
        {
            InitializeComponent();
        }
        List<Hoadonphong> l;
        BUShoadonP bus = new BUShoadonP();
        private void HOADONPHONG_Load(object sender, EventArgs e)
        {
            l = bus.GetHoadonphongs();
            dataGridView1.DataSource = l;
        }

        private void butchit_Click(object sender, EventArgs e)
        {
            PHONGKT p = new PHONGKT();
            this.Hide();
            p.Show();
        }

        private void buthd_Click(object sender, EventArgs e)
        {
            CHITIETPHONG c = new CHITIETPHONG();
            this.Hide();
            c.Show();
        }

        private void butback_Click(object sender, EventArgs e)
        {
            frmMENU m = new frmMENU();
            m.Show();
            this.Hide();
        }
    }
}
