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
    public class BUS_QuanLyNhanVien
    {
        DAL_QuanLyNhanVien dalNhanVien = new DAL_QuanLyNhanVien();

        public DataTable HienThiDSNhanVien(ref int flag, string tukhoa)
        {
            return dalNhanVien.HienThiDSNhanVien(ref flag, tukhoa);
        }

        public int ThemNhanVien(DTO_QuanLyNhanVien qlNhanVien)
        {
            return dalNhanVien.ThemNhanVien(qlNhanVien);
        }

        public int SuaNhanVien(DTO_QuanLyNhanVien qlNhanVien)
        {
            return dalNhanVien.SuaNhanVien(qlNhanVien);
        }

        public int XoaNhanVien(string TaiKhoan)
        {
            return dalNhanVien.XoaNhanVien(TaiKhoan);
        }
    }
}
