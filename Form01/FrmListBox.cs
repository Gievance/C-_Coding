using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Form01.Models;
namespace Form01
{
    public partial class FrmListBox : Form
    {
        public FrmListBox()
        {
            InitializeComponent();

        }
        private List<BookInfo> bk;
        private ArrayList bk2;

        private void FrmListBox_Load(object sender, EventArgs e)
        {
            // 创建创建List数据
            stu = new List<Student>();
            stu.Add(new Student() {SId=1,SName="王树海",SClass="C#" });
            stu.Add(new Student() { SId = 1, SName = "赵又廷", SClass = "C#" });
            stu.Add(new Student() { SId = 1, SName = "石莹", SClass = "Java" });
            stu.Add(new Student() { SId = 1, SName = "祁海", SClass = "C#" });
            stu.Add(new Student() { SId = 1, SName = "夏七七", SClass = "C#" });
            
            
            foreach (Student s in stu)
            {
                lbx1.Items.Add(s.SName); // 对象保存在bk,Items存字符串(bookName)
            }

            bk = new List<BookInfo>();
            bk.Add(new BookInfo() { bookId = 1, bookName = "101 书架" });
            bk.Add(new BookInfo() { bookId = 2, bookName = "102 书架" });
            bk.Add(new BookInfo() { bookId = 3, bookName = "103 书架" });
            bk.Add(new BookInfo() { bookId = 4, bookName = "104 书架" });
            bk.Add(new BookInfo() { bookId = 5, bookName = "105 书架" });
            bk.Add(new BookInfo() { bookId = 6, bookName = "106 书架" });
            bk.Add(new BookInfo() { bookId = 7, bookName = "107 书架" });
            bk.Add(new BookInfo() { bookId = 8, bookName = "108 书架" });
            bk.Add(new BookInfo() { bookId = 9, bookName = "109 书架" });

            lbx3.DataSource = bk;
            lbx3.DisplayMember = "bookName";
            lbx3.ValueMember = "bookId";

            bk2 = new ArrayList();
           
            bk2.Add(new BookInfo() { bookId = 1, bookName = "201 书架" });
            bk2.Add(new BookInfo() { bookId = 2, bookName = "202 书架" });
            bk2.Add(new BookInfo() { bookId = 3, bookName = "203 书架" });
            bk2.Add(new BookInfo() { bookId = 4, bookName = "204 书架" });
            bk2.Add(new BookInfo() { bookId = 5, bookName = "205 书架" });
            bk2.Add(new BookInfo() { bookId = 6, bookName = "206 书架" });
            bk2.Add(new BookInfo() { bookId = 7, bookName = "207 书架" });
            bk2.Add(new BookInfo() { bookId = 8, bookName = "208 书架" });
            bk2.Add(new BookInfo() { bookId = 9, bookName = "209 书架" });

            lbx4.DataSource = bk2;
            lbx4.DisplayMember = "bookName";
            lbx4.ValueMember = "bookId";
        }
        private List<Student> stu;
        private void btnleft_Click(object sender, EventArgs e)
        {
            if(lbx1.SelectedItems != null)
            {

                var list = new List<object>();
                foreach (var item in lbx1.SelectedItems)
                {
                    list.Add(item);
                }
                foreach (var item in list)
                {
                    lbx2.Items.Add(item);
                    lbx1.Items.Remove(item);
                }
            }
        }

        private void btnleft2_Click(object sender, EventArgs e)
        {
            lbx2.Items.AddRange(lbx1.Items);
            lbx1.Items.Clear();
        }

        // 程序退出

        private void btnright_Click(object sender, EventArgs e)
        {
            if(lbx2.SelectedItems != null)
            {
                var list = new List<object>();
                foreach(var item in lbx2.SelectedItems)
                {
                    list.Add(item);
                }
                foreach (var item in list)
                {
                    lbx1.Items.Add(item);
                    lbx2.Items.Remove(item);
                }
            }
        }

        private void btnrigh2_Click(object sender, EventArgs e)
        {
            lbx1.Items.AddRange(lbx2.Items);
            lbx2.Items.Clear();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            lbDisplay.Text = "您好!";
            // 判断是否存在选中项
            if (lbx2.SelectedItems.Count > 0)
            {
                foreach (var item in lbx2.SelectedItems)
                {
                    lbDisplay.Text += item.ToString() + ",";
                }
            }
            else
            {
                // 无选中，输出全部项
                foreach (var item in lbx2.Items)
                {
                    lbDisplay.Text += item.ToString() + ",";
                }
            }

        }
        
        private void lbx3_SelectedIndexChanged(object sender, EventArgs e)
        {
            BookInfo book = lbx3.SelectedItem as BookInfo;
            label4.Text = $"编号：{book.bookId} 名称：{book.bookName}";

        }

        
        private void lbx4_SelectedIndexChanged(object sender, EventArgs e)
        {
            BookInfo book = lbx4.SelectedItem as BookInfo;
            label5.Text = $"编号：{book.bookId} 名称：{book.bookName}";
        }
        private void FrmListBox_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("是否退出？", "提醒", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void FrmListBox_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
            System.Diagnostics.Process.GetCurrentProcess().Kill();
        }

    }
}
