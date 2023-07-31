using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DTO;

namespace DAL
{
    public class DAL_ThuChi: DBConnect
    {
        DBConnect con = new DBConnect();
        public DataTable HienThiDSThuChi(ref int flag, DateTime? NgayBD = null, DateTime? NgayKT = null)
        {
            String temp = "(" + (NgayBD == null ? "null" : "'" + NgayBD.Value.ToString("yyyy-MM-dd") + "'") + ",";
            temp += (NgayKT == null ? "null" : "'" + NgayKT.Value.ToString("yyyy-MM-dd") + "'") + ")";
            return con.getdatatable(ref flag, "SELECT * FROM LayThuChi" + temp);
        }
    }
}
