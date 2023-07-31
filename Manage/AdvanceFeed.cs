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
using DTO;
using BUS;
using DAL;

namespace QLAoCa
{
    public partial class AdvanceFeed : Form
    {
        DBConnect con = new DBConnect();
        BUS_ChoAn BusChoAn = new BUS_ChoAn();
        DTO_ChoAn qlChoAn = new DTO_ChoAn();
        public AdvanceFeed()
        {
            InitializeComponent();
            dgvChoAn.Font = new Font("Arial", 12);
        }
        public bool check()
        {
            int flag = 0;
            BusChoAn.HienThiDSChoAnAdmin(ref flag, int.Parse(txtSearch.Text == "" ? "0" : txtSearch.Text));
            return flag == 1;
        }
        private void showData()
        {
            int flag = 0;
            dgvChoAn.DataSource = BusChoAn.HienThiDSChoAnAdmin(ref flag, int.Parse(txtSearch.Text == "" ? "0" : txtSearch.Text));
        }
        public void ClearChoAn()
        {
            txtMaLua.Clear();
            txtMaThucAn.Clear();
            txtSL.Clear();
            txtMaLua.Focus();
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (txtMaLua.Text.Equals("") || txtMaThucAn.Text.Equals("") || txtSL.Text.Equals(""))
            {
                MessageBox.Show("Điền thông tin chưa đầy đủ!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DateTime d = DateTime.Now;
            qlChoAn.MaLua = int.Parse(txtMaLua.Text);
            qlChoAn.MaThucAn = int.Parse(txtMaThucAn.Text);
            qlChoAn.ThoiGian = d.AddMilliseconds(-d.Millisecond);
            qlChoAn.SL = int.Parse(txtSL.Text);
            BusChoAn.ThemChoAn(qlChoAn);
            this.showData();
            this.ClearChoAn();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (txtMaLua.Text.Equals("") || txtMaThucAn.Text.Equals("") || txtSL.Text.Equals(""))
            {
                MessageBox.Show("Điền thông tin chưa đầy đủ!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            qlChoAn.MaLua = int.Parse(txtMaLua.Text);
            qlChoAn.MaThucAn = int.Parse(txtMaThucAn.Text);
            qlChoAn.ThoiGian = dateTimeThoiGian.Value;
            qlChoAn.SL = int.Parse(txtSL.Text);
            BusChoAn.SuaChoAn(qlChoAn);
            this.showData();
            this.ClearChoAn();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (txtMaLua.Text.Equals("") || txtMaThucAn.Text.Equals(""))
            {
                MessageBox.Show("Điền thông tin chưa đầy đủ!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            qlChoAn.MaLua = int.Parse(txtMaLua.Text);
            qlChoAn.MaThucAn = int.Parse(txtMaThucAn.Text);
            qlChoAn.ThoiGian = dateTimeThoiGian.Value;
            BusChoAn.XoaChoAn(qlChoAn.MaLua, qlChoAn.MaThucAn, qlChoAn.ThoiGian);
            this.showData();
            this.ClearChoAn();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            showData();
        }

        private void dgvChoAn_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int Chi_So_Dong = e.RowIndex;
            if (Chi_So_Dong < dgvChoAn.Rows.Count - 1) { 
            txtMaLua.Text = dgvChoAn[0, Chi_So_Dong].Value.ToString();
            txtMaThucAn.Text = dgvChoAn[2, Chi_So_Dong].Value.ToString();
            dateTimeThoiGian.Value = Convert.ToDateTime(dgvChoAn[4, Chi_So_Dong].Value.ToString());
            txtSL.Text = dgvChoAn[5, Chi_So_Dong].Value.ToString();
            }
            
        }

        private void AdvanceFeed_Load(object sender, EventArgs e)
        {
            this.showData();
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            this.showData();
        }
    }
}
