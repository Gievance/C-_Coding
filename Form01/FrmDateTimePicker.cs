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
    public partial class FrmDateTimePicker : Form
    {
        public FrmDateTimePicker()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string dt = dtp1.Value.ToString();
            label4.Text = dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string dt = dtp2.Value.ToString();
            label5.Text = dt;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string dt = dtp3.Value.ToString();
            label6.Text = dt;
        }
    }
}
