namespace ToDoList
{
    partial class TodoForm
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.TodoTypeFilter = new MetroFramework.Controls.MetroComboBox();
            this.VisibleDeleteData = new MetroFramework.Controls.MetroCheckBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.TodoGrid = new ToDoList.Component.TodoGrid();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Done = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Limit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Priority = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.TodoType = new System.Windows.Forms.DataGridViewComboBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.TodoGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // TodoTypeFilter
            // 
            this.TodoTypeFilter.FormattingEnabled = true;
            this.TodoTypeFilter.ItemHeight = 23;
            this.TodoTypeFilter.Location = new System.Drawing.Point(613, 58);
            this.TodoTypeFilter.Name = "TodoTypeFilter";
            this.TodoTypeFilter.Size = new System.Drawing.Size(100, 29);
            this.TodoTypeFilter.TabIndex = 1;
            this.TodoTypeFilter.UseSelectable = true;
            this.TodoTypeFilter.SelectedIndexChanged += new System.EventHandler(this.TodoTypeFilter_SelectedIndexChanged);
            // 
            // VisibleDeleteData
            // 
            this.VisibleDeleteData.AutoSize = true;
            this.VisibleDeleteData.Location = new System.Drawing.Point(671, 412);
            this.VisibleDeleteData.Name = "VisibleDeleteData";
            this.VisibleDeleteData.Size = new System.Drawing.Size(106, 15);
            this.VisibleDeleteData.TabIndex = 2;
            this.VisibleDeleteData.Text = "削除データ表示";
            this.VisibleDeleteData.UseSelectable = true;
            this.VisibleDeleteData.CheckedChanged += new System.EventHandler(this.VisibleDeleteData_CheckedChanged);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(24, 413);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(296, 19);
            this.metroLabel1.TabIndex = 3;
            this.metroLabel1.Text = "※データを決定するときは別の行に移動してください。";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(529, 60);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(78, 19);
            this.metroLabel2.TabIndex = 4;
            this.metroLabel2.Text = "タスクフィルタ";
            // 
            // TodoGrid
            // 
            this.TodoGrid.AllowUserToResizeRows = false;
            this.TodoGrid.AutoGenerateColumns = false;
            this.TodoGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.TodoGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TodoGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.TodoGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TodoGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.TodoGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TodoGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Done,
            this.Limit,
            this.Description,
            this.Priority,
            this.TodoType});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.TodoGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.TodoGrid.EnableHeadersVisualStyles = false;
            this.TodoGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TodoGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.TodoGrid.Location = new System.Drawing.Point(22, 93);
            this.TodoGrid.Name = "TodoGrid";
            this.TodoGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TodoGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.TodoGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.TodoGrid.RowTemplate.Height = 21;
            this.TodoGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TodoGrid.Size = new System.Drawing.Size(766, 313);
            this.TodoGrid.TabIndex = 0;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            this.Id.Width = 30;
            // 
            // Done
            // 
            this.Done.DataPropertyName = "Done";
            this.Done.HeaderText = "Done";
            this.Done.Name = "Done";
            this.Done.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Done.Width = 50;
            // 
            // Limit
            // 
            this.Limit.DataPropertyName = "Limit";
            this.Limit.HeaderText = "期限";
            this.Limit.MaxInputLength = 10;
            this.Limit.Name = "Limit";
            // 
            // Description
            // 
            this.Description.DataPropertyName = "Description";
            this.Description.HeaderText = "内容";
            this.Description.MaxInputLength = 100;
            this.Description.Name = "Description";
            this.Description.Width = 300;
            // 
            // Priority
            // 
            this.Priority.DataPropertyName = "Priority";
            this.Priority.HeaderText = "優先度";
            this.Priority.Name = "Priority";
            this.Priority.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Priority.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // TodoType
            // 
            this.TodoType.DataPropertyName = "TodoType";
            this.TodoType.HeaderText = "どんなタスク?";
            this.TodoType.Name = "TodoType";
            this.TodoType.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // TodoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.VisibleDeleteData);
            this.Controls.Add(this.TodoTypeFilter);
            this.Controls.Add(this.TodoGrid);
            this.Name = "TodoForm";
            this.Text = "Todo";
            this.Load += new System.EventHandler(this.Todo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TodoGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ToDoList.Component.TodoGrid TodoGrid;
        private MetroFramework.Controls.MetroComboBox TodoTypeFilter;
        private MetroFramework.Controls.MetroCheckBox VisibleDeleteData;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Done;
        private System.Windows.Forms.DataGridViewTextBoxColumn Limit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewComboBoxColumn Priority;
        private System.Windows.Forms.DataGridViewComboBoxColumn TodoType;
    }
}

