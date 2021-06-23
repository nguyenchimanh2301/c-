using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAOKTX;
using BUSKTX.BUSQLKT;

namespace QUANLIKTX.VIEW
{
    public partial class CHITIETPHONG : Form
    {
        public CHITIETPHONG()
        {
            InitializeComponent();
        }
        BUSphongkt bp = new BUSphongkt();
        List<Phongkt> l;
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void CHITIETPHONG_Load(object sender, EventArgs e)
        {
            l = bp.GetPhongkts();
            dataGridView1.DataSource = l;
        }

        private void butp_Click(object sender, EventArgs e)
        {
            PHONGKT p = new PHONGKT();
            p.Show();
            this.Hide();
        }

        private void butback_Click(object sender, EventArgs e)
        {
            frmMENU m = new frmMENU();
            m.Show();
            this.Hide();
        }

        private void buthd_Click(object sender, EventArgs e)
        {
            HOADONPHONG f = new HOADONPHONG();
            f.Show();
            this.Hide();
        }
    }
}
