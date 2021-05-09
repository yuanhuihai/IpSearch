namespace IpSearch
{
    partial class Form1
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
            this.onlineList = new System.Windows.Forms.ListBox();
            this.offlineList = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // onlineList
            // 
            this.onlineList.FormattingEnabled = true;
            this.onlineList.ItemHeight = 12;
            this.onlineList.Location = new System.Drawing.Point(21, 27);
            this.onlineList.Name = "onlineList";
            this.onlineList.Size = new System.Drawing.Size(207, 412);
            this.onlineList.TabIndex = 0;
            // 
            // offlineList
            // 
            this.offlineList.FormattingEnabled = true;
            this.offlineList.ItemHeight = 12;
            this.offlineList.Location = new System.Drawing.Point(426, 27);
            this.offlineList.Name = "offlineList";
            this.offlineList.Size = new System.Drawing.Size(207, 412);
            this.offlineList.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(258, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.offlineList);
            this.Controls.Add(this.onlineList);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox onlineList;
        private System.Windows.Forms.ListBox offlineList;
        private System.Windows.Forms.Label label1;
    }
}

