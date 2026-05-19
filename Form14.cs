using System;
using System.Drawing;
using System.Windows.Forms;

namespace практика
{
    public partial class Form14 : Form
    {
        public Form14()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Size = new Size(600, 400);
            this.BackColor = Color.DarkGray;

            Label lbl = new Label();
            lbl.Text = "Брачное агентство «Сердце»\nЗагрузка...";
            lbl.Font = new Font("Segoe UI", 18, FontStyle.Bold);
            lbl.ForeColor = Color.White;
            lbl.BackColor = Color.LightBlue;
            lbl.TextAlign = ContentAlignment.MiddleCenter;
            lbl.Dock = DockStyle.Fill;
            this.Controls.Add(lbl);

            Timer timer = new Timer();
            timer.Interval = 2000;
            timer.Tick += (s, e) =>
            {
                timer.Stop();
                this.Hide();
                Form1 main = new Form1();
                main.ShowDialog();
                this.Close();
            };
            timer.Start();
        }
    }
}