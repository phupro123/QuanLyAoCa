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
    public partial class AdvanceBe : Form
    {
        DBConnect con = new DBConnect();
        BUS_QuanLyBe BusBe = new BUS_QuanLyBe();
        DTO_QuanLyBe qlBe = new DTO_QuanLyBe();
        public AdvanceBe()
        {
            InitializeComponent();
            txtSearch.Text = "";
            dgvMoiTruong.Font = new Font("Arial", 12);
        }
        public bool check()
        {
            int flag = 0;
            BusBe.HienThiDSMoiTruongAdmin(ref flag, txtSearch.Text == "" ? 0 : int.Parse(txtSearch.Text));
            return flag == 1;
        }
        private void showData()
        {
            int flag = 0;
            dgvMoiTruong.DataSource = BusBe.HienThiDSMoiTruongAdmin(ref flag, txtSearch.Text == "" ? 0 : int.Parse(txtSearch.Text));
        }
        public void ClearMoiTruong()
        {
            txtMaBe.Clear();
            txtpH.Clear();
            txtNH3.Clear();
            txtH2S.Clear();
            txtOxy.Clear();
            txtGhiChu.Clear();
            txtMaBe.Focus();
        }
        private void btAdd_Click(object sender, EventArgs e)
        {
            if (txtMaBe.Text.Equals("") || txtpH.Text.Equals("") || txtNH3.Text.Equals("")
                || txtH2S.Text.Equals("") || txtOxy.Text.Equals(""))
            {
                MessageBox.Show("Điền thông tin chưa đầy đủ!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            qlBe.MaBe = int.Parse(txtMaBe.Text);
            qlBe.Ngay = dateTimeNgay.Value;
            qlBe.pH = float.Parse(txtpH.Text);
            qlBe.NH3 = float.Parse(txtNH3.Text);
            qlBe.H2S = float.Parse(txtH2S.Text);
            qlBe.Oxy = float.Parse(txtOxy.Text);
            qlBe.GhiChu = txtGhiChu.Text;
            BusBe.ThemMoiTruong(qlBe);
            this.showData();
            this.ClearMoiTruong();
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            if (txtMaBe.Text.Equals("") || txtpH.Text.Equals("") || txtNH3.Text.Equals("")
                || txtH2S.Text.Equals("") || txtOxy.Text.Equals(""))
            {
                MessageBox.Show("Điền thông tin chưa đầy đủ!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            qlBe.MaBe = int.Parse(txtMaBe.Text);
            qlBe.Ngay = dateTimeNgay.Value;
            qlBe.pH = float.Parse(txtpH.Text);
            qlBe.NH3 = float.Parse(txtNH3.Text);
            qlBe.H2S = float.Parse(txtH2S.Text);
            qlBe.Oxy = float.Parse(txtOxy.Text);
            qlBe.GhiChu = txtGhiChu.Text;
            BusBe.SuaMoiTruong(qlBe);
            MessageBox.Show(qlBe.Ngay.ToString());
            this.showData();
            this.ClearMoiTruong();
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            if (txtMaBe.Text.Equals(""))
            {
                MessageBox.Show("Điền thông tin chưa đầy đủ!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            qlBe.MaBe = int.Parse(txtMaBe.Text);
            qlBe.Ngay = dateTimeNgay.Value;
            BusBe.XoaMoiTruong(qlBe.MaBe, qlBe.Ngay);
            this.showData();
            this.ClearMoiTruong();
        }

        private void btRefresh_Click(object sender, EventArgs e)
        {
            this.showData();
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            showData();
        }

        private void AdvanceBe_Load(object sender, EventArgs e)
        {
            this.showData();
        }

        private void dgvMoiTruong_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int Chi_So_Dong = e.RowIndex;
            if (Chi_So_Dong < dgvMoiTruong.Rows.Count - 1)
            {
                txtMaBe.Text = dgvMoiTruong[0, Chi_So_Dong].Value.ToString();
                dateTimeNgay.Value = Convert.ToDateTime(dgvMoiTruong[4, Chi_So_Dong].Value.ToString());
                txtpH.Text = dgvMoiTruong[5, Chi_So_Dong].Value.ToString();
                txtNH3.Text = dgvMoiTruong[6, Chi_So_Dong].Value.ToString();
                txtH2S.Text = dgvMoiTruong[7, Chi_So_Dong].Value.ToString();
                txtOxy.Text = dgvMoiTruong[8, Chi_So_Dong].Value.ToString();
                txtGhiChu.Text = dgvMoiTruong[9, Chi_So_Dong].Value.ToString();
            }
        }
    }
}
