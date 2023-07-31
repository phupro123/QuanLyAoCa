using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DTO;

namespace DAL
{
    public class DAL_QuanLyNhanVien: DBConnect
    {
        DBConnect con = new DBConnect();
        public DataTable HienThiDSNhanVien(ref int flag, string tukhoa)
        {
            return con.getdatatable(ref flag, "SELECT * FROM LayNhanVien('" + tukhoa +"')");
        }
        public int ThemNhanVien(DTO_QuanLyNhanVien qlNhanVien)
        {            
            int so_Luong = 8;
            string sql = "sp_ThemNhanVien";
            string[] Name = new string[so_Luong];
            object[] Values = new object[so_Luong];

            Name[0] = "@TaiKhoan"; Values[0] = qlNhanVien.TaiKhoan;
            Name[1] = "@MatKhau"; Values[1] = qlNhanVien.MatKhau;
            Name[2] = "@HoTen"; Values[2] = qlNhanVien.HoTen;
            Name[3] = "@NgSinh"; Values[3] = qlNhanVien.NgSinh;
            Name[4] = "@Sdt"; Values[4] = qlNhanVien.Sdt;
            Name[5] = "@NgLam"; Values[5] = qlNhanVien.NgLam;
            Name[6] = "@MoTaCV"; Values[6] = qlNhanVien.MoTaCV;
            Name[7] = "@ConLamViec"; Values[7] = qlNhanVien.ConLamViec;

            return con.Excute(sql, Name, Values, so_Luong);
        }
        public int SuaNhanVien(DTO_QuanLyNhanVien qlNhanVien)
        {
            int so_Luong = 8;
            string sql = "sp_SuaNhanVien";
            string[] Name = new string[so_Luong];
            object[] Values = new object[so_Luong];

            Name[0] = "@TaiKhoan"; Values[0] = qlNhanVien.TaiKhoan;
            Name[1] = "@MatKhau"; Values[1] = qlNhanVien.MatKhau;
            Name[2] = "@HoTen"; Values[2] = qlNhanVien.HoTen;
            Name[3] = "@NgSinh"; Values[3] = qlNhanVien.NgSinh;
            Name[4] = "@Sdt"; Values[4] = qlNhanVien.Sdt;
            Name[5] = "@NgLam"; Values[5] = qlNhanVien.NgLam;
            Name[6] = "@MoTaCV"; Values[6] = qlNhanVien.MoTaCV;
            Name[7] = "@ConLamViec"; Values[7] = qlNhanVien.ConLamViec;

            return con.Excute(sql, Name, Values, so_Luong);
        }
        public int XoaNhanVien(string TaiKhoan)
        {
            int so_Luong = 1;
            string sql = "sp_XoaNhanVien";
            string[] Name = new string[so_Luong];
            object[] Values = new object[so_Luong];

            Name[0] = "@TaiKhoan"; Values[0] = TaiKhoan;

            return con.Excute(sql, Name, Values, so_Luong);
        }
    }
}
