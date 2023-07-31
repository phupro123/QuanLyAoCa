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
    public class DAL_Luong: DBConnect
    {
        DBConnect con = new DBConnect();
        public DataTable HienThiDSLuongUser(ref int flag)
        {
            return con.getdatatable(ref flag, "SELECT * FROM LayLuong_User()");
        }
        public DataTable HienThiDSLuongAdmin(ref int flag, string name)
        {
            return con.getdatatable(ref flag, "SELECT * FROM LayLuong_Admin('" + name + "')");
        }
        public int ThemLuong(DTO_Luong qlLuong)
        {
            int so_Luong = 4;
            string sql = "sp_ThemLuong";
            string[] Name = new string[so_Luong];
            object[] Values = new object[so_Luong];

            Name[0] = "@TaiKhoan"; Values[0] = qlLuong.TaiKhoan;
            Name[1] = "@NgTraLuong"; Values[1] = qlLuong.NgTraLuong;
            Name[2] = "@Luong"; Values[2] = qlLuong.Luong;
            Name[3] = "@DanhGia"; Values[3] = qlLuong.DanhGia;

            return con.Excute(sql, Name, Values, so_Luong);
        }
        public int SuaLuong(DTO_Luong qlLuong)
        {
            int so_Luong = 4;
            string sql = "sp_SuaLuong";
            string[] Name = new string[so_Luong];
            object[] Values = new object[so_Luong];

            Name[0] = "@TaiKhoan"; Values[0] = qlLuong.TaiKhoan;
            Name[1] = "@NgTraLuong"; Values[1] = qlLuong.NgTraLuong;
            Name[2] = "@Luong"; Values[2] = qlLuong.Luong;
            Name[3] = "@DanhGia"; Values[3] = qlLuong.DanhGia;

            return con.Excute(sql, Name, Values, so_Luong);
        }
        public int XoaLuong(string TaiKhoan, DateTime NgTraLuong)
        {
            int so_Luong = 2;
            string sql = "sp_XoaLuong";
            string[] Name = new string[so_Luong];
            object[] Values = new object[so_Luong];

            Name[0] = "@TaiKhoan"; Values[0] = TaiKhoan;
            Name[1] = "@NgTraLuong"; Values[1] = NgTraLuong;

            return con.Excute(sql, Name, Values, so_Luong);
        }
    }
}
