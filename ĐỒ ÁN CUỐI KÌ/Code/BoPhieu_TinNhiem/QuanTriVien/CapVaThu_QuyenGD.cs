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


namespace BoPhieu_TinNhiem.QuanTriVien
{
    public partial class CapVaThu_QuyenGD : Form
    {
        public CapVaThu_QuyenGD()
        {
            InitializeComponent();
        }

        private void bt_PhanQuyen_Click(object sender, EventArgs e)
        {
            if ((txt_Quyen.Text.ToString()!="")&& (txt_DoiTuong.Text.ToString()!="")&&(cb_Bang.Text.ToString()!=""))
            {
                BoPhieu_BUS.cap_Quyen(txt_Quyen.Text.ToString(), cb_Bang.Text.ToString(), txt_DoiTuong.Text.ToString());
                MessageBox.Show("Cấp quyền thành công!", "Thông báo");
            }
            else
            {
                MessageBox.Show("Thông tin bạn nhập chưa đầy đủ. Vui lòng kiểm tra lại!", "Thông báo");
            }
        }

        private void bt_QuayVe_Click(object sender, EventArgs e)
        {
            QuanTriVienGD qtv = new QuanTriVienGD();
            qtv.Show();
            this.Hide();
        }

        private void bt_ThuQuyen_Click(object sender, EventArgs e)
        {
            if ((txt_Quyen.Text.ToString() != "") && (txt_DoiTuong.Text.ToString() != "") && (cb_Bang.Text.ToString() != ""))
            {
                BoPhieu_BUS.thu_Quyen(txt_Quyen.Text.ToString(), cb_Bang.Text.ToString(), txt_DoiTuong.Text.ToString());
                MessageBox.Show("Thu lại quyền thành công!", "Thông báo");
            }
            else
            {
                MessageBox.Show("Thông tin bạn nhập chưa đầy đủ. Vui lòng kiểm tra lại!", "Thông báo");
            }
        }
    }
}
