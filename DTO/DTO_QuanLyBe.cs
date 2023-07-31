using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_QuanLyBe
    {
        public int MaBe { get; set; }
        public int DienTich { get; set; }
        public int DoSau { get; set; }
        public bool TrangThaiDung { get; set; }
        public DateTime Ngay { get; set; }
        public float pH { get; set; }
        public float NH3 { get; set; }
        public float H2S { get; set; }
        public float Oxy { get; set; }
        public string GhiChu { get; set; }
    }
}
