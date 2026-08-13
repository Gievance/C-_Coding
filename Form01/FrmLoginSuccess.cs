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
    public partial class FrmLoginSuccess : Form
    {
        public FrmLoginSuccess()
        {   
            InitializeComponent();
        }
        public FrmLoginSuccess(string uname)
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;

            this.Text = uname+"欢迎您";
            lbUname.Text = uname + "欢迎您";
        }
    }
}
