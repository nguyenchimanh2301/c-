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
using BUSKTX.BUSQLKT;
using DAOKTX;
namespace QUANLIKTX.VIEW
{
    public partial class frmSINHVIENRA : Form
    {
        public frmSINHVIENRA()
        {
            InitializeComponent();
        }
        BUSSVra bus = new BUSSVra();
        List<SINHVIENRA> lis;

        private void butsvv_Click(object sender, EventArgs e)
        {
            frmSINHVIENVAO s = new frmSINHVIENVAO();
            s.Show();
            this.Hide();
        }

        private void buthd_Click(object sender, EventArgs e)
        {
            HOADONSV s = new HOADONSV();
            s.Show();
            this.Hide();
        }

        private void frmSINHVIENRA_Load(object sender, EventArgs e)
        {
            lis = bus.GetSINHVIENRAs();
            dataGridView1.DataSource = lis;
        }

        private void butback_Click(object sender, EventArgs e)
        {
            frmMENU m = new frmMENU();
            m.Show();
            this.Hide();
        }
    }
}
