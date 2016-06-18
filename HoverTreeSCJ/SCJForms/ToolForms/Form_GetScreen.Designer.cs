namespace HoverTreeSCJ.SCJForms.ToolForms
{
    partial class Form_GetScreen
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
            this.button_getScreen = new System.Windows.Forms.Button();
            this.saveFileDialog_getScreen = new System.Windows.Forms.SaveFileDialog();
            this.checkBox_isHide = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // button_getScreen
            // 
            this.button_getScreen.Location = new System.Drawing.Point(92, 93);
            this.button_getScreen.Name = "button_getScreen";
            this.button_getScreen.Size = new System.Drawing.Size(82, 35);
            this.button_getScreen.TabIndex = 0;
            this.button_getScreen.Text = "截取全屏";
            this.button_getScreen.UseVisualStyleBackColor = true;
            this.button_getScreen.Click += new System.EventHandler(this.button_getScreen_Click);
            // 
            // saveFileDialog_getScreen
            // 
            this.saveFileDialog_getScreen.Filter = "jpg|*.jpg";
            // 
            // checkBox_isHide
            // 
            this.checkBox_isHide.AutoSize = true;
            this.checkBox_isHide.Checked = true;
            this.checkBox_isHide.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_isHide.Location = new System.Drawing.Point(66, 46);
            this.checkBox_isHide.Name = "checkBox_isHide";
            this.checkBox_isHide.Size = new System.Drawing.Size(134, 19);
            this.checkBox_isHide.TabIndex = 1;
            this.checkBox_isHide.Text = "是否隐藏本窗体";
            this.checkBox_isHide.UseVisualStyleBackColor = true;
            // 
            // Form_GetScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Controls.Add(this.checkBox_isHide);
            this.Controls.Add(this.button_getScreen);
            this.Name = "Form_GetScreen";
            this.Text = "截屏";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_getScreen;
        private System.Windows.Forms.SaveFileDialog saveFileDialog_getScreen;
        private System.Windows.Forms.CheckBox checkBox_isHide;
    }
}