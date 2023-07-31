using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;
using DTO;

namespace BUS
{
    public class BUS_QuanLyLua
    {
        DAL_QuanLyLua dalLua = new DAL_QuanLyLua();

        public DataTable HienThiDSLuaAdmin(ref int flag, DateTime? NgayBD, DateTime? NgayKT)
        {
            return dalLua.HienThiDSLuaAdmin(ref flag, NgayBD, NgayKT);
        }
        public DataTable HienThiDSLuaUser(ref int flag)
        {
            return dalLua.HienThiDSLuaUser(ref flag);
        }

        public int ThemLua(DTO_QuanLyLua qlLua)
        {
            return dalLua.ThemLua(qlLua);
        }

        public int SuaLua(DTO_QuanLyLua qlLua)
        {
            return dalLua.SuaLua(qlLua);
        }

        public int XoaLua(int MaLua)
        {
            return dalLua.XoaLua(MaLua);
        }
    }
}
