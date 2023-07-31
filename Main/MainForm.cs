using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLAoCa
{
    public partial class MainForm : Form
    {
        Login _login;
        public MainForm(Login login)
        {
            InitializeComponent();
            _login = login;
            labelWelcom.Text = login.id;
        }
        
        int flag = 0;

        private void MainForm2_Load(object sender, EventArgs e)
        {
           

        }
        
        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MainForm2_Load(null, null);
            for (int i = 0; i < Tab.TabPages.Count; i++)
            {     
                Tab.TabPages.Clear();
            }
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Would you like to Logout ?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                _login.Show();
                flag = 1;
                this.Close();
            }
            
        }

        private void Tab_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.DrawBackground();
            Graphics g = e.Graphics;

            Font drawFont = new Font("Arial", 10);

            g.FillRectangle(new SolidBrush(Color.Silver), e.Bounds);

            e.Graphics.DrawString("X", drawFont, Brushes.White, e.Bounds.Right -12, e.Bounds.Top +5);

            e.Graphics.DrawString(this.Tab.TabPages[e.Index].Text, e.Font, Brushes.White, e.Bounds.Left + 1, e.Bounds.Top + 5);



            e.DrawFocusRectangle();
        }

        private void Tab_MouseDown(object sender, MouseEventArgs e)
        {
            for (int i = 0; i < this.Tab.TabPages.Count; i++)
            {
                Rectangle r = Tab.GetTabRect(i);
                //Getting the position of the “x” mark.
                Rectangle closeButton = new Rectangle(r.Right - 12, r.Top + 6, 10, 10);
                if (closeButton.Contains(e.Location))
                {
                    if (MessageBox.Show("Would you like to Close this Tab ?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        this.Tab.TabPages.RemoveAt(i);
                        break;
                    }
                }
            }
        }

        static int KiemTraTonTai(TabControl TabControlName, string TabName)
        {
            int temp = -1;

            for (int i = 0; i < TabControlName.TabPages.Count; i++)
            {
                if (TabControlName.TabPages[i].Text == TabName)
                {
                    temp = i;
                    break;
                }
            }
            return temp;
        }

        public void TabCreating(TabControl TabControl, string Text, Form Form)
        {

            int Index = KiemTraTonTai(TabControl, Text);
            if (Index >= 0)
            {
                TabControl.SelectedTab = TabControl.TabPages[Index];
                TabControl.SelectedTab.Text = Text;
            }
            else
            {

                TabPage TabPage = new TabPage { Text = Text };
                TabControl.TabPages.Add(TabPage);         
                TabControl.SelectedTab = TabPage;
                Form.TopLevel = false;
                Form.Parent = TabPage;
               //  Form.MdiParent = this;
                Form.Show();
                Form.Dock = DockStyle.Fill;
                
            }

        }

        private void MainForm2_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(flag ==0)
                _login.Close();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Would you like to Exit ?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Close();
            }
        }

        private void buttonDoanhThu_Click(object sender, EventArgs e)
        {
            DoanhThu form = new DoanhThu();
            if (!form.check())
            {
                form.Close();
                return;
            }
            TabCreating(Tab, "DoanhThu", form);

        }

        private void buttonManageBe_Click(object sender, EventArgs e)
        {
            ManageBe form = new ManageBe();
            if (!form.check())
            {
                form.Close();
                return;
            }
            TabCreating(Tab, "ManagePond", form);
        }

        private void buttonSick_Click(object sender, EventArgs e)
        {
            ManageBenh form = new ManageBenh();
            if (!form.check())
            {
                form.Close();
                return;
            }
            TabCreating(Tab, "ManageSick", form);
        }

        private void buttonFish_Click(object sender, EventArgs e)
        {
            ManageLua form = new ManageLua();
            if (!form.check())
            {
                form.Close();
                return;
            }
            TabCreating(Tab, "ManageFishes", form);
        }

        private void buttonStore_Click(object sender, EventArgs e)
        {
            ManageKho form = new ManageKho();
            if (!form.check())
            {
                form.Close();
                return;
            }
            TabCreating(Tab, "ManageStore", form);
        }

        private void buttonMananeStaff_Click(object sender, EventArgs e)
        {
            ManageStaff form = new ManageStaff();
            if (!form.check())
            {
                form.Close();
                return;
            }
            form.Show(this);
            TabCreating(Tab, "ManageStaff", form);
        }

        private void labelWelcom_Click(object sender, EventArgs e)
        {

        }
    }
}
