using Form01.Models;
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
    public partial class FrmCheckedListBox : Form
    {
        public FrmCheckedListBox()
        {
            InitializeComponent();
        }
        private List<ClassInfo> ci = new List<ClassInfo>();
        private void FrmCheckedListBox_Load(object sender, EventArgs e)
        {
            ci.Add(new ClassInfo() { ClassId = 10101, ClassName = "2021-01班"});
            ci.Add(new ClassInfo() { ClassId = 10102, ClassName = "2021-02班"});
            ci.Add(new ClassInfo() { ClassId = 10103, ClassName = "2021-03班"});

            ci.Add(new ClassInfo() { ClassId = 10104, ClassName = "2022-01班"});
            ci.Add(new ClassInfo() { ClassId = 10105, ClassName = "2022-02班"});
            ci.Add(new ClassInfo() { ClassId = 10106, ClassName = "2022-03班"});

            ci.Add(new ClassInfo() { ClassId = 10107, ClassName = "2023-01班"});
            ci.Add(new ClassInfo() { ClassId = 10108, ClassName = "2023-02班"});
            ci.Add(new ClassInfo() { ClassId = 10109, ClassName = "2023-03班"});

            ci.Add(new ClassInfo() { ClassId = 10110, ClassName = "2024-01班"});
            ci.Add(new ClassInfo() { ClassId = 10111, ClassName = "2024-02班"});
            ci.Add(new ClassInfo() { ClassId = 10112, ClassName = "2024-03班"});

            ci.Add(new ClassInfo() { ClassId = 10113, ClassName = "2025-01班"});
            ci.Add(new ClassInfo() { ClassId = 10114, ClassName = "2025-02班"});
            ci.Add(new ClassInfo() { ClassId = 10115, ClassName = "2025-03班"});

            ci.Add(new ClassInfo() { ClassId = 10116, ClassName = "2026-01班"});
            ci.Add(new ClassInfo() { ClassId = 10117, ClassName = "2026-02班"});
            ci.Add(new ClassInfo() { ClassId = 10118, ClassName = "2026-03班"});

            cbx1.DataSource = ci;
            cbx1.DisplayMember = "ClassName";
            cbx1.ValueMember = "ClassId";
            cbx1.SelectedIndex = 0;

            cbx2.DataSource = ci;
            cbx2.DisplayMember = "ClassName";
            cbx2.ValueMember = "ClassId";
            cbx2.SelectedIndex = 0;
        }

        // 复选列表框选 中的项显示在 列表框 中
        private void cbx1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
           string curText = cbx1.GetItemText(cbx1.Items[e.Index]);

           if(e.NewValue ==CheckState.Checked)
            {
                lb1.Items.Add(curText);
            }
            else
            {
                lb1.Items.Remove(curText);
            }
        }


        private void FrmCheckedListBox_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
            System.Diagnostics.Process.GetCurrentProcess().Kill();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if(cbx2.GetItemChecked(0))
            {
                cbx2.SetItemChecked(0, false);
            }
            else
            {
                cbx2.SetItemChecked(0, true);
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(cbx2.GetItemChecked(1))
            {
                cbx2.SetItemCheckState(1, CheckState.Unchecked);
            }
            else
            {

                cbx2.SetItemCheckState(1, CheckState.Checked);
            }
        }



        private void button4_Click(object sender, EventArgs e)
        {
            if (cbx2.GetItemChecked(0))
            {
                label1.Text = "位置 1 选中";
            }
           else
            {
                label1.Text = "位置 1  未选中";
            }
                
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CheckState st = cbx2.GetItemCheckState(1);
            switch (st)
            {
                case CheckState.Checked:
                    label1.Text = "选中";
                    break;
                case CheckState.Unchecked:
                    label1.Text = "未选中";
                    break;
                default:
                    label1.Text = "异常";
                    break;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // 获取选中对象
            var ob = cbx2.SelectedItem as ClassInfo;
            // 获取选中项的 文本
            string obt = cbx2.GetItemText(ob);
            label1.Text = obt;
        }
    }
}
