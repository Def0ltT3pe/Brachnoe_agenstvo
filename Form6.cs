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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void национальностиBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.национальностиBindingSource.EndEdit();
            this.национальностиTableAdapter.Update(this.brachnoeAgentstvoDataSet.Национальности);
            MessageBox.Show("Сохранено");

        }

        private void Form6_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "brachnoeAgentstvoDataSet.Национальности". При необходимости она может быть перемещена или удалена.
            this.национальностиTableAdapter.Fill(this.brachnoeAgentstvoDataSet.Национальности);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
