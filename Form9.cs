using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace практика
{
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void услугиBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.услугиBindingSource.EndEdit();
            this.услугиTableAdapter.Update(this.brachnoeAgentstvoDataSet.Услуги);
            MessageBox.Show("Сохранено");
        }

        private void Form9_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "brachnoeAgentstvoDataSet.Сотрудники". При необходимости она может быть перемещена или удалена.
            this.сотрудникиTableAdapter.Fill(this.brachnoeAgentstvoDataSet.Сотрудники);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "brachnoeAgentstvoDataSet.Дополнительные_услуги". При необходимости она может быть перемещена или удалена.
            this.дополнительные_услугиTableAdapter.Fill(this.brachnoeAgentstvoDataSet.Дополнительные_услуги);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "brachnoeAgentstvoDataSet.Клиенты". При необходимости она может быть перемещена или удалена.
            this.клиентыTableAdapter.Fill(this.brachnoeAgentstvoDataSet.Клиенты);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "brachnoeAgentstvoDataSet.Услуги". При необходимости она может быть перемещена или удалена.
            this.услугиTableAdapter.Fill(this.brachnoeAgentstvoDataSet.Услуги);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
