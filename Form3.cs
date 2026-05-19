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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void должностиBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.должностиBindingSource.EndEdit();
            this.должностиTableAdapter.Update(this.brachnoeAgentstvoDataSet.Должности);
            MessageBox.Show("Сохранено");

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "brachnoeAgentstvoDataSet.Должности". При необходимости она может быть перемещена или удалена.
            this.должностиTableAdapter.Fill(this.brachnoeAgentstvoDataSet.Должности);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
