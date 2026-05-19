using System;
using System.ComponentModel;
using System.Data;        // ← добавить для DataRowView
using System.Linq;
using System.Windows.Forms;

namespace практика
{
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
            this.Text = "Отдел кадров";
        }

        private void Form10_Load(object sender, EventArgs e)
        {
            this.отдел_кадровTableAdapter.Fill(this.brachnoeAgentstvoDataSet.Отдел_кадров);

            comboBoxSortField.Items.Clear();
            comboBoxSortField.Items.AddRange(new[] { "Сотрудник", "Возраст", "Оклад", "Должность" });
            comboBoxSortField.SelectedIndex = 0;

            if (отдел_кадровBindingSource.Count > 0)
            {
                var positions = отдел_кадровBindingSource
                    .Cast<DataRowView>()
                    .Select(r => r["Должность"].ToString())
                    .Distinct()
                    .OrderBy(p => p)
                    .ToList();
                comboBoxFilter.Items.Clear();
                comboBoxFilter.Items.Add("Все");
                comboBoxFilter.Items.AddRange(positions.ToArray());
                comboBoxFilter.SelectedIndex = 0;
            }
        }

        private void buttonSort_Click(object sender, EventArgs e)
        {
            if (comboBoxSortField.SelectedItem == null) return;
            string field = comboBoxSortField.SelectedItem.ToString();

            DataGridViewColumn col = null;
            foreach (DataGridViewColumn c in отдел_кадровDataGridView.Columns)
            {
                if (c.HeaderText == field)
                {
                    col = c;
                    break;
                }
            }
            if (col != null)
            {
                ListSortDirection direction = radioButtonAsc.Checked
                    ? ListSortDirection.Ascending
                    : ListSortDirection.Descending;
                отдел_кадровDataGridView.Sort(col, direction);
            }
        }

        private void buttonFind_Click(object sender, EventArgs e)
        {
            string search = textBoxFind.Text.Trim();
            if (string.IsNullOrEmpty(search))
                отдел_кадровBindingSource.Filter = "";
            else
                отдел_кадровBindingSource.Filter = $"Сотрудник LIKE '%{search}%' OR Должность LIKE '%{search}%'";
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            отдел_кадровBindingSource.Filter = "";
            textBoxFind.Text = "";
            comboBoxFilter.SelectedIndex = 0;
        }

        private void comboBoxFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxFilter.SelectedIndex == 0)
                отдел_кадровBindingSource.Filter = "";
            else
                отдел_кадровBindingSource.Filter = $"Должность = '{comboBoxFilter.SelectedItem}'";
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Пустые обработчики для старых элементов (если они есть)
        private void отдел_кадровDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void radioButton1_CheckedChanged(object sender, EventArgs e) { }
        private void button2_Click(object sender, EventArgs e) { }

        // Добавьте недостающий метод, если ошибка просит
        private void radioButtonDesc_CheckedChanged(object sender, EventArgs e) { }

        private void comboBoxFilter_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (comboBoxFilter.SelectedIndex == 0)
                отдел_кадровBindingSource.Filter = "";
            else
                отдел_кадровBindingSource.Filter = $"Должность = '{comboBoxFilter.SelectedItem}'";
        }
    }
}