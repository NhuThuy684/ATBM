using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Oracle.DataAccess.Client;
using DTO;

namespace DAO
{
    public class connectionData
    {
        public static OracleConnection Connect(string user, string password)
        {
            Console.WriteLine("Getting Connection ...");

            // 'Connection String' kết nối trực tiếp tới Oracle.
            string connString = "DATA SOURCE=localhost:1521/QLOracle;PERSIST SECURITY INFO=True;Password=" + password + ";User ID=" + user;
            OracleConnection conn = new OracleConnection();
            conn.ConnectionString = connString;

            return conn;
        }
    }

    public class NguoiDung_DAO
    {
        //Chạy VPD:
        public static DataTable xem_ThongTinTV(string user, string password)
        {
            OracleConnection cnn = connectionData.Connect(user, password);
            cnn.Open();
            string oracle = "SELECT* FROM QLBBTN.THANHVIEN";
            OracleCommand cmd = new OracleCommand(oracle, cnn);
            cmd.ExecuteReader();
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            DataTable dtb = new DataTable();
            da.Fill(dtb);
            return dtb;
            cnn.Close();
        }

        //Chạy mã hóa nơi công tác:
        public static DataTable xem_CongTac_MaHoa(string user, string password)
        {
            OracleConnection cnn = connectionData.Connect(user, password);
            cnn.Open();
            string oracle = "SELECT MA_THANHVIEN, HOTEN, CONGTAC FROM QLBBTN.THANHVIEN";
            OracleCommand cmd = new OracleCommand(oracle, cnn);
            cmd.ExecuteReader();
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            DataTable dtb = new DataTable();
            da.Fill(dtb);
            return dtb;
            cnn.Close();
        }

        public static DataTable xem_CongTac_GiaiMa(string user, string password)
        {
            OracleConnection cnn = connectionData.Connect(user, password);
            cnn.Open();
            string oracle = "SELECT* FROM QLBBTN.view_nhanviengiaima";
            OracleCommand cmd = new OracleCommand(oracle, cnn);
            cmd.ExecuteReader();
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            DataTable dtb = new DataTable();
            da.Fill(dtb);
            return dtb;
            cnn.Close();
        }
    }
}
