namespace Windows2Android
{
    partial class DeviceListForm
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
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
            this.deviceGridView = new System.Windows.Forms.DataGridView();
            this.modelColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serialColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.deviceGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // deviceGridView
            // 
            this.deviceGridView.AllowUserToResizeColumns = false;
            this.deviceGridView.AllowUserToResizeRows = false;
            this.deviceGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.deviceGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.deviceGridView.CausesValidation = false;
            this.deviceGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.deviceGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.modelColumn,
            this.serialColumn,
            this.productColumn,
            this.stateColumn});
            this.deviceGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.deviceGridView.Location = new System.Drawing.Point(0, 0);
            this.deviceGridView.MultiSelect = false;
            this.deviceGridView.Name = "deviceGridView";
            this.deviceGridView.ReadOnly = true;
            this.deviceGridView.RowHeadersVisible = false;
            this.deviceGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.deviceGridView.RowTemplate.Height = 33;
            this.deviceGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.deviceGridView.Size = new System.Drawing.Size(1532, 1103);
            this.deviceGridView.TabIndex = 0;
            this.deviceGridView.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.deviceGridView_CellMouseDoubleClick);
            // 
            // modelColumn
            // 
            this.modelColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.modelColumn.DataPropertyName = "Model";
            this.modelColumn.HeaderText = "Model";
            this.modelColumn.Name = "modelColumn";
            this.modelColumn.ReadOnly = true;
            this.modelColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // serialColumn
            // 
            this.serialColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.serialColumn.DataPropertyName = "Serial";
            this.serialColumn.HeaderText = "Serial";
            this.serialColumn.Name = "serialColumn";
            this.serialColumn.ReadOnly = true;
            this.serialColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // productColumn
            // 
            this.productColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.productColumn.DataPropertyName = "Product";
            this.productColumn.HeaderText = "Product";
            this.productColumn.Name = "productColumn";
            this.productColumn.ReadOnly = true;
            this.productColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // stateColumn
            // 
            this.stateColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.stateColumn.DataPropertyName = "State";
            this.stateColumn.HeaderText = "State";
            this.stateColumn.Name = "stateColumn";
            this.stateColumn.ReadOnly = true;
            this.stateColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // DeviceListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1532, 1103);
            this.Controls.Add(this.deviceGridView);
            this.Name = "DeviceListForm";
            this.Text = "Device List";
            ((System.ComponentModel.ISupportInitialize)(this.deviceGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView deviceGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn serialColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stateColumn;
    }
}

