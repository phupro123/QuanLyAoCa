using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace DAL
{
    public class DBConnect
    {
        protected SqlConnection _conn = null;
        public static string server = "";
        public static string user= "";
        public static string pass = "";
        public SqlCommand cmd;
        public SqlDataAdapter da;
        public DBConnect()
        {
            _conn = new SqlConnection("Server=" + server + ";Database=QLBE;User ID="
                + user + ";Password=" + pass + ";");
            _conn.Close();
        }
        public int Connection()
        {
            int r = -1;
            try
            {
                _conn.Open();
                if (_conn.State == ConnectionState.Open)
                {
                    _conn.Close();
                }
                r = 1;
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Sai mật khẩu!\nError: " + ex.Message.ToString(), 
                    "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            _conn.Close();
            return r;
        }
        public static bool TryConnection()
        {
            return true;
        }
        public DataTable getdatatable(ref int flag, string sql)
        {
            flag = 1;
            DataTable table = new DataTable();
            try
            {
                cmd = new SqlCommand(sql, _conn);
                cmd.CommandType = CommandType.Text;
                da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                da.Fill(table);
            }
            catch (Exception ex)
            {
                flag = -1;
                MessageBox.Show("Lỗi thực thi hoặc bạn không có quyền thực hiện điều này!\nError: "
                    + ex.Message, "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return table;
        }
        public int Excute(string sql, string[] Name, object[] Values, int so_Luong)
        {
            int r = -1;
            try
            {
                cmd = new SqlCommand(sql, _conn);
                cmd.CommandType = CommandType.StoredProcedure;
                if (_conn.State == ConnectionState.Closed)
                {
                    _conn.Open();
                }
                for (int i = 0; i < so_Luong; i++)
                {
                    cmd.Parameters.AddWithValue(Name[i], Values[i]);
                }
                r = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thực thi hoặc bạn không có quyền thực hiện điều này!\nError: " 
                    + ex.Message, "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return r;
        }
    }
}
