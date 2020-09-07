using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAO;
using DTO;


namespace BUS
{
    public class BoPhieu_BUS
    {
        public static void dangNhapTaiKhoan(string @taiKhoan, string @passWord)
        {
            dangNhap_DAO.dangNhapTaiKhoan(@taiKhoan, @passWord);
        }

        public static DataTable load_DSUser()
        {

            return Admin_DAO.load_DSUser();
        }

        public static DataTable load_DSRole()
        {

            return Admin_DAO.load_DSRole();
        }

        public static DataTable load_DSTable()
        {

            return Admin_DAO.load_DSTable();
        }

        //public static DataTable load_DSQuyenKetNoi()
        //{
        //    return Admin_DAO.load_DSQuyenKetNoi();
        //}

        public static DataTable load_DSQuyen_MotDT(string tenGT)
        {
            return Admin_DAO.load_DSQuyen_MotDT(tenGT);
        }

        public static void them_User(string userName, string pass)
        {
              Admin_DAO.them_User(userName, pass);
        }

        public static void them_Role(string tenRole)
        {
            Admin_DAO.them_Role(tenRole);
        }

        public static DataTable xem_Audit(string ten_audit)
        {
            return Admin_DAO.xem_Audit(ten_audit);
        }

        public static void cap_Quyen(string type, string table, string user)
        {
            Admin_DAO.cap_Quyen(type, table, user);
        }

        public static void thu_Quyen(string type, string table, string user)
        {
            Admin_DAO.thu_Quyen(type, table, user);
        }
    }
    //Người dùng:
    public class NguoiDung_BUS
    {
        public static DataTable xem_ThongTinTV(string user, string password)
        {
            return NguoiDung_DAO.xem_ThongTinTV(user, password);
        }

        public static DataTable xem_CongTac_MaHoa(string user, string password)
        {
            return NguoiDung_DAO.xem_CongTac_MaHoa(user, password);       
        }
    
        public static DataTable xem_CongTac_GiaiMa(string user, string password)
        {
            return NguoiDung_DAO.xem_CongTac_GiaiMa(user, password);
        }
    }
}
