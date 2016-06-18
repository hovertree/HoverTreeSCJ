namespace HoverTreeSCJ.SCJForms
{
    partial class Form_Add
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
            this.label_url = new System.Windows.Forms.Label();
            this.textBox_url = new System.Windows.Forms.TextBox();
            this.label_title = new System.Windows.Forms.Label();
            this.textBox_title = new System.Windows.Forms.TextBox();
            this.button_add = new System.Windows.Forms.Button();
            this.textBox_tips = new System.Windows.Forms.TextBox();
            this.checkBox_ulCase = new System.Windows.Forms.CheckBox();
            this.button_getTitle = new System.Windows.Forms.Button();
            this.textBox_summary = new System.Windows.Forms.TextBox();
            this.label_summary = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_url
            // 
            this.label_url.AutoSize = true;
            this.label_url.Location = new System.Drawing.Point(36, 39);
            this.label_url.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_url.Name = "label_url";
            this.label_url.Size = new System.Drawing.Size(52, 15);
            this.label_url.TabIndex = 0;
            this.label_url.Text = "网址：";
            // 
            // textBox_url
            // 
            this.textBox_url.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_url.Location = new System.Drawing.Point(99, 35);
            this.textBox_url.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_url.Name = "textBox_url";
            this.textBox_url.Size = new System.Drawing.Size(651, 25);
            this.textBox_url.TabIndex = 10;
            // 
            // label_title
            // 
            this.label_title.AutoSize = true;
            this.label_title.Location = new System.Drawing.Point(36, 77);
            this.label_title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(52, 15);
            this.label_title.TabIndex = 2;
            this.label_title.Text = "标题：";
            // 
            // textBox_title
            // 
            this.textBox_title.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_title.Location = new System.Drawing.Point(99, 77);
            this.textBox_title.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_title.Name = "textBox_title";
            this.textBox_title.Size = new System.Drawing.Size(651, 25);
            this.textBox_title.TabIndex = 20;
            // 
            // button_add
            // 
            this.button_add.Location = new System.Drawing.Point(99, 137);
            this.button_add.Margin = new System.Windows.Forms.Padding(4);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(100, 29);
            this.button_add.TabIndex = 50;
            this.button_add.Text = "添加";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // textBox_tips
            // 
            this.textBox_tips.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_tips.Location = new System.Drawing.Point(99, 297);
            this.textBox_tips.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_tips.Multiline = true;
            this.textBox_tips.Name = "textBox_tips";
            this.textBox_tips.ReadOnly = true;
            this.textBox_tips.Size = new System.Drawing.Size(651, 48);
            this.textBox_tips.TabIndex = 90;
            // 
            // checkBox_ulCase
            // 
            this.checkBox_ulCase.AutoSize = true;
            this.checkBox_ulCase.Location = new System.Drawing.Point(99, 110);
            this.checkBox_ulCase.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox_ulCase.Name = "checkBox_ulCase";
            this.checkBox_ulCase.Size = new System.Drawing.Size(104, 19);
            this.checkBox_ulCase.TabIndex = 30;
            this.checkBox_ulCase.Text = "区分大小写";
            this.checkBox_ulCase.UseVisualStyleBackColor = true;
            // 
            // button_getTitle
            // 
            this.button_getTitle.Location = new System.Drawing.Point(226, 138);
            this.button_getTitle.Name = "button_getTitle";
            this.button_getTitle.Size = new System.Drawing.Size(98, 28);
            this.button_getTitle.TabIndex = 60;
            this.button_getTitle.Text = "获取标题";
            this.button_getTitle.UseVisualStyleBackColor = true;
            this.button_getTitle.Click += new System.EventHandler(this.button_getTitle_Click);
            // 
            // textBox_summary
            // 
            this.textBox_summary.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_summary.Location = new System.Drawing.Point(99, 189);
            this.textBox_summary.Multiline = true;
            this.textBox_summary.Name = "textBox_summary";
            this.textBox_summary.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox_summary.Size = new System.Drawing.Size(651, 101);
            this.textBox_summary.TabIndex = 40;
            // 
            // label_summary
            // 
            this.label_summary.AutoSize = true;
            this.label_summary.Location = new System.Drawing.Point(33, 233);
            this.label_summary.Name = "label_summary";
            this.label_summary.Size = new System.Drawing.Size(52, 15);
            this.label_summary.TabIndex = 9;
            this.label_summary.Text = "摘要：";
            // 
            // Form_Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 358);
            this.Controls.Add(this.label_summary);
            this.Controls.Add(this.textBox_summary);
            this.Controls.Add(this.button_getTitle);
            this.Controls.Add(this.checkBox_ulCase);
            this.Controls.Add(this.textBox_tips);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.textBox_title);
            this.Controls.Add(this.label_title);
            this.Controls.Add(this.textBox_url);
            this.Controls.Add(this.label_url);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form_Add";
            this.Text = "添加网址";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_url;
        private System.Windows.Forms.TextBox textBox_url;
        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.TextBox textBox_title;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.TextBox textBox_tips;
        private System.Windows.Forms.CheckBox checkBox_ulCase;
        private System.Windows.Forms.Button button_getTitle;
        private System.Windows.Forms.TextBox textBox_summary;
        private System.Windows.Forms.Label label_summary;
    }
}