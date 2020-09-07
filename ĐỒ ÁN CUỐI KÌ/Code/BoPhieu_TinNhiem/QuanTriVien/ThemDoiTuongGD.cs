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
    public partial class ThemDoiTuongGD : Form
    {
        public ThemDoiTuongGD()
        {
            InitializeComponent();
        }

        private void button_TaoMoi_Click(object sender, EventArgs e)
        {
            if (rB_User.Checked == true)
            {
                if ((txt_TenUser.Text.ToString() != "") && (txt_Password.Text.ToString() != ""))
                {
                    BoPhieu_BUS.them_User(txt_TenUser.Text.ToString(), txt_Password.Text.ToString());
                    MessageBox.Show("User đã thêm thành công!", "Thông báo");
                }
                else
                {
                    MessageBox.Show("Bạn chưa nhập tên user hoặc password !", "Thông báo");
                }
            }

            if (rB_Role.Checked == true)
            {
                if ((txt_tenRole.Text.ToString() != ""))
                {
                    BoPhieu_BUS.them_Role(txt_tenRole.Text.ToString());
                    MessageBox.Show("Role đã thêm thành công!", "Thông báo");
                }
                else
                {
                    MessageBox.Show("Bạn chưa nhập tên role!", "Thông báo");
                }
            }
        }

        private void button_QuayVe_Click(object sender, EventArgs e)
        {
            QuanTriVienGD qtv = new QuanTriVienGD();
            qtv.Show();
            this.Hide();
        }
    }
}
