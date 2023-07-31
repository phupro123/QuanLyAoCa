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
    public class BUS_ChoAn
    {
        DAL_ChoAn dalChoAn = new DAL_ChoAn();
        public DataTable HienThiDSChoAnUser(ref int flag)
        {
            return dalChoAn.HienThiDSChoAnUser(ref flag);
        }
        public DataTable HienThiDSChoAnAdmin(ref int flag, int MaLua)
        {
            return dalChoAn.HienThiDSChoAnAdmin(ref flag, MaLua);
        }
        public int ThemChoAn(DTO_ChoAn qlChoAn)
        {
            return dalChoAn.ThemChoAn(qlChoAn);
        }
        public int SuaChoAn(DTO_ChoAn qlChoAn)
        {
            return dalChoAn.SuaChoAn(qlChoAn);
        }
        public int XoaChoAn(int MaLua, int MaThucAn, DateTime ThoiGian)
        {
            return dalChoAn.XoaChoAn(MaLua, MaThucAn, ThoiGian);
        }
    }
}
