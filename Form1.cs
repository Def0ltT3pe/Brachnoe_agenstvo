using System;
using System.Windows.Forms;

namespace практика
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Text = "База данных \"Брачное агентство\"";
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        // Далее обработчики кнопок (создаются двойным щелчком по каждой кнопке)
        // Ниже примеры. Вы должны дважды щёлкнуть по каждой кнопке на форме,
        // чтобы Visual Studio создала заготовку, а затем вставить тело метода.

        private void button_Сотрудники_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.Show();
        }

        private void button_Должности_Click(object sender, EventArgs e)
        {
            Form3 frm = new Form3();
            frm.Show();
        }

        private void Button_Знаки_Зодиака_Click(object sender, EventArgs e)
        {
            Form4 frm = new Form4();
            frm.Show();
        }

        private void Button_Типы_отношений_Click(object sender, EventArgs e)
        {
            Form5 frm = new Form5();
            frm.Show();
        }

        private void Button_Национальности_Click(object sender, EventArgs e)
        {
            Form6 frm = new Form6();
            frm.Show();
        }

        private void Button_Доп_услуги_Click(object sender, EventArgs e)
        {
            Form11 frm = new Form11();
            frm.Show();
        }

        private void Button_Сотрудники_Click(object sender, EventArgs e)
        {
            Form7 frm = new Form7();
            frm.Show();
        }

        private void Button_Клиенты_Click(object sender, EventArgs e)
        {
            Form8 frm = new Form8();
            frm.Show();
        }

        private void Button_Услуги_Click(object sender, EventArgs e)
        {
            Form9 frm = new Form9();
            frm.Show();
        }

        private void Button_Отдел_Кадров_Click(object sender, EventArgs e)
        {
            Form10 frm = new Form10();
            frm.Show();
        }

        private void Button_Список_Клиентов_Click(object sender, EventArgs e)
        {
            Form13 frm = new Form13();
            frm.Show();
        }

        private void Button_Список_Услуг_Click(object sender, EventArgs e)
        {
            Form12 frm = new Form12();
            frm.Show();
        }
        private void button_Выход_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_ОПрограмме_Click(object sender, EventArgs e)
        {
            //Form13 frm = new Form13();
            //frm.ShowDialog();
        }

        private void button_Гистограмма_Click(object sender, EventArgs e)
        {
            //Form15 frm = new Form15();
            //frm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}