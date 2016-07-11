namespace HoverTreeSCJ.HTControls
{
    partial class HtUcTagPanel
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
            this.flowLayoutPanel_tag = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // flowLayoutPanel_tag
            // 
            this.flowLayoutPanel_tag.Location = new System.Drawing.Point(3, 49);
            this.flowLayoutPanel_tag.Name = "flowLayoutPanel_tag";
            this.flowLayoutPanel_tag.Size = new System.Drawing.Size(493, 138);
            this.flowLayoutPanel_tag.TabIndex = 0;
            // 
            // HtUcTagPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowLayoutPanel_tag);
            this.Name = "HtUcTagPanel";
            this.Size = new System.Drawing.Size(499, 208);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_tag;
    }
}
