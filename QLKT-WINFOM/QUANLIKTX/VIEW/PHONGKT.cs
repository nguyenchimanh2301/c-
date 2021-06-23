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
    public partial class PHONGKT : Form
    {
        public PHONGKT()
        {
            InitializeComponent();
        }
        BUSphongkt bus = new BUSphongkt();
        List<Phongkt> list;
        private void butchit_Click(object sender, EventArgs e)
        {
            CHITIETPHONG c = new CHITIETPHONG();
            c.Show();
            this.Hide();
        }

        private void PHONGKT_Load(object sender, EventArgs e)
        {
            list = bus.GetPhongkts();
            dataGridView1.DataSource = list;
        }
        private void buthd_Click(object sender, EventArgs e)
        {
            HOADONPHONG h = new HOADONPHONG();
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
            Phongkt p = new Phongkt();
            p.maphong = txtmp.Text;
            p.tenday = textvt.Text;
            p.vitri = textvt.Text;
            p.loaiphong = textlp.Text;
            p.tinhtrang = txttt.Text;
            list.Add(p);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = list;
            bus.save();

        }

        private void butxoa_Click(object sender, EventArgs e)
        {
            bus.delete(txtmp.Text);
            list.Remove(list.Find(s => s.maphong == txtmp.Text));
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = list;
        }

        private void butsua_Click(object sender, EventArgs e)
        {
            Phongkt p = new Phongkt();
            Phongkt pp = list.Find(u => u.maphong.Trim() == txtmp.Text.Trim());
            pp.tenday = texttenday.Text;
            pp.vitri = textvt.Text;
            pp.loaiphong = textlp.Text;
            pp.tinhtrang = txttt.Text;
            list.Remove(list.Find(s => s.maphong.Trim() == txtmp.Text.Trim()));
            list.Add(pp);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = list;
        }
        private void buttim_Click(object sender, EventArgs e)
        {
            List<Phongkt> l = new List<Phongkt>();
            Phongkt p = list.Find(u => u.maphong == txtmp.Text);
            l.Add(p);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = l;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
