using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogViewer
{
    public delegate void FilterCallback();

    public partial class FilterForm : Form
    {
        public static List<Filter> filters = new List<Filter>();
        public static event FilterCallback filtersChanged;

        public FilterForm()
        {
            InitializeComponent();
        }

        private void FilterForm_Load(object sender, EventArgs e)
        {

        }

        private void newButton_Click(object sender, EventArgs e)
        {
            FilterEditor editor = new FilterEditor();
            DialogResult dr = editor.ShowDialog();
            if (dr == DialogResult.Cancel) return;

            Filter filter = editor.GetFilter();
            if (filter.variableName == "") return;
            filters.Add(filter);
            filterList.Items.Add(filter.Label());
            filterList.Refresh();

            filtersChanged?.Invoke();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            int index = filterList.SelectedIndex;
            FilterEditor editor = new FilterEditor(filters[index]);
            DialogResult dr = editor.ShowDialog();
            if (dr == DialogResult.Cancel) return;

            Filter filter = editor.GetFilter();
            filters[index] = filter;
            filterList.Items[index] = filter.Label();

            filtersChanged?.Invoke();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            int index = filterList.SelectedIndex;
            filterList.Items.RemoveAt(index);
            filters.RemoveAt(index);

            filtersChanged?.Invoke();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                Hide();
            }
        }

        private void filterList_SelectedValueChanged(object sender, EventArgs e)
        {
            if(filterList.SelectedIndex != -1)
            {
                editButton.Enabled = true;
                deleteButton.Enabled = true;
            }
        }
    }

    public class Filter
    {
        public string variableName;
        public decimal lessThan = decimal.MaxValue;
        public decimal greaterThan = decimal.MinValue;

        public string Label()
        {
            string lessThanString = lessThan == decimal.MaxValue ? "" : ", less than " + lessThan.ToString();
            string greaterThanString = greaterThan == decimal.MinValue ? "" : ", greater than " + greaterThan.ToString();
            return variableName + lessThanString + greaterThanString;
        }
    }
}
