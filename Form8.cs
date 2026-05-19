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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void клиентыBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.клиентыBindingSource.EndEdit();
            this.клиентыTableAdapter.Update(this.brachnoeAgentstvoDataSet.Клиенты);
            MessageBox.Show("Сохранено");
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "brachnoeAgentstvoDataSet.Национальности". При необходимости она может быть перемещена или удалена.
            this.национальностиTableAdapter.Fill(this.brachnoeAgentstvoDataSet.Национальности);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "brachnoeAgentstvoDataSet.Отношения". При необходимости она может быть перемещена или удалена.
            this.отношенияTableAdapter.Fill(this.brachnoeAgentstvoDataSet.Отношения);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "brachnoeAgentstvoDataSet.Знаки_зодиака". При необходимости она может быть перемещена или удалена.
            this.знаки_зодиакаTableAdapter.Fill(this.brachnoeAgentstvoDataSet.Знаки_зодиака);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "brachnoeAgentstvoDataSet.Клиенты". При необходимости она может быть перемещена или удалена.
            this.клиентыTableAdapter.Fill(this.brachnoeAgentstvoDataSet.Клиенты);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.клиентыTableAdapter.Fill(this.brachnoeAgentstvoDataSet.Клиенты);
            this.знаки_зодиакаTableAdapter.Fill(this.brachnoeAgentstvoDataSet.Знаки_зодиака);
            this.отношенияTableAdapter.Fill(this.brachnoeAgentstvoDataSet.Отношения);
            this.национальностиTableAdapter.Fill(this.brachnoeAgentstvoDataSet.Национальности);
            this.Close();
        }
    }
}
