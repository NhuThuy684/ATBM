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
    public partial class MaHoaGD : Form
    {
        public MaHoaGD()
        {
            InitializeComponent();
        }

        private void button_MaHoa_Click(object sender, EventArgs e)
        {
            if((txt_UserName.Text.ToString()!="")&&(txt_Pass.Text.ToString() != ""))
            {
                dgv_XemMaHoa.DataSource = NguoiDung_BUS.xem_CongTac_MaHoa(txt_UserName.Text.ToString(), txt_Pass.Text.ToString());
            }
            else
            {
                MessageBox.Show("Bạn chưa nhập Username/Password. Vui lòng kiểm tra lại");
            }
        }

        private void button_GiaiMa_Click(object sender, EventArgs e)
        {
            if ((txt_UserName.Text.ToString() != "") && (txt_Pass.Text.ToString() != ""))
            {
                dgv_XemGiaiMa.DataSource = NguoiDung_BUS.xem_CongTac_GiaiMa(txt_UserName.Text.ToString(), txt_Pass.Text.ToString());
            }
            else
            {
                MessageBox.Show("Bạn chưa nhập Username/Password. Vui lòng kiểm tra lại");
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
