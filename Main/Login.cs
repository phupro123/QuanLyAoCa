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
using DAL;

namespace QLAoCa
{
    public partial class Login : Form
    {
        public string id = "";
        public Login()
        {
            InitializeComponent();
        }
      
        private void Login_Load(object sender, EventArgs e)
        {
            AcceptButton = buttonLogin;
            CancelButton = buttonCancel;
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (textBoxPass.Text.Equals("") || textBoxName.Text.Equals("") || txtServer.Text.Equals(""))
            {
                MessageBox.Show("Empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DBConnect.server = txtServer.Text;
            id = textBoxName.Text;
            DBConnect.user = textBoxName.Text;
            DBConnect.pass = textBoxPass.Text;
            DBConnect conn = new DBConnect();
            if (conn.Connection() == 1)
            {
                MainForm form2 = new MainForm(this);
                this.Hide();
                form2.Show();
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
