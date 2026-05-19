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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void отношенияBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.отношенияBindingSource.EndEdit();
            this.отношенияTableAdapter.Update(this.brachnoeAgentstvoDataSet.Отношения);
            MessageBox.Show("Сохранено");

        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "brachnoeAgentstvoDataSet.Отношения". При необходимости она может быть перемещена или удалена.
            this.отношенияTableAdapter.Fill(this.brachnoeAgentstvoDataSet.Отношения);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
