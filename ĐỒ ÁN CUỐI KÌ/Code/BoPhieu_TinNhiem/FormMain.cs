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

using BoPhieu_TinNhiem.NguoiDung;

namespace BoPhieu_TinNhiem
{
    public partial class FormMain : Form
    {
        NguoiDungGD dn;
        public FormMain()
        {
            InitializeComponent();
        }

        private void checkHienThiPass_CheckedChanged(object sender, EventArgs e)
        {
            if (checkHienThiPass.Checked)
            {
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        //Đăng nhập người dùng:
        private void Login_Click(object sender, EventArgs e)
        {
            try
            {
                BoPhieu_BUS.dangNhapTaiKhoan(txtUserName.Text, txtPassword.Text);
                if (true)
                {
                    this.Hide();
                    dn = new NguoiDungGD();
                    dn.Show();
                }
                else
                {
                    //Đăng nhập thất bai.
                    //MessageBox.Show("Fail!!!");
                    labInCorrect.Text = "Invalid Username or Password. Please enter again!";
                    txtPassword.Text = "";
                    txtPassword.Text = "";
                    txtUserName.Focus();
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {
            if (txtUserName.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tên đăng nhập!");
                txtUserName.Focus();
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập mật khẩu!");
                txtPassword.Focus();
            }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
