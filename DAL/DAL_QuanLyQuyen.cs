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
    public class DAL_QuanLyQuyen: DBConnect
    {
        DBConnect con = new DBConnect();
        public DataTable HienThiDSQuyen(ref int flag, string name)
        {
            return con.getdatatable(ref flag, "SELECT * FROM LayPhanQuyen_Admin('" + name + "')");
        }
        public DataTable HienThiQuyen(ref int flag)
        {
            return con.getdatatable(ref flag, "SELECT * FROM QUYEN");
        }
        public int ThemPhanQuyen(DTO_QuanLyQuyen qlQuyen)
        {
            int so_Luong = 2;
            string sql = "sp_ThemPhanQuyen";
            string[] Name = new string[so_Luong];
            object[] Values = new object[so_Luong];

            Name[0] = "@TaiKhoan"; Values[0] = qlQuyen.TaiKhoan;
            Name[1] = "@MaQuyen"; Values[1] = qlQuyen.MaQuyen;

            return con.Excute(sql, Name, Values, so_Luong);
        }
        public int XoaPhanQuyen(string TaiKhoan, string MaQuyen)
        {
            int so_Luong = 2;
            string sql = "sp_XoaPhanQuyen";
            string[] Name = new string[so_Luong];
            object[] Values = new object[so_Luong];

            Name[0] = "@TaiKhoan"; Values[0] = TaiKhoan;
            Name[1] = "@MaQuyen"; Values[1] = MaQuyen;

            return con.Excute(sql, Name, Values, so_Luong);
        }
    }
}
