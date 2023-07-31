using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
    public partial class AdvanceLuong : Form
    {
        DBConnect con = new DBConnect();
        BUS_Luong BusLuong = new BUS_Luong();
        DTO_Luong qlLuong = new DTO_Luong();
        public AdvanceLuong()
        {
            InitializeComponent();
            txtSearch.Text = "";
            dgvLuong.Font = new Font("Arial", 12);
        }
        public bool check()
        {
            int flag = 0;
            BusLuong.HienThiDSLuongAdmin(ref flag, txtSearch.Text);
            return flag == 1;
        }
        private void showData()
        {
            int flag = 0;
            dgvLuong.DataSource = BusLuong.HienThiDSLuongAdmin(ref flag, txtSearch.Text);
        }
        public void Clear()
        {
            txtTaiKhoan.Clear();
            txtLuong.Clear();
            txtDanhGia.Clear();
            txtTaiKhoan.Focus();
        }

        private void AdvanceLuong_Load(object sender, EventArgs e)
        {
            this.showData();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (txtTaiKhoan.Text.Equals("") || txtLuong.Text.Equals(""))
            {
                MessageBox.Show("Điền thông tin chưa đầy đủ!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            qlLuong.TaiKhoan = txtTaiKhoan.Text;
            qlLuong.NgTraLuong = dateTimeNgayTra.Value;
            qlLuong.Luong = int.Parse(txtLuong.Text);
            qlLuong.DanhGia = txtDanhGia.Text;
            BusLuong.ThemLuong(qlLuong);
            this.showData();
            this.Clear();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (txtTaiKhoan.Text.Equals("") || txtLuong.Text.Equals(""))
            {
                MessageBox.Show("Điền thông tin chưa đầy đủ!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            qlLuong.TaiKhoan = txtTaiKhoan.Text;
            qlLuong.NgTraLuong = dateTimeNgayTra.Value;
            qlLuong.Luong = int.Parse(txtLuong.Text);
            qlLuong.DanhGia = txtDanhGia.Text;
            BusLuong.SuaLuong(qlLuong);
            this.showData();
            this.Clear();
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            if (txtTaiKhoan.Text.Equals(""))
            {
                MessageBox.Show("Điền thông tin chưa đầy đủ!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            qlLuong.TaiKhoan = txtTaiKhoan.Text;
            qlLuong.NgTraLuong = dateTimeNgayTra.Value;
            BusLuong.XoaLuong(qlLuong.TaiKhoan, qlLuong.NgTraLuong);
            this.showData();
            this.Clear();
        }

        private void dgvLuong_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int Chi_So_Dong = e.RowIndex;
            if (Chi_So_Dong < dgvLuong.Rows.Count - 1) { 
            txtTaiKhoan.Text = dgvLuong[0, Chi_So_Dong].Value.ToString();
            dateTimeNgayTra.Value = Convert.ToDateTime(dgvLuong[3, Chi_So_Dong].Value.ToString());
            txtLuong.Text = dgvLuong[2, Chi_So_Dong].Value.ToString();
            txtDanhGia.Text = dgvLuong[4, Chi_So_Dong].Value.ToString();
            }
        }

        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            showData();
            txtSearch.Text = "";
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            this.showData();
        }
    }
}
