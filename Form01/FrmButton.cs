using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form01
{
    public partial class FrmButton : Form
    {
        public FrmButton()
        {
            InitializeComponent();
        }
        

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string getUname = txtUname.Text.Trim();
            string getPassd = txtPassd.Text.Trim();
            if (getUname.Equals(uname) && getPassd.Equals(passd))
            {
                FrmLoginSuccess pageSuccess = new FrmLoginSuccess(uname);
                pageSuccess.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("不正确，请重新输入");
            }

        }


        // 预留账户+密码
        string uname = "admin";
        string passd = "123456";

        private void FrmClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("是否继续","退出界面",MessageBoxButtons.YesNo)==DialogResult.Yes)
            {
                e.Cancel = true;
            }
            else
            {
                e.Cancel = false;
            }
        }

        private void FrmClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
            System.Diagnostics.Process.GetCurrentProcess().Kill();
        }
    }
}
