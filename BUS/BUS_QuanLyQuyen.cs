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
    public class BUS_QuanLyQuyen
    {
        DAL_QuanLyQuyen dalPhanQuyen = new DAL_QuanLyQuyen();
        public DataTable HienThiDSQuyen(ref int flag, string name)
        {
            return dalPhanQuyen.HienThiDSQuyen(ref flag, name);
        }
        public DataTable HienThiQuyen(ref int flag)
        {
            return dalPhanQuyen.HienThiQuyen(ref flag);
        }

        public int ThemPhanQuyen(DTO_QuanLyQuyen qlPhanQuyen)
        {
            return dalPhanQuyen.ThemPhanQuyen(qlPhanQuyen);
        }
        public int XoaPhanQuyen(string TaiKhoan, string MaQuyen)
        {
            return dalPhanQuyen.XoaPhanQuyen(TaiKhoan, MaQuyen);
        }
    }
}
