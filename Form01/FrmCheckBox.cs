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
    public partial class FrmCheckBox : Form
    {
        public FrmCheckBox()
        {
            InitializeComponent();

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cb = sender as CheckBox;
            tb1.Text = cb.Checked ? "状态：正常" : "状态：异常";
        }



        private void FrmClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
            System.Diagnostics.Process.GetCurrentProcess().Kill();
        }

        private void FrmClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("是否继续？","提醒",MessageBoxButtons.YesNo)==DialogResult.Yes)
            {
                e.Cancel = true;
            }
            else
            {
                e.Cancel = false;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cb = sender as CheckBox;
            switch (cb.CheckState)
            {
                case CheckState.Checked:
                    tb2.Text = "状态：正常";
                    break;
                case CheckState.Unchecked:
                    tb2.Text = "状态：异常";
                    break;
                case CheckState.Indeterminate:
                    tb2.Text = "状态：中间";
                    break;

            };


        }

        private void submit_Click(object sender, EventArgs e)
        {
            foreach(CheckBox c in panel2.Controls.OfType<CheckBox>().Where(r => r.Checked))
            {
                if (!pos.Contains(c.Text))
                {
                    pos.Add(c.Text);
                }
                
            }
            tb3.Text = string.Join(",", pos);
        }
        private List<string> pos = new List<string>();

        private void posCheckChanged(object sender, EventArgs e)
        {
            CheckBox cb = sender as CheckBox;
            if (cb.Checked)
            {
                if (!pos.Contains(cb.Text))
                {
                    pos.Add(cb.Text);
                }
            }
            else
            {
                if (pos.Contains(cb.Text))
                {
                    pos.Remove(cb.Text);
                }
                

            }
            tb4.Text = string.Join(",", pos);
        }
    }
}
