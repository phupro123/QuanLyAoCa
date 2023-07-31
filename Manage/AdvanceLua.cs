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
    public partial class AdvanceLua : Form
    {
        DBConnect con = new DBConnect();
        BUS_QuanLyLua BusLua = new BUS_QuanLyLua();
        DTO_QuanLyLua qlLua = new DTO_QuanLyLua();
        public AdvanceLua()
        {
            InitializeComponent();
            dgvLua.Font = new Font("Arial", 12);
        }
        public bool check()
        {
            int flag = 0;
            BusLua.HienThiDSLuaAdmin(ref flag, null, null);
            return flag == 1;
        }
        private void showData(DateTime? bd = null, DateTime? kt = null)        
        {
            int flag = 0;
            dgvLua.DataSource = BusLua.HienThiDSLuaAdmin(ref flag, bd, kt);
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

        private void AdvanceLua_Load(object sender, EventArgs e)
        {
            this.showData();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (txtSL.Text.Equals("") || txtMaBe.Text.Equals("") || txtGiaTri.Text.Equals(""))
            {
                MessageBox.Show("Điền thông tin chưa đầy đủ!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            qlLua.NgayNuoi = dateTimeNgayNuoi.Value;
            qlLua.SL = int.Parse(txtSL.Text);
            qlLua.MaBe = int.Parse(txtMaBe.Text);
            qlLua.NgayThu = dateTimeNgayThu.Value;
            qlLua.GiaTri = long.Parse(txtGiaTri.Text);
            qlLua.GhiChu = txtGhiChu.Text;
            BusLua.ThemLua(qlLua);
            this.showData();
            this.Clear();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (txtSL.Text.Equals("") || txtMaBe.Text.Equals("")
                || txtGiaTri.Text.Equals("") || txtMaLua.Text.Equals(""))
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
            MessageBox.Show(txtMaLua + ":");
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
            qlLua.MaLua = int.Parse(txtMaLua.Text);
            BusLua.XoaLua(qlLua.MaLua);
            this.showData();
            this.Clear();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            showData(dateTimeNgayBD.Value, dateTimeNgayKT.Value);
        }

        private void buttonFeed_Click(object sender, EventArgs e)
        {
            AdvanceFeed form = new AdvanceFeed();
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
    }
}
