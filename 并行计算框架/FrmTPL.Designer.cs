namespace 并行计算框架
{
    partial class FrmTPL
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnStart = new System.Windows.Forms.Button();
            this.btn_Stop = new System.Windows.Forms.Button();
            this.tbInfo = new System.Windows.Forms.TextBox();
            this.lbInfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("宋体", 14F);
            this.btnStart.Location = new System.Drawing.Point(83, 116);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(285, 109);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "开始并行计算";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btn_Stop
            // 
            this.btn_Stop.Font = new System.Drawing.Font("宋体", 14F);
            this.btn_Stop.Location = new System.Drawing.Point(83, 267);
            this.btn_Stop.Name = "btn_Stop";
            this.btn_Stop.Size = new System.Drawing.Size(285, 109);
            this.btn_Stop.TabIndex = 1;
            this.btn_Stop.Text = "停止计算";
            this.btn_Stop.UseVisualStyleBackColor = true;
            this.btn_Stop.Click += new System.EventHandler(this.btn_Stop_Click);
            // 
            // tbInfo
            // 
            this.tbInfo.Location = new System.Drawing.Point(420, 120);
            this.tbInfo.Multiline = true;
            this.tbInfo.Name = "tbInfo";
            this.tbInfo.Size = new System.Drawing.Size(736, 612);
            this.tbInfo.TabIndex = 2;
            // 
            // lbInfo
            // 
            this.lbInfo.AutoSize = true;
            this.lbInfo.Font = new System.Drawing.Font("宋体", 14F);
            this.lbInfo.Location = new System.Drawing.Point(425, 82);
            this.lbInfo.Name = "lbInfo";
            this.lbInfo.Size = new System.Drawing.Size(124, 28);
            this.lbInfo.TabIndex = 3;
            this.lbInfo.Text = "状态信息";
            // 
            // FrmTPL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1217, 775);
            this.Controls.Add(this.lbInfo);
            this.Controls.Add(this.tbInfo);
            this.Controls.Add(this.btn_Stop);
            this.Controls.Add(this.btnStart);
            this.Name = "FrmTPL";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btn_Stop;
        private System.Windows.Forms.TextBox tbInfo;
        private System.Windows.Forms.Label lbInfo;
    }
}

