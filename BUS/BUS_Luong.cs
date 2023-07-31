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
    public class BUS_Luong
    {
        DAL_Luong dalLuong = new DAL_Luong();
        public DataTable HienThiDSLuongUser(ref int flag)
        {
            return dalLuong.HienThiDSLuongUser(ref flag);
        }
        public DataTable HienThiDSLuongAdmin(ref int flag, string name)
        {
            return dalLuong.HienThiDSLuongAdmin(ref flag, name);
        }
        public int ThemLuong(DTO_Luong qlLuong)
        {
            return dalLuong.ThemLuong(qlLuong);
        }
        public int SuaLuong(DTO_Luong qlLuong)
        {
            return dalLuong.SuaLuong(qlLuong);
        }
        public int XoaLuong(string TaiKhoan, DateTime NgTraLuong)
        {
            return dalLuong.XoaLuong(TaiKhoan, NgTraLuong);
        }
    }
}
