namespace Form01
{
    partial class FrmListView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("07", 6);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("06", 5);
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("05", 4);
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem("04", 3);
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem("03", 2);
            System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem("02", 1);
            System.Windows.Forms.ListViewItem listViewItem7 = new System.Windows.Forms.ListViewItem(new string[] {
            "01",
            "jpg",
            "150×150"}, 0);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmListView));
            this.lv1 = new System.Windows.Forms.ListView();
            this.colName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colSize = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.largelist = new System.Windows.Forms.ImageList(this.components);
            this.smallList = new System.Windows.Forms.ImageList(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.btnView1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnView2 = new System.Windows.Forms.Button();
            this.btnView3 = new System.Windows.Forms.Button();
            this.btnView4 = new System.Windows.Forms.Button();
            this.btnView5 = new System.Windows.Forms.Button();
            this.PanelViews = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.Aligb = new System.Windows.Forms.GroupBox();
            this.AliDefault = new System.Windows.Forms.RadioButton();
            this.AliTop = new System.Windows.Forms.RadioButton();
            this.AliLeft = new System.Windows.Forms.RadioButton();
            this.AliSnaptoGrid = new System.Windows.Forms.RadioButton();
            this.Sortgb = new System.Windows.Forms.GroupBox();
            this.RbSortd = new System.Windows.Forms.RadioButton();
            this.RbSorta = new System.Windows.Forms.RadioButton();
            this.button11 = new System.Windows.Forms.Button();
            this.RbSortn = new System.Windows.Forms.RadioButton();
            this.PanelViews.SuspendLayout();
            this.Aligb.SuspendLayout();
            this.Sortgb.SuspendLayout();
            this.SuspendLayout();
            // 
            // lv1
            // 
            this.lv1.AllowColumnReorder = true;
            this.lv1.AutoArrange = false;
            this.lv1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colName,
            this.colType,
            this.colSize});
            this.lv1.HideSelection = false;
            this.lv1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4,
            listViewItem5,
            listViewItem6,
            listViewItem7});
            this.lv1.LargeImageList = this.largelist;
            this.lv1.Location = new System.Drawing.Point(501, 153);
            this.lv1.Name = "lv1";
            this.lv1.Size = new System.Drawing.Size(1085, 654);
            this.lv1.SmallImageList = this.smallList;
            this.lv1.Sorting = System.Windows.Forms.SortOrder.Descending;
            this.lv1.TabIndex = 0;
            this.lv1.UseCompatibleStateImageBehavior = false;
            this.lv1.SelectedIndexChanged += new System.EventHandler(this.lv1_SelectedIndexChanged);
            // 
            // colName
            // 
            this.colName.Text = "图片名称";
            this.colName.Width = 150;
            // 
            // colType
            // 
            this.colType.Text = "图片类型";
            this.colType.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colType.Width = 150;
            // 
            // colSize
            // 
            this.colSize.Text = "图片尺寸";
            this.colSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colSize.Width = 150;
            // 
            // largelist
            // 
            this.largelist.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("largelist.ImageStream")));
            this.largelist.TransparentColor = System.Drawing.Color.Transparent;
            this.largelist.Images.SetKeyName(0, "01.png");
            this.largelist.Images.SetKeyName(1, "01-dy.jpg");
            this.largelist.Images.SetKeyName(2, "01-mm.jpg");
            this.largelist.Images.SetKeyName(3, "02-flower.png");
            this.largelist.Images.SetKeyName(4, "02-sd.jpg");
            this.largelist.Images.SetKeyName(5, "03-hu.jpg");
            this.largelist.Images.SetKeyName(6, "03-xrk.png");
            this.largelist.Images.SetKeyName(7, "04-jh.jpg");
            this.largelist.Images.SetKeyName(8, "04-timg.jpg");
            // 
            // smallList
            // 
            this.smallList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("smallList.ImageStream")));
            this.smallList.TransparentColor = System.Drawing.Color.Transparent;
            this.smallList.Images.SetKeyName(0, "01.png");
            this.smallList.Images.SetKeyName(1, "01-dy.jpg");
            this.smallList.Images.SetKeyName(2, "01-mm.jpg");
            this.smallList.Images.SetKeyName(3, "02-flower.png");
            this.smallList.Images.SetKeyName(4, "02-sd.jpg");
            this.smallList.Images.SetKeyName(5, "03-hu.jpg");
            this.smallList.Images.SetKeyName(6, "03-xrk.png");
            this.smallList.Images.SetKeyName(7, "04-jh.jpg");
            this.smallList.Images.SetKeyName(8, "04-timg.jpg");
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(191, 69);
            this.button1.TabIndex = 1;
            this.button1.Text = "AllowColumnReorder";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 87);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(191, 69);
            this.button2.TabIndex = 2;
            this.button2.Text = "AllowDrop";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 162);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(191, 69);
            this.button3.TabIndex = 3;
            this.button3.Text = "AutoArrage";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(12, 237);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(191, 69);
            this.button4.TabIndex = 4;
            this.button4.Text = "CheckBoxes";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(12, 312);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(191, 69);
            this.button5.TabIndex = 5;
            this.button5.Text = "FullRowSelect";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnView1
            // 
            this.btnView1.Location = new System.Drawing.Point(6, 14);
            this.btnView1.Name = "btnView1";
            this.btnView1.Size = new System.Drawing.Size(156, 42);
            this.btnView1.TabIndex = 6;
            this.btnView1.Text = "LargeIcon";
            this.btnView1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(498, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "Views";
            // 
            // btnView2
            // 
            this.btnView2.Location = new System.Drawing.Point(186, 14);
            this.btnView2.Name = "btnView2";
            this.btnView2.Size = new System.Drawing.Size(156, 42);
            this.btnView2.TabIndex = 8;
            this.btnView2.Text = "SmallIcon";
            this.btnView2.UseVisualStyleBackColor = true;
            // 
            // btnView3
            // 
            this.btnView3.Location = new System.Drawing.Point(361, 14);
            this.btnView3.Name = "btnView3";
            this.btnView3.Size = new System.Drawing.Size(156, 42);
            this.btnView3.TabIndex = 9;
            this.btnView3.Text = "Details";
            this.btnView3.UseVisualStyleBackColor = true;
            // 
            // btnView4
            // 
            this.btnView4.Location = new System.Drawing.Point(540, 14);
            this.btnView4.Name = "btnView4";
            this.btnView4.Size = new System.Drawing.Size(156, 42);
            this.btnView4.TabIndex = 10;
            this.btnView4.Text = "List";
            this.btnView4.UseVisualStyleBackColor = true;
            // 
            // btnView5
            // 
            this.btnView5.Location = new System.Drawing.Point(719, 14);
            this.btnView5.Name = "btnView5";
            this.btnView5.Size = new System.Drawing.Size(156, 42);
            this.btnView5.TabIndex = 11;
            this.btnView5.Text = "Tile";
            this.btnView5.UseVisualStyleBackColor = true;
            // 
            // PanelViews
            // 
            this.PanelViews.Controls.Add(this.btnView5);
            this.PanelViews.Controls.Add(this.btnView4);
            this.PanelViews.Controls.Add(this.btnView3);
            this.PanelViews.Controls.Add(this.btnView2);
            this.PanelViews.Controls.Add(this.btnView1);
            this.PanelViews.Location = new System.Drawing.Point(501, 33);
            this.PanelViews.Name = "PanelViews";
            this.PanelViews.Size = new System.Drawing.Size(883, 66);
            this.PanelViews.TabIndex = 12;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(12, 387);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(191, 69);
            this.button6.TabIndex = 13;
            this.button6.Text = "LabelEdit";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(12, 462);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(191, 69);
            this.button7.TabIndex = 14;
            this.button7.Text = "LabelWrap";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(12, 537);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(191, 69);
            this.button8.TabIndex = 15;
            this.button8.Text = "MultiSelect";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(12, 612);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(191, 69);
            this.button9.TabIndex = 16;
            this.button9.Text = "Scrollable";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(12, 687);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(191, 69);
            this.button10.TabIndex = 17;
            this.button10.Text = "OwnerDraw";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // Aligb
            // 
            this.Aligb.Controls.Add(this.AliSnaptoGrid);
            this.Aligb.Controls.Add(this.AliLeft);
            this.Aligb.Controls.Add(this.AliTop);
            this.Aligb.Controls.Add(this.AliDefault);
            this.Aligb.Location = new System.Drawing.Point(209, 12);
            this.Aligb.Name = "Aligb";
            this.Aligb.Size = new System.Drawing.Size(265, 162);
            this.Aligb.TabIndex = 19;
            this.Aligb.TabStop = false;
            this.Aligb.Text = "Alignment";
            // 
            // AliDefault
            // 
            this.AliDefault.AutoSize = true;
            this.AliDefault.Location = new System.Drawing.Point(63, 35);
            this.AliDefault.Name = "AliDefault";
            this.AliDefault.Size = new System.Drawing.Size(96, 22);
            this.AliDefault.TabIndex = 0;
            this.AliDefault.TabStop = true;
            this.AliDefault.Text = "Default";
            this.AliDefault.UseVisualStyleBackColor = true;
            // 
            // AliTop
            // 
            this.AliTop.AutoSize = true;
            this.AliTop.Location = new System.Drawing.Point(63, 65);
            this.AliTop.Name = "AliTop";
            this.AliTop.Size = new System.Drawing.Size(60, 22);
            this.AliTop.TabIndex = 1;
            this.AliTop.TabStop = true;
            this.AliTop.Text = "Top";
            this.AliTop.UseVisualStyleBackColor = true;
            // 
            // AliLeft
            // 
            this.AliLeft.AutoSize = true;
            this.AliLeft.Location = new System.Drawing.Point(63, 94);
            this.AliLeft.Name = "AliLeft";
            this.AliLeft.Size = new System.Drawing.Size(69, 22);
            this.AliLeft.TabIndex = 2;
            this.AliLeft.TabStop = true;
            this.AliLeft.Text = "Left";
            this.AliLeft.UseVisualStyleBackColor = true;
            // 
            // AliSnaptoGrid
            // 
            this.AliSnaptoGrid.AutoSize = true;
            this.AliSnaptoGrid.Location = new System.Drawing.Point(63, 126);
            this.AliSnaptoGrid.Name = "AliSnaptoGrid";
            this.AliSnaptoGrid.Size = new System.Drawing.Size(123, 22);
            this.AliSnaptoGrid.TabIndex = 3;
            this.AliSnaptoGrid.TabStop = true;
            this.AliSnaptoGrid.Text = "SnaptoGrid";
            this.AliSnaptoGrid.UseVisualStyleBackColor = true;
            // 
            // Sortgb
            // 
            this.Sortgb.Controls.Add(this.RbSortn);
            this.Sortgb.Controls.Add(this.RbSortd);
            this.Sortgb.Controls.Add(this.RbSorta);
            this.Sortgb.Location = new System.Drawing.Point(209, 180);
            this.Sortgb.Name = "Sortgb";
            this.Sortgb.Size = new System.Drawing.Size(264, 126);
            this.Sortgb.TabIndex = 20;
            this.Sortgb.TabStop = false;
            this.Sortgb.Text = "Sorting";
            // 
            // RbSortd
            // 
            this.RbSortd.AutoSize = true;
            this.RbSortd.Location = new System.Drawing.Point(63, 59);
            this.RbSortd.Name = "RbSortd";
            this.RbSortd.Size = new System.Drawing.Size(123, 22);
            this.RbSortd.TabIndex = 5;
            this.RbSortd.Text = "Descending";
            this.RbSortd.UseVisualStyleBackColor = true;
            // 
            // RbSorta
            // 
            this.RbSorta.AutoSize = true;
            this.RbSorta.Location = new System.Drawing.Point(63, 27);
            this.RbSorta.Name = "RbSorta";
            this.RbSorta.Size = new System.Drawing.Size(114, 22);
            this.RbSorta.TabIndex = 4;
            this.RbSorta.Text = "Ascending";
            this.RbSorta.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(12, 762);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(191, 69);
            this.button11.TabIndex = 21;
            this.button11.Text = "GridLines";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // RbSortn
            // 
            this.RbSortn.AutoSize = true;
            this.RbSortn.Location = new System.Drawing.Point(63, 87);
            this.RbSortn.Name = "RbSortn";
            this.RbSortn.Size = new System.Drawing.Size(69, 22);
            this.RbSortn.TabIndex = 6;
            this.RbSortn.Text = "None";
            this.RbSortn.UseVisualStyleBackColor = true;
            // 
            // FrmListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1677, 901);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.Sortgb);
            this.Controls.Add(this.Aligb);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.PanelViews);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lv1);
            this.Name = "FrmListView";
            this.Text = "FrmListView";
            this.Load += new System.EventHandler(this.FrmListView_Load);
            this.PanelViews.ResumeLayout(false);
            this.Aligb.ResumeLayout(false);
            this.Aligb.PerformLayout();
            this.Sortgb.ResumeLayout(false);
            this.Sortgb.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lv1;
        private System.Windows.Forms.ImageList largelist;
        private System.Windows.Forms.ImageList smallList;
        private System.Windows.Forms.ColumnHeader colName;
        private System.Windows.Forms.ColumnHeader colType;
        private System.Windows.Forms.ColumnHeader colSize;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btnView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnView2;
        private System.Windows.Forms.Button btnView3;
        private System.Windows.Forms.Button btnView4;
        private System.Windows.Forms.Button btnView5;
        private System.Windows.Forms.Panel PanelViews;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.GroupBox Aligb;
        private System.Windows.Forms.RadioButton AliDefault;
        private System.Windows.Forms.RadioButton AliSnaptoGrid;
        private System.Windows.Forms.RadioButton AliLeft;
        private System.Windows.Forms.RadioButton AliTop;
        private System.Windows.Forms.GroupBox Sortgb;
        private System.Windows.Forms.RadioButton RbSortd;
        private System.Windows.Forms.RadioButton RbSorta;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.RadioButton RbSortn;
    }
}