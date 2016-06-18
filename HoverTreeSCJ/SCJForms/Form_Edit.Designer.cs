namespace HoverTreeSCJ.SCJForms
{
    partial class Form_Edit
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
            this.label_id = new System.Windows.Forms.Label();
            this.textBox_id = new System.Windows.Forms.TextBox();
            this.label_url = new System.Windows.Forms.Label();
            this.textBox_url = new System.Windows.Forms.TextBox();
            this.label_title = new System.Windows.Forms.Label();
            this.textBox_title = new System.Windows.Forms.TextBox();
            this.label_summary = new System.Windows.Forms.Label();
            this.textBox_summary = new System.Windows.Forms.TextBox();
            this.button_edit = new System.Windows.Forms.Button();
            this.button_cancel = new System.Windows.Forms.Button();
            this.checkBox_ulCase = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label_id
            // 
            this.label_id.AutoSize = true;
            this.label_id.Location = new System.Drawing.Point(61, 42);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(38, 15);
            this.label_id.TabIndex = 0;
            this.label_id.Text = "ID：";
            // 
            // textBox_id
            // 
            this.textBox_id.Location = new System.Drawing.Point(115, 39);
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.ReadOnly = true;
            this.textBox_id.Size = new System.Drawing.Size(129, 25);
            this.textBox_id.TabIndex = 1;
            // 
            // label_url
            // 
            this.label_url.AutoSize = true;
            this.label_url.Location = new System.Drawing.Point(53, 88);
            this.label_url.Name = "label_url";
            this.label_url.Size = new System.Drawing.Size(46, 15);
            this.label_url.TabIndex = 2;
            this.label_url.Text = "URL：";
            // 
            // textBox_url
            // 
            this.textBox_url.Location = new System.Drawing.Point(115, 88);
            this.textBox_url.Name = "textBox_url";
            this.textBox_url.Size = new System.Drawing.Size(519, 25);
            this.textBox_url.TabIndex = 3;
            // 
            // label_title
            // 
            this.label_title.AutoSize = true;
            this.label_title.Location = new System.Drawing.Point(44, 133);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(62, 15);
            this.label_title.TabIndex = 4;
            this.label_title.Text = "Title：";
            // 
            // textBox_title
            // 
            this.textBox_title.Location = new System.Drawing.Point(115, 130);
            this.textBox_title.Name = "textBox_title";
            this.textBox_title.Size = new System.Drawing.Size(519, 25);
            this.textBox_title.TabIndex = 5;
            // 
            // label_summary
            // 
            this.label_summary.AutoSize = true;
            this.label_summary.Location = new System.Drawing.Point(44, 179);
            this.label_summary.Name = "label_summary";
            this.label_summary.Size = new System.Drawing.Size(52, 15);
            this.label_summary.TabIndex = 6;
            this.label_summary.Text = "摘要：";
            // 
            // textBox_summary
            // 
            this.textBox_summary.Location = new System.Drawing.Point(115, 179);
            this.textBox_summary.Multiline = true;
            this.textBox_summary.Name = "textBox_summary";
            this.textBox_summary.Size = new System.Drawing.Size(519, 100);
            this.textBox_summary.TabIndex = 7;
            // 
            // button_edit
            // 
            this.button_edit.Location = new System.Drawing.Point(115, 305);
            this.button_edit.Name = "button_edit";
            this.button_edit.Size = new System.Drawing.Size(75, 31);
            this.button_edit.TabIndex = 8;
            this.button_edit.Text = "保存";
            this.button_edit.UseVisualStyleBackColor = true;
            this.button_edit.Click += new System.EventHandler(this.button_edit_Click);
            // 
            // button_cancel
            // 
            this.button_cancel.Location = new System.Drawing.Point(220, 305);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(75, 31);
            this.button_cancel.TabIndex = 9;
            this.button_cancel.Text = "取消";
            this.button_cancel.UseVisualStyleBackColor = true;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // checkBox_ulCase
            // 
            this.checkBox_ulCase.AutoSize = true;
            this.checkBox_ulCase.Location = new System.Drawing.Point(286, 41);
            this.checkBox_ulCase.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox_ulCase.Name = "checkBox_ulCase";
            this.checkBox_ulCase.Size = new System.Drawing.Size(104, 19);
            this.checkBox_ulCase.TabIndex = 10;
            this.checkBox_ulCase.Text = "区分大小写";
            this.checkBox_ulCase.UseVisualStyleBackColor = true;
            // 
            // Form_Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 375);
            this.Controls.Add(this.checkBox_ulCase);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.button_edit);
            this.Controls.Add(this.textBox_summary);
            this.Controls.Add(this.label_summary);
            this.Controls.Add(this.textBox_title);
            this.Controls.Add(this.label_title);
            this.Controls.Add(this.textBox_url);
            this.Controls.Add(this.label_url);
            this.Controls.Add(this.textBox_id);
            this.Controls.Add(this.label_id);
            this.Name = "Form_Edit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "网址修改";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_id;
        private System.Windows.Forms.TextBox textBox_id;
        private System.Windows.Forms.Label label_url;
        private System.Windows.Forms.TextBox textBox_url;
        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.TextBox textBox_title;
        private System.Windows.Forms.Label label_summary;
        private System.Windows.Forms.TextBox textBox_summary;
        private System.Windows.Forms.Button button_edit;
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.CheckBox checkBox_ulCase;
    }
}