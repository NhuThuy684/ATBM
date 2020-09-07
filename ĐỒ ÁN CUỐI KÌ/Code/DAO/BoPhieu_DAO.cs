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
    public class oracleconnectionData
    {
        public static OracleConnection hamKetNoi()
        {
            OracleConnection cnn = new OracleConnection("DATA SOURCE=localhost:1521/QLOracle;USER ID=QLBBTN;Password=123456;");
            return cnn;
        }
    }

    public class dangNhap_DAO
    {
        public static void dangNhapTaiKhoan(string @taiKhoan, string @passWord)
        {
            OracleConnection cnn = oracleconnectionData.hamKetNoi();
            cnn.Open();
            string query = "SELECT* FROM THANHVIEN WHERE MA_THANHVIEN= @TaiKhoan AND MA_THANHVIEN=@MatKhau;";
            OracleCommand cmd = new OracleCommand(query, cnn);

            cmd.Parameters.Add("@TaiKhoan", OracleDbType.NVarchar2, 8);
            cmd.Parameters.Add("@MatKhau", OracleDbType.NVarchar2, 8);
            //Gán giá trị:
            cmd.Parameters["@TaiKhoan"].Value = @taiKhoan;
            cmd.Parameters["@MatKhau"].Value = @passWord;
            OracleDataReader dta = cmd.ExecuteReader();
            cnn.Close();
        }

    }

    public class Admin_DAO
        {
        //Load danh sách tên User:
        public static DataTable load_DSUser()
        {
            OracleConnection cnn = oracleconnectionData.hamKetNoi();
            cnn.Open();
            string oracle = "select  username from DBA_USERS where account_status = 'OPEN'";
            OracleCommand cmd = new OracleCommand(oracle, cnn);
            cmd.ExecuteReader();
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            DataTable dtb = new DataTable();
            da.Fill(dtb);
            return dtb;
            cnn.Close();
        }

        //Load danh sách các tên Role:
        public static DataTable load_DSRole()
            {
                OracleConnection cnn = oracleconnectionData.hamKetNoi();
                cnn.Open();
                string oracle = "select  role from  DBA_ROLES  where  common = 'YES'";
                OracleCommand cmd = new OracleCommand(oracle, cnn);
                cmd.ExecuteReader();
                OracleDataAdapter da = new OracleDataAdapter(cmd);
                DataTable dtb = new DataTable();
                da.Fill(dtb);
                return dtb;
                cnn.Close();
            }

        //Load danh sách tất cả các tên Table:
        public static DataTable load_DSTable()
        {
            OracleConnection cnn = oracleconnectionData.hamKetNoi();
            cnn.Open();
            string oracle = "select  table_name  from all_tables  where  owner = 'SYS'";
            OracleCommand cmd = new OracleCommand(oracle, cnn);
            cmd.ExecuteReader();
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            DataTable dtb = new DataTable();
            da.Fill(dtb);
            return dtb;
            cnn.Close();
        }

        //Xem danh sách tất cả các tên User và quyền của chúng:
        public static DataTable load_DSQuyenKetNoi()
        {
            OracleConnection cnn = oracleconnectionData.hamKetNoi();
            cnn.Open();
            string oracle = "select grantee, table_name, privilege from USER_TAB_PRIVS where  owner = 'SYS'";
            OracleCommand cmd = new OracleCommand(oracle, cnn);
            cmd.ExecuteReader();
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            DataTable dtb = new DataTable();
            da.Fill(dtb);
            return dtb;
            cnn.Close();
        }
        //Xem danh sách các quyền theo một đối tượng cụ thể:
        public static DataTable load_DSQuyen_MotDT(string tenGT)
        {
            OracleConnection cnn = oracleconnectionData.hamKetNoi();
            cnn.Open();
            string oracle = "select grantee, table_name, privilege from USER_TAB_PRIVS where grantee='" + tenGT + "'";
            OracleCommand cmd = new OracleCommand(oracle, cnn);
            cmd.ExecuteReader();
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            DataTable dtb = new DataTable();
            da.Fill(dtb);
            return dtb;
            cnn.Close();
        }
        //Thêm user hoặc role:
        public static void them_User(string userName, string pass)
        {
            OracleConnection cnn = oracleconnectionData.hamKetNoi();
            string oracle = "CREATE USER " + userName + " IDENTIFIED BY " + pass + "";
            OracleCommand cmd = new OracleCommand(oracle, cnn);
            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        public static void them_Role(string tenRole)
        {
            OracleConnection cnn = oracleconnectionData.hamKetNoi();
            string oracle = "CREATE ROLE " + tenRole + "";
            OracleCommand cmd = new OracleCommand(oracle, cnn);
            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }


        //Cấp và thu lại quyền:
        public static void cap_Quyen(string type, string table, string user)
        {
            OracleConnection cnn = oracleconnectionData.hamKetNoi();
            string oracle = "GRANT " + type + " ON " + table + " TO " + user + "";
            OracleCommand cmd = new OracleCommand(oracle, cnn);
            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        public static void thu_Quyen(string type, string table, string user)
        {
            OracleConnection cnn = oracleconnectionData.hamKetNoi();
            string oracle = "REVOKE " + type + " ON " + table + " FROM " + user + "";
            OracleCommand cmd = new OracleCommand(oracle, cnn);
            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        //Xem lịch sử Audit:
        public static DataTable xem_Audit(string ten_audit)
        {
            OracleConnection cnn = oracleconnectionData.hamKetNoi();
            cnn.Open();
            string oracle = "SELECT username, extended_timestamp, obj_name, action_name FROM dba_audit_trail where obj_name= '" + ten_audit + "'";
            OracleCommand cmd = new OracleCommand(oracle, cnn);
            cmd.ExecuteReader();
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            DataTable dtb = new DataTable();
            da.Fill(dtb);
            return dtb;
            cnn.Close();
        }

        //Mã hóa:
        public static DataTable xem_MaHoa()
        {
            OracleConnection cnn = oracleconnectionData.hamKetNoi();
            cnn.Open();
            string oracle = "select from THANHVIEN";
            OracleCommand cmd = new OracleCommand(oracle, cnn);
            
            //cmd.Parameters.Add("@tenBang", OracleDbType.Varchar2);
            //cmd.Parameters["@tenBang"].Value = tenTable;
            cmd.ExecuteReader();
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            DataTable dtb = new DataTable();
            da.Fill(dtb);
            return dtb;
            cnn.Close();
        }
    }

 
    
}
