namespace HoverTreeSCJ.HTControls
{
    partial class HtUcPages
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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label_per = new System.Windows.Forms.Label();
            this.label_pageIndex = new System.Windows.Forms.Label();
            this.label_pageSize = new System.Windows.Forms.Label();
            this.linkLabel_pre = new System.Windows.Forms.LinkLabel();
            this.linkLabel_next = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label_per
            // 
            this.label_per.AutoSize = true;
            this.label_per.Location = new System.Drawing.Point(227, 16);
            this.label_per.Name = "label_per";
            this.label_per.Size = new System.Drawing.Size(11, 12);
            this.label_per.TabIndex = 0;
            this.label_per.Text = "/";
            // 
            // label_pageIndex
            // 
            this.label_pageIndex.AutoSize = true;
            this.label_pageIndex.Location = new System.Drawing.Point(201, 16);
            this.label_pageIndex.Name = "label_pageIndex";
            this.label_pageIndex.Size = new System.Drawing.Size(11, 12);
            this.label_pageIndex.TabIndex = 1;
            this.label_pageIndex.Text = "1";
            // 
            // label_pageSize
            // 
            this.label_pageSize.AutoSize = true;
            this.label_pageSize.Location = new System.Drawing.Point(249, 16);
            this.label_pageSize.Name = "label_pageSize";
            this.label_pageSize.Size = new System.Drawing.Size(11, 12);
            this.label_pageSize.TabIndex = 2;
            this.label_pageSize.Text = "1";
            // 
            // linkLabel_pre
            // 
            this.linkLabel_pre.AutoSize = true;
            this.linkLabel_pre.Location = new System.Drawing.Point(143, 16);
            this.linkLabel_pre.Name = "linkLabel_pre";
            this.linkLabel_pre.Size = new System.Drawing.Size(41, 12);
            this.linkLabel_pre.TabIndex = 3;
            this.linkLabel_pre.TabStop = true;
            this.linkLabel_pre.Text = "上一页";
            this.linkLabel_pre.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_pre_LinkClicked);
            // 
            // linkLabel_next
            // 
            this.linkLabel_next.AutoSize = true;
            this.linkLabel_next.Location = new System.Drawing.Point(281, 16);
            this.linkLabel_next.Name = "linkLabel_next";
            this.linkLabel_next.Size = new System.Drawing.Size(41, 12);
            this.linkLabel_next.TabIndex = 4;
            this.linkLabel_next.TabStop = true;
            this.linkLabel_next.Text = "下一页";
            this.linkLabel_next.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_next_LinkClicked);
            // 
            // HtUcPages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.linkLabel_next);
            this.Controls.Add(this.linkLabel_pre);
            this.Controls.Add(this.label_pageSize);
            this.Controls.Add(this.label_pageIndex);
            this.Controls.Add(this.label_per);
            this.Name = "HtUcPages";
            this.Size = new System.Drawing.Size(513, 42);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_per;
        private System.Windows.Forms.Label label_pageIndex;
        private System.Windows.Forms.Label label_pageSize;
        private System.Windows.Forms.LinkLabel linkLabel_pre;
        private System.Windows.Forms.LinkLabel linkLabel_next;
    }
}
