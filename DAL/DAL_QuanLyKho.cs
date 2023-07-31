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
    public class DAL_QuanLyKho: DBConnect
    {
        DBConnect con = new DBConnect();
        public DataTable HienThiDSNhapKhoUser(ref int flag)
        {
            return con.getdatatable(ref flag, "SELECT * FROM LayKho_User()");
        }
        public DataTable HienThiDSNhapKhoAdmin(ref int flag, string tukhoa)
        {
            return con.getdatatable(ref flag, "SELECT * FROM LayKho_Admin('" +tukhoa+"')");
        }
        public int ThemNhapKho(DTO_QuanLyKho qlKho)
        {
            int so_Luong = 10;
            string sql = "sp_ThemNhapKho";
            string[] Name = new string[so_Luong];
            object[] Values = new object[so_Luong];

            Name[0] = "@MaLoai"; Values[0] = qlKho.MaLoai;
            Name[1] = "@Ten"; Values[1] = qlKho.Ten;
            Name[2] = "@Donvi"; Values[2] = qlKho.Donvi;
            Name[3] = "@SLCon"; Values[3] = qlKho.SLCon;
            Name[4] = "@NSX"; Values[4] = qlKho.NSX;
            Name[5] = "@GhiChu"; Values[5] = qlKho.GhiChu;
            Name[6] = "@GiaTri"; Values[6] = qlKho.GiaTri;
            Name[7] = "@SLNhap"; Values[7] = qlKho.SLNhap;
            Name[8] = "@NgNhap"; Values[8] = qlKho.NgNhap;
            Name[9] = "@HSD"; Values[9] = qlKho.HSD;

            return con.Excute(sql, Name, Values, so_Luong);
        }
        public int SuaNhapKho(DTO_QuanLyKho qlKho)
        {
            int so_Luong = 11;
            string sql = "sp_SuaNhapKho";
            string[] Name = new string[so_Luong];
            object[] Values = new object[so_Luong];

            Name[0] = "@MaNhapKho"; Values[0] = qlKho.MaNhapKho;
            Name[1] = "@MaLoai"; Values[1] = qlKho.MaLoai;
            Name[2] = "@Ten"; Values[2] = qlKho.Ten;
            Name[3] = "@Donvi"; Values[3] = qlKho.Donvi;
            Name[4] = "@SLCon"; Values[4] = qlKho.SLCon;
            Name[5] = "@NSX"; Values[5] = qlKho.NSX;
            Name[6] = "@GhiChu"; Values[6] = qlKho.GhiChu;
            Name[7] = "@GiaTri"; Values[7] = qlKho.GiaTri;
            Name[8] = "@SLNhap"; Values[8] = qlKho.SLNhap;
            Name[9] = "@NgNhap"; Values[9] = qlKho.NgNhap;
            Name[10] = "@HSD"; Values[10] = qlKho.HSD;

            return con.Excute(sql, Name, Values, so_Luong);
        }
        public int XoaNhapKho(int MaNhapKho)
        {
            int so_Luong = 1;
            string sql = "sp_XoaNhapKho";
            string[] Name = new string[so_Luong];
            object[] Values = new object[so_Luong];
            Name[0] = "@MaNhapKho"; Values[0] = MaNhapKho;
            return con.Excute(sql, Name, Values, so_Luong);
        }
    }
}
