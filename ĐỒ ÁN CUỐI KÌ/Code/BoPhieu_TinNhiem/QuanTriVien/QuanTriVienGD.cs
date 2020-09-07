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
    
    public partial class QuanTriVienGD : Form
    {
        public QuanTriVienGD()
        {
            InitializeComponent();
        }

        private void button_XemTTND_Click(object sender, EventArgs e)
        {
            XemThongTinGD audit = new XemThongTinGD();
            audit.Show();
            this.Hide();
        }

        private void button_QuyenTruyCap_Click(object sender, EventArgs e)
        {
            CapVaThu_QuyenGD audit = new CapVaThu_QuyenGD();
            audit.Show();
            this.Hide();
        }

        private void button_HieuChinh_Click(object sender, EventArgs e)
        {
            ThemDoiTuongGD add = new ThemDoiTuongGD();
            add.Show();
            this.Hide();

        }

        private void button_Audit_Click(object sender, EventArgs e)
        {
            AuditGD audit = new AuditGD();
            audit.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txt_DoiTuong.Text.ToString() != "")
            {
                dataGridView_KQQTV.DataSource = BoPhieu_BUS.load_DSQuyen_MotDT(txt_DoiTuong.Text.ToString());
            }
            else
            {
                MessageBox.Show("Bạn chưa nhập tên đối tượng. Vui lòng nhập lại!", "Thông báo");
            }
        }

        private void button_MaHoa_Click(object sender, EventArgs e)
        {

        }

    }
}
