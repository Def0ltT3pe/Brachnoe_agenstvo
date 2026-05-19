
namespace практика
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button15 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(226, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(407, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Брачное Агенство \"Сердце\"";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(81, 122);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(651, 225);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button9);
            this.tabPage1.Controls.Add(this.button8);
            this.tabPage1.Controls.Add(this.button6);
            this.tabPage1.Controls.Add(this.button5);
            this.tabPage1.Controls.Add(this.button4);
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(643, 196);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Формы";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(310, 67);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(112, 43);
            this.button9.TabIndex = 8;
            this.button9.Text = "Услуги (заказы)";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.Button_Услуги_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(192, 67);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(112, 43);
            this.button8.TabIndex = 7;
            this.button8.Text = "Клиенты";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.Button_Клиенты_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(74, 67);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(112, 43);
            this.button6.TabIndex = 5;
            this.button6.Text = "Доп. услуги";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.Button_Доп_услуги_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(436, 67);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(129, 43);
            this.button5.TabIndex = 4;
            this.button5.Text = "Национальности";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.Button_Национальности_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(436, 6);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(112, 43);
            this.button4.TabIndex = 3;
            this.button4.Text = "Типы отношений";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Button_Типы_отношений_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(310, 6);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(112, 43);
            this.button3.TabIndex = 2;
            this.button3.Text = "Знаки зодиака";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button_Знаки_Зодиака_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(192, 6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 43);
            this.button2.TabIndex = 1;
            this.button2.Text = "Должности";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button_Должности_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(74, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 43);
            this.button1.TabIndex = 0;
            this.button1.Text = "Сотрудники";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button_Сотрудники_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button15);
            this.tabPage2.Controls.Add(this.button14);
            this.tabPage2.Controls.Add(this.button13);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(643, 196);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Отчеты";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(30, 122);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(590, 37);
            this.button15.TabIndex = 2;
            this.button15.Text = "Список услуг";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.Button_Список_Услуг_Click);
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(30, 63);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(590, 37);
            this.button14.TabIndex = 1;
            this.button14.Text = "Список клиентов";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.Button_Список_Клиентов_Click);
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(30, 6);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(590, 37);
            this.button13.TabIndex = 0;
            this.button13.Text = "Отдел кадров";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.Button_Отдел_Кадров_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "База данных \"Брачное агентство\"";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button13;
    }
}

