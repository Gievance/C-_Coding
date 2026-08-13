namespace Form01
{
    partial class FrmRadioButton
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rbtMale = new System.Windows.Forms.RadioButton();
            this.rbtFemale = new System.Windows.Forms.RadioButton();
            this.rbtR1 = new System.Windows.Forms.RadioButton();
            this.rbtR2 = new System.Windows.Forms.RadioButton();
            this.rbtR3 = new System.Windows.Forms.RadioButton();
            this.rbtR4 = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "性别：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "角色：";
            // 
            // rbtMale
            // 
            this.rbtMale.AutoSize = true;
            this.rbtMale.Checked = true;
            this.rbtMale.Location = new System.Drawing.Point(6, 13);
            this.rbtMale.Name = "rbtMale";
            this.rbtMale.Size = new System.Drawing.Size(51, 22);
            this.rbtMale.TabIndex = 1;
            this.rbtMale.TabStop = true;
            this.rbtMale.Text = "男";
            this.rbtMale.UseVisualStyleBackColor = true;
            this.rbtMale.CheckedChanged += new System.EventHandler(this.rbtFemale_CheckedChanged);
            // 
            // rbtFemale
            // 
            this.rbtFemale.AutoSize = true;
            this.rbtFemale.Location = new System.Drawing.Point(102, 13);
            this.rbtFemale.Name = "rbtFemale";
            this.rbtFemale.Size = new System.Drawing.Size(51, 22);
            this.rbtFemale.TabIndex = 2;
            this.rbtFemale.Text = "女";
            this.rbtFemale.UseVisualStyleBackColor = true;
            this.rbtFemale.CheckedChanged += new System.EventHandler(this.rbtFemale_CheckedChanged);
            // 
            // rbtR1
            // 
            this.rbtR1.AutoSize = true;
            this.rbtR1.Checked = true;
            this.rbtR1.Location = new System.Drawing.Point(5, 18);
            this.rbtR1.Name = "rbtR1";
            this.rbtR1.Size = new System.Drawing.Size(87, 22);
            this.rbtR1.TabIndex = 3;
            this.rbtR1.TabStop = true;
            this.rbtR1.Text = "管理员";
            this.rbtR1.UseVisualStyleBackColor = true;
            this.rbtR1.CheckedChanged += new System.EventHandler(this.rbtGender_CheckedChanged);
            // 
            // rbtR2
            // 
            this.rbtR2.AutoSize = true;
            this.rbtR2.Location = new System.Drawing.Point(119, 18);
            this.rbtR2.Name = "rbtR2";
            this.rbtR2.Size = new System.Drawing.Size(87, 22);
            this.rbtR2.TabIndex = 4;
            this.rbtR2.Text = "采购员";
            this.rbtR2.UseVisualStyleBackColor = true;
            this.rbtR2.CheckedChanged += new System.EventHandler(this.rbtGender_CheckedChanged);
            // 
            // rbtR3
            // 
            this.rbtR3.AutoSize = true;
            this.rbtR3.Location = new System.Drawing.Point(230, 18);
            this.rbtR3.Name = "rbtR3";
            this.rbtR3.Size = new System.Drawing.Size(87, 22);
            this.rbtR3.TabIndex = 5;
            this.rbtR3.Text = "销售员";
            this.rbtR3.UseVisualStyleBackColor = true;
            this.rbtR3.CheckedChanged += new System.EventHandler(this.rbtGender_CheckedChanged);
            // 
            // rbtR4
            // 
            this.rbtR4.AutoSize = true;
            this.rbtR4.Location = new System.Drawing.Point(347, 18);
            this.rbtR4.Name = "rbtR4";
            this.rbtR4.Size = new System.Drawing.Size(105, 22);
            this.rbtR4.TabIndex = 6;
            this.rbtR4.Text = "销售主管";
            this.rbtR4.UseVisualStyleBackColor = true;
            this.rbtR4.CheckedChanged += new System.EventHandler(this.rbtGender_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbtFemale);
            this.panel1.Controls.Add(this.rbtMale);
            this.panel1.Location = new System.Drawing.Point(171, 81);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(192, 51);
            this.panel1.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rbtR4);
            this.panel2.Controls.Add(this.rbtR3);
            this.panel2.Controls.Add(this.rbtR2);
            this.panel2.Controls.Add(this.rbtR1);
            this.panel2.Location = new System.Drawing.Point(171, 174);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(457, 63);
            this.panel2.TabIndex = 8;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(172, 274);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(413, 50);
            this.textBox1.TabIndex = 9;
            // 
            // btnConfirm
            // 
            this.btnConfirm.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnConfirm.Location = new System.Drawing.Point(171, 356);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(143, 58);
            this.btnConfirm.TabIndex = 10;
            this.btnConfirm.Text = "确认";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btn_Click);
            // 
            // FrmRadioButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1274, 647);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmRadioButton";
            this.Text = "FrmRadioButton";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbtMale;
        private System.Windows.Forms.RadioButton rbtFemale;
        private System.Windows.Forms.RadioButton rbtR1;
        private System.Windows.Forms.RadioButton rbtR2;
        private System.Windows.Forms.RadioButton rbtR3;
        private System.Windows.Forms.RadioButton rbtR4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnConfirm;
    }
}