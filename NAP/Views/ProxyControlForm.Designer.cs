namespace NAP.Views
{
    partial class ProxyControlForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            this.CapturePacketButton = new System.Windows.Forms.Button();
            this.AddListButton = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.MonitorTab = new System.Windows.Forms.TabPage();
            this.dgridMain = new System.Windows.Forms.DataGridView();
            this.method = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.state = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.size = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RawData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SendListTab = new System.Windows.Forms.TabPage();
            this.SendCountUpDown = new System.Windows.Forms.NumericUpDown();
            this.NameText = new System.Windows.Forms.TextBox();
            this.LoadButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.ListSendCheck = new System.Windows.Forms.CheckBox();
            this.ListSendIntervalText = new System.Windows.Forms.TextBox();
            this.dgridSendList = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SendPacketCheckBox = new System.Windows.Forms.CheckBox();
            this.SendIntervalText = new System.Windows.Forms.TextBox();
            this.StreamComboBox = new System.Windows.Forms.ComboBox();
            this.PacketText = new System.Windows.Forms.TextBox();
            this.SendPacketButton = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.MonitorTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgridMain)).BeginInit();
            this.SendListTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SendCountUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgridSendList)).BeginInit();
            this.SuspendLayout();
            // 
            // CapturePacketButton
            // 
            this.CapturePacketButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CapturePacketButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.CapturePacketButton.Location = new System.Drawing.Point(513, 3);
            this.CapturePacketButton.Margin = new System.Windows.Forms.Padding(2);
            this.CapturePacketButton.Name = "CapturePacketButton";
            this.CapturePacketButton.Size = new System.Drawing.Size(125, 40);
            this.CapturePacketButton.TabIndex = 42;
            this.CapturePacketButton.Text = "Capture Packets";
            this.CapturePacketButton.UseVisualStyleBackColor = false;
            this.CapturePacketButton.Click += new System.EventHandler(this.CapturePacketButton_Click);
            // 
            // AddListButton
            // 
            this.AddListButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddListButton.Enabled = false;
            this.AddListButton.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.AddListButton.Location = new System.Drawing.Point(580, 81);
            this.AddListButton.Name = "AddListButton";
            this.AddListButton.Size = new System.Drawing.Size(58, 23);
            this.AddListButton.TabIndex = 40;
            this.AddListButton.Text = "add list";
            this.AddListButton.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.MonitorTab);
            this.tabControl1.Controls.Add(this.SendListTab);
            this.tabControl1.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tabControl1.Location = new System.Drawing.Point(4, 139);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(632, 267);
            this.tabControl1.TabIndex = 39;
            // 
            // MonitorTab
            // 
            this.MonitorTab.Controls.Add(this.dgridMain);
            this.MonitorTab.Location = new System.Drawing.Point(4, 22);
            this.MonitorTab.Name = "MonitorTab";
            this.MonitorTab.Padding = new System.Windows.Forms.Padding(3);
            this.MonitorTab.Size = new System.Drawing.Size(624, 241);
            this.MonitorTab.TabIndex = 0;
            this.MonitorTab.Text = "   Monitor";
            this.MonitorTab.UseVisualStyleBackColor = true;
            // 
            // dgridMain
            // 
            this.dgridMain.AllowUserToAddRows = false;
            this.dgridMain.AllowUserToOrderColumns = true;
            this.dgridMain.AllowUserToResizeRows = false;
            this.dgridMain.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgridMain.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgridMain.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle19;
            this.dgridMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgridMain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.method,
            this.state,
            this.size,
            this.data,
            this.RawData});
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgridMain.DefaultCellStyle = dataGridViewCellStyle20;
            this.dgridMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgridMain.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgridMain.Location = new System.Drawing.Point(3, 3);
            this.dgridMain.Name = "dgridMain";
            this.dgridMain.ReadOnly = true;
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle21.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle21.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle21.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgridMain.RowHeadersDefaultCellStyle = dataGridViewCellStyle21;
            this.dgridMain.RowHeadersVisible = false;
            this.dgridMain.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgridMain.ShowCellErrors = false;
            this.dgridMain.Size = new System.Drawing.Size(618, 235);
            this.dgridMain.TabIndex = 12;
            // 
            // method
            // 
            this.method.HeaderText = "Method";
            this.method.Name = "method";
            this.method.ReadOnly = true;
            this.method.Width = 85;
            // 
            // state
            // 
            this.state.HeaderText = "State";
            this.state.Name = "state";
            this.state.ReadOnly = true;
            // 
            // size
            // 
            this.size.HeaderText = "Size";
            this.size.Name = "size";
            this.size.ReadOnly = true;
            this.size.Width = 70;
            // 
            // data
            // 
            this.data.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.data.HeaderText = "Data";
            this.data.Name = "data";
            this.data.ReadOnly = true;
            // 
            // RawData
            // 
            this.RawData.HeaderText = "RawData";
            this.RawData.Name = "RawData";
            this.RawData.ReadOnly = true;
            this.RawData.Visible = false;
            // 
            // SendListTab
            // 
            this.SendListTab.Controls.Add(this.SendCountUpDown);
            this.SendListTab.Controls.Add(this.NameText);
            this.SendListTab.Controls.Add(this.LoadButton);
            this.SendListTab.Controls.Add(this.SaveButton);
            this.SendListTab.Controls.Add(this.ListSendCheck);
            this.SendListTab.Controls.Add(this.ListSendIntervalText);
            this.SendListTab.Controls.Add(this.dgridSendList);
            this.SendListTab.Location = new System.Drawing.Point(4, 22);
            this.SendListTab.Name = "SendListTab";
            this.SendListTab.Padding = new System.Windows.Forms.Padding(3);
            this.SendListTab.Size = new System.Drawing.Size(624, 241);
            this.SendListTab.TabIndex = 1;
            this.SendListTab.Text = "  SendList";
            this.SendListTab.UseVisualStyleBackColor = true;
            // 
            // SendCountUpDown
            // 
            this.SendCountUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SendCountUpDown.Enabled = false;
            this.SendCountUpDown.Location = new System.Drawing.Point(538, 7);
            this.SendCountUpDown.Name = "SendCountUpDown";
            this.SendCountUpDown.Size = new System.Drawing.Size(74, 19);
            this.SendCountUpDown.TabIndex = 20;
            this.SendCountUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // NameText
            // 
            this.NameText.Enabled = false;
            this.NameText.Location = new System.Drawing.Point(226, 6);
            this.NameText.Name = "NameText";
            this.NameText.Size = new System.Drawing.Size(100, 19);
            this.NameText.TabIndex = 19;
            this.NameText.Text = "Name";
            // 
            // LoadButton
            // 
            this.LoadButton.Enabled = false;
            this.LoadButton.Location = new System.Drawing.Point(108, 6);
            this.LoadButton.Name = "LoadButton";
            this.LoadButton.Size = new System.Drawing.Size(103, 23);
            this.LoadButton.TabIndex = 18;
            this.LoadButton.Text = "Load";
            this.LoadButton.UseVisualStyleBackColor = true;
            // 
            // SaveButton
            // 
            this.SaveButton.Enabled = false;
            this.SaveButton.Location = new System.Drawing.Point(6, 6);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(96, 23);
            this.SaveButton.TabIndex = 17;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            // 
            // ListSendCheck
            // 
            this.ListSendCheck.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ListSendCheck.AutoSize = true;
            this.ListSendCheck.Enabled = false;
            this.ListSendCheck.Location = new System.Drawing.Point(394, 9);
            this.ListSendCheck.Name = "ListSendCheck";
            this.ListSendCheck.Size = new System.Drawing.Size(88, 16);
            this.ListSendCheck.TabIndex = 16;
            this.ListSendCheck.Text = "Send Packet";
            this.ListSendCheck.UseVisualStyleBackColor = true;
            // 
            // ListSendIntervalText
            // 
            this.ListSendIntervalText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ListSendIntervalText.Enabled = false;
            this.ListSendIntervalText.Location = new System.Drawing.Point(488, 7);
            this.ListSendIntervalText.Name = "ListSendIntervalText";
            this.ListSendIntervalText.Size = new System.Drawing.Size(45, 19);
            this.ListSendIntervalText.TabIndex = 15;
            this.ListSendIntervalText.Text = "1000";
            this.ListSendIntervalText.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // dgridSendList
            // 
            this.dgridSendList.AllowUserToAddRows = false;
            this.dgridSendList.AllowUserToOrderColumns = true;
            this.dgridSendList.AllowUserToResizeRows = false;
            this.dgridSendList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgridSendList.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgridSendList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle22.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle22.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle22.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgridSendList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle22;
            this.dgridSendList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgridSendList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle23.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle23.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle23.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgridSendList.DefaultCellStyle = dataGridViewCellStyle23;
            this.dgridSendList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgridSendList.Location = new System.Drawing.Point(3, 35);
            this.dgridSendList.Name = "dgridSendList";
            this.dgridSendList.ReadOnly = true;
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle24.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle24.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle24.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle24.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgridSendList.RowHeadersDefaultCellStyle = dataGridViewCellStyle24;
            this.dgridSendList.RowHeadersVisible = false;
            this.dgridSendList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgridSendList.ShowCellErrors = false;
            this.dgridSendList.Size = new System.Drawing.Size(618, 200);
            this.dgridSendList.TabIndex = 13;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Method";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 85;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Size";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 70;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.HeaderText = "Data";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // SendPacketCheckBox
            // 
            this.SendPacketCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SendPacketCheckBox.AutoSize = true;
            this.SendPacketCheckBox.Enabled = false;
            this.SendPacketCheckBox.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.SendPacketCheckBox.Location = new System.Drawing.Point(514, 115);
            this.SendPacketCheckBox.Name = "SendPacketCheckBox";
            this.SendPacketCheckBox.Size = new System.Drawing.Size(88, 16);
            this.SendPacketCheckBox.TabIndex = 33;
            this.SendPacketCheckBox.Text = "Send Packet";
            this.SendPacketCheckBox.UseVisualStyleBackColor = true;
            // 
            // SendIntervalText
            // 
            this.SendIntervalText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SendIntervalText.Enabled = false;
            this.SendIntervalText.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.SendIntervalText.Location = new System.Drawing.Point(603, 113);
            this.SendIntervalText.Name = "SendIntervalText";
            this.SendIntervalText.Size = new System.Drawing.Size(34, 19);
            this.SendIntervalText.TabIndex = 34;
            this.SendIntervalText.Text = "1000";
            this.SendIntervalText.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // StreamComboBox
            // 
            this.StreamComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StreamComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StreamComboBox.Enabled = false;
            this.StreamComboBox.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.StreamComboBox.FormattingEnabled = true;
            this.StreamComboBox.Items.AddRange(new object[] {
            "ChatServer",
            "InfoServer",
            "ChatClient",
            "InfoClient"});
            this.StreamComboBox.Location = new System.Drawing.Point(514, 51);
            this.StreamComboBox.Name = "StreamComboBox";
            this.StreamComboBox.Size = new System.Drawing.Size(123, 20);
            this.StreamComboBox.TabIndex = 32;
            // 
            // PacketText
            // 
            this.PacketText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PacketText.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.PacketText.Location = new System.Drawing.Point(5, 3);
            this.PacketText.MaxLength = 100000;
            this.PacketText.Multiline = true;
            this.PacketText.Name = "PacketText";
            this.PacketText.Size = new System.Drawing.Size(504, 132);
            this.PacketText.TabIndex = 31;
            // 
            // SendPacketButton
            // 
            this.SendPacketButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SendPacketButton.Enabled = false;
            this.SendPacketButton.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.SendPacketButton.Location = new System.Drawing.Point(513, 81);
            this.SendPacketButton.Name = "SendPacketButton";
            this.SendPacketButton.Size = new System.Drawing.Size(58, 23);
            this.SendPacketButton.TabIndex = 30;
            this.SendPacketButton.Text = "send";
            this.SendPacketButton.UseVisualStyleBackColor = true;
            this.SendPacketButton.Click += new System.EventHandler(this.SendPacketButton_Click);
            // 
            // ProxyControlForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 408);
            this.Controls.Add(this.CapturePacketButton);
            this.Controls.Add(this.AddListButton);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.SendPacketCheckBox);
            this.Controls.Add(this.SendIntervalText);
            this.Controls.Add(this.StreamComboBox);
            this.Controls.Add(this.PacketText);
            this.Controls.Add(this.SendPacketButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ProxyControlForm";
            this.Text = "ProxyControlForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ProxyControlForm_FormClosing);
            this.Load += new System.EventHandler(this.ProxyControlForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.MonitorTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgridMain)).EndInit();
            this.SendListTab.ResumeLayout(false);
            this.SendListTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SendCountUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgridSendList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CapturePacketButton;
        private System.Windows.Forms.Button AddListButton;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage MonitorTab;
        private System.Windows.Forms.DataGridView dgridMain;
        private System.Windows.Forms.TabPage SendListTab;
        private System.Windows.Forms.NumericUpDown SendCountUpDown;
        private System.Windows.Forms.TextBox NameText;
        private System.Windows.Forms.Button LoadButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.CheckBox ListSendCheck;
        private System.Windows.Forms.TextBox ListSendIntervalText;
        private System.Windows.Forms.DataGridView dgridSendList;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.CheckBox SendPacketCheckBox;
        private System.Windows.Forms.TextBox SendIntervalText;
        private System.Windows.Forms.ComboBox StreamComboBox;
        private System.Windows.Forms.TextBox PacketText;
        private System.Windows.Forms.Button SendPacketButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn method;
        private System.Windows.Forms.DataGridViewTextBoxColumn state;
        private System.Windows.Forms.DataGridViewTextBoxColumn size;
        private System.Windows.Forms.DataGridViewTextBoxColumn data;
        private System.Windows.Forms.DataGridViewTextBoxColumn RawData;
    }
}