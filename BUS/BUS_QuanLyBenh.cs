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
    public class BUS_QuanLyBenh
    {
        DAL_QuanLyBenh dalBenh = new DAL_QuanLyBenh();

        public DataTable HienThiDSBenh(ref int flag)
        {
            return dalBenh.HienThiDSBenh(ref flag);
        }
        public DataTable HienThiDSMacBenhUser(ref int flag)
        {
            return dalBenh.HienThiDSMacBenhUser(ref flag);
        }
        public DataTable HienThiDSMacBenhAdmin(ref int flag, DateTime? NgayBD, DateTime? NgayKT)
        {
            return dalBenh.HienThiDSMacBenhAdmin(ref flag, NgayBD, NgayKT);
        }
        public int ThemBenh(DTO_QuanLyBenh qlBenh)
        {
            return dalBenh.ThemBenh(qlBenh);
        }
        public int SuaBenh(DTO_QuanLyBenh qlBenh)
        {
            return dalBenh.SuaBenh(qlBenh);
        }
        public int XoaBenh(int MaBenh)
        {
            return dalBenh.XoaBenh(MaBenh);
        }
        public int ThemMacBenh(DTO_QuanLyBenh qlBenh)
        {
            return dalBenh.ThemMacBenh(qlBenh);
        }
        public int SuaMacBenh(DTO_QuanLyBenh qlBenh)
        {
            return dalBenh.SuaMacBenh(qlBenh);
        }
        public int XoaMacBenh(int MaMacBenh)
        {
            return dalBenh.XoaMacBenh(MaMacBenh);
        }
    }
}
