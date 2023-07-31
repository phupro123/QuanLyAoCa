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
    public partial class ManageLua : Form
    {
        DBConnect con = new DBConnect();
        BUS_QuanLyLua BusLua = new BUS_QuanLyLua();
        DTO_QuanLyLua qlLua = new DTO_QuanLyLua();
        public ManageLua()
        {
            InitializeComponent();
            dgvLua.Font = new Font("Arial", 12);
        }
        public bool check()
        {
            int flag = 0;
            BusLua.HienThiDSLuaUser(ref flag);
            return flag == 1;
        }
        public void showData()
        {
            int flag = 0;
            dgvLua.DataSource = BusLua.HienThiDSLuaUser(ref flag);
        }
        public void Clear()
        {
            txtMaLua.Clear();
            txtSL.Clear();
            txtMaBe.Clear();
            txtGiaTri.Clear();
            txtGhiChu.Clear();
            txtMaLua.Focus();
        }

        private void ManageLua_Load(object sender, EventArgs e)
        {
            this.showData();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (txtSL.Text.Equals("") || txtMaBe.Text.Equals(""))
            {
                MessageBox.Show("Điền thông tin chưa đầy đủ!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            qlLua.NgayNuoi = dateTimeNgayNuoi.Value;
            qlLua.SL = int.Parse(txtSL.Text == "" ? "0" : txtSL.Text);
            qlLua.MaBe = int.Parse(txtMaBe.Text == "" ? "0" : txtMaBe.Text);
            qlLua.NgayThu = dateTimeNgayThu.Value;
            qlLua.GiaTri = long.Parse(txtGiaTri.Text == "" ? "0" : txtGiaTri.Text);
            qlLua.GhiChu = txtGhiChu.Text;
            BusLua.ThemLua(qlLua);
            this.showData();
            this.Clear();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (txtMaLua.Text.Equals("") || txtSL.Text.Equals("") || txtMaBe.Text.Equals("")
                || txtGiaTri.Text.Equals("") || txtGhiChu.Text.Equals(""))
            {
                MessageBox.Show("Điền thông tin chưa đầy đủ!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            qlLua.MaLua = int.Parse(txtMaLua.Text == "" ? "0" : txtMaLua.Text);
            qlLua.NgayNuoi = dateTimeNgayNuoi.Value;
            qlLua.SL = int.Parse(txtSL.Text == "" ? "0" : txtSL.Text);
            qlLua.MaBe = int.Parse(txtMaBe.Text == "" ? "0" : txtMaBe.Text);
            qlLua.NgayThu = dateTimeNgayThu.Value;
            qlLua.GiaTri = long.Parse(txtGiaTri.Text == "" ? "0" : txtGiaTri.Text);
            qlLua.GhiChu = txtGhiChu.Text;
            BusLua.SuaLua(qlLua);
            this.showData();
            this.Clear();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (txtMaLua.Text.Equals(""))
            {
                MessageBox.Show("Điền thông tin chưa đầy đủ!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            qlLua.MaLua = int.Parse(txtMaLua.Text == "" ? "0" : txtMaLua.Text);
            BusLua.XoaLua(qlLua.MaLua);
            this.showData();
            this.Clear();
        }

        private void buttonFeed_Click(object sender, EventArgs e)
        {
            Feed form = new Feed();
            if (!form.check())
            {
                form.Close();
                return;
            }
            form.Show(this);
        }

        private void dgvLua_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int Chi_So_Dong = e.RowIndex;
            if (Chi_So_Dong < dgvLua.Rows.Count - 1)
            {
                txtMaLua.Text = dgvLua[0, Chi_So_Dong].Value.ToString();
                dateTimeNgayNuoi.Value = Convert.ToDateTime(dgvLua[1, Chi_So_Dong].Value.ToString());
                txtSL.Text = dgvLua[2, Chi_So_Dong].Value.ToString();
                txtMaBe.Text = dgvLua[3, Chi_So_Dong].Value.ToString();
                if (dgvLua[4, Chi_So_Dong].Value.ToString() == "")
                {
                    dateTimeNgayThu.Value = DateTime.Parse("01/01/2000");
                }
                else
                {
                    dateTimeNgayThu.Value = Convert.ToDateTime(dgvLua[4, Chi_So_Dong].Value.ToString());
                }
                txtGiaTri.Text = dgvLua[5, Chi_So_Dong].Value.ToString();
                txtGhiChu.Text = dgvLua[6, Chi_So_Dong].Value.ToString();
            }
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            this.showData();
        }

        private void buttonAdvance_Click(object sender, EventArgs e)
        {
            AdvanceLua form = new AdvanceLua();
            if (!form.check())
            {
                form.Close();
                return;
            }
            form.Show(this);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
