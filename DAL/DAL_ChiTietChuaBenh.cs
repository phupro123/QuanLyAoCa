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
    public class DAL_ChiTietChuaBenh : DBConnect
    {
        DBConnect con = new DBConnect();
        public DataTable DSChiTietCachChua(ref int flag, int MaMacBenh)
        {

            return con.getdatatable(ref flag, "SELECT * FROM LayChiTietCachChua(" + MaMacBenh.ToString() + ")");
        }
        public int ThemChiTietCachChua(DTO_ChiTietCachChua qlKho)
        {
            int so_Luong = 3;
            string sql = "sp_ThemChiTietCachChua";
            string[] Name = new string[so_Luong];
            object[] Values = new object[so_Luong];

            Name[0] = "@MaMacBenh"; Values[0] = qlKho.MaMacBenh;
            Name[1] = "@MaThuoc"; Values[1] = qlKho.MaThuoc;
            Name[2] = "@SL"; Values[2] = qlKho.SL;

            return con.Excute(sql, Name, Values, so_Luong);
        }
        public int SuaChiTietCachChua(DTO_ChiTietCachChua qlKho)
        {
            int so_Luong = 3;
            string sql = "sp_SuaChiTietCachChua";
            string[] Name = new string[so_Luong];
            object[] Values = new object[so_Luong];

            Name[0] = "@MaMacBenh"; Values[0] = qlKho.MaMacBenh;
            Name[1] = "@MaThuoc"; Values[1] = qlKho.MaThuoc;
            Name[2] = "@SL"; Values[2] = qlKho.SL;

            return con.Excute(sql, Name, Values, so_Luong);
        }
        public int XoaChiTietCachChua(int MaMacBenh, int MaThuoc)
        {
            int so_Luong = 2;
            string sql = "sp_XoaChiTietCachChua";
            string[] Name = new string[so_Luong];
            object[] Values = new object[so_Luong];

            Name[0] = "@MaMacBenh"; Values[0] = MaMacBenh;
            Name[1] = "@MaThuoc"; Values[1] = MaThuoc;

            return con.Excute(sql, Name, Values, so_Luong);
        }
    }
}
