namespace Year_Month_Day
{
    partial class dataGridViewUsing
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColumnJing = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCareer = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.ColumnBlog = new System.Windows.Forms.DataGridViewLinkColumn();
            this.ColumnOpt = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ColumnImage = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnJing,
            this.ColumnName,
            this.ColumnCareer,
            this.ColumnBlog,
            this.ColumnOpt,
            this.ColumnImage});
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.Location = new System.Drawing.Point(225, 76);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 30;
            this.dataGridView1.Size = new System.Drawing.Size(1214, 630);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ColumnJing
            // 
            this.ColumnJing.HeaderText = "#";
            this.ColumnJing.MinimumWidth = 8;
            this.ColumnJing.Name = "ColumnJing";
            // 
            // ColumnName
            // 
            this.ColumnName.HeaderText = "姓名";
            this.ColumnName.MinimumWidth = 8;
            this.ColumnName.Name = "ColumnName";
            // 
            // ColumnCareer
            // 
            this.ColumnCareer.HeaderText = "职业";
            this.ColumnCareer.MinimumWidth = 8;
            this.ColumnCareer.Name = "ColumnCareer";
            // 
            // ColumnBlog
            // 
            this.ColumnBlog.HeaderText = "博客";
            this.ColumnBlog.MinimumWidth = 8;
            this.ColumnBlog.Name = "ColumnBlog";
            this.ColumnBlog.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // ColumnOpt
            // 
            this.ColumnOpt.HeaderText = "操作";
            this.ColumnOpt.MinimumWidth = 8;
            this.ColumnOpt.Name = "ColumnOpt";
            this.ColumnOpt.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // ColumnImage
            // 
            this.ColumnImage.HeaderText = "图片";
            this.ColumnImage.MinimumWidth = 8;
            this.ColumnImage.Name = "ColumnImage";
            this.ColumnImage.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnImage.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // dataGridViewUsing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1674, 889);
            this.Controls.Add(this.dataGridView1);
            this.Name = "dataGridViewUsing";
            this.Text = "dataGridViewUsing";
            this.Load += new System.EventHandler(this.dataGridViewUsing_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnJing;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnName;
        private System.Windows.Forms.DataGridViewComboBoxColumn ColumnCareer;
        private System.Windows.Forms.DataGridViewLinkColumn ColumnBlog;
        private System.Windows.Forms.DataGridViewButtonColumn ColumnOpt;
        private System.Windows.Forms.DataGridViewImageColumn ColumnImage;
    }
}