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
    public partial class ManageKho : Form
    {
        DBConnect con = new DBConnect();
        BUS_QuanLyKho BusKho = new BUS_QuanLyKho();
        DTO_QuanLyKho qlKho = new DTO_QuanLyKho();
        public ManageKho()
        {
            InitializeComponent();
            dgvKho.Font = new Font("Arial", 12);
        }
        public bool check()
        {
            int flag = 0;
            BusKho.HienThiDSNhapKhoUser(ref flag);
            return flag == 1;
        }
        public void showData()
        {
            int flag = 0;
            dgvKho.DataSource = BusKho.HienThiDSNhapKhoUser(ref flag);
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

        private void ManageKho_Load(object sender, EventArgs e)
        {
            this.showData();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (txtMaLoai.Text.Equals("") || txtTen.Text.Equals("") || txtDonVi.Text.Equals("") ||
                txtSLCon.Text.Equals("") || txtNSX.Text.Equals("") ||
                txtGiaTri.Text.Equals("") || txtSLNhap.Text.Equals(""))
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
            if (txtMaNhapKho.Text.Equals("") ||  txtMaLoai.Text.Equals("") || txtTen.Text.Equals("") 
                || txtDonVi.Text.Equals("") || txtSLCon.Text.Equals("") || txtNSX.Text.Equals("") 
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

        private void dgvKho_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int Chi_So_Dong = e.RowIndex;
            if (Chi_So_Dong < dgvKho.Rows.Count - 1)
            {
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
        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            this.showData();
        }
        private void buttonAdvance_Click(object sender, EventArgs e)
        {
            AdvanceKho form = new AdvanceKho();
            if (!form.check())
            {
                form.Close();
                return;
            }
            form.Show(this);
        }

        private void btnLoai_Click(object sender, EventArgs e)
        {
            ManageLoai form = new ManageLoai();
            if (!form.check())
            {
                form.Close();
                return;
            }
            form.Show(this);
        }
    }
}
