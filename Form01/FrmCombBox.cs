using System;
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
    public partial class FrmCombBox : Form
    {
        public FrmCombBox()
        {
            InitializeComponent();
        }
        private List<GradeInfo> gi = new List<GradeInfo>();
        private List<ClassInfo> ci= new List<ClassInfo>();
        private void FrmCombBox_Load(object sender, EventArgs e)
        {
            gi.Add(new GradeInfo() { GradeId = 0, GradeName = "请选择" });
            gi.Add(new GradeInfo() { GradeId = 101, GradeName = "2021级" });
            gi.Add(new GradeInfo() { GradeId = 102, GradeName = "2022级" });
            gi.Add(new GradeInfo() { GradeId = 103, GradeName = "2023级" });
            gi.Add(new GradeInfo() { GradeId = 104, GradeName = "2024级" });
            gi.Add(new GradeInfo() { GradeId = 105, GradeName = "2025级" });
            gi.Add(new GradeInfo() { GradeId = 106, GradeName = "2026级" });


            ci.Add(new ClassInfo() { ClassId = 10101, ClassName = "2021-01班",GradeId=101 });
            ci.Add(new ClassInfo() { ClassId = 10102, ClassName = "2021-02班", GradeId = 101 });
            ci.Add(new ClassInfo() { ClassId = 10103, ClassName = "2021-03班", GradeId = 101 });

            ci.Add(new ClassInfo() { ClassId = 10104, ClassName = "2022-01班", GradeId = 102 });
            ci.Add(new ClassInfo() { ClassId = 10105, ClassName = "2022-02班", GradeId = 102 });
            ci.Add(new ClassInfo() { ClassId = 10106, ClassName = "2022-03班", GradeId = 102 });

            ci.Add(new ClassInfo() { ClassId = 10107, ClassName = "2023-01班", GradeId = 103 });
            ci.Add(new ClassInfo() { ClassId = 10108, ClassName = "2023-02班", GradeId = 103 });
            ci.Add(new ClassInfo() { ClassId = 10109, ClassName = "2023-03班", GradeId = 103 });

            ci.Add(new ClassInfo() { ClassId = 10110, ClassName = "2024-01班", GradeId = 104 });
            ci.Add(new ClassInfo() { ClassId = 10111, ClassName = "2024-02班", GradeId = 104 });
            ci.Add(new ClassInfo() { ClassId = 10112, ClassName = "2024-03班", GradeId = 104 });

            ci.Add(new ClassInfo() { ClassId = 10113, ClassName = "2025-01班", GradeId = 105 });
            ci.Add(new ClassInfo() { ClassId = 10114, ClassName = "2025-02班", GradeId = 105 });
            ci.Add(new ClassInfo() { ClassId = 10115, ClassName = "2025-03班", GradeId = 105 });

            ci.Add(new ClassInfo() { ClassId = 10116, ClassName = "2026-01班", GradeId = 106 });
            ci.Add(new ClassInfo() { ClassId = 10117, ClassName = "2026-02班", GradeId = 106 });
            ci.Add(new ClassInfo() { ClassId = 10118, ClassName = "2026-03班", GradeId = 106 });
            //ci.Insert(0, new ClassInfo() { ClassId = 0, ClassName = "请选择", GradeId = 0 });

            comboBox1.DisplayMember = "GradeName";
            comboBox1.ValueMember = "GradeId";
            comboBox1.DataSource = gi;
            comboBox1.SelectedIndex = 0;

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // 获取选中的班级列表 
            int gradeid = Convert.ToInt32(comboBox1.SelectedValue);
            //注意清空DataSource
            comboBox2.DataSource = null;

            List<ClassInfo> cls = ci.Where(c => c.GradeId == gradeid).ToList();
            if (cls.Count > 0)
            {

                cls.Insert(0, new ClassInfo() { ClassId = 0, ClassName = "请选择", GradeId = 0 });

            }
            else
            {
                cls.Insert(0, new ClassInfo() { ClassId = 0, ClassName = "请选择", GradeId = 0 });
            }
            comboBox2.DisplayMember = "ClassName";
            comboBox2.ValueMember = "ClassId";
            comboBox2.DataSource = cls;
        }
    }
}
