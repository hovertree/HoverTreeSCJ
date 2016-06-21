namespace HoverTreeSCJ
{
    partial class HoverTreeSCJForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HoverTreeSCJForm));
            this.menuStrip_hoverTree = new System.Windows.Forms.MenuStrip();
            this.sCJToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tagAddToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.getScreenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tagListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip_hoverTree.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip_hoverTree
            // 
            this.menuStrip_hoverTree.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip_hoverTree.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sCJToolStripMenuItem,
            this.toolToolStripMenuItem});
            this.menuStrip_hoverTree.Location = new System.Drawing.Point(0, 0);
            this.menuStrip_hoverTree.Name = "menuStrip_hoverTree";
            this.menuStrip_hoverTree.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip_hoverTree.Size = new System.Drawing.Size(943, 28);
            this.menuStrip_hoverTree.TabIndex = 1;
            this.menuStrip_hoverTree.Text = "menuStrip1";
            // 
            // sCJToolStripMenuItem
            // 
            this.sCJToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.listToolStripMenuItem,
            this.tagAddToolStripMenuItem,
            this.tagListToolStripMenuItem});
            this.sCJToolStripMenuItem.Name = "sCJToolStripMenuItem";
            this.sCJToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.sCJToolStripMenuItem.Text = "菜单";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.addToolStripMenuItem.Text = "添加";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // listToolStripMenuItem
            // 
            this.listToolStripMenuItem.Name = "listToolStripMenuItem";
            this.listToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.listToolStripMenuItem.Text = "查询";
            this.listToolStripMenuItem.Click += new System.EventHandler(this.listToolStripMenuItem_Click);
            // 
            // tagAddToolStripMenuItem
            // 
            this.tagAddToolStripMenuItem.Name = "tagAddToolStripMenuItem";
            this.tagAddToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.tagAddToolStripMenuItem.Text = "添加标签";
            this.tagAddToolStripMenuItem.Click += new System.EventHandler(this.tagAddToolStripMenuItem_Click);
            // 
            // toolToolStripMenuItem
            // 
            this.toolToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.getScreenToolStripMenuItem});
            this.toolToolStripMenuItem.Name = "toolToolStripMenuItem";
            this.toolToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.toolToolStripMenuItem.Text = "工具";
            // 
            // getScreenToolStripMenuItem
            // 
            this.getScreenToolStripMenuItem.Name = "getScreenToolStripMenuItem";
            this.getScreenToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
            this.getScreenToolStripMenuItem.Text = "保存截屏";
            this.getScreenToolStripMenuItem.Click += new System.EventHandler(this.getScreenToolStripMenuItem_Click);
            // 
            // tagListToolStripMenuItem
            // 
            this.tagListToolStripMenuItem.Name = "tagListToolStripMenuItem";
            this.tagListToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.tagListToolStripMenuItem.Text = "查看标签";
            this.tagListToolStripMenuItem.Click += new System.EventHandler(this.tagListToolStripMenuItem_Click);
            // 
            // HoverTreeSCJForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 499);
            this.Controls.Add(this.menuStrip_hoverTree);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip_hoverTree;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "HoverTreeSCJForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "何问起收藏夹HoverTreeSCJ";
            this.menuStrip_hoverTree.ResumeLayout(false);
            this.menuStrip_hoverTree.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip_hoverTree;
        private System.Windows.Forms.ToolStripMenuItem sCJToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tagAddToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem getScreenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tagListToolStripMenuItem;
    }
}

