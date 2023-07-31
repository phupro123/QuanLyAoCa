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
    public partial class ManageLuong : Form
    {
        int flag = 0;
        DBConnect con = new DBConnect();
        BUS_Luong BusLuong = new BUS_Luong();
        DTO_Luong qlLuong = new DTO_Luong();
        public ManageLuong()
        {
            InitializeComponent();
            dgvLuong.Font = new Font("Arial", 12);
        }
        public bool check()
        {
            int flag = 0;
            BusLuong.HienThiDSLuongUser(ref flag);
            return flag == 1;
        }
        public void showData()
        {
            dgvLuong.DataSource = BusLuong.HienThiDSLuongUser(ref flag);
        }
        public void Clear()
        {
            txtTaiKhoan.Clear();
            txtLuong.Clear();
            txtDanhGia.Clear();
            txtTaiKhoan.Focus();
        }

        private void ManageLuong_Load(object sender, EventArgs e)
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
            qlLuong.Luong = long.Parse(txtLuong.Text);
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
            if (Chi_So_Dong < dgvLuong.Rows.Count - 1)
            {
            txtTaiKhoan.Text = dgvLuong[0, Chi_So_Dong].Value.ToString();
            dateTimeNgayTra.Value = Convert.ToDateTime(dgvLuong[3, Chi_So_Dong].Value.ToString());
            txtLuong.Text = dgvLuong[2, Chi_So_Dong].Value.ToString();
            txtDanhGia.Text = dgvLuong[4, Chi_So_Dong].Value.ToString();
            }
        }

        private void ButtonAdvance_Click(object sender, EventArgs e)
        {
            AdvanceLuong form = new AdvanceLuong();
            if (!form.check())
            {
                form.Close();
                return;
            }
            form.Show(this);
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            this.showData();
        }
    }
}
