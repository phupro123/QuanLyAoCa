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
    public class BUS_QuanLyLoai
    {
        DAL_QuanLyLoai dalKho = new DAL_QuanLyLoai();

        public DataTable HienThiDSLoai(ref int flag)
        {
            return dalKho.HienThiDSLoai(ref flag);
        }

        public int ThemLoaiNhapKho(DTO_QuanLyLoai qlLoai)
        {
            return dalKho.ThemLoai(qlLoai);
        }

        public int SuaLoaiNhapKho(DTO_QuanLyLoai qlLoai)
        {
            return dalKho.SuaLoai(qlLoai);
        }

        public int XoaLoaiNhapKho(int Ma)
        {
            return dalKho.XoaLoai(Ma);
        }
    }
}
