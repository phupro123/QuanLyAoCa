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
    public partial class AdvanceBenh : Form
    {
        DBConnect con = new DBConnect();
        BUS_QuanLyBenh BusBenh = new BUS_QuanLyBenh();
        DTO_QuanLyBenh qlBenh = new DTO_QuanLyBenh();
        public AdvanceBenh()
        {
            InitializeComponent();
            dateTimeNgayBD.Value = Constant.start;
            dateTimeNgayKT.Value = Constant.end;
            dgvMacBenh.Font = new Font("Arial", 12);
        }
        public bool check()
        {
            int flag = 0;
            BusBenh.HienThiDSMacBenhAdmin(ref flag, dateTimeNgayBD.Value, dateTimeNgayKT.Value);
            return flag == 1;
        }
        private void showDataMacBenh()
        {
            int flag = 0;
            dgvMacBenh.DataSource = BusBenh.HienThiDSMacBenhAdmin(ref flag, dateTimeNgayBD.Value, dateTimeNgayKT.Value);
        }
        public void ClearMacBenh()
        {
            txtMaMacBenh.Clear();
            txtMaBenh2.Clear();
            txtMaLua.Clear();
            txtGhiChu.Clear();
            txtMaMacBenh.Focus();
        }
        private void AdvanceBenh_Load(object sender, EventArgs e)
        {
            this.showDataMacBenh();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (txtMaBenh2.Text.Equals("") || txtMaLua.Text.Equals(""))
            {
                MessageBox.Show("Điền thông tin chưa đầy đủ!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            qlBenh.MaBenh = int.Parse(txtMaBenh2.Text);
            qlBenh.MaLua = int.Parse(txtMaLua.Text);
            qlBenh.NgPhatHien = dateTimeNgayBenh.Value;
            qlBenh.NgChuaKhoi = dateTimeNgayKhoe.Value;
            qlBenh.GhiChu = txtGhiChu.Text;
            BusBenh.ThemMacBenh(qlBenh);
            this.showDataMacBenh();
            this.ClearMacBenh();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (txtMaMacBenh.Text.Equals("") || txtMaBenh2.Text.Equals("") 
                || txtMaLua.Text.Equals(""))
            {
                MessageBox.Show("Điền thông tin chưa đầy đủ!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            qlBenh.MaMacBenh = int.Parse(txtMaMacBenh.Text);
            qlBenh.MaBenh = int.Parse(txtMaBenh2.Text);
            qlBenh.MaLua = int.Parse(txtMaLua.Text);
            qlBenh.NgPhatHien = dateTimeNgayBenh.Value;
            qlBenh.NgChuaKhoi = dateTimeNgayKhoe.Value;
            qlBenh.GhiChu = txtGhiChu.Text;
            BusBenh.SuaMacBenh(qlBenh);
            this.showDataMacBenh();
            this.ClearMacBenh();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (txtMaMacBenh.Text.Equals(""))
            {
                MessageBox.Show("Điền thông tin chưa đầy đủ!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            qlBenh.MaMacBenh = int.Parse(txtMaMacBenh.Text);
            BusBenh.XoaMacBenh(qlBenh.MaMacBenh);
            this.showDataMacBenh();
            this.ClearMacBenh();
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            showDataMacBenh();
        }

        private void dgvMacBenh_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int Chi_So_Dong = e.RowIndex;
            if (Chi_So_Dong < dgvMacBenh.Rows.Count - 1)
            {
                txtMaMacBenh.Text = dgvMacBenh[0, Chi_So_Dong].Value.ToString();
                txtMaBenh2.Text = dgvMacBenh[2, Chi_So_Dong].Value.ToString();
                txtMaLua.Text = dgvMacBenh[4, Chi_So_Dong].Value.ToString();
                dateTimeNgayBenh.Value = Convert.ToDateTime(dgvMacBenh[5, Chi_So_Dong].Value.ToString());
                if (dgvMacBenh[6, Chi_So_Dong].Value.ToString() == "")
                {
                    dateTimeNgayKhoe.Value = DateTime.Parse("01/01/2000");
                }
                else
                {
                    dateTimeNgayKhoe.Value = Convert.ToDateTime(dgvMacBenh[6, Chi_So_Dong].Value.ToString());
                }
                txtGhiChu.Text = dgvMacBenh[7, Chi_So_Dong].Value.ToString();
            }
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            this.showDataMacBenh();
        }
    }
}
