using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_QuanLyBenh
    {
        public int MaBenh { get; set; }
        public string TenBenh { get; set; }
        public string TacNhan { get; set; }
        public string DauHieu { get; set; }
        public int MaMacBenh { get; set; }
        public int MaLua { get; set; }
        public DateTime NgPhatHien { get; set; }
        public DateTime NgChuaKhoi  { get; set; }
        public string GhiChu { get; set; }
    }
}
