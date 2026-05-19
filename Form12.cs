using System;
using System.Data;
using System.Windows.Forms;

namespace практика
{
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
            this.Text = "Список услуг (фильтры)";
        }

        private void Form12_Load(object sender, EventArgs e)
        {
            // Загрузка основного представления
            this.список_услугTableAdapter.Fill(this.brachnoeAgentstvoDataSet.Список_услуг);

            // Загрузка сотрудников для фильтра
            this.сотрудникиTableAdapter.Fill(this.brachnoeAgentstvoDataSet.Сотрудники);
            comboBoxEmployee.DataSource = сотрудникиBindingSource;
            comboBoxEmployee.DisplayMember = "ФИО";
            comboBoxEmployee.ValueMember = "Код_сотрудника";
            comboBoxEmployee.SelectedIndex = -1;

            // Загрузка услуг для фильтра
            this.дополнительные_услугиTableAdapter.Fill(this.brachnoeAgentstvoDataSet.Дополнительные_услуги);
            comboBoxService.DataSource = дополнительные_услугиBindingSource;
            comboBoxService.DisplayMember = "Наименование";
            comboBoxService.ValueMember = "Код_услуги";
            comboBoxService.SelectedIndex = -1;

            // Устанавливаем дату по умолчанию (сегодня)
            dateTimePickerFilter.Value = DateTime.Now;
        }

        // Применить фильтры
        private void buttonApplyFilter_Click(object sender, EventArgs e)
        {
            string filter = "";

            // Фильтр по дате
            if (checkBoxUseDate.Checked)
            {
                string date = dateTimePickerFilter.Value.ToString("yyyy-MM-dd");
                filter += $"Дата = '{date}' AND ";
            }

            // Фильтр по сотруднику (по полю Сотрудник в представлении)
            if (comboBoxEmployee.SelectedIndex != -1)
            {
                string emp = comboBoxEmployee.Text; // ФИО
                filter += $"Сотрудник = '{emp}' AND ";
            }

            // Фильтр по услуге (проверяем, есть ли поле "Услуга_1" или подходящее)
            // В представлении "Список_услуг" есть поля Услуга_1, Услуга_2, Услуга_3.
            // Можно фильтровать, если любая из услуг совпадает с выбранной.
            if (comboBoxService.SelectedIndex != -1)
            {
                string service = comboBoxService.Text;
                filter += $"(Услуга_1 = '{service}' OR Услуга_2 = '{service}' OR Услуга_3 = '{service}') AND ";
            }

            if (filter.EndsWith(" AND "))
                filter = filter.Substring(0, filter.Length - 5);

            список_услугBindingSource.Filter = filter;
        }

        // Сброс фильтров
        private void buttonResetFilters_Click(object sender, EventArgs e)
        {
            comboBoxEmployee.SelectedIndex = -1;
            comboBoxService.SelectedIndex = -1;
            checkBoxUseDate.Checked = false;
            dateTimePickerFilter.Value = DateTime.Now;
            список_услугBindingSource.Filter = "";
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}