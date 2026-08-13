namespace 并行计算框架
{
    partial class FrmTPL_Corrected
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
            this.lbInfo = new System.Windows.Forms.Label();
            this.tbInfo = new System.Windows.Forms.TextBox();
            this.btn_Stop = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbInfo
            // 
            this.lbInfo.AutoSize = true;
            this.lbInfo.Font = new System.Drawing.Font("宋体", 14F);
            this.lbInfo.Location = new System.Drawing.Point(479, 48);
            this.lbInfo.Name = "lbInfo";
            this.lbInfo.Size = new System.Drawing.Size(124, 28);
            this.lbInfo.TabIndex = 7;
            this.lbInfo.Text = "状态信息";
            // 
            // tbInfo
            // 
            this.tbInfo.Location = new System.Drawing.Point(474, 86);
            this.tbInfo.Multiline = true;
            this.tbInfo.Name = "tbInfo";
            this.tbInfo.Size = new System.Drawing.Size(736, 612);
            this.tbInfo.TabIndex = 6;
            // 
            // btn_Stop
            // 
            this.btn_Stop.Font = new System.Drawing.Font("宋体", 14F);
            this.btn_Stop.Location = new System.Drawing.Point(137, 233);
            this.btn_Stop.Name = "btn_Stop";
            this.btn_Stop.Size = new System.Drawing.Size(285, 109);
            this.btn_Stop.TabIndex = 5;
            this.btn_Stop.Text = "停止计算";
            this.btn_Stop.UseVisualStyleBackColor = true;
            this.btn_Stop.Click += new System.EventHandler(this.btn_Stop_Click);
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("宋体", 14F);
            this.btnStart.Location = new System.Drawing.Point(137, 82);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(285, 109);
            this.btnStart.TabIndex = 4;
            this.btnStart.Text = "开始并行计算";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // FrmTPL_Corrected
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1346, 747);
            this.Controls.Add(this.lbInfo);
            this.Controls.Add(this.tbInfo);
            this.Controls.Add(this.btn_Stop);
            this.Controls.Add(this.btnStart);
            this.Name = "FrmTPL_Corrected";
            this.Text = "FrmTPL_Corrected";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbInfo;
        private System.Windows.Forms.TextBox tbInfo;
        private System.Windows.Forms.Button btn_Stop;
        private System.Windows.Forms.Button btnStart;
    }
}