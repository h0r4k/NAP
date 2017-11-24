namespace NAP
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.DGridContext = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copyHexToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SendListTab = new System.Windows.Forms.TabPage();
            this.ListSendCheck = new System.Windows.Forms.CheckBox();
            this.ListSendIntervalText = new System.Windows.Forms.TextBox();
            this.dgridSendList = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SendPacketCheckBox = new System.Windows.Forms.CheckBox();
            this.SendIntervalText = new System.Windows.Forms.TextBox();
            this.PacketText = new System.Windows.Forms.TextBox();
            this.SendPacketButton = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.DGridSendListContext = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copyHexToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1.SuspendLayout();
            this.MonitorTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgridMain)).BeginInit();
            this.DGridContext.SuspendLayout();
            this.SendListTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgridSendList)).BeginInit();
            this.DGridSendListContext.SuspendLayout();
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
            this.AddListButton.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.AddListButton.Location = new System.Drawing.Point(580, 81);
            this.AddListButton.Name = "AddListButton";
            this.AddListButton.Size = new System.Drawing.Size(58, 23);
            this.AddListButton.TabIndex = 40;
            this.AddListButton.Text = "add list";
            this.AddListButton.UseVisualStyleBackColor = true;
            this.AddListButton.Click += new System.EventHandler(this.AddListButton_Click);
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgridMain.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgridMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgridMain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.method,
            this.state,
            this.size,
            this.data,
            this.RawData});
            this.dgridMain.ContextMenuStrip = this.DGridContext;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgridMain.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgridMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgridMain.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgridMain.Location = new System.Drawing.Point(3, 3);
            this.dgridMain.Name = "dgridMain";
            this.dgridMain.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgridMain.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgridMain.RowHeadersVisible = false;
            this.dgridMain.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgridMain.ShowCellErrors = false;
            this.dgridMain.Size = new System.Drawing.Size(618, 235);
            this.dgridMain.TabIndex = 12;
            this.dgridMain.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgridMain_MouseDoubleClick);
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
            // DGridContext
            // 
            this.DGridContext.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.DGridContext.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyHexToolStripMenuItem,
            this.addListToolStripMenuItem,
            this.clearViewToolStripMenuItem});
            this.DGridContext.Name = "DGridContext";
            this.DGridContext.Size = new System.Drawing.Size(153, 92);
            // 
            // copyHexToolStripMenuItem
            // 
            this.copyHexToolStripMenuItem.Name = "copyHexToolStripMenuItem";
            this.copyHexToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.copyHexToolStripMenuItem.Text = "CopyHex";
            this.copyHexToolStripMenuItem.Click += new System.EventHandler(this.copyHexToolStripMenuItem_Click);
            // 
            // addListToolStripMenuItem
            // 
            this.addListToolStripMenuItem.Name = "addListToolStripMenuItem";
            this.addListToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.addListToolStripMenuItem.Text = "AddList";
            this.addListToolStripMenuItem.Click += new System.EventHandler(this.addListToolStripMenuItem_Click);
            // 
            // clearViewToolStripMenuItem
            // 
            this.clearViewToolStripMenuItem.Name = "clearViewToolStripMenuItem";
            this.clearViewToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.clearViewToolStripMenuItem.Text = "ClearView";
            this.clearViewToolStripMenuItem.Click += new System.EventHandler(this.clearViewToolStripMenuItem_Click);
            // 
            // SendListTab
            // 
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
            // ListSendCheck
            // 
            this.ListSendCheck.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ListSendCheck.AutoSize = true;
            this.ListSendCheck.Location = new System.Drawing.Point(478, 12);
            this.ListSendCheck.Name = "ListSendCheck";
            this.ListSendCheck.Size = new System.Drawing.Size(88, 16);
            this.ListSendCheck.TabIndex = 16;
            this.ListSendCheck.Text = "Send Packet";
            this.ListSendCheck.UseVisualStyleBackColor = true;
            this.ListSendCheck.CheckedChanged += new System.EventHandler(this.ListSendCheck_CheckedChanged);
            // 
            // ListSendIntervalText
            // 
            this.ListSendIntervalText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ListSendIntervalText.Location = new System.Drawing.Point(572, 10);
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
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgridSendList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgridSendList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgridSendList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.dgridSendList.ContextMenuStrip = this.DGridSendListContext;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgridSendList.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgridSendList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgridSendList.Location = new System.Drawing.Point(3, 35);
            this.dgridSendList.Name = "dgridSendList";
            this.dgridSendList.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgridSendList.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
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
            this.SendPacketCheckBox.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.SendPacketCheckBox.Location = new System.Drawing.Point(514, 115);
            this.SendPacketCheckBox.Name = "SendPacketCheckBox";
            this.SendPacketCheckBox.Size = new System.Drawing.Size(88, 16);
            this.SendPacketCheckBox.TabIndex = 33;
            this.SendPacketCheckBox.Text = "Send Packet";
            this.SendPacketCheckBox.UseVisualStyleBackColor = true;
            this.SendPacketCheckBox.CheckedChanged += new System.EventHandler(this.SendPacketCheckBox_CheckedChanged);
            // 
            // SendIntervalText
            // 
            this.SendIntervalText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SendIntervalText.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.SendIntervalText.Location = new System.Drawing.Point(603, 113);
            this.SendIntervalText.Name = "SendIntervalText";
            this.SendIntervalText.Size = new System.Drawing.Size(34, 19);
            this.SendIntervalText.TabIndex = 34;
            this.SendIntervalText.Text = "1000";
            this.SendIntervalText.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
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
            this.SendPacketButton.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.SendPacketButton.Location = new System.Drawing.Point(513, 81);
            this.SendPacketButton.Name = "SendPacketButton";
            this.SendPacketButton.Size = new System.Drawing.Size(58, 23);
            this.SendPacketButton.TabIndex = 30;
            this.SendPacketButton.Text = "send";
            this.SendPacketButton.UseVisualStyleBackColor = true;
            this.SendPacketButton.Click += new System.EventHandler(this.SendPacketButton_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(514, 49);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 20);
            this.comboBox1.TabIndex = 43;
            // 
            // DGridSendListContext
            // 
            this.DGridSendListContext.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.DGridSendListContext.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyHexToolStripMenuItem1,
            this.toolStripMenuItem1,
            this.toolStripMenuItem2});
            this.DGridSendListContext.Name = "DGridContext";
            this.DGridSendListContext.Size = new System.Drawing.Size(131, 70);
            // 
            // copyHexToolStripMenuItem1
            // 
            this.copyHexToolStripMenuItem1.Name = "copyHexToolStripMenuItem1";
            this.copyHexToolStripMenuItem1.Size = new System.Drawing.Size(130, 22);
            this.copyHexToolStripMenuItem1.Text = "CopyHex";
            this.copyHexToolStripMenuItem1.Click += new System.EventHandler(this.copyHexToolStripMenuItem1_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(130, 22);
            this.toolStripMenuItem1.Text = "DeleteRow";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(130, 22);
            this.toolStripMenuItem2.Text = "ClearList";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // ProxyControlForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 408);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.CapturePacketButton);
            this.Controls.Add(this.AddListButton);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.SendPacketCheckBox);
            this.Controls.Add(this.SendIntervalText);
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
            this.DGridContext.ResumeLayout(false);
            this.SendListTab.ResumeLayout(false);
            this.SendListTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgridSendList)).EndInit();
            this.DGridSendListContext.ResumeLayout(false);
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
        private System.Windows.Forms.CheckBox ListSendCheck;
        private System.Windows.Forms.TextBox ListSendIntervalText;
        private System.Windows.Forms.DataGridView dgridSendList;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.CheckBox SendPacketCheckBox;
        private System.Windows.Forms.TextBox SendIntervalText;
        private System.Windows.Forms.TextBox PacketText;
        private System.Windows.Forms.Button SendPacketButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn method;
        private System.Windows.Forms.DataGridViewTextBoxColumn state;
        private System.Windows.Forms.DataGridViewTextBoxColumn size;
        private System.Windows.Forms.DataGridViewTextBoxColumn data;
        private System.Windows.Forms.DataGridViewTextBoxColumn RawData;
        private System.Windows.Forms.ContextMenuStrip DGridContext;
        private System.Windows.Forms.ToolStripMenuItem copyHexToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearViewToolStripMenuItem;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ToolStripMenuItem addListToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip DGridSendListContext;
        private System.Windows.Forms.ToolStripMenuItem copyHexToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
    }
}