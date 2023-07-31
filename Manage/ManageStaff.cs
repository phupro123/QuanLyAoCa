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
    public partial class ManageStaff : Form
    {
        DBConnect con = new DBConnect();
        BUS_QuanLyNhanVien BusNV = new BUS_QuanLyNhanVien();
        DTO_QuanLyNhanVien qlNV = new DTO_QuanLyNhanVien();
        public ManageStaff()
        {
            InitializeComponent();
            txtSearch.Text = "";
            dgvNhanVien.Font = new Font("Arial", 12);
        }
        public bool check()
        {
            int flag = 0;
            BusNV.HienThiDSNhanVien(ref flag, txtSearch.Text);
            return flag == 1;
        }
        public void showData()
        {
            int flag = 0;
            dgvNhanVien.DataSource = BusNV.HienThiDSNhanVien(ref flag, txtSearch.Text);
        }
        public void Clear()
        {
            txtTaiKhoan.Clear();
            txtHoTen.Clear();
            txtPhone.Clear();
            txtMoTa.Clear();
            txtConLamViec.Clear();
            txtTaiKhoan.Focus();
        }

        private void ManageStaff_Load(object sender, EventArgs e)
        {
            this.showData();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (txtTaiKhoan.Text.Equals("") || txtMatKhau.Text.Equals("") || txtHoTen.Text.Equals("")
                || txtPhone.Text.Equals("") || txtConLamViec.Text.Equals(""))
            {
                MessageBox.Show("Điền thông tin chưa đầy đủ!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            qlNV.TaiKhoan = txtTaiKhoan.Text;
            qlNV.MatKhau = txtMatKhau.Text;
            qlNV.HoTen = txtHoTen.Text;
            qlNV.NgSinh = dateTimeNgaySinh.Value;
            qlNV.Sdt = txtPhone.Text;
            qlNV.NgLam = dateTimeNgayVao.Value;
            qlNV.MoTaCV = txtMoTa.Text;
            qlNV.ConLamViec = bool.Parse(txtConLamViec.Text);
            BusNV.ThemNhanVien(qlNV);
            this.showData();
            this.Clear();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (txtTaiKhoan.Text.Equals("") || txtMatKhau.Text.Equals("") || txtHoTen.Text.Equals("")
                || txtPhone.Text.Equals("") || txtConLamViec.Text.Equals(""))
            {
                MessageBox.Show("Điền thông tin chưa đầy đủ!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            qlNV.TaiKhoan = txtTaiKhoan.Text;
            qlNV.MatKhau = txtMatKhau.Text;
            qlNV.HoTen = txtHoTen.Text;
            qlNV.NgSinh = dateTimeNgaySinh.Value;
            qlNV.Sdt = txtPhone.Text;
            qlNV.NgLam = dateTimeNgayVao.Value;
            qlNV.MoTaCV = txtMoTa.Text;
            qlNV.ConLamViec = bool.Parse(txtConLamViec.Text);
            BusNV.SuaNhanVien(qlNV);
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
            qlNV.TaiKhoan = txtTaiKhoan.Text;
            BusNV.XoaNhanVien(qlNV.TaiKhoan);
            this.showData();
            this.Clear();
        }

        private void dgvNhanVien_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int Chi_So_Dong = e.RowIndex;
            if (Chi_So_Dong < dgvNhanVien.Rows.Count - 1)
            {
            txtTaiKhoan.Text = dgvNhanVien[0, Chi_So_Dong].Value.ToString();
            txtMatKhau.Text = dgvNhanVien[1, Chi_So_Dong].Value.ToString();
            txtHoTen.Text = dgvNhanVien[2, Chi_So_Dong].Value.ToString();
            dateTimeNgaySinh.Value = Convert.ToDateTime(dgvNhanVien[3, Chi_So_Dong].Value.ToString());
            txtPhone.Text = dgvNhanVien[4, Chi_So_Dong].Value.ToString();
            dateTimeNgayVao.Value = Convert.ToDateTime(dgvNhanVien[5, Chi_So_Dong].Value.ToString());
            txtMoTa.Text = dgvNhanVien[6, Chi_So_Dong].Value.ToString();
            txtConLamViec.Text = dgvNhanVien[7, Chi_So_Dong].Value.ToString();
            }
        }

        private void Permission_Click(object sender, EventArgs e)
        {
            ManageQuyen form = new ManageQuyen();
            if (!form.check())
            {
                form.Close();
                return;
            }
            form.Show(this);
        }

        private void btLuong_Click(object sender, EventArgs e)
        {
            ManageLuong form = new ManageLuong();
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

        private void btSearch_Click(object sender, EventArgs e)
        {
            showData();
            txtSearch.Text = "";
        }
    }
}
