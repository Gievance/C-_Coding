namespace Form01
{
    partial class FrmListBox
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
            this.lbx1 = new System.Windows.Forms.ListBox();
            this.lbx2 = new System.Windows.Forms.ListBox();
            this.lbx3 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbx4 = new System.Windows.Forms.ListBox();
            this.lbx5 = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnleft = new System.Windows.Forms.Button();
            this.btnleft2 = new System.Windows.Forms.Button();
            this.btnrigh2 = new System.Windows.Forms.Button();
            this.btnright = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.lbDisplay = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbx1
            // 
            this.lbx1.FormattingEnabled = true;
            this.lbx1.ItemHeight = 18;
            this.lbx1.Location = new System.Drawing.Point(202, 74);
            this.lbx1.Name = "lbx1";
            this.lbx1.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbx1.Size = new System.Drawing.Size(319, 202);
            this.lbx1.TabIndex = 0;
            // 
            // lbx2
            // 
            this.lbx2.FormattingEnabled = true;
            this.lbx2.ItemHeight = 18;
            this.lbx2.Location = new System.Drawing.Point(716, 74);
            this.lbx2.Name = "lbx2";
            this.lbx2.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbx2.Size = new System.Drawing.Size(329, 202);
            this.lbx2.TabIndex = 1;
            // 
            // lbx3
            // 
            this.lbx3.FormattingEnabled = true;
            this.lbx3.ItemHeight = 18;
            this.lbx3.Location = new System.Drawing.Point(202, 322);
            this.lbx3.Name = "lbx3";
            this.lbx3.Size = new System.Drawing.Size(318, 94);
            this.lbx3.TabIndex = 2;
            this.lbx3.SelectedIndexChanged += new System.EventHandler(this.lbx3_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 363);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "数据源1:DS对象";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 504);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "数据源2：DS数组";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 631);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "数据源3：DS数据表";
            // 
            // lbx4
            // 
            this.lbx4.FormattingEnabled = true;
            this.lbx4.ItemHeight = 18;
            this.lbx4.Location = new System.Drawing.Point(202, 461);
            this.lbx4.Name = "lbx4";
            this.lbx4.Size = new System.Drawing.Size(316, 94);
            this.lbx4.TabIndex = 6;
            this.lbx4.SelectedIndexChanged += new System.EventHandler(this.lbx4_SelectedIndexChanged);
            // 
            // lbx5
            // 
            this.lbx5.FormattingEnabled = true;
            this.lbx5.ItemHeight = 18;
            this.lbx5.Location = new System.Drawing.Point(202, 598);
            this.lbx5.Name = "lbx5";
            this.lbx5.Size = new System.Drawing.Size(316, 94);
            this.lbx5.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(539, 363);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "数据源1显示：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(539, 504);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 18);
            this.label5.TabIndex = 9;
            this.label5.Text = "数据源2显示：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(539, 631);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 18);
            this.label6.TabIndex = 10;
            this.label6.Text = "数据源3显示：";
            // 
            // btnleft
            // 
            this.btnleft.Location = new System.Drawing.Point(542, 99);
            this.btnleft.Name = "btnleft";
            this.btnleft.Size = new System.Drawing.Size(59, 51);
            this.btnleft.TabIndex = 11;
            this.btnleft.Text = ">";
            this.btnleft.UseVisualStyleBackColor = true;
            this.btnleft.Click += new System.EventHandler(this.btnleft_Click);
            // 
            // btnleft2
            // 
            this.btnleft2.Location = new System.Drawing.Point(630, 99);
            this.btnleft2.Name = "btnleft2";
            this.btnleft2.Size = new System.Drawing.Size(59, 51);
            this.btnleft2.TabIndex = 12;
            this.btnleft2.Text = ">>";
            this.btnleft2.UseVisualStyleBackColor = true;
            this.btnleft2.Click += new System.EventHandler(this.btnleft2_Click);
            // 
            // btnrigh2
            // 
            this.btnrigh2.Location = new System.Drawing.Point(630, 201);
            this.btnrigh2.Name = "btnrigh2";
            this.btnrigh2.Size = new System.Drawing.Size(59, 51);
            this.btnrigh2.TabIndex = 14;
            this.btnrigh2.Text = "<<";
            this.btnrigh2.UseVisualStyleBackColor = true;
            this.btnrigh2.Click += new System.EventHandler(this.btnrigh2_Click);
            // 
            // btnright
            // 
            this.btnright.Location = new System.Drawing.Point(542, 201);
            this.btnright.Name = "btnright";
            this.btnright.Size = new System.Drawing.Size(59, 51);
            this.btnright.TabIndex = 13;
            this.btnright.Text = "<";
            this.btnright.UseVisualStyleBackColor = true;
            this.btnright.Click += new System.EventHandler(this.btnright_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(1075, 86);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(148, 76);
            this.btnConfirm.TabIndex = 15;
            this.btnConfirm.Text = "确定";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // lbDisplay
            // 
            this.lbDisplay.AutoSize = true;
            this.lbDisplay.Location = new System.Drawing.Point(1116, 234);
            this.lbDisplay.Name = "lbDisplay";
            this.lbDisplay.Size = new System.Drawing.Size(62, 18);
            this.lbDisplay.TabIndex = 16;
            this.lbDisplay.Text = "您好！";
            // 
            // FrmListBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1301, 713);
            this.Controls.Add(this.lbDisplay);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.btnrigh2);
            this.Controls.Add(this.btnright);
            this.Controls.Add(this.btnleft2);
            this.Controls.Add(this.btnleft);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbx5);
            this.Controls.Add(this.lbx4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbx3);
            this.Controls.Add(this.lbx2);
            this.Controls.Add(this.lbx1);
            this.Name = "FrmListBox";
            this.Text = "FrmListBox";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmListBox_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmListBox_FormClosed);
            this.Load += new System.EventHandler(this.FrmListBox_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbx1;
        private System.Windows.Forms.ListBox lbx2;
        private System.Windows.Forms.ListBox lbx3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lbx4;
        private System.Windows.Forms.ListBox lbx5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnleft;
        private System.Windows.Forms.Button btnleft2;
        private System.Windows.Forms.Button btnrigh2;
        private System.Windows.Forms.Button btnright;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Label lbDisplay;
    }
}