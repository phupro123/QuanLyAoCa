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
    public partial class ChiTietCachChua : Form
    {
        DBConnect con = new DBConnect();
        BUS_ChiTietChuaBenh BusCTCC = new BUS_ChiTietChuaBenh();
        DTO_ChiTietCachChua qlCTCC = new DTO_ChiTietCachChua();
        public ChiTietCachChua(DTO_QuanLyBenh qlB)
        {
            InitializeComponent();
            dgvChiTiet.Font = new Font("Arial", 12);
            txtMaMacBenh.Text = qlB.MaMacBenh.ToString();
            txtMaBenh.Text = qlB.MaBenh.ToString();
            txtGhiChu.Text = qlB.GhiChu;
            txtTenBenh.Text = qlB.TenBenh;
            txtMaLua.Text = qlB.MaLua.ToString();
            dtChuaKhoi.Value = qlB.NgChuaKhoi;
            dtPhatHien.Value = qlB.NgPhatHien;
        }

        public bool check()
        {
            int flag = 0;
            BusCTCC.DSChiTietCachChua(ref flag, int.Parse(txtMaMacBenh.Text));
            return flag == 1;
        }
        private void showData()
        {
            int flag = 0;
            dgvChiTiet.DataSource = BusCTCC.DSChiTietCachChua(ref flag, int.Parse(txtMaMacBenh.Text));
        }

        public void Clear()
        {
            txtMaThuoc.Clear();
            txtSL.Clear();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtMaThuoc.Text.Equals("") || txtSL.Text.Equals(""))
            {
                MessageBox.Show("Điền thông tin chưa đầy đủ!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            qlCTCC.MaMacBenh = int.Parse(txtMaMacBenh.Text);
            qlCTCC.MaThuoc = int.Parse(txtMaThuoc.Text);
            MessageBox.Show(txtMaThuoc.Text);
            qlCTCC.SL = int.Parse(txtSL.Text);
            BusCTCC.ThemChiTietCachChua(qlCTCC);
            this.showData();
            this.Clear();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (txtMaMacBenh.Text.Equals("") || txtMaThuoc.Text.Equals("") || txtSL.Text.Equals(""))
            {
                MessageBox.Show("Điền thông tin chưa đầy đủ!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            qlCTCC.MaMacBenh = int.Parse(txtMaMacBenh.Text);
            qlCTCC.MaThuoc = int.Parse(txtMaThuoc.Text);
            qlCTCC.SL = int.Parse(txtSL.Text);
            BusCTCC.SuaChiTietCachChua(qlCTCC);
            this.showData();
            this.Clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtMaThuoc.Text.Equals("") || txtMaMacBenh.Text.Equals(""))
            {
                MessageBox.Show("Điền thông tin chưa đầy đủ!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            qlCTCC.MaThuoc = int.Parse(txtMaThuoc.Text);
            qlCTCC.MaMacBenh = int.Parse(txtMaMacBenh.Text);
            BusCTCC.XoaChiTietCachChua(qlCTCC.MaMacBenh, qlCTCC.MaThuoc);
            this.showData();
            this.Clear();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            showData();
        }

        private void ManageLoai_Load(object sender, EventArgs e)
        {
            showData();
        }

        private void dgvChiTiet_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int Chi_So_Dong = e.RowIndex;
            if (Chi_So_Dong < dgvChiTiet.Rows.Count - 1)
            {
                txtMaThuoc.Text = dgvChiTiet[1, Chi_So_Dong].Value.ToString();
                txtSL.Text = dgvChiTiet[2, Chi_So_Dong].Value.ToString();
            }
        }
    }
}
