namespace Form01
{
    partial class FrmButton
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
            this.btn01 = new System.Windows.Forms.Button();
            this.lb01 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtUname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPassd = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn01
            // 
            this.btn01.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn01.Location = new System.Drawing.Point(174, 74);
            this.btn01.Name = "btn01";
            this.btn01.Size = new System.Drawing.Size(122, 58);
            this.btn01.TabIndex = 1;
            this.btn01.Text = "文字";
            this.btn01.UseVisualStyleBackColor = true;
            // 
            // lb01
            // 
            this.lb01.AutoSize = true;
            this.lb01.Location = new System.Drawing.Point(12, 94);
            this.lb01.Name = "lb01";
            this.lb01.Size = new System.Drawing.Size(134, 18);
            this.lb01.TabIndex = 0;
            this.lb01.Text = "不同类型的按钮";
            // 
            // button1
            // 
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.ImageKey = "(无)";
            this.button1.Location = new System.Drawing.Point(330, 74);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 58);
            this.button1.TabIndex = 2;
            this.button1.Text = "文字+图片";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.ImageKey = "(无)";
            this.button2.Location = new System.Drawing.Point(525, 74);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(123, 58);
            this.button2.TabIndex = 3;
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 221);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "具有功能的按钮";
            // 
            // btnLogin
            // 
            this.btnLogin.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnLogin.Location = new System.Drawing.Point(330, 330);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(122, 58);
            this.btnLogin.TabIndex = 9;
            this.btnLogin.Text = "登录";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtUname
            // 
            this.txtUname.Location = new System.Drawing.Point(294, 218);
            this.txtUname.Name = "txtUname";
            this.txtUname.Size = new System.Drawing.Size(266, 28);
            this.txtUname.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(193, 221);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "用户名：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(193, 270);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "密码：";
            // 
            // txtPassd
            // 
            this.txtPassd.Location = new System.Drawing.Point(294, 267);
            this.txtPassd.Name = "txtPassd";
            this.txtPassd.Size = new System.Drawing.Size(266, 28);
            this.txtPassd.TabIndex = 8;
            // 
            // FrmButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1316, 641);
            this.Controls.Add(this.txtPassd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtUname);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lb01);
            this.Controls.Add(this.btn01);
            this.Name = "FrmButton";
            this.Text = "FrmButton";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn01;
        private System.Windows.Forms.Label lb01;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtUname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPassd;
    }
}