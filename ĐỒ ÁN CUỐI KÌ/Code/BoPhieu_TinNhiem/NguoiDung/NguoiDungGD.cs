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

namespace BoPhieu_TinNhiem.NguoiDung
{
    public partial class NguoiDungGD : Form
    {
        public NguoiDungGD()
        {
            InitializeComponent();
        }

        private void pictureBox_BoPhieu_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox_ThongBao_Click(object sender, EventArgs e)
        {
            
            
        }

        private void pictureBox_XemUCV_Click(object sender, EventArgs e)
        {
            XemThongTinNDGD nd = new XemThongTinNDGD();
            nd.Show();
            this.Hide();
        }

        private void pictureBox_XemBTC_Click(object sender, EventArgs e)
        {
            MaHoaGD MH = new MaHoaGD();
            MH.Show();
            this.Hide();
        }
    }
}
