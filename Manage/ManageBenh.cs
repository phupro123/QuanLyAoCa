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
    public partial class ManageBenh : Form
    {
        int flag = 0;
        DBConnect con = new DBConnect();
        BUS_QuanLyBenh BusBenh = new BUS_QuanLyBenh();
        DTO_QuanLyBenh qlBenh = new DTO_QuanLyBenh();
        public ManageBenh()
        {
            InitializeComponent();
            dgvBenh.Font = new Font("Arial", 12);
        }

        public bool check()
        {
            int flag = 0;
            BusBenh.HienThiDSBenh(ref flag);
            return flag == 1;
        }
        public void showDataBenh()
        {
            dgvBenh.DataSource = BusBenh.HienThiDSBenh(ref flag);
        }
        public void ClearBenh()
        {
            txtMaBenh.Clear();
            txtTenBenh.Clear();
            txtTacNhan.Clear();
            txtDauHieu.Clear();
            txtMaBenh.Focus();
        }
        private void ManageBenh_Load(object sender, EventArgs e)
        {
            this.showDataBenh();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (txtTenBenh.Text.Equals("") || txtTacNhan.Text.Equals("") || txtDauHieu.Text.Equals(""))
            {
                MessageBox.Show("Điền thông tin chưa đầy đủ!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            qlBenh.TenBenh = txtTenBenh.Text;
            qlBenh.TacNhan = txtTacNhan.Text;
            qlBenh.DauHieu = txtDauHieu.Text;
            BusBenh.ThemBenh(qlBenh);
            this.showDataBenh();
            this.ClearBenh();
        }
        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (txtMaBenh.Text.Equals("") || txtTenBenh.Text.Equals("") 
                || txtTacNhan.Text.Equals("") || txtDauHieu.Text.Equals(""))
            {
                MessageBox.Show("Điền thông tin chưa đầy đủ!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            qlBenh.MaBenh = int.Parse(txtMaBenh.Text);
            qlBenh.TenBenh = txtTenBenh.Text;
            qlBenh.TacNhan = txtTacNhan.Text;
            qlBenh.DauHieu = txtDauHieu.Text;
            BusBenh.SuaBenh(qlBenh);
            this.showDataBenh();
            this.ClearBenh();
        }
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (txtMaBenh.Text.Equals(""))
            {
                MessageBox.Show("Điền thông tin chưa đầy đủ!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            BusBenh.XoaBenh(int.Parse(txtMaBenh.Text));
            this.showDataBenh();
            this.ClearBenh();
        }

        private void dgvBenh_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int Chi_So_Dong = e.RowIndex;
            if (Chi_So_Dong < dgvBenh.Rows.Count - 1)
            {
                txtMaBenh.Text = dgvBenh[0, Chi_So_Dong].Value.ToString();
                txtTenBenh.Text = dgvBenh[1, Chi_So_Dong].Value.ToString();
                txtTacNhan.Text = dgvBenh[2, Chi_So_Dong].Value.ToString();
                txtDauHieu.Text = dgvBenh[3, Chi_So_Dong].Value.ToString();
            }            
        }
        private void buttonMacBenh_Click(object sender, EventArgs e)
        {
            MacBenh form = new MacBenh();
            if (!form.check())
            {
                form.Close();
                return;
            }
            form.Show(this);
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            this.showDataBenh();
        }

        private void txtTenBenh_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
