namespace HoverTreeSCJ.SCJForms.TagForms
{
    partial class Form_TagEdit
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
            this.button_save = new System.Windows.Forms.Button();
            this.textBox_tagName = new System.Windows.Forms.TextBox();
            this.label_tagName = new System.Windows.Forms.Label();
            this.label_id = new System.Windows.Forms.Label();
            this.numericUpDown_id = new System.Windows.Forms.NumericUpDown();
            this.button_cancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_id)).BeginInit();
            this.SuspendLayout();
            // 
            // button_save
            // 
            this.button_save.Location = new System.Drawing.Point(81, 113);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(79, 32);
            this.button_save.TabIndex = 5;
            this.button_save.Text = "保存";
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // textBox_tagName
            // 
            this.textBox_tagName.Location = new System.Drawing.Point(81, 42);
            this.textBox_tagName.Name = "textBox_tagName";
            this.textBox_tagName.Size = new System.Drawing.Size(355, 25);
            this.textBox_tagName.TabIndex = 4;
            // 
            // label_tagName
            // 
            this.label_tagName.AutoSize = true;
            this.label_tagName.Location = new System.Drawing.Point(8, 45);
            this.label_tagName.Name = "label_tagName";
            this.label_tagName.Size = new System.Drawing.Size(67, 15);
            this.label_tagName.TabIndex = 3;
            this.label_tagName.Text = "标签名：";
            // 
            // label_id
            // 
            this.label_id.AutoSize = true;
            this.label_id.Location = new System.Drawing.Point(37, 14);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(38, 15);
            this.label_id.TabIndex = 6;
            this.label_id.Text = "ID：";
            // 
            // numericUpDown_id
            // 
            this.numericUpDown_id.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.numericUpDown_id.InterceptArrowKeys = false;
            this.numericUpDown_id.Location = new System.Drawing.Point(81, 12);
            this.numericUpDown_id.Name = "numericUpDown_id";
            this.numericUpDown_id.ReadOnly = true;
            this.numericUpDown_id.Size = new System.Drawing.Size(120, 25);
            this.numericUpDown_id.TabIndex = 7;
            // 
            // button_cancel
            // 
            this.button_cancel.Location = new System.Drawing.Point(178, 113);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(93, 32);
            this.button_cancel.TabIndex = 8;
            this.button_cancel.Text = "取消";
            this.button_cancel.UseVisualStyleBackColor = true;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // Form_TagEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 253);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.numericUpDown_id);
            this.Controls.Add(this.label_id);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.textBox_tagName);
            this.Controls.Add(this.label_tagName);
            this.Name = "Form_TagEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "编辑标签";
            this.Load += new System.EventHandler(this.Form_TagEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_id)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.TextBox textBox_tagName;
        private System.Windows.Forms.Label label_tagName;
        private System.Windows.Forms.Label label_id;
        private System.Windows.Forms.NumericUpDown numericUpDown_id;
        private System.Windows.Forms.Button button_cancel;
    }
}