using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    class BoPhieu_DTO
    {
        public class CHINHANH_DTO
        {
            private string maChiNhanh;
            private string tenChiNhanh;

            public string MaChiNhanh { get => maChiNhanh; set => maChiNhanh = value; }
            public string TenChiNhanh { get => tenChiNhanh; set => tenChiNhanh = value; }
        }

        public class THANHVIEN_DTO
        {
            private string maThanhVien;
            private string hoTen;
            private string gioiTinh;
            private string queQuan;
            private int namSinh;
            private string quocTich;
            private string DC_thuongTru;
            private string DC_tamTru;
            private string donVi;
            private string chiNhanh;
            private string congTac;
            private string tamNghi;
            private string Luong;

            public string MaThanhVien { get => maThanhVien; set => maThanhVien = value; }
            public string HoTen { get => hoTen; set => hoTen = value; }
            public string GioiTinh { get => gioiTinh; set => gioiTinh = value; }
            public string QueQuan { get => queQuan; set => queQuan = value; }
            public int NamSinh { get => namSinh; set => namSinh = value; }
            public string QuocTich { get => quocTich; set => quocTich = value; }
            public string DC_thuongTru1 { get => DC_thuongTru; set => DC_thuongTru = value; }
            public string DC_tamTru1 { get => DC_tamTru; set => DC_tamTru = value; }
            public string DonVi { get => donVi; set => donVi = value; }
            public string ChiNhanh { get => chiNhanh; set => chiNhanh = value; }
            public string CongTac { get => congTac; set => congTac = value; }
            public string TamNghi { get => tamNghi; set => tamNghi = value; }
            public string Luong1 { get => Luong; set => Luong = value; }
        }

        public class DONVI_DTO
        {
            private string ma_DonVi;
            private string ten_DonVi;
            private string truongDonVi;

            public string Ma_DonVi { get => ma_DonVi; set => ma_DonVi = value; }
            public string Ten_DonVi { get => ten_DonVi; set => ten_DonVi = value; }
            public string TruongDonVi { get => truongDonVi; set => truongDonVi = value; }
        }

        public class BTC_DTO
        {
            private string ID_BTC;
            private string hoTen;
            private int namSinh;
            private string gioiTinh;

            public string ID_BTC1 { get => ID_BTC; set => ID_BTC = value; }
            public string HoTen { get => hoTen; set => hoTen = value; }
            public int NamSinh { get => namSinh; set => namSinh = value; }
            public string GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        }

        public class PHIEUBAU_DTO
        {
            private string ma_ThanhVien;
            private string UCV1;
            private string UCV2;
            private string UCV3;

            public string Ma_ThanhVien { get => ma_ThanhVien; set => ma_ThanhVien = value; }
            public string UCV11 { get => UCV1; set => UCV1 = value; }
            public string UCV21 { get => UCV2; set => UCV2 = value; }
            public string UCV31 { get => UCV3; set => UCV3 = value; }
        }

        public class TOLAP_DTO
        {
            private string ID_ToLap;
            private string hoTen;
            private int namSinh;
            private string gioiTinh;
            private string donVi;

            public string ID_ToLap1 { get => ID_ToLap; set => ID_ToLap = value; }
            public string HoTen { get => hoTen; set => hoTen = value; }
            public int NamSinh { get => namSinh; set => namSinh = value; }
            public string GioiTinh { get => gioiTinh; set => gioiTinh = value; }
            public string DonVi { get => donVi; set => donVi = value; }
        }

        public class GIAMSAT_DTO
        {
            private string ID_GiamSat;
            private string hoTen;
            private int namSinh;
            private string gioiTinh;

            public string ID_GiamSat1 { get => ID_GiamSat; set => ID_GiamSat = value; }
            public string HoTen { get => hoTen; set => hoTen = value; }
            public int NamSinh { get => namSinh; set => namSinh = value; }
            public string GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        }

        public class THONGBAO_DTO
        {
            private string noiDung;
            private string loaiTB;
            private string column_OLS;

            public string NoiDung { get => noiDung; set => noiDung = value; }
            public string LoaiTB { get => loaiTB; set => loaiTB = value; }
            public string Column_OLS { get => column_OLS; set => column_OLS = value; }
        }

        public class THEODOI_DTO
        {
            private string ID_TheoDoi;
            private string hoTen;
            private int namSinh;
            private string gioiTinh;

            public string ID_TheoDoi1 { get => ID_TheoDoi; set => ID_TheoDoi = value; }
            public string HoTen { get => hoTen; set => hoTen = value; }
            public int NamSinh { get => namSinh; set => namSinh = value; }
            public string GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        }

        public class UNGCUVIEN_DTO
        {
            private string ma_UCV;
            private string hoTen;
            private int namSinh;
            private string chucVu;
            private string khoa;

            public string Ma_UCV { get => ma_UCV; set => ma_UCV = value; }
            public string HoTen { get => hoTen; set => hoTen = value; }
            public int NamSinh { get => namSinh; set => namSinh = value; }
            public string ChucVu { get => chucVu; set => chucVu = value; }
            public string Khoa { get => khoa; set => khoa = value; }
        }
    }
}
