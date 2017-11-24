using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Be.Windows.Forms;

namespace NAP
{
    public partial class HexPacketForm : Form
    {
        public HexPacketForm(byte[] data)
        {
            InitializeComponent();

            hexBox1.ByteProvider = new DynamicByteProvider(data);
            hexBox1.Update();
        }

        private void copyAsciiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hexBox1.Copy();
        }

        private void copyHexToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hexBox1.CopyHex();
            string clipboardText = Clipboard.GetText();
            Clipboard.SetText(clipboardText.Replace(" ", ""));
        }

        private void pasteAsciiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hexBox1.Paste();
        }

        private void pasteHexToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string clipboardText = Clipboard.GetText();
            for (int i = clipboardText.Length / 2; i > 0; i--)
            {
                clipboardText = clipboardText.Insert(i * 2, " ");
            }
            Clipboard.SetText(clipboardText);
            hexBox1.PasteHex();
        }
    }
}
