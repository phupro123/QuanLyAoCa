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
    public class BUS_ChiTietChuaBenh
    {
        DAL_ChiTietChuaBenh dalKho = new DAL_ChiTietChuaBenh();

        public DataTable DSChiTietCachChua(ref int flag, int Ma)
        {
            return dalKho.DSChiTietCachChua(ref flag, Ma);
        }

        public int ThemChiTietCachChua(DTO_ChiTietCachChua qlLoai)
        {
            return dalKho.ThemChiTietCachChua(qlLoai);
        }

        public int SuaChiTietCachChua(DTO_ChiTietCachChua qlLoai)
        {
            return dalKho.SuaChiTietCachChua(qlLoai);
        }

        public int XoaChiTietCachChua(int MaMacbenh, int MaThuoc)
        {
            return dalKho.XoaChiTietCachChua(MaMacbenh, MaThuoc);
        }
    }
}
