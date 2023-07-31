using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_QuanLyNhanVien
    {
        public string TaiKhoan { get; set; }
        public string MatKhau { get; set; }
        public string HoTen { get; set; }
        public DateTime NgSinh { get; set; }
        public string Sdt { get; set; }
        public DateTime NgLam { get; set; }
        public string MoTaCV { get; set; }
        public bool ConLamViec { get; set; }

    }
}
