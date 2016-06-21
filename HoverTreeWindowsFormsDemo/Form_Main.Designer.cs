namespace HoverTreeWindowsFormsDemo
{
    partial class Form_Main
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
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanel_hovertree = new System.Windows.Forms.TableLayoutPanel();
            this.button_listView = new System.Windows.Forms.Button();
            this.contextMenuStrip_control = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showControlPanelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button_hideControlPanel = new System.Windows.Forms.Button();
            this.tableLayoutPanel_hovertree.SuspendLayout();
            this.contextMenuStrip_control.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel_hovertree
            // 
            this.tableLayoutPanel_hovertree.ColumnCount = 2;
            this.tableLayoutPanel_hovertree.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_hovertree.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_hovertree.Controls.Add(this.button_listView, 0, 0);
            this.tableLayoutPanel_hovertree.Controls.Add(this.button_hideControlPanel, 0, 1);
            this.tableLayoutPanel_hovertree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_hovertree.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel_hovertree.Name = "tableLayoutPanel_hovertree";
            this.tableLayoutPanel_hovertree.RowCount = 2;
            this.tableLayoutPanel_hovertree.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_hovertree.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_hovertree.Size = new System.Drawing.Size(675, 347);
            this.tableLayoutPanel_hovertree.TabIndex = 1;
            // 
            // button_listView
            // 
            this.button_listView.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_listView.Location = new System.Drawing.Point(107, 65);
            this.button_listView.Name = "button_listView";
            this.button_listView.Size = new System.Drawing.Size(123, 42);
            this.button_listView.TabIndex = 0;
            this.button_listView.Text = "ListViewDemo";
            this.button_listView.UseVisualStyleBackColor = true;
            this.button_listView.Click += new System.EventHandler(this.button_listView_Click);
            // 
            // contextMenuStrip_control
            // 
            this.contextMenuStrip_control.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip_control.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showControlPanelToolStripMenuItem});
            this.contextMenuStrip_control.Name = "contextMenuStrip_control";
            this.contextMenuStrip_control.Size = new System.Drawing.Size(175, 30);
            // 
            // showControlPanelToolStripMenuItem
            // 
            this.showControlPanelToolStripMenuItem.Name = "showControlPanelToolStripMenuItem";
            this.showControlPanelToolStripMenuItem.Size = new System.Drawing.Size(174, 26);
            this.showControlPanelToolStripMenuItem.Text = "显示控制面板";
            this.showControlPanelToolStripMenuItem.Click += new System.EventHandler(this.showControlPanelToolStripMenuItem_Click);
            // 
            // button_hideControlPanel
            // 
            this.button_hideControlPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_hideControlPanel.Location = new System.Drawing.Point(105, 226);
            this.button_hideControlPanel.Name = "button_hideControlPanel";
            this.button_hideControlPanel.Size = new System.Drawing.Size(126, 67);
            this.button_hideControlPanel.TabIndex = 1;
            this.button_hideControlPanel.Text = "隐藏控制面板";
            this.button_hideControlPanel.UseVisualStyleBackColor = true;
            this.button_hideControlPanel.Click += new System.EventHandler(this.button_hideControlPanel_Click);
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 347);
            this.ContextMenuStrip = this.contextMenuStrip_control;
            this.Controls.Add(this.tableLayoutPanel_hovertree);
            this.IsMdiContainer = true;
            this.Name = "Form_Main";
            this.Text = "何问起WinForm示例_右键打开控制面板";
            this.tableLayoutPanel_hovertree.ResumeLayout(false);
            this.contextMenuStrip_control.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_hovertree;
        private System.Windows.Forms.Button button_listView;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip_control;
        private System.Windows.Forms.ToolStripMenuItem showControlPanelToolStripMenuItem;
        private System.Windows.Forms.Button button_hideControlPanel;
    }
}

