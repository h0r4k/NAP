namespace NAP
{
    partial class HexPacketForm
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
            this.hexBox1 = new Be.Windows.Forms.HexBox();
            this.DGridContext = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copyAsciiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyHexToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteAsciiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteHexToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DGridContext.SuspendLayout();
            this.SuspendLayout();
            // 
            // hexBox1
            // 
            this.hexBox1.AllowDrop = true;
            this.hexBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.hexBox1.ContextMenuStrip = this.DGridContext;
            this.hexBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hexBox1.Font = new System.Drawing.Font("Yu Gothic UI", 9F);
            this.hexBox1.LineInfoVisible = true;
            this.hexBox1.Location = new System.Drawing.Point(0, 0);
            this.hexBox1.Name = "hexBox1";
            this.hexBox1.ShadowSelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(60)))), ((int)(((byte)(188)))), ((int)(((byte)(255)))));
            this.hexBox1.Size = new System.Drawing.Size(645, 592);
            this.hexBox1.StringViewVisible = true;
            this.hexBox1.TabIndex = 0;
            this.hexBox1.UseFixedBytesPerLine = true;
            this.hexBox1.VScrollBarVisible = true;
            // 
            // DGridContext
            // 
            this.DGridContext.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.DGridContext.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyAsciiToolStripMenuItem,
            this.copyHexToolStripMenuItem,
            this.pasteAsciiToolStripMenuItem,
            this.pasteHexToolStripMenuItem});
            this.DGridContext.Name = "DGridContext";
            this.DGridContext.Size = new System.Drawing.Size(128, 92);
            // 
            // copyAsciiToolStripMenuItem
            // 
            this.copyAsciiToolStripMenuItem.Name = "copyAsciiToolStripMenuItem";
            this.copyAsciiToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.copyAsciiToolStripMenuItem.Text = "CopyAscii";
            this.copyAsciiToolStripMenuItem.Click += new System.EventHandler(this.copyAsciiToolStripMenuItem_Click);
            // 
            // copyHexToolStripMenuItem
            // 
            this.copyHexToolStripMenuItem.Name = "copyHexToolStripMenuItem";
            this.copyHexToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.copyHexToolStripMenuItem.Text = "CopyHex";
            this.copyHexToolStripMenuItem.Click += new System.EventHandler(this.copyHexToolStripMenuItem_Click);
            // 
            // pasteAsciiToolStripMenuItem
            // 
            this.pasteAsciiToolStripMenuItem.Name = "pasteAsciiToolStripMenuItem";
            this.pasteAsciiToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.pasteAsciiToolStripMenuItem.Text = "PasteAscii";
            this.pasteAsciiToolStripMenuItem.Click += new System.EventHandler(this.pasteAsciiToolStripMenuItem_Click);
            // 
            // pasteHexToolStripMenuItem
            // 
            this.pasteHexToolStripMenuItem.Name = "pasteHexToolStripMenuItem";
            this.pasteHexToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.pasteHexToolStripMenuItem.Text = "PasteHex";
            this.pasteHexToolStripMenuItem.Click += new System.EventHandler(this.pasteHexToolStripMenuItem_Click);
            // 
            // HexPacketForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 592);
            this.Controls.Add(this.hexBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "HexPacketForm";
            this.Text = "HexData";
            this.DGridContext.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Be.Windows.Forms.HexBox hexBox1;
        private System.Windows.Forms.ContextMenuStrip DGridContext;
        private System.Windows.Forms.ToolStripMenuItem copyAsciiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyHexToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteAsciiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteHexToolStripMenuItem;
    }
}