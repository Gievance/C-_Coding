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
    public partial class FrmRadioButton : Form
    {
        public FrmRadioButton()
        {
            InitializeComponent();
        }

        private void FrmClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("是否继续？","退出提醒",MessageBoxButtons.YesNo)== DialogResult.No)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }

        }
        private void FrmClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
            System.Diagnostics.Process.GetCurrentProcess().Kill();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            
            textBox1.Text = $"性别：{sex} ,角色：{rolename}";
        }

        private void rbtGender_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rbt = sender as RadioButton;
            if (rbt.Checked)
            {
                rolename = rbt.Text;
            }

        }

        private void rbtFemale_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rbtG = sender as RadioButton;
            if (rbtG.Checked)
            {
                sex = rbtG.Text;
            }
        }
        // Args
        private string rolename = "管理员";
        private string sex = "男";

    }
}
