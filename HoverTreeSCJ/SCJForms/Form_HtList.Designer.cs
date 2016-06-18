namespace HoverTreeSCJ.SCJForms
{
    partial class Form_HtList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_HtList));
            this.button_htQuery = new System.Windows.Forms.Button();
            this.dataGridView_htList = new System.Windows.Forms.DataGridView();
            this.HtId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HtUrlColumn = new System.Windows.Forms.DataGridViewLinkColumn();
            this.HtTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HtULCase = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.HtSummary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HtAddTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.htUcPages1 = new HoverTreeSCJ.HTControls.HtUcPages();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_htList)).BeginInit();
            this.SuspendLayout();
            // 
            // button_htQuery
            // 
            this.button_htQuery.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button_htQuery.Location = new System.Drawing.Point(336, 350);
            this.button_htQuery.Margin = new System.Windows.Forms.Padding(4);
            this.button_htQuery.Name = "button_htQuery";
            this.button_htQuery.Size = new System.Drawing.Size(100, 29);
            this.button_htQuery.TabIndex = 0;
            this.button_htQuery.Text = "查询";
            this.button_htQuery.UseVisualStyleBackColor = true;
            this.button_htQuery.Click += new System.EventHandler(this.button_htQuery_Click);
            // 
            // dataGridView_htList
            // 
            this.dataGridView_htList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_htList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_htList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.HtId,
            this.HtUrlColumn,
            this.HtTitle,
            this.HtULCase,
            this.HtSummary,
            this.HtAddTime});
            this.dataGridView_htList.Location = new System.Drawing.Point(16, 15);
            this.dataGridView_htList.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView_htList.Name = "dataGridView_htList";
            this.dataGridView_htList.RowTemplate.Height = 23;
            this.dataGridView_htList.Size = new System.Drawing.Size(812, 261);
            this.dataGridView_htList.TabIndex = 1;
            this.dataGridView_htList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_htList_CellClick);
            this.dataGridView_htList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_htList_CellContentClick);
            // 
            // HtId
            // 
            this.HtId.DataPropertyName = "htid";
            this.HtId.HeaderText = "ID";
            this.HtId.Name = "HtId";
            this.HtId.ReadOnly = true;
            this.HtId.Width = 40;
            // 
            // HtUrlColumn
            // 
            this.HtUrlColumn.DataPropertyName = "hturl";
            this.HtUrlColumn.HeaderText = "URL";
            this.HtUrlColumn.Name = "HtUrlColumn";
            this.HtUrlColumn.ReadOnly = true;
            this.HtUrlColumn.Width = 200;
            // 
            // HtTitle
            // 
            this.HtTitle.DataPropertyName = "httitle";
            this.HtTitle.HeaderText = "Title";
            this.HtTitle.Name = "HtTitle";
            this.HtTitle.ReadOnly = true;
            this.HtTitle.Width = 200;
            // 
            // HtULCase
            // 
            this.HtULCase.DataPropertyName = "HtULCase";
            this.HtULCase.HeaderText = "区分大小写";
            this.HtULCase.Name = "HtULCase";
            this.HtULCase.ReadOnly = true;
            this.HtULCase.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.HtULCase.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // HtSummary
            // 
            this.HtSummary.DataPropertyName = "HtSummary";
            this.HtSummary.HeaderText = "摘要";
            this.HtSummary.Name = "HtSummary";
            this.HtSummary.ReadOnly = true;
            // 
            // HtAddTime
            // 
            this.HtAddTime.DataPropertyName = "HtAddTime";
            this.HtAddTime.HeaderText = "添加时间";
            this.HtAddTime.Name = "HtAddTime";
            this.HtAddTime.ReadOnly = true;
            // 
            // htUcPages1
            // 
            this.htUcPages1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.htUcPages1.Location = new System.Drawing.Point(79, 282);
            this.htUcPages1.Margin = new System.Windows.Forms.Padding(5);
            this.htUcPages1.Name = "htUcPages1";
            this.htUcPages1.Size = new System.Drawing.Size(684, 52);
            this.htUcPages1.TabIndex = 2;
            // 
            // Form_HtList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 386);
            this.Controls.Add(this.htUcPages1);
            this.Controls.Add(this.dataGridView_htList);
            this.Controls.Add(this.button_htQuery);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form_HtList";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "网址列表_何问起";
            this.Load += new System.EventHandler(this.Form_HtList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_htList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_htQuery;
        private System.Windows.Forms.DataGridView dataGridView_htList;
        private HTControls.HtUcPages htUcPages1;
        private System.Windows.Forms.DataGridViewTextBoxColumn HtId;
        private System.Windows.Forms.DataGridViewLinkColumn HtUrlColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn HtTitle;
        private System.Windows.Forms.DataGridViewCheckBoxColumn HtULCase;
        private System.Windows.Forms.DataGridViewTextBoxColumn HtSummary;
        private System.Windows.Forms.DataGridViewTextBoxColumn HtAddTime;
    }
}