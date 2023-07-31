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
    public class DAL_QuanLyBenh: DBConnect
    {
        DBConnect con = new DBConnect();
        public DataTable HienThiDSBenh(ref int flag)
        {
            return con.getdatatable(ref flag, "SELECT * FROM LayBenh()");
        }
        public DataTable HienThiDSMacBenhUser(ref int flag)
        {
            return con.getdatatable(ref flag, "SELECT * FROM LayMacBenh_User()");
        }
        public DataTable HienThiDSMacBenhAdmin(ref int flag, DateTime? NgayBD, DateTime? NgayKT)
        {
            String temp = "(" + (NgayBD == null ? "null" : "'" + NgayBD.Value.ToString("yyyy-MM-dd") + "'") + ",";
            temp += (NgayKT == null ? "null" : "'" + NgayKT.Value.ToString("yyyy-MM-dd") + "'") + ")";
            return con.getdatatable(ref flag, "SELECT * FROM LayMacBenh_Admin" + temp);
        }
        public int ThemBenh(DTO_QuanLyBenh qlBenh)
        {
            int so_Luong = 3;
            string sql = "sp_ThemBenh";
            string[] Name = new string[so_Luong];
            object[] Values = new object[so_Luong];

            Name[0] = "@TenBenh"; Values[0] = qlBenh.TenBenh;
            Name[1] = "@TacNhan"; Values[1] = qlBenh.TacNhan;
            Name[2] = "@DauHieu"; Values[2] = qlBenh.DauHieu;

            return con.Excute(sql, Name, Values, so_Luong);
        }
        public int SuaBenh(DTO_QuanLyBenh qlBenh)
        {
            int so_Luong = 4;
            string sql = "sp_SuaBenh";
            string[] Name = new string[so_Luong];
            object[] Values = new object[so_Luong];

            Name[0] = "@MaBenh"; Values[0] = qlBenh.MaBenh;
            Name[1] = "@TenBenh"; Values[1] = qlBenh.TenBenh;
            Name[2] = "@TacNhan"; Values[2] = qlBenh.TacNhan;
            Name[3] = "@DauHieu"; Values[3] = qlBenh.DauHieu;

            return con.Excute(sql, Name, Values, so_Luong);
        }
        public int XoaBenh(int MaBenh)
        {
            int so_Luong = 1;
            string sql = "sp_XoaBenh";
            string[] Name = new string[so_Luong];
            object[] Values = new object[so_Luong];

            Name[0] = "@MaBenh"; Values[0] = MaBenh;

            return con.Excute(sql, Name, Values, so_Luong);
        }

        public int ThemMacBenh(DTO_QuanLyBenh qlBenh)
        {
            int so_Luong = 5;
            string sql = "sp_ThemMacBenh";
            string[] Name = new string[so_Luong];
            object[] Values = new object[so_Luong];

            Name[0] = "@MaBenh"; Values[0] = qlBenh.MaBenh;
            Name[1] = "@MaLua"; Values[1] = qlBenh.MaLua;
            Name[2] = "@NgPhatHien"; Values[2] = qlBenh.NgPhatHien;
            if (DateTime.Compare(qlBenh.NgChuaKhoi, DateTime.Parse("01/01/2000")) == 0)
            {
                Name[3] = "@NgChuaKhoi"; Values[3] = DBNull.Value;
            }
            else
            {
                Name[3] = "@NgChuaKhoi"; Values[3] = qlBenh.NgChuaKhoi;
            }
            Name[4] = "@GhiChu"; Values[4] = qlBenh.GhiChu;

            return con.Excute(sql, Name, Values, so_Luong);
        }
        public int SuaMacBenh(DTO_QuanLyBenh qlBenh)
        {
            int so_Luong = 6;
            string sql = "sp_SuaMacBenh";
            string[] Name = new string[so_Luong];
            object[] Values = new object[so_Luong];

            Name[0] = "@MaMacBenh"; Values[0] = qlBenh.MaMacBenh;
            Name[1] = "@MaBenh"; Values[1] = qlBenh.MaBenh;
            Name[2] = "@MaLua"; Values[2] = qlBenh.MaLua;
            Name[3] = "@NgPhatHien"; Values[3] = qlBenh.NgPhatHien;
            if (DateTime.Compare(qlBenh.NgChuaKhoi, DateTime.Parse("01/01/2000")) == 0)
            {
                Name[4] = "@NgChuaKhoi"; Values[4] = DBNull.Value;
            }
            else
            {
                Name[4] = "@NgChuaKhoi"; Values[4] = qlBenh.NgChuaKhoi;
            }
            Name[5] = "@GhiChu"; Values[5] = qlBenh.GhiChu;

            return con.Excute(sql, Name, Values, so_Luong);
        }
        public int XoaMacBenh(int MaMacBenh)
        {
            int so_Luong = 1;
            string sql = "sp_XoaMacBenh";
            string[] Name = new string[so_Luong];
            object[] Values = new object[so_Luong];

            Name[0] = "@MaMacBenh"; Values[0] = MaMacBenh;

            return con.Excute(sql, Name, Values, so_Luong);
        }
    }
}
