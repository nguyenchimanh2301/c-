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
using QUANLIKTX.VIEW;

namespace QUANLIKTX.VIEW
{
    public partial class HOADONSV : Form
    {
        public HOADONSV()
        {
            InitializeComponent();
        }
        BUShoadonSV bhsv = new BUShoadonSV();
        List<Hoadonsv> l;
        private void HOADONSV_Load(object sender, EventArgs e)
        {
            l = bhsv.GetHoadonsvs();
            dataGridView1.DataSource = l;
        }

        private void butsvv_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmSINHVIENVAO s = new frmSINHVIENVAO();
            s.Show();
        }

        private void butsvr_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmSINHVIENRA s = new frmSINHVIENRA();
            s.Show();
        }

        private void butback_Click(object sender, EventArgs e)
        {
            frmMENU m = new frmMENU();
            m.Show();
            this.Hide();
        }
    }
}
