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
    public partial class ManageLoai : Form
    {
        DBConnect con = new DBConnect();
        BUS_QuanLyLoai BusLoai = new BUS_QuanLyLoai();
        DTO_QuanLyLoai qlLoai = new DTO_QuanLyLoai();
        public ManageLoai()
        {
            InitializeComponent();
            dgvLoai.Font = new Font("Arial", 12);
        }

        public bool check()
        {
            int flag = 0;
            BusLoai.HienThiDSLoai(ref flag);
            return flag == 1;
        }
        private void showData()
        {
            int flag = 0;
            dgvLoai.DataSource = BusLoai.HienThiDSLoai(ref flag);
        }

        public void Clear()
        {
            txtMa.Clear();
            txtTen.Clear();
        }

        private void dgvLoai_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int Chi_So_Dong = e.RowIndex;
            if (Chi_So_Dong < dgvLoai.Rows.Count - 1)
            {
                txtMa.Text = dgvLoai[0, Chi_So_Dong].Value.ToString();
                txtTen.Text = dgvLoai[1, Chi_So_Dong].Value.ToString();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtTen.Text.Equals(""))
            {
                MessageBox.Show("Điền thông tin chưa đầy đủ!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            qlLoai.Ten = txtTen.Text;
            BusLoai.ThemLoaiNhapKho(qlLoai);
            this.showData();
            this.Clear();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (txtMa.Text.Equals("") || txtTen.Text.Equals(""))
            {
                MessageBox.Show("Điền thông tin chưa đầy đủ!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            qlLoai.Ten = txtTen.Text;
            qlLoai.Ma= int.Parse(txtMa.Text);
            BusLoai.SuaLoaiNhapKho(qlLoai);
            this.showData();
            this.Clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtMa.Text.Equals(""))
            {
                MessageBox.Show("Điền thông tin chưa đầy đủ!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            qlLoai.Ma= int.Parse(txtMa.Text);
            BusLoai.XoaLoaiNhapKho(qlLoai.Ma);
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
    }
}
