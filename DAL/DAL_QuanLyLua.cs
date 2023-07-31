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
    public class DAL_QuanLyLua: DBConnect
    {
        DBConnect con = new DBConnect();
        public DataTable HienThiDSLuaAdmin(ref int flag, DateTime? NgayBD, DateTime? NgayKT)
        {
            String temp = "(" + (NgayBD == null ? "null" : "'" + NgayBD.Value.ToString("yyyy-MM-dd") + "'") + ",";
            temp += (NgayKT == null ? "null" : "'" + NgayKT.Value.ToString("yyyy-MM-dd") + "'") + ")";
            return con.getdatatable(ref flag, "SELECT * FROM LayLua_Admin" + temp);
        }
        public DataTable HienThiDSLuaUser(ref int flag)
        {
            return con.getdatatable(ref flag, "SELECT * FROM LayLua_User()");
        }
        public int ThemLua(DTO_QuanLyLua qlLua)
        {
            int so_Luong = 6;
            string sql = "sp_ThemLua";
            string[] Name = new string[so_Luong];
            object[] Values = new object[so_Luong];

            Name[0] = "@NgayNuoi"; Values[0] = qlLua.NgayNuoi;
            Name[1] = "@SL"; Values[1] = qlLua.SL;
            Name[2] = "@MaBe"; Values[2] = qlLua.MaBe;
            if (DateTime.Compare(qlLua.NgayThu, DateTime.Parse("01/01/2000")) == 0)
            {
                Name[3] = "@NgayThu"; Values[3] = DBNull.Value;
            }
            else
            {
                Name[3] = "@NgayThu"; Values[3] = qlLua.NgayThu;
            }
            if (qlLua.GiaTri == 0)
            {
                Name[4] = "@GiaTri"; Values[4] = DBNull.Value;
            }
            else
            {
                Name[4] = "@GiaTri"; Values[4] = qlLua.GiaTri;
            }
            Name[5] = "@GhiChu"; Values[5] = qlLua.GhiChu;

            return con.Excute(sql, Name, Values, so_Luong);
        }
        public int SuaLua(DTO_QuanLyLua qlLua)
        {
            int so_Luong = 7;
            string sql = "sp_SuaLua";
            string[] Name = new string[so_Luong];
            object[] Values = new object[so_Luong];

            Name[0] = "@MaLua"; Values[0] = qlLua.MaLua;
            Name[1] = "@NgayNuoi"; Values[1] = qlLua.NgayNuoi;
            Name[2] = "@SL"; Values[2] = qlLua.SL;
            Name[3] = "@MaBe"; Values[3] = qlLua.MaBe;
            if (DateTime.Compare(qlLua.NgayThu, DateTime.Parse("01/01/2000")) == 0)
            {
                Name[4] = "@NgayThu"; Values[4] = DBNull.Value;
            }
            else
            {
                Name[4] = "@NgayThu"; Values[4] = qlLua.NgayThu;
            }
            if (qlLua.GiaTri == 0)
            {
                Name[5] = "@GiaTri"; Values[5] = DBNull.Value;
            }
            else
            {
                Name[5] = "@GiaTri"; Values[5] = qlLua.GiaTri;
            }
            Name[6] = "@GhiChu"; Values[6] = qlLua.GhiChu;

            return con.Excute(sql, Name, Values, so_Luong);
        }
        public int XoaLua(int MaLua)
        {
            int so_Luong = 1;
            string sql = "sp_XoaLua";
            string[] Name = new string[so_Luong];
            object[] Values = new object[so_Luong];

            Name[0] = "@MaLua"; Values[0] = MaLua;

            return con.Excute(sql, Name, Values, so_Luong);
        }
    }
}
