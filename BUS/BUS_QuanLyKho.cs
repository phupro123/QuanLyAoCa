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
    public class BUS_QuanLyKho
    {
        DAL_QuanLyKho dalKho = new DAL_QuanLyKho();

        public DataTable HienThiDSNhapKhoUser(ref int flag)
        {
            return dalKho.HienThiDSNhapKhoUser(ref flag);
        }
        public DataTable HienThiDSNhapKhoAdmin(ref int flag, string tukhoa)
        {
            return dalKho.HienThiDSNhapKhoAdmin(ref flag, tukhoa);
        }

        public int ThemNhapKho(DTO_QuanLyKho qlKho)
        {
            return dalKho.ThemNhapKho(qlKho);
        }

        public int SuaNhapKho(DTO_QuanLyKho qlKho)
        {
            return dalKho.SuaNhapKho(qlKho);
        }

        public int XoaNhapKho(int MaNhapKho)
        {
            return dalKho.XoaNhapKho(MaNhapKho);
        }
    }
}
