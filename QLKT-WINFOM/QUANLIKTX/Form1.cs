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

namespace QUANLIKTX
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        BUSlogin lg = new BUSlogin();
        frmMENU menu = new frmMENU();
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void butlogin_Click(object sender, EventArgs e)
        {
            Program.us = lg.GetLogin(txtus.Text, txtpass.Text);
                if (Program.us == null)
                {
                    MessageBox.Show("Tài khoản và mật khẩu không được để trống");
                }
            else
            {
                this.Hide();
                menu.Show();
            }

            }

        private void butexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
    }

