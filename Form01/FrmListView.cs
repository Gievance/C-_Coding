using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form01
{
    public partial class FrmListView : Form
    {
        public FrmListView()
        {
            InitializeComponent();
        }

        
        private void FrmListView_Load(object sender, EventArgs e)
        {
            //string path = Directory.GetCurrentDirectory();
            //string curPaht = AppDomain.CurrentDomain.BaseDirectory;
            //if(Directory.Exists(path))
            //{
            //    string[] files = Directory.GetFiles(path);
            //    if (files.Length>0)
            //    {
            //        largelist.Images.Clear();
            //        smallList.Images.Clear();

            //        string[] filetype = { ".jpg", ".png", ".bmp", ".ico" };
            //        int idx = 0;
            //        foreach(string fpath in files)
            //        {
            //            if (filetype.Contains(Path.GetExtension(fpath)))
            //            {
            //                Image img = Image.FromFile(fpath);
            //                string key = Path.GetFileNameWithoutExtension(fpath);
            //                largelist.Images.Add(key, img);
            //                smallList.Images.Add(key, img);

            //                idx++;
            //            }
            //        }
            //    }
            //}
            //lv1.Items.Clear();
            lv1.View = View.LargeIcon;
            btnView1.BackColor = Color.LightYellow;

            // View 绑定
            btnView1.Click += Btnview_Click;
            btnView2.Click += Btnview_Click;
            btnView3.Click += Btnview_Click;
            btnView4.Click += Btnview_Click;
            btnView5.Click += Btnview_Click;

            //lv1.LargeImageList = largelist;
            //lv1.SmallImageList = smallList;

            // Alignment
            // 确定初始 对齐方式
            string align = lv1.Alignment.ToString();
            foreach (RadioButton r in Aligb.Controls.OfType<RadioButton>())
            {
                if(r.Text == align)
                {
                    r.Checked = true;
                }
            }

            // Sorting 
            // 确定初始 排序方式
            string sortway = lv1.Sorting.ToString();
            foreach (RadioButton r in Sortgb.Controls.OfType<RadioButton>())
            {
                if (r.Text == sortway)
                {
                    r.Checked = true;
                }
            }

            AliDefault.CheckedChanged += btnAlign_CheckChange;
            AliTop.CheckedChanged += btnAlign_CheckChange;
            AliLeft.CheckedChanged += btnAlign_CheckChange;
            AliSnaptoGrid.CheckedChanged += btnAlign_CheckChange;

            RbSorta.CheckedChanged += btnSort_CheckChange;
            RbSortd.CheckedChanged += btnSort_CheckChange;
            RbSortn.CheckedChanged += btnSort_CheckChange;
        }

        private void lv1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            lv1.AllowColumnReorder = lv1.AllowColumnReorder == true ? false : true;
            if(lv1.AllowColumnReorder == true)
            {
                button1.BackColor = Color.LightYellow;
            }
            else
            {
                button1.BackColor = Color.White;
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lv1.AllowDrop = lv1.AllowDrop == true ? false : true;

            if (lv1.AllowDrop == true)
            {
                button2.BackColor = Color.LightYellow;
            }
            else
            {
                button2.BackColor = Color.White;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            lv1.AutoArrange = lv1.AutoArrange == true ? false : true;

            if (lv1.AutoArrange == true)
            {
                button3.BackColor = Color.LightYellow;
            }
            else
            {
                button3.BackColor = Color.White;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            lv1.CheckBoxes = lv1.CheckBoxes == true ? false : true;

            if (lv1.CheckBoxes == true)
            {
                button4.BackColor = Color.LightYellow;
            }
            else
            {
                button4.BackColor = Color.White;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            lv1.FullRowSelect = lv1.FullRowSelect == true ? false : true;

            if (lv1.FullRowSelect == true)
            {
                button5.BackColor = Color.LightYellow;
            }
            else
            {
                button5.BackColor = Color.White;
            }
        }

        private void Btnview_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            string view = btn.Text.ToString();
            switch (view)
            {
                case "LargeIcon":
                    lv1.View = View.LargeIcon;
                    break;
                case "SmallIcon":
                    lv1.View = View.SmallIcon;
                    break;
                case "Details":
                    lv1.View = View.Details;
                    break;
                case "List":
                    lv1.View = View.List;
                    break;
                default:
                    lv1.View = View.Tile;
                    break;
            }
            foreach(Button b in PanelViews.Controls.OfType<Button>())
            {
                if(b.Text != view)
                {
                    b.BackColor = Color.White;
                }
                else
                {
                    b.BackColor = Color.LightYellow;
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            lv1.LabelEdit = lv1.LabelEdit == true ? false : true;

            if (lv1.LabelEdit == true)
            {
                button5.BackColor = Color.LightYellow;
            }
            else
            {
                button5.BackColor = Color.White;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            lv1.LabelWrap = lv1.LabelWrap == true ? false : true;

            if (lv1.LabelWrap == true)
            {
                button5.BackColor = Color.LightYellow;
            }
            else
            {
                button5.BackColor = Color.White;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            lv1.MultiSelect = lv1.MultiSelect == true ? false : true;

            if (lv1.MultiSelect == true)
            {
                button5.BackColor = Color.LightYellow;
            }
            else
            {
                button5.BackColor = Color.White;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            lv1.Scrollable = lv1.Scrollable == true ? false : true;

            if (lv1.Scrollable == true)
            {
                button5.BackColor = Color.LightYellow;
            }
            else
            {
                button5.BackColor = Color.White;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            lv1.OwnerDraw = lv1.OwnerDraw == true ? false : true;

            if (lv1.OwnerDraw == true)
            {
                button5.BackColor = Color.LightYellow;
            }
            else
            {
                button5.BackColor = Color.White;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            lv1.GridLines = lv1.GridLines == true ? false : true;

            if (lv1.GridLines == true)
            {
                button5.BackColor = Color.LightYellow;
            }
            else
            {
                button5.BackColor = Color.White;
            }
        }
        private void btnAlign_CheckChange(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            if (rb.Checked)
            {
                string choose = (sender as RadioButton).Text;
                switch (choose)
                {
                    case "Default":
                        lv1.Alignment = ListViewAlignment.Default;
                        break;
                    case "Left":
                        lv1.Alignment = ListViewAlignment.Left;
                        break;
                    case "Top":
                        lv1.Alignment = ListViewAlignment.Top;
                        break;
                    case "SnaptoGrid":
                        lv1.Alignment = ListViewAlignment.SnapToGrid;
                        break;
                    default:
                        lv1.Alignment = ListViewAlignment.Default;
                        break;
                }
            }
          
        }

        private void btnSort_CheckChange(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            if (rb.Checked)
            {
                string choose = rb.Text;
                if (lv1.View == View.LargeIcon || lv1.View == View.SmallIcon || lv1.View == View.Tile)
                {
                    lv1.AutoArrange = false;
                    button3.BackColor = Color.White; // 同步更新按钮3状态（AutoArrange关闭）
                }
                else
                {
                    // Details视图可以保留自动排列
                    lv1.AutoArrange = true;
                    button3.BackColor = Color.LightYellow;
                }

                switch (choose)
                {
                    case "Ascending":
                        lv1.Sorting = SortOrder.Ascending;
                        break;
                    case "Descending":
                        lv1.Sorting = SortOrder.Descending;
                        break;
                    default:
                        lv1.Sorting = SortOrder.Ascending;
                        break;
                }

                lv1.Sort();
            }
            
        }
    }
}
