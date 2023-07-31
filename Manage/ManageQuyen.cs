using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;
using DAL;

namespace QLAoCa
{
    public partial class ManageQuyen : Form
    {
        DBConnect con = new DBConnect();
        BUS_QuanLyQuyen BusQuyen = new BUS_QuanLyQuyen();
        DTO_QuanLyQuyen qlQuyen = new DTO_QuanLyQuyen();
        public ManageQuyen()
        {
            InitializeComponent();
            txtSearch.Text = "";
            dgvQuyen.Font = new Font("Arial", 12);
            dgvRole.Font = new Font("Arial", 12);
        }
        public bool check()
        {
            int flag = 0;
            BusQuyen.HienThiQuyen(ref flag);
            return flag == 1;
        }
        public void showData()
        {
            int flag = 0;
            dgvQuyen.DataSource = BusQuyen.HienThiDSQuyen(ref flag, txtSearch.Text);
            dgvRole.DataSource = BusQuyen.HienThiQuyen(ref flag);
        }
        public void ClearQuyen()
        {
            txtTaiKhoan.Clear();
            txtMaQuyen.Clear();
            txtTaiKhoan.Focus();
        }

        private void ManageQuyen_Load(object sender, EventArgs e)
        {
            this.showData();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (txtTaiKhoan.Text.Equals("") || txtMaQuyen.Text.Equals(""))
            {
                MessageBox.Show("Điền thông tin chưa đầy đủ!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            qlQuyen.TaiKhoan = txtTaiKhoan.Text;
            qlQuyen.MaQuyen = txtMaQuyen.Text;
            BusQuyen.ThemPhanQuyen(qlQuyen);
            this.showData();
            this.ClearQuyen();
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            if (txtTaiKhoan.Text.Equals("") || txtMaQuyen.Text.Equals(""))
            {
                MessageBox.Show("Điền thông tin chưa đầy đủ!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            qlQuyen.TaiKhoan = txtTaiKhoan.Text;
            qlQuyen.MaQuyen = txtMaQuyen.Text;
            BusQuyen.XoaPhanQuyen(qlQuyen.TaiKhoan, qlQuyen.MaQuyen);
            this.showData();
            this.ClearQuyen();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            showData();
        }

        private void dgvQuyen_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int Chi_So_Dong = e.RowIndex;
            if (Chi_So_Dong < dgvQuyen.Rows.Count - 1)
            {
            txtTaiKhoan.Text = dgvQuyen[0, Chi_So_Dong].Value.ToString();
            txtMaQuyen.Text = dgvQuyen[2, Chi_So_Dong].Value.ToString();
            }
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            this.showData();
        }

        private void dgvRole_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int Chi_So_Dong = e.RowIndex;
            if (Chi_So_Dong < dgvRole.Rows.Count - 1)
            {
                txtMaQuyen.Text = dgvRole[0, Chi_So_Dong].Value.ToString();
            }
        }
    }
}
