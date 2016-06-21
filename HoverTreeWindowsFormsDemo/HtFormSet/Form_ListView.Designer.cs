namespace HoverTreeWindowsFormsDemo.HtFormSet
{
    partial class Form_ListView
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
            this.listView_HoverTree = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // listView_HoverTree
            // 
            this.listView_HoverTree.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView_HoverTree.Location = new System.Drawing.Point(12, 12);
            this.listView_HoverTree.Name = "listView_HoverTree";
            this.listView_HoverTree.Size = new System.Drawing.Size(529, 327);
            this.listView_HoverTree.TabIndex = 0;
            this.listView_HoverTree.UseCompatibleStateImageBehavior = false;
            this.listView_HoverTree.View = System.Windows.Forms.View.Details;
            // 
            // Form_ListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 361);
            this.Controls.Add(this.listView_HoverTree);
            this.Name = "Form_ListView";
            this.Text = "ListView示例_何问起";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form_ListView_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView_HoverTree;
    }
}