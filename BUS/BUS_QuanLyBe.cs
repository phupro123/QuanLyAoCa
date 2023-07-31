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
    public class BUS_QuanLyBe
    {
        DAL_QuanLyBe dalBe = new DAL_QuanLyBe();
        public DataTable HienThiDSBe(ref int flag)
        {
            return dalBe.HienThiDSBe(ref flag);
        }
        public DataTable HienThiDSMoiTruongUser(ref int flag)
        {
            return dalBe.HienThiDSMoiTruongUser(ref flag);
        }
        public DataTable HienThiDSMoiTruongAdmin(ref int flag, int MaBe)
        {
            return dalBe.HienThiDSMoiTruongAdmin(ref flag, MaBe);
        }
        public int ThemBe(DTO_QuanLyBe qlBe)
        {
            return dalBe.ThemBe(qlBe);
        }
        public int SuaBe(DTO_QuanLyBe qlBe)
        {
            return dalBe.SuaBe(qlBe);
        }
        public int XoaBe(int MaBe)
        {
            return dalBe.XoaBe(MaBe);
        }

        public int ThemMoiTruong(DTO_QuanLyBe qlBe)
        {
            return dalBe.ThemMoiTruong(qlBe);
        }
        public int SuaMoiTruong(DTO_QuanLyBe qlBe)
        {
            return dalBe.SuaMoiTruong(qlBe);
        }
        public int XoaMoiTruong(int MaBe, DateTime Ngay)
        {
            return dalBe.XoaMoiTruong(MaBe, Ngay);
        }
    }
}
