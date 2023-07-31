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
    public class BUS_ThuChi
    {
        DAL_ThuChi dalPhanQuyen = new DAL_ThuChi();
        public DataTable HienThiDSThuChi(ref int flag, DateTime? start = null, DateTime? end = null)
        {
            return dalPhanQuyen.HienThiDSThuChi(ref flag, start, end);
        }
    }
}
