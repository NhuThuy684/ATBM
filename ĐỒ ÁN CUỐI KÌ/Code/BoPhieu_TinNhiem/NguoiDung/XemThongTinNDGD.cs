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
namespace BoPhieu_TinNhiem.NguoiDung
{
    public partial class XemThongTinNDGD : Form
    {
        public XemThongTinNDGD()
        {
            InitializeComponent();
        }

        private void button_XemND_Click(object sender, EventArgs e)
        {
            if ((txt_UserName.Text.ToString() != "") && (txt_Pass.Text.ToString() != ""))
            {
                dgv_XemTTND.DataSource = NguoiDung_BUS.xem_ThongTinTV(txt_UserName.Text.ToString(), txt_Pass.Text.ToString());
            }
            else
            {
                MessageBox.Show("Bạn chưa nhập Username/ Password. Vui lòng kiểm tra lại!");
            }
        }

        private void button_QuayVe_Click(object sender, EventArgs e)
        {
            NguoiDungGD ND = new NguoiDungGD();
            ND.Show();
            this.Hide();
        }
    }
}
