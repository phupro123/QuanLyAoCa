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
    public partial class AdvanceKho : Form
    {
        DBConnect con = new DBConnect();
        BUS_QuanLyKho BusKho = new BUS_QuanLyKho();
        DTO_QuanLyKho qlKho = new DTO_QuanLyKho();
        public AdvanceKho()
        {
            InitializeComponent();
            txtSeacrh.Text = "";
            dgvKho.Font = new Font("Arial", 12);
        }
        public bool check()
        {
            int flag = 0;
            BusKho.HienThiDSNhapKhoAdmin(ref flag, txtSeacrh.Text);
            return flag == 1;
        }
        private void showData()
        {
            int flag = 0;
            dgvKho.DataSource = BusKho.HienThiDSNhapKhoAdmin(ref flag, txtSeacrh.Text);
        }
        public void Clear()
        {
            txtMaLoai.Clear();
            txtTen.Clear();
            txtDonVi.Clear();
            txtSLCon.Clear();
            txtNSX.Clear();
            txtGhiChu.Clear();
            txtGiaTri.Clear();
            txtSLNhap.Clear();
            txtMaNhapKho.Focus();
        }

        private void AdvanceKho_Load(object sender, EventArgs e)
        {
            this.showData();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (txtMaLoai.Text.Equals("") || txtTen.Text.Equals("") || txtDonVi.Text.Equals("")
                || txtSLCon.Text.Equals("") || txtGiaTri.Text.Equals("") || txtSLNhap.Text.Equals(""))
            {
                MessageBox.Show("Điền thông tin chưa đầy đủ!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            qlKho.MaLoai = int.Parse(txtMaLoai.Text);
            qlKho.Ten = txtTen.Text;
            qlKho.Donvi = txtDonVi.Text;
            qlKho.SLCon = int.Parse(txtSLCon.Text);
            qlKho.NSX = txtNSX.Text;
            qlKho.GhiChu = txtGhiChu.Text;
            qlKho.GiaTri = int.Parse(txtGiaTri.Text);
            qlKho.SLNhap = int.Parse(txtSLNhap.Text);
            qlKho.NgNhap = dateTimeNgNhap.Value;
            qlKho.HSD = dateTimeHSD.Value;
            BusKho.ThemNhapKho(qlKho);
            this.showData();
            this.Clear();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (txtMaNhapKho.Text.Equals("") || txtMaLoai.Text.Equals("") || txtTen.Text.Equals("") 
                || txtDonVi.Text.Equals("") || txtSLCon.Text.Equals("") 
                || txtGiaTri.Text.Equals("") || txtSLNhap.Text.Equals(""))
            {
                MessageBox.Show("Điền thông tin chưa đầy đủ!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            qlKho.MaNhapKho = int.Parse(txtMaNhapKho.Text);
            qlKho.MaLoai = int.Parse(txtMaLoai.Text);
            qlKho.Ten = txtTen.Text;
            qlKho.Donvi = txtDonVi.Text;
            qlKho.SLCon = int.Parse(txtSLCon.Text);
            qlKho.NSX = txtNSX.Text;
            qlKho.GhiChu = txtGhiChu.Text;
            qlKho.GiaTri = int.Parse(txtGiaTri.Text);
            qlKho.SLNhap = int.Parse(txtSLNhap.Text);
            qlKho.NgNhap = dateTimeNgNhap.Value;
            qlKho.HSD = dateTimeHSD.Value;
            BusKho.SuaNhapKho(qlKho);
            this.showData();
            this.Clear();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (txtMaNhapKho.Text.Equals(""))
            {
                MessageBox.Show("Điền thông tin chưa đầy đủ!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            qlKho.MaNhapKho = int.Parse(txtMaNhapKho.Text);
            BusKho.XoaNhapKho(qlKho.MaNhapKho);
            this.showData();
            this.Clear();
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            this.showData();
        }

        private void dgvKho_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int Chi_So_Dong = e.RowIndex;
            if (Chi_So_Dong < dgvKho.Rows.Count - 1) { 
            txtMaNhapKho.Text = dgvKho[0, Chi_So_Dong].Value.ToString();
            txtMaLoai.Text = dgvKho[2, Chi_So_Dong].Value.ToString();
            txtTen.Text = dgvKho[1, Chi_So_Dong].Value.ToString();
            txtDonVi.Text = dgvKho[6, Chi_So_Dong].Value.ToString();
            txtSLCon.Text = dgvKho[5, Chi_So_Dong].Value.ToString();
            txtNSX.Text = dgvKho[9, Chi_So_Dong].Value.ToString();
            txtGhiChu.Text = dgvKho[11, Chi_So_Dong].Value.ToString();
            txtGiaTri.Text = dgvKho[7, Chi_So_Dong].Value.ToString();
            txtSLNhap.Text = dgvKho[4, Chi_So_Dong].Value.ToString();
            dateTimeNgNhap.Value = Convert.ToDateTime(dgvKho[8, Chi_So_Dong].Value.ToString());
            dateTimeHSD.Value = Convert.ToDateTime(dgvKho[10, Chi_So_Dong].Value.ToString());
            }
            
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            showData();
            txtSeacrh.Text = "";
        }
    }
}
