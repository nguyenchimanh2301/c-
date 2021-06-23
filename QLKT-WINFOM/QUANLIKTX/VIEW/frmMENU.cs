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

namespace QUANLIKTX.VIEW
{
    public partial class frmMENU : Form
    {
        public frmMENU()
        {
            InitializeComponent();
        }

        private void butphongkt_Click(object sender, EventArgs e)
        {
            this.Hide();
            PHONGKT c = new PHONGKT();
            c.Show();
        }

        private void butsv_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmSINHVIENVAO s = new frmSINHVIENVAO();
            s.Show();
        }

        private void butback_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }
    }
}
