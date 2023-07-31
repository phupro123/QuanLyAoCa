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
    public partial class ManageBe : Form
    {
        DBConnect con = new DBConnect();
        BUS_QuanLyBe BusBe = new BUS_QuanLyBe();
        DTO_QuanLyBe qlBe = new DTO_QuanLyBe();
        public ManageBe()
        {
            InitializeComponent();
            dgvBe.Font = new Font("Arial", 12);
        }

        public bool check()
        {
            int flag = 0;
            BusBe.HienThiDSBe(ref flag);
            return flag == 1;
        }
        private void showDataBe()
        {
            int flag = 0;
            dgvBe.DataSource = BusBe.HienThiDSBe(ref flag);
        }
        public void ClearBe()
        {
            txtMaBe.Clear();
            txtDienTich.Clear();
            txtDoSau.Clear();
            txtTrangThai.Clear();
            txtMaBe.Focus();
        }
        private void ManageBe_Load(object sender, EventArgs e)
        {
            this.showDataBe();
        }

        private void btAddBe_Click(object sender, EventArgs e)
        {

        }

        private void btEditBe_Click(object sender, EventArgs e)
        {
            if (txtMaBe.Text.Equals("") || txtDienTich.Text.Equals("") 
                || txtDoSau.Text.Equals("") || txtTrangThai.Text.Equals(""))
            {
                MessageBox.Show("Điền thông tin chưa đầy đủ!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            qlBe.MaBe = int.Parse(txtMaBe.Text);
            qlBe.DienTich = int.Parse(txtDienTich.Text);
            qlBe.DoSau = int.Parse(txtDoSau.Text);
            BusBe.SuaBe(qlBe);
            this.showDataBe();
            this.ClearBe();
        }

        private void btDeleteBe_Click(object sender, EventArgs e)
        {
            if (txtMaBe.Text.Equals(""))
            {
                MessageBox.Show("Điền thông tin chưa đầy đủ!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            qlBe.MaBe = int.Parse(txtMaBe.Text);
            BusBe.XoaBe(qlBe.MaBe);
            this.showDataBe();
            this.ClearBe();
        }
        private void dgvBe_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int Chi_So_Dong = e.RowIndex;
            if (Chi_So_Dong < dgvBe.Rows.Count - 1) { 
            txtMaBe.Text = dgvBe[0, Chi_So_Dong].Value.ToString();
            txtDienTich.Text = dgvBe[1, Chi_So_Dong].Value.ToString();
            txtDoSau.Text = dgvBe[2, Chi_So_Dong].Value.ToString();
            txtTrangThai.Text = dgvBe[3, Chi_So_Dong].Value.ToString();
            }
        }

        private void buttonMoiTruong_Click(object sender, EventArgs e)
        {
            MoiTruong form = new MoiTruong();
            if (!form.check())
            {
                form.Close();
                return;
            }
            form.Show(this);
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            this.showDataBe();
        }
    }
}
