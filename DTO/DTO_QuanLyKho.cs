using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_QuanLyKho
    {
        public int MaNhapKho { get; set; }
        public int MaLoai { get; set; }
        public string Ten { get; set; }
        public string Donvi { get; set; }
        public int SLCon { get; set; }
        public string NSX { get; set; }
        public string GhiChu { get; set; }
        public long GiaTri { get; set; }
        public int SLNhap { get; set; }
        public DateTime NgNhap { get; set; }
        public DateTime HSD { get; set; }
    }
}
