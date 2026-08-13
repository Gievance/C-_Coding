namespace Form01
{
    partial class FrmCheckBox
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.cb1 = new System.Windows.Forms.CheckBox();
            this.cb2 = new System.Windows.Forms.CheckBox();
            this.cb3 = new System.Windows.Forms.CheckBox();
            this.cb4 = new System.Windows.Forms.CheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.tb1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb3 = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.submit = new System.Windows.Forms.Button();
            this.tb4 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "两种状态：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "职位：";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(30, 17);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(70, 22);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "正常";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Location = new System.Drawing.Point(128, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(182, 54);
            this.panel1.TabIndex = 3;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // cb1
            // 
            this.cb1.AutoSize = true;
            this.cb1.Location = new System.Drawing.Point(29, 12);
            this.cb1.Name = "cb1";
            this.cb1.Size = new System.Drawing.Size(88, 22);
            this.cb1.TabIndex = 4;
            this.cb1.Text = "管理员";
            this.cb1.UseVisualStyleBackColor = true;
            this.cb1.CheckedChanged += new System.EventHandler(this.posCheckChanged);
            // 
            // cb2
            // 
            this.cb2.AutoSize = true;
            this.cb2.Location = new System.Drawing.Point(141, 12);
            this.cb2.Name = "cb2";
            this.cb2.Size = new System.Drawing.Size(70, 22);
            this.cb2.TabIndex = 5;
            this.cb2.Text = "经理";
            this.cb2.UseVisualStyleBackColor = true;
            this.cb2.CheckedChanged += new System.EventHandler(this.posCheckChanged);
            // 
            // cb3
            // 
            this.cb3.AutoSize = true;
            this.cb3.Location = new System.Drawing.Point(235, 12);
            this.cb3.Name = "cb3";
            this.cb3.Size = new System.Drawing.Size(88, 22);
            this.cb3.TabIndex = 6;
            this.cb3.Text = "销售员";
            this.cb3.UseVisualStyleBackColor = true;
            this.cb3.CheckedChanged += new System.EventHandler(this.posCheckChanged);
            // 
            // cb4
            // 
            this.cb4.AutoSize = true;
            this.cb4.Location = new System.Drawing.Point(345, 12);
            this.cb4.Name = "cb4";
            this.cb4.Size = new System.Drawing.Size(88, 22);
            this.cb4.TabIndex = 7;
            this.cb4.Text = "采购员";
            this.cb4.UseVisualStyleBackColor = true;
            this.cb4.CheckedChanged += new System.EventHandler(this.posCheckChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cb4);
            this.panel2.Controls.Add(this.cb3);
            this.panel2.Controls.Add(this.cb2);
            this.panel2.Controls.Add(this.cb1);
            this.panel2.Location = new System.Drawing.Point(129, 133);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(466, 49);
            this.panel2.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 236);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 18);
            this.label3.TabIndex = 9;
            this.label3.Text = "两种：";
            // 
            // tb1
            // 
            this.tb1.Location = new System.Drawing.Point(130, 214);
            this.tb1.Multiline = true;
            this.tb1.Name = "tb1";
            this.tb1.Size = new System.Drawing.Size(180, 71);
            this.tb1.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 324);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 18);
            this.label4.TabIndex = 11;
            this.label4.Text = "职业选择：";
            // 
            // tb3
            // 
            this.tb3.Location = new System.Drawing.Point(130, 300);
            this.tb3.Multiline = true;
            this.tb3.Name = "tb3";
            this.tb3.Size = new System.Drawing.Size(465, 71);
            this.tb3.TabIndex = 12;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.checkBox2);
            this.panel3.Location = new System.Drawing.Point(414, 41);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(182, 54);
            this.panel3.TabIndex = 5;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(60, 17);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(70, 22);
            this.checkBox2.TabIndex = 2;
            this.checkBox2.Text = "正常";
            this.checkBox2.ThreeState = true;
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckStateChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(316, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "三种状态：";
            // 
            // tb2
            // 
            this.tb2.Location = new System.Drawing.Point(414, 214);
            this.tb2.Multiline = true;
            this.tb2.Name = "tb2";
            this.tb2.Size = new System.Drawing.Size(180, 71);
            this.tb2.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(344, 236);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 18);
            this.label6.TabIndex = 13;
            this.label6.Text = "三种：";
            // 
            // submit
            // 
            this.submit.Location = new System.Drawing.Point(130, 385);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(201, 53);
            this.submit.TabIndex = 15;
            this.submit.Text = "提交";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // tb4
            // 
            this.tb4.Location = new System.Drawing.Point(131, 510);
            this.tb4.Multiline = true;
            this.tb4.Name = "tb4";
            this.tb4.Size = new System.Drawing.Size(465, 71);
            this.tb4.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoEllipsis = true;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 479);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(215, 18);
            this.label7.TabIndex = 16;
            this.label7.Text = "职业选择(Pos列表内容)：";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FrmCheckBox
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 620);
            this.Controls.Add(this.tb4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.tb2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmCheckBox";
            this.Text = "FrmCheckBox";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmClosed);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.CheckBox cb1;
        private System.Windows.Forms.CheckBox cb2;
        private System.Windows.Forms.CheckBox cb3;
        private System.Windows.Forms.CheckBox cb4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.TextBox tb4;
        private System.Windows.Forms.Label label7;
    }
}