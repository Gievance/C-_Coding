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
    public partial class FrmMonthCalendar : Form
    {
        public FrmMonthCalendar()
        {
            InitializeComponent();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            DateTime start = mcal.SelectionStart;
            DateTime end = mcal.SelectionEnd;

            tb1.Text = start.ToString();
            tb2.Text = end.ToString();
        }

        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            foreach(RadioButton item in panel1.Controls.OfType<RadioButton>())
            {
               if(item.Checked)
               {
                    switch (item.Text)
                    {
                        case "显示":
                            mcal.ShowWeekNumbers = true;
                            break;
                        case "不显示":
                            mcal.ShowWeekNumbers = false;
                            break;
                        default:
                            MessageBox.Show("状态错误");
                            break;
                    }
               }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cb = sender as CheckBox;
            if (cb.Checked)
            {
                mcal.ShowToday = true;
            }
            else
            {
                mcal.ShowToday = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string setRange = tb3.Text;
            int range = 0;
            if (int.TryParse(setRange,out range))
            {
                mcal.MaxSelectionCount = range;
            }
            else
            {
                MessageBox.Show("选择天数格式不正确");
            }
        }

        private void FrmMonthCalendar_Load(object sender, EventArgs e)
        {
            foreach(var item in panel1.Controls.OfType<RadioButton>())
            {
                if (item.Text == "显示")
                {
                    mcal.ShowWeekNumbers = true;
                }
            }

            foreach (var item in panel2.Controls.OfType<RadioButton>())
            {
                if (item.Checked)
                {
                    mcal.FirstDayOfWeek = (Day)Enum.Parse(typeof(Day),item.Text);
                }
            }

            days.Add(Day.Monday);
            days.Add(Day.Tuesday);
            days.Add(Day.Wednesday);
            days.Add(Day.Thursday);
            days.Add(Day.Friday);
            days.Add(Day.Saturday);
            days.Add(Day.Sunday);

            lb1.DataSource = days;
            cbx.DataSource = days;
            checklist.DataSource = days;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            if (rb.Checked)
            {
                mcal.FirstDayOfWeek = (Day)Enum.Parse(typeof(Day), rb.Text);

            }
        }

        private List<Day> days = new List<Day>();

        private void lb1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lb1.SelectedItem!= null)
            {
                string str = lb1.SelectedItem.ToString(); 
                mcal.FirstDayOfWeek = (Day)Enum.Parse(typeof(Day), str);

            }
            
        }

        private void cbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbx.SelectedItem != null)
            {
                string s = cbx.SelectedItem.ToString();
                mcal.FirstDayOfWeek = (Day)Enum.Parse(typeof(Day), s);
            }
        }

        private void checklist_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
