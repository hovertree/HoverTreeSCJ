﻿namespace HoverTreeSCJ.SCJForms.TagForms
{
    partial class Form_TagList
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
            this.listView_tags = new System.Windows.Forms.ListView();
            this.button_freshen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView_tags
            // 
            this.listView_tags.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView_tags.LabelWrap = false;
            this.listView_tags.Location = new System.Drawing.Point(29, 30);
            this.listView_tags.Name = "listView_tags";
            this.listView_tags.Size = new System.Drawing.Size(576, 209);
            this.listView_tags.TabIndex = 0;
            this.listView_tags.UseCompatibleStateImageBehavior = false;
            this.listView_tags.View = System.Windows.Forms.View.Tile;
            // 
            // button_freshen
            // 
            this.button_freshen.Location = new System.Drawing.Point(248, 263);
            this.button_freshen.Name = "button_freshen";
            this.button_freshen.Size = new System.Drawing.Size(87, 38);
            this.button_freshen.TabIndex = 1;
            this.button_freshen.Text = "刷新";
            this.button_freshen.UseVisualStyleBackColor = true;
            this.button_freshen.Click += new System.EventHandler(this.button_freshen_Click);
            // 
            // Form_TagList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 351);
            this.Controls.Add(this.button_freshen);
            this.Controls.Add(this.listView_tags);
            this.Name = "Form_TagList";
            this.Text = "Form_TagList";
            this.Load += new System.EventHandler(this.Form_TagList_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView_tags;
        private System.Windows.Forms.Button button_freshen;
    }
}