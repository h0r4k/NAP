using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Net;
using NAP.Network.Filter;
using NAP.Network.Packet;

namespace NAP
{
    public partial class FilterSettingForm : Form
    {
        FilterData filterData;

        public FilterSettingForm(FilterData filterData)
        {
            InitializeComponent();
            comboBox1.DataSource = Enum.GetValues(typeof(PacketMethods));
            comboBox2.DataSource = Enum.GetValues(typeof(Protocols));
            this.filterData = filterData;

            if (filterData.name == null) return;
            comboBox1.SelectedItem = filterData.method;
            comboBox2.SelectedItem = filterData.protocol;
            EnableCheck.Checked = filterData.enable;
            textBox1.Text = filterData.name;
            textBox2.Text = filterData.search;
            textBox3.Text = filterData.modify;
            textBox4.Text = filterData.portStr;
            textBox5.Text = filterData.destIPStr;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            saveFileDialog1.FileName = textBox1.Text;
            saveFileDialog1.Filter = "|*.pfl";
            saveFileDialog1.ShowDialog();
        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "";
            openFileDialog1.Filter = "|*.pfl";
            openFileDialog1.ShowDialog();
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            /*
            string filterdata = StreamComboBox.SelectedItem + "|" + textBox2.Text + "|" + textBox3.Text;
            Stream stream = saveFileDialog1.OpenFile();
            StreamWriter sw = new StreamWriter(stream);
            sw.Write(filterdata);
            sw.Close();
            stream.Close();*/
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            /*
            Stream stream = openFileDialog1.OpenFile();
            StreamReader sr = new StreamReader(stream);
            string filterdata = sr.ReadToEnd();
            sr.Close();
            stream.Close();
            string[] filterdatas = filterdata.Split('|');
            StreamComboBox.SelectedItem = filterdatas[0];
            textBox1.Text = openFileDialog1.SafeFileName.Replace(".pfl","");
            textBox2.Text = filterdatas[1];
            textBox3.Text = filterdatas[2];*/
        }

        private void SetButton_Click(object sender, EventArgs e)
        {
            filterData.Set(
                EnableCheck.Checked,
                textBox1.Text,
                textBox4.Text,
                (Protocols)comboBox2.SelectedItem,
                (PacketMethods)comboBox1.SelectedItem,
                textBox5.Text,
                textBox2.Text,
                textBox3.Text
            );
            this.Close();
        }
    }
}