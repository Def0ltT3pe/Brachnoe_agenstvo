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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void знаки_зодиакаBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.знаки_зодиакаBindingSource.EndEdit();
            this.знаки_зодиакаTableAdapter.Update(this.brachnoeAgentstvoDataSet.Знаки_зодиака);
            MessageBox.Show("Сохранено");
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "brachnoeAgentstvoDataSet.Знаки_зодиака". При необходимости она может быть перемещена или удалена.
            this.знаки_зодиакаTableAdapter.Fill(this.brachnoeAgentstvoDataSet.Знаки_зодиака);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
