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
    public class DAL_QuanLyBe: DBConnect
    {
        DBConnect con = new DBConnect();
        public DataTable HienThiDSBe(ref int flag) 
        {
            return con.getdatatable(ref flag, "SELECT * FROM LayBe()");
        }
        public DataTable HienThiDSMoiTruongUser(ref int flag)
        {
            return con.getdatatable(ref flag, "SELECT * FROM LayChiSoBe_User()");
        }
        public DataTable HienThiDSMoiTruongAdmin(ref int flag, int MaBe)
        {
            return con.getdatatable(ref flag, "SELECT * FROM LayChiSoBe_Admin(" + (MaBe == 0 ? "null": MaBe.ToString()) +")");
        }
        public int ThemBe(DTO_QuanLyBe qlBe)
        {
            int so_Luong = 2;
            string sql = "sp_ThemBe";
            string[] Name = new string[so_Luong];
            object[] Values = new object[so_Luong];

            Name[0] = "@DienTich"; Values[0] = qlBe.DienTich;
            Name[1] = "@DoSau"; Values[1] = qlBe.DoSau;

            return con.Excute(sql, Name, Values, so_Luong);
        }
        public int SuaBe(DTO_QuanLyBe qlBe)
        {
            int so_Luong = 3;
            string sql = "sp_SuaBe";
            string[] Name = new string[so_Luong];
            object[] Values = new object[so_Luong];

            Name[0] = "@MaBe"; Values[0] = qlBe.MaBe;
            Name[1] = "@DienTich"; Values[1] = qlBe.DienTich;
            Name[2] = "@DoSau"; Values[2] = qlBe.DoSau;

            return con.Excute(sql, Name, Values, so_Luong);
        }
        public int XoaBe(int MaBe)
        {
            int so_Luong = 1;
            string sql = "sp_XoaBe";
            string[] Name = new string[so_Luong];
            object[] Values = new object[so_Luong];
            Name[0] = "@MaBe"; Values[0] = MaBe;
            return con.Excute(sql, Name, Values, so_Luong);
        }
        public int ThemMoiTruong(DTO_QuanLyBe qlBe)
        {
            int so_Luong = 7;
            string sql = "sp_ThemMoiTruong";
            string[] Name = new string[so_Luong];
            object[] Values = new object[so_Luong];

            Name[0] = "@MaBe"; Values[0] = qlBe.MaBe;
            Name[1] = "@Ngay"; Values[1] = qlBe.Ngay;
            Name[2] = "@pH"; Values[2] = qlBe.pH;
            Name[3] = "@NH3"; Values[3] = qlBe.NH3;
            Name[4] = "@H2S"; Values[4] = qlBe.H2S;
            Name[5] = "@Oxy"; Values[5] = qlBe.Oxy;
            Name[6] = "@GhiChu"; Values[6] = qlBe.GhiChu;

            return con.Excute(sql, Name, Values, so_Luong);
        }
        public int SuaMoiTruong(DTO_QuanLyBe qlBe)
        {
            int so_Luong = 7;
            string sql = "sp_SuaMoiTruong";
            string[] Name = new string[so_Luong];
            object[] Values = new object[so_Luong];

            Name[0] = "@MaBe"; Values[0] = qlBe.MaBe;
            Name[1] = "@Ngay"; Values[1] = qlBe.Ngay;
            Name[2] = "@pH"; Values[2] = qlBe.pH;
            Name[3] = "@NH3"; Values[3] = qlBe.NH3;
            Name[4] = "@H2S"; Values[4] = qlBe.H2S;
            Name[5] = "@Oxy"; Values[5] = qlBe.Oxy;
            Name[6] = "@GhiChu"; Values[6] = qlBe.GhiChu;
            
            return con.Excute(sql, Name, Values, so_Luong);
            
        }
        public int XoaMoiTruong(int MaBe, DateTime Ngay)
        {
            int so_Luong = 2;
            string sql = "sp_XoaMoiTruong";
            string[] Name = new string[so_Luong];
            object[] Values = new object[so_Luong];
            Name[0] = "@MaBe"; Values[0] = MaBe;
            Name[1] = "@Ngay"; Values[1] = Ngay;
            return con.Excute(sql, Name, Values, so_Luong);
        }
    }
}
