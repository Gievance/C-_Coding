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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Button btn = new Button();

        private void Form1_Load(object sender, EventArgs e)
        {
            btn.Location = new Point(157, 76);
            btn.Size = new Size(70, 30);
            btn.Name = "btn";
            btn.Text = "点击";
            btn.Click += Btn_Click;

            this.Controls.Add(btn);
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("OK");
        }
    }
}
