using BUS;
using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLAoCa
{
    public partial class DoanhThu : Form
    {
        DBConnect con = new DBConnect();
        BUS_ThuChi thuChi = new BUS_ThuChi();
        public DoanhThu()
        {
            InitializeComponent();
            dtStart.Value = Constant.start;
            dtEnd.Value = Constant.end;
            dgvThuChi.Font = new Font("Arial", 12);
        }
     
        private void DoanhThu_Load(object sender, EventArgs e)
        {
            loadData();
        }
        public bool check()
        {
            int flag = 0;
            thuChi.HienThiDSThuChi(ref flag, dtStart.Value, dtEnd.Value);
            return flag == 1;
        }
        private void loadData()
        {
            int flag = 0;
            dgvThuChi.DataSource = thuChi.HienThiDSThuChi(ref flag, dtStart.Value, dtEnd.Value);
            loadTong();
        }
        void loadTong()
        {
            double tong = 0;
            int len = dgvThuChi.RowCount - 1;
            for (int i = 0; i < len; i++)
            {
                tong = tong + Convert.ToDouble(dgvThuChi.Rows[i].Cells[0].Value.ToString());
            }
            textBoxTong.Text = tong.ToString();
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            DoanhThu_Load(null, null);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            loadData();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            loadData();
        }
    }
}
