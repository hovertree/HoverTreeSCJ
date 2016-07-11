namespace HoverTreeWindowsFormsDemo.HtFormSet
{
    partial class Form_listView2
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
            this.listView_myLV = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // listView_myLV
            // 
            this.listView_myLV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView_myLV.Location = new System.Drawing.Point(12, 52);
            this.listView_myLV.Name = "listView_myLV";
            this.listView_myLV.Size = new System.Drawing.Size(564, 257);
            this.listView_myLV.TabIndex = 0;
            this.listView_myLV.UseCompatibleStateImageBehavior = false;
            this.listView_myLV.View = System.Windows.Forms.View.Details;
            this.listView_myLV.SelectedIndexChanged += new System.EventHandler(this.listView_myLV_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "第一列";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "第二列";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "第三列";
            // 
            // Form_listView2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 416);
            this.Controls.Add(this.listView_myLV);
            this.Name = "Form_listView2";
            this.Text = "Form_listView2";
            this.Load += new System.EventHandler(this.Form_listView2_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView_myLV;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
    }
}