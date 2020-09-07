using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using BoPhieu_TinNhiem.NguoiDung;
using BoPhieu_TinNhiem.QuanTriVien;

namespace BoPhieu_TinNhiem
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new QuanTriVienGD());
            //Application.Run(new NguoiDungGD());
        }
    }
}
