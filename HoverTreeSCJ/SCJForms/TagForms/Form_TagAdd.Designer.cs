namespace HoverTreeSCJ.SCJForms.TagForms
{
    partial class Form_TagAdd
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
            this.label_tagName = new System.Windows.Forms.Label();
            this.textBox_tagName = new System.Windows.Forms.TextBox();
            this.button_add = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_tagName
            // 
            this.label_tagName.AutoSize = true;
            this.label_tagName.Location = new System.Drawing.Point(50, 48);
            this.label_tagName.Name = "label_tagName";
            this.label_tagName.Size = new System.Drawing.Size(67, 15);
            this.label_tagName.TabIndex = 0;
            this.label_tagName.Text = "标签名：";
            // 
            // textBox_tagName
            // 
            this.textBox_tagName.Location = new System.Drawing.Point(123, 38);
            this.textBox_tagName.Name = "textBox_tagName";
            this.textBox_tagName.Size = new System.Drawing.Size(355, 25);
            this.textBox_tagName.TabIndex = 1;
            // 
            // button_add
            // 
            this.button_add.Location = new System.Drawing.Point(136, 137);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(79, 32);
            this.button_add.TabIndex = 2;
            this.button_add.Text = "添加";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // Form_TagAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 317);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.textBox_tagName);
            this.Controls.Add(this.label_tagName);
            this.Name = "Form_TagAdd";
            this.Text = "Form_TagAdd";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_tagName;
        private System.Windows.Forms.TextBox textBox_tagName;
        private System.Windows.Forms.Button button_add;
    }
}