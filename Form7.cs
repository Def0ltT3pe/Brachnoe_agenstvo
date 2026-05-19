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
    public partial class Form7 : Form
    {


        public Form7()
        {
            InitializeComponent();
        }

        private void дополнительные_услугиBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.дополнительные_услугиBindingSource.EndEdit();
            this.дополнительные_услугиTableAdapter.Update(this.brachnoeAgentstvoDataSet.Дополнительные_услуги);
            MessageBox.Show("Сохранено");
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "brachnoeAgentstvoDataSet.Сотрудники". При необходимости она может быть перемещена или удалена.
            this.сотрудникиTableAdapter.Fill(this.brachnoeAgentstvoDataSet.Сотрудники);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "brachnoeAgentstvoDataSet.Дополнительные_услуги". При необходимости она может быть перемещена или удалена.
            this.дополнительные_услугиTableAdapter.Fill(this.brachnoeAgentstvoDataSet.Дополнительные_услуги);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
