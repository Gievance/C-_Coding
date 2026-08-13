namespace Form01
{
    partial class FrmLoginSuccess
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
            this.lbUname = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbUname
            // 
            this.lbUname.AutoSize = true;
            this.lbUname.Location = new System.Drawing.Point(351, 203);
            this.lbUname.Name = "lbUname";
            this.lbUname.Size = new System.Drawing.Size(62, 18);
            this.lbUname.TabIndex = 0;
            this.lbUname.Text = "label1";
            // 
            // FrmLoginSuccess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbUname);
            this.Name = "FrmLoginSuccess";
            this.Text = "欢迎您";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbUname;
    }
}