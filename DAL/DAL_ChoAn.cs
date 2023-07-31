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
    public class DAL_ChoAn: DBConnect
    {
        DBConnect con = new DBConnect();
        public DataTable HienThiDSChoAnUser(ref int flag)
        {
            return con.getdatatable(ref flag, "SELECT * FROM LayChoAn_User()");
        }
        public DataTable HienThiDSChoAnAdmin(ref int flag, int MaLua)
        {
            return con.getdatatable(ref flag, "SELECT * FROM LayChoAn_Admin(" + (MaLua == 0 ? "null" : MaLua.ToString()) +")");
        }
        public int ThemChoAn(DTO_ChoAn qlChoAn)
        {
            int so_Luong = 4;
            string sql = "sp_ThemChoAn";
            string[] Name = new string[so_Luong];
            object[] Values = new object[so_Luong];

            Name[0] = "@MaLua"; Values[0] = qlChoAn.MaLua;
            Name[1] = "@MaThucAn"; Values[1] = qlChoAn.MaThucAn;
            Name[2] = "@ThoiGian"; Values[2] = qlChoAn.ThoiGian;
            Name[3] = "@SL"; Values[3] = qlChoAn.SL;

            return con.Excute(sql, Name, Values, so_Luong);
        }
        public int SuaChoAn(DTO_ChoAn qlChoAn)
        {
            int so_Luong = 4;
            string sql = "sp_SuaChoAn";
            string[] Name = new string[so_Luong];
            object[] Values = new object[so_Luong];

            Name[0] = "@MaLua"; Values[0] = qlChoAn.MaLua;
            Name[1] = "@MaThucAn"; Values[1] = qlChoAn.MaThucAn;
            Name[2] = "@ThoiGian"; Values[2] = qlChoAn.ThoiGian;
            Name[3] = "@SL"; Values[3] = qlChoAn.SL;    

            return con.Excute(sql, Name, Values, so_Luong);
        }
        public int XoaChoAn(int MaLua, int MaThucAn, DateTime ThoiGian)
        {
            int so_Luong = 3;
            string sql = "sp_XoaChoAn";
            string[] Name = new string[so_Luong];
            object[] Values = new object[so_Luong];

            Name[0] = "@MaLua"; Values[0] = MaLua;
            Name[1] = "@MaThucAn"; Values[1] = MaThucAn;
            Name[2] = "@ThoiGian"; Values[2] = ThoiGian;

            return con.Excute(sql, Name, Values, so_Luong);
        }
    }
}
