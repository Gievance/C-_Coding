namespace Form01
{
    partial class FrmCheckedListBox
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
            this.cbx1 = new System.Windows.Forms.CheckedListBox();
            this.lb1 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.cbx2 = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbx1
            // 
            this.cbx1.FormattingEnabled = true;
            this.cbx1.Location = new System.Drawing.Point(26, 40);
            this.cbx1.Name = "cbx1";
            this.cbx1.Size = new System.Drawing.Size(267, 154);
            this.cbx1.TabIndex = 0;
            this.cbx1.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.cbx1_ItemCheck);
            // 
            // lb1
            // 
            this.lb1.FormattingEnabled = true;
            this.lb1.ItemHeight = 18;
            this.lb1.Location = new System.Drawing.Point(26, 209);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(267, 148);
            this.lb1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(81, 376);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 58);
            this.button1.TabIndex = 2;
            this.button1.Text = "提交";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(433, 220);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(182, 57);
            this.btn1.TabIndex = 3;
            this.btn1.Text = "SetItemChecked";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(433, 298);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(182, 51);
            this.button2.TabIndex = 4;
            this.button2.Text = "SetItemCheckState";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(621, 298);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(173, 51);
            this.button3.TabIndex = 7;
            this.button3.Text = "GetItemCheckState";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(621, 220);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(173, 57);
            this.button4.TabIndex = 6;
            this.button4.Text = "GetItemChecked";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(621, 376);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(173, 51);
            this.button5.TabIndex = 8;
            this.button5.Text = "GetItemText";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // cbx2
            // 
            this.cbx2.FormattingEnabled = true;
            this.cbx2.Location = new System.Drawing.Point(448, 40);
            this.cbx2.Name = "cbx2";
            this.cbx2.Size = new System.Drawing.Size(346, 154);
            this.cbx2.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(828, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 18);
            this.label1.TabIndex = 10;
            this.label1.Text = "显示";
            // 
            // FrmCheckedListBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 489);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbx2);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lb1);
            this.Controls.Add(this.cbx1);
            this.Name = "FrmCheckedListBox";
            this.Text = "FrmCheckedListBox";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmCheckedListBox_FormClosed);
            this.Load += new System.EventHandler(this.FrmCheckedListBox_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox cbx1;
        private System.Windows.Forms.ListBox lb1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.CheckedListBox cbx2;
        private System.Windows.Forms.Label label1;
    }
}