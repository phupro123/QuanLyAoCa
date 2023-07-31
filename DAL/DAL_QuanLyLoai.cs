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
    public class DAL_QuanLyLoai: DBConnect
    {
        DBConnect con = new DBConnect();
        public DataTable HienThiDSLoai(ref int flag)
        {
            return con.getdatatable(ref flag, "SELECT * FROM LayLoaiNhapKho()");
        }
        public int ThemLoai(DTO_QuanLyLoai qlKho)
        {
            int so_Luong = 1;
            string sql = "sp_ThemLoaiNhapKho";
            string[] Name = new string[so_Luong];
            object[] Values = new object[so_Luong];

            Name[0] = "@Ten"; Values[0] = qlKho.Ten;

            return con.Excute(sql, Name, Values, so_Luong);
        }
        public int SuaLoai(DTO_QuanLyLoai qlKho)
        {
            int so_Luong = 2;
            string sql = "sp_SuaLoaiNhapKho";
            string[] Name = new string[so_Luong];
            object[] Values = new object[so_Luong];

            Name[0] = "@Ma"; Values[0] = qlKho.Ma;
            Name[1] = "@Ten"; Values[1] = qlKho.Ten;

            return con.Excute(sql, Name, Values, so_Luong);
        }
        public int XoaLoai(int Ma)
        {
            int so_Luong = 1;
            string sql = "sp_XoaLoaiNhapKho";
            string[] Name = new string[so_Luong];
            object[] Values = new object[so_Luong];

            Name[0] = "@Ma"; Values[0] = Ma;

            return con.Excute(sql, Name, Values, so_Luong);
        }
    }
}
