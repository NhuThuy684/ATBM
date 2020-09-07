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

namespace BoPhieu_TinNhiem
{
    public partial class AuditGD : Form
    {
        public AuditGD()
        {
            InitializeComponent();
        }

        private void button_XemAudit_Click(object sender, EventArgs e)
        {
            if (rB_THANHVIEN.Checked == true)
            {
                dgv_Audit.DataSource = BoPhieu_BUS.xem_Audit("THANHVIEN");
            }
            if (rB_CHINHANH.Checked == true)
            {
                dgv_Audit.DataSource = BoPhieu_BUS.xem_Audit("CHINHANH");
            }
            if (rB_DONVI.Checked == true)
            {
                dgv_Audit.DataSource = BoPhieu_BUS.xem_Audit("DONVI");
            }
            if (rB_BTC.Checked == true)
            {
                dgv_Audit.DataSource = BoPhieu_BUS.xem_Audit("BTC");
            }
            if (rB_PHIEUBAU.Checked == true)
            {
                dgv_Audit.DataSource = BoPhieu_BUS.xem_Audit("PHIEUBAU");
            }
            if (rB_GIAMSAT.Checked == true)
            {
                dgv_Audit.DataSource = BoPhieu_BUS.xem_Audit("GIAMSAT");
            }
            if (rB_THEODOI.Checked == true)
            {
                dgv_Audit.DataSource = BoPhieu_BUS.xem_Audit("THEODOI");
            }
            if (rB_THONGBAO.Checked == true)
            {
                dgv_Audit.DataSource = BoPhieu_BUS.xem_Audit("THONGBAO");
            }
            if (rB_TOLAP.Checked == true)
            {
                dgv_Audit.DataSource = BoPhieu_BUS.xem_Audit("TO_LAP");
            }
            if (rB_UCV.Checked == true)
            {
                dgv_Audit.DataSource = BoPhieu_BUS.xem_Audit("UNGCUVIEN");
            }

        }

        private void bt_QuayVe_Click(object sender, EventArgs e)
        {
            QuanTriVienGD audit = new QuanTriVienGD();
            audit.Show();
            this.Hide();
        }
    }
}
