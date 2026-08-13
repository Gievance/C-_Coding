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
    public partial class FrmPanel : Form
    {
        public FrmPanel()
        {
            InitializeComponent();
        }

        private void FrmPanel_Load(object sender, EventArgs e)
        {
            panel7.Controls.Clear();
            for (int i = 0; i < 7; i++)
            {
                CheckBox cb = new CheckBox();
                cb.Text = "按钮" + i.ToString();
                cb.Size = new Size(60, 25);
                cb.Location = new Point(24 + i * 60, 27);
                cb.Anchor = AnchorStyles.Top;
                panel7.Controls.Add(cb);            }
        }
    }
}
