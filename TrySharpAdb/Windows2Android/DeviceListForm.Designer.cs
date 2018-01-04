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
            this.deviceListBox = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.statusTextBox = new System.Windows.Forms.TextBox();
            this.modelTextBox = new System.Windows.Forms.TextBox();
            this.serialTextBox = new System.Windows.Forms.TextBox();
            this.productTextBox = new System.Windows.Forms.TextBox();
            this.statuslLabel = new System.Windows.Forms.Label();
            this.modelLabel = new System.Windows.Forms.Label();
            this.serialLabel = new System.Windows.Forms.Label();
            this.productLabel = new System.Windows.Forms.Label();
            this.connectButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // deviceListBox
            // 
            this.deviceListBox.FormattingEnabled = true;
            this.deviceListBox.ItemHeight = 24;
            this.deviceListBox.Location = new System.Drawing.Point(23, 23);
            this.deviceListBox.Name = "deviceListBox";
            this.deviceListBox.Size = new System.Drawing.Size(334, 604);
            this.deviceListBox.TabIndex = 1;
            this.deviceListBox.SelectedIndexChanged += new System.EventHandler(this.deviceListBox_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.statusTextBox);
            this.panel1.Controls.Add(this.modelTextBox);
            this.panel1.Controls.Add(this.serialTextBox);
            this.panel1.Controls.Add(this.productTextBox);
            this.panel1.Controls.Add(this.statuslLabel);
            this.panel1.Controls.Add(this.modelLabel);
            this.panel1.Controls.Add(this.serialLabel);
            this.panel1.Controls.Add(this.productLabel);
            this.panel1.Controls.Add(this.connectButton);
            this.panel1.Location = new System.Drawing.Point(377, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(546, 604);
            this.panel1.TabIndex = 2;
            // 
            // statusTextBox
            // 
            this.statusTextBox.Location = new System.Drawing.Point(237, 318);
            this.statusTextBox.Name = "statusTextBox";
            this.statusTextBox.ReadOnly = true;
            this.statusTextBox.Size = new System.Drawing.Size(253, 31);
            this.statusTextBox.TabIndex = 13;
            // 
            // modelTextBox
            // 
            this.modelTextBox.Location = new System.Drawing.Point(237, 227);
            this.modelTextBox.Name = "modelTextBox";
            this.modelTextBox.ReadOnly = true;
            this.modelTextBox.Size = new System.Drawing.Size(253, 31);
            this.modelTextBox.TabIndex = 12;
            // 
            // serialTextBox
            // 
            this.serialTextBox.Location = new System.Drawing.Point(237, 129);
            this.serialTextBox.Name = "serialTextBox";
            this.serialTextBox.ReadOnly = true;
            this.serialTextBox.Size = new System.Drawing.Size(253, 31);
            this.serialTextBox.TabIndex = 11;
            // 
            // productTextBox
            // 
            this.productTextBox.Location = new System.Drawing.Point(237, 36);
            this.productTextBox.Name = "productTextBox";
            this.productTextBox.ReadOnly = true;
            this.productTextBox.Size = new System.Drawing.Size(253, 31);
            this.productTextBox.TabIndex = 10;
            // 
            // statuslLabel
            // 
            this.statuslLabel.AutoSize = true;
            this.statuslLabel.Location = new System.Drawing.Point(43, 318);
            this.statuslLabel.Name = "statuslLabel";
            this.statuslLabel.Size = new System.Drawing.Size(74, 24);
            this.statuslLabel.TabIndex = 9;
            this.statuslLabel.Text = "Status";
            // 
            // modelLabel
            // 
            this.modelLabel.AutoSize = true;
            this.modelLabel.Location = new System.Drawing.Point(43, 227);
            this.modelLabel.Name = "modelLabel";
            this.modelLabel.Size = new System.Drawing.Size(69, 24);
            this.modelLabel.TabIndex = 8;
            this.modelLabel.Text = "Model";
            // 
            // serialLabel
            // 
            this.serialLabel.AutoSize = true;
            this.serialLabel.Location = new System.Drawing.Point(43, 132);
            this.serialLabel.Name = "serialLabel";
            this.serialLabel.Size = new System.Drawing.Size(65, 24);
            this.serialLabel.TabIndex = 7;
            this.serialLabel.Text = "Serial";
            // 
            // productLabel
            // 
            this.productLabel.AutoSize = true;
            this.productLabel.Location = new System.Drawing.Point(43, 39);
            this.productLabel.Name = "productLabel";
            this.productLabel.Size = new System.Drawing.Size(89, 24);
            this.productLabel.TabIndex = 6;
            this.productLabel.Text = "Product";
            // 
            // connectButton
            // 
            this.connectButton.Location = new System.Drawing.Point(180, 432);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(184, 100);
            this.connectButton.TabIndex = 1;
            this.connectButton.Text = "Connect";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // DeviceListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 652);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.deviceListBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "DeviceListForm";
            this.Text = "Device List";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListBox deviceListBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label statuslLabel;
        private System.Windows.Forms.Label modelLabel;
        private System.Windows.Forms.Label serialLabel;
        private System.Windows.Forms.Label productLabel;
        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.TextBox productTextBox;
        private System.Windows.Forms.TextBox statusTextBox;
        private System.Windows.Forms.TextBox modelTextBox;
        private System.Windows.Forms.TextBox serialTextBox;
    }
}

