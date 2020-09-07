using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;

using BoPhieu_TinNhiem.QuanTriVien;
namespace BoPhieu_TinNhiem.QuanTriVien
{
    public partial class XemThongTinGD : Form
    {
        public XemThongTinGD()
        {
            InitializeComponent();
        }

        private void button_XemTT_Click(object sender, EventArgs e)
        {
            if (rB_User.Checked == true)
            {
                dgv_XemTT.DataSource = BoPhieu_BUS.load_DSUser();
            }
            if (rB_Role.Checked == true)
            {
                dgv_XemTT.DataSource = BoPhieu_BUS.load_DSRole();
            }
            if (rB_Table.Checked == true)
            {
                dgv_XemTT.DataSource = BoPhieu_BUS.load_DSTable();
            }
        }

        private void button_QuayVe_Click(object sender, EventArgs e)
        {
            QuanTriVienGD audit = new QuanTriVienGD();
            audit.Show();
            this.Hide();
        }
    }
}
