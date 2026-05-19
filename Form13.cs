using System;
using System.Data;
using System.Windows.Forms;

namespace практика
{
    public partial class Form13 : Form
    {
        public Form13()
        {
            InitializeComponent();
            this.Text = "Список клиентов (фильтры)";
        }

        private void Form13_Load(object sender, EventArgs e)
        {
            // Загружаем данные для списка клиентов
            this.список_клиентовTableAdapter.Fill(this.brachnoeAgentstvoDataSet.Список_клиентов);

            // Загружаем знаки зодиака и заполняем comboBoxSign
            this.знаки_зодиакаTableAdapter.Fill(this.brachnoeAgentstvoDataSet.Знаки_зодиака);
            comboBoxSign.Items.Clear();
            comboBoxSign.Items.Add(""); // пустой пункт
            foreach (DataRow row in this.brachnoeAgentstvoDataSet.Знаки_зодиака.Rows)
                comboBoxSign.Items.Add(row["Наименование"].ToString());
            comboBoxSign.SelectedIndex = 0;

            // Загружаем отношения
            this.отношенияTableAdapter.Fill(this.brachnoeAgentstvoDataSet.Отношения);
            comboBoxRelation.Items.Clear();
            comboBoxRelation.Items.Add("");
            foreach (DataRow row in this.brachnoeAgentstvoDataSet.Отношения.Rows)
                comboBoxRelation.Items.Add(row["Наименование"].ToString());
            comboBoxRelation.SelectedIndex = 0;

            // Загружаем национальности
            this.национальностиTableAdapter.Fill(this.brachnoeAgentstvoDataSet.Национальности);
            comboBoxNationality.Items.Clear();
            comboBoxNationality.Items.Add("");
            foreach (DataRow row in this.brachnoeAgentstvoDataSet.Национальности.Rows)
                comboBoxNationality.Items.Add(row["Наименование"].ToString());
            comboBoxNationality.SelectedIndex = 0;

            // Семейное положение – вручную
            comboBoxMarital.Items.Clear();
            comboBoxMarital.Items.AddRange(new string[] { "", "Холост", "Не замужем", "Разведён", "Разведена", "Вдова", "В гражданском браке" });
            comboBoxMarital.SelectedIndex = 0;
            список_клиентовDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
        }

        // Применить фильтры
        private void buttonApplyFilter_Click(object sender, EventArgs e)
        {
            string filter = "";

            if (comboBoxSign.SelectedIndex > 0)
                filter += $"Знак_зодиака = '{comboBoxSign.Text}' AND ";

            if (comboBoxRelation.SelectedIndex > 0)
                filter += $"Тип_отношений = '{comboBoxRelation.Text}' AND ";

            if (comboBoxNationality.SelectedIndex > 0)
                filter += $"Национальность = '{comboBoxNationality.Text}' AND ";

            if (!string.IsNullOrWhiteSpace(textBoxHobby.Text))
                filter += $"Хобби LIKE '%{textBoxHobby.Text.Trim().Replace("'", "''")}%' AND ";

            if (comboBoxMarital.SelectedIndex > 0)
                filter += $"Семейное_положение = '{comboBoxMarital.Text}' AND ";

            if (filter.EndsWith(" AND "))
                filter = filter.Substring(0, filter.Length - 5);

            список_клиентовBindingSource.Filter = filter;
        }

        // Сброс фильтров
        private void buttonResetFilters_Click(object sender, EventArgs e)
        {
            comboBoxSign.SelectedIndex = 0;
            comboBoxRelation.SelectedIndex = 0;
            comboBoxNationality.SelectedIndex = 0;
            textBoxHobby.Text = "";
            comboBoxMarital.SelectedIndex = 0;
            список_клиентовBindingSource.Filter = "";
        }

        // Закрыть форму
        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBoxMarital_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}