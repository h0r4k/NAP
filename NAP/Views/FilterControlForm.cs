using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using NAP.Network.Filter;

namespace NAP.Views
{
    public partial class FilterControlForm : Form
    {
        delegate void dele();
        FilterManager filterManager;

        public FilterControlForm(FilterManager filterManager)
        {
            InitializeComponent();
            this.filterManager = filterManager;
        }

        private void NewFilterButton_Click(object sender, EventArgs e)
        {
            FilterData filterData = new FilterData();
            FilterSettingForm filterSettingForm = new FilterSettingForm(filterData);
            filterSettingForm.ShowDialog();

            if (filterData.name == null) return;
            filterManager.AddFilterData(filterData);
            ReloadFilterDatas();
        }

        /*
        public void DgridAdd(string function,bool check,string name,string search,string modify)
        {
            Invoke(new dele(() =>
            {
                dgridFilters.Rows.Add(check,name,function,search,modify);
            }));
        }*/

        private void FilterForm_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (dgridFilters.Rows.Count != 0)
            {
                dgridFilters.Rows.Remove(dgridFilters.SelectedRows[0]);
            }
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            if (dgridFilters.Rows.Count <= 0) return;
            FilterData filterData = (FilterData)dgridFilters.SelectedRows[0].Cells[5].Value; ;
            FilterSettingForm filterSettingForm = new FilterSettingForm(filterData);
            filterSettingForm.ShowDialog();
            if (filterData.name == null) return;
            filterManager.RemoveFilterData(filterData);
            filterManager.AddFilterData(filterData);
            ReloadFilterDatas();
        }

        private void dgridFilters_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            bool enabled = !(bool)dgridFilters.SelectedRows[0].Cells[0].Value;
            FilterData filterData = (FilterData)dgridFilters.SelectedRows[0].Cells[5].Value;
            filterData.enable = enabled;
            dgridFilters.SelectedRows[0].Cells[0].Value = enabled;
            dgridFilters.SelectedRows[0].Cells[5].Value = filterData;
        }

        private void ReloadFilterDatas()
        {
            dgridFilters.Rows.Clear();
            foreach (var filterData in filterManager.filterDatas)
            {
                dgridFilters.Rows.Add(
                    filterData.enable,
                    filterData.name,
                    filterData.method,
                    filterData.destIP,
                    filterData.port,
                    filterData);
            }
        }
    }
}