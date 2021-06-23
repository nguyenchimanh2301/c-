using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QUANLIKTX;
using BUSKTX.BUSQLKT;
using DAOKTX;
using QUANLIKTX.VIEW;

namespace QUANLIKTX.VIEW
{
    public partial class frmSINHVIENVAO : Form
    {
        public frmSINHVIENVAO()
        {
            InitializeComponent();
        }
        BUSSVvao bus = new BUSSVvao();
        List<SINHVIENVAO> l;
        private void label5_Click(object sender, EventArgs e)
        {

        }
        private void frmSINHVIENVAO_Load(object sender, EventArgs e)
        {
            l = bus.GetSINHVIENVAOs();
            dataGridView1.DataSource = l;
        }

        private void butsvr_Click(object sender, EventArgs e)
        {
            frmSINHVIENRA s = new frmSINHVIENRA();
            s.Show();
            this.Hide();
        }

        private void buthd_Click(object sender, EventArgs e)
        {
            HOADONSV h = new HOADONSV();
            h.Show();
            this.Hide();
        }

        private void butback_Click(object sender, EventArgs e)
        {
            frmMENU m = new frmMENU();
            m.Show();
            this.Hide();
        }

        private void butthem_Click(object sender, EventArgs e)
        {
            SINHVIENVAO s = new SINHVIENVAO();
            s.masv = txtmsv.Text;
            s.malop = txtmalop.Text;
            s.hoten = texthoten.Text;
            s.gioitinh = textgioitinh.Text;
            s.ngaysinh = dateTimePicker1.Value;
            s.diachi = textdc.Text;
            s.sdt = txtsdt.Text;
            s.ngaydangki = dateTimePicker2.Value;
            l.Add(s);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = l;  
        }

        private void butxoa_Click(object sender, EventArgs e)
        {
            bus.delete(txtmsv.Text);
            l.Remove(l.Find(u => u.masv.Trim() == txtmsv.Text));
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = l;
        }

        private void buttim_Click(object sender, EventArgs e)
        {
            List<SINHVIENVAO> s = new List<SINHVIENVAO>();
            SINHVIENVAO ss = l.Find(u => u.masv.Trim() == txtmsv.Text);
            s.Add(ss);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = s;
        }
    }
}
