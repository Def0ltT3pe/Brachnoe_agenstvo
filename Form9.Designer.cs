
namespace практика
{
    partial class Form9
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form9));
            System.Windows.Forms.Label код_клиентаLabel;
            System.Windows.Forms.Label датаLabel;
            System.Windows.Forms.Label код_услуги_1Label;
            System.Windows.Forms.Label код_услуги_2Label;
            System.Windows.Forms.Label код_услуги_3Label;
            System.Windows.Forms.Label стоимостьLabel;
            System.Windows.Forms.Label код_сотрудникаLabel;
            this.brachnoeAgentstvoDataSet = new практика.BrachnoeAgentstvoDataSet();
            this.услугиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.услугиTableAdapter = new практика.BrachnoeAgentstvoDataSetTableAdapters.УслугиTableAdapter();
            this.tableAdapterManager = new практика.BrachnoeAgentstvoDataSetTableAdapters.TableAdapterManager();
            this.услугиBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.услугиBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.датаDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.стоимостьTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.клиентыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.клиентыTableAdapter = new практика.BrachnoeAgentstvoDataSetTableAdapters.КлиентыTableAdapter();
            this.дополнительныеуслугиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.дополнительные_услугиTableAdapter = new практика.BrachnoeAgentstvoDataSetTableAdapters.Дополнительные_услугиTableAdapter();
            this.сотрудникиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.сотрудникиTableAdapter = new практика.BrachnoeAgentstvoDataSetTableAdapters.СотрудникиTableAdapter();
            код_клиентаLabel = new System.Windows.Forms.Label();
            датаLabel = new System.Windows.Forms.Label();
            код_услуги_1Label = new System.Windows.Forms.Label();
            код_услуги_2Label = new System.Windows.Forms.Label();
            код_услуги_3Label = new System.Windows.Forms.Label();
            стоимостьLabel = new System.Windows.Forms.Label();
            код_сотрудникаLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.brachnoeAgentstvoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.услугиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.услугиBindingNavigator)).BeginInit();
            this.услугиBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.клиентыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.дополнительныеуслугиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникиBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // brachnoeAgentstvoDataSet
            // 
            this.brachnoeAgentstvoDataSet.DataSetName = "BrachnoeAgentstvoDataSet";
            this.brachnoeAgentstvoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // услугиBindingSource
            // 
            this.услугиBindingSource.DataMember = "Услуги";
            this.услугиBindingSource.DataSource = this.brachnoeAgentstvoDataSet;
            // 
            // услугиTableAdapter
            // 
            this.услугиTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = практика.BrachnoeAgentstvoDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ДолжностиTableAdapter = null;
            this.tableAdapterManager.Дополнительные_услугиTableAdapter = this.дополнительные_услугиTableAdapter;
            this.tableAdapterManager.Знаки_зодиакаTableAdapter = null;
            this.tableAdapterManager.КлиентыTableAdapter = this.клиентыTableAdapter;
            this.tableAdapterManager.НациональностиTableAdapter = null;
            this.tableAdapterManager.ОтношенияTableAdapter = null;
            this.tableAdapterManager.СотрудникиTableAdapter = this.сотрудникиTableAdapter;
            this.tableAdapterManager.УслугиTableAdapter = this.услугиTableAdapter;
            // 
            // услугиBindingNavigator
            // 
            this.услугиBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.услугиBindingNavigator.BindingSource = this.услугиBindingSource;
            this.услугиBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.услугиBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.услугиBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.услугиBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.услугиBindingNavigatorSaveItem});
            this.услугиBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.услугиBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.услугиBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.услугиBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.услугиBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.услугиBindingNavigator.Name = "услугиBindingNavigator";
            this.услугиBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.услугиBindingNavigator.Size = new System.Drawing.Size(800, 31);
            this.услугиBindingNavigator.TabIndex = 0;
            this.услугиBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(55, 20);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // услугиBindingNavigatorSaveItem
            // 
            this.услугиBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.услугиBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("услугиBindingNavigatorSaveItem.Image")));
            this.услугиBindingNavigatorSaveItem.Name = "услугиBindingNavigatorSaveItem";
            this.услугиBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.услугиBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.услугиBindingNavigatorSaveItem.Click += new System.EventHandler(this.услугиBindingNavigatorSaveItem_Click);
            // 
            // код_клиентаLabel
            // 
            код_клиентаLabel.AutoSize = true;
            код_клиентаLabel.Location = new System.Drawing.Point(9, 78);
            код_клиентаLabel.Name = "код_клиентаLabel";
            код_клиентаLabel.Size = new System.Drawing.Size(95, 17);
            код_клиентаLabel.TabIndex = 1;
            код_клиентаLabel.Text = "Код клиента:";
            // 
            // датаLabel
            // 
            датаLabel.AutoSize = true;
            датаLabel.Location = new System.Drawing.Point(9, 107);
            датаLabel.Name = "датаLabel";
            датаLabel.Size = new System.Drawing.Size(46, 17);
            датаLabel.TabIndex = 3;
            датаLabel.Text = "Дата:";
            // 
            // датаDateTimePicker
            // 
            this.датаDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.услугиBindingSource, "Дата", true));
            this.датаDateTimePicker.Location = new System.Drawing.Point(132, 103);
            this.датаDateTimePicker.Name = "датаDateTimePicker";
            this.датаDateTimePicker.Size = new System.Drawing.Size(656, 22);
            this.датаDateTimePicker.TabIndex = 4;
            // 
            // код_услуги_1Label
            // 
            код_услуги_1Label.AutoSize = true;
            код_услуги_1Label.Location = new System.Drawing.Point(9, 134);
            код_услуги_1Label.Name = "код_услуги_1Label";
            код_услуги_1Label.Size = new System.Drawing.Size(95, 17);
            код_услуги_1Label.TabIndex = 5;
            код_услуги_1Label.Text = "Код услуги 1:";
            // 
            // код_услуги_2Label
            // 
            код_услуги_2Label.AutoSize = true;
            код_услуги_2Label.Location = new System.Drawing.Point(9, 162);
            код_услуги_2Label.Name = "код_услуги_2Label";
            код_услуги_2Label.Size = new System.Drawing.Size(95, 17);
            код_услуги_2Label.TabIndex = 7;
            код_услуги_2Label.Text = "Код услуги 2:";
            // 
            // код_услуги_3Label
            // 
            код_услуги_3Label.AutoSize = true;
            код_услуги_3Label.Location = new System.Drawing.Point(9, 190);
            код_услуги_3Label.Name = "код_услуги_3Label";
            код_услуги_3Label.Size = new System.Drawing.Size(95, 17);
            код_услуги_3Label.TabIndex = 9;
            код_услуги_3Label.Text = "Код услуги 3:";
            // 
            // стоимостьLabel
            // 
            стоимостьLabel.AutoSize = true;
            стоимостьLabel.Location = new System.Drawing.Point(9, 218);
            стоимостьLabel.Name = "стоимостьLabel";
            стоимостьLabel.Size = new System.Drawing.Size(82, 17);
            стоимостьLabel.TabIndex = 11;
            стоимостьLabel.Text = "Стоимость:";
            // 
            // стоимостьTextBox
            // 
            this.стоимостьTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.услугиBindingSource, "Стоимость", true));
            this.стоимостьTextBox.Location = new System.Drawing.Point(132, 215);
            this.стоимостьTextBox.Name = "стоимостьTextBox";
            this.стоимостьTextBox.Size = new System.Drawing.Size(656, 22);
            this.стоимостьTextBox.TabIndex = 12;
            // 
            // код_сотрудникаLabel
            // 
            код_сотрудникаLabel.AutoSize = true;
            код_сотрудникаLabel.Location = new System.Drawing.Point(9, 246);
            код_сотрудникаLabel.Name = "код_сотрудникаLabel";
            код_сотрудникаLabel.Size = new System.Drawing.Size(117, 17);
            код_сотрудникаLabel.TabIndex = 13;
            код_сотрудникаLabel.Text = "Код сотрудника:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(323, 402);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 36);
            this.button1.TabIndex = 44;
            this.button1.Text = "Закрыть";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.услугиBindingSource, "Код_клиента", true));
            this.comboBox1.DataSource = this.клиентыBindingSource;
            this.comboBox1.DisplayMember = "ФИО";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(132, 69);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(656, 24);
            this.comboBox1.TabIndex = 45;
            this.comboBox1.ValueMember = "Код_клиента";
            // 
            // comboBox2
            // 
            this.comboBox2.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.услугиBindingSource, "Код_услуги_1", true));
            this.comboBox2.DataSource = this.дополнительныеуслугиBindingSource;
            this.comboBox2.DisplayMember = "Наименование";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(132, 131);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(656, 24);
            this.comboBox2.TabIndex = 46;
            this.comboBox2.ValueMember = "Код_услуги";
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(132, 159);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(656, 24);
            this.comboBox3.TabIndex = 47;
            // 
            // comboBox4
            // 
            this.comboBox4.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.услугиBindingSource, "Код_услуги_3", true));
            this.comboBox4.DataSource = this.дополнительныеуслугиBindingSource;
            this.comboBox4.DisplayMember = "Наименование";
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(132, 187);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(656, 24);
            this.comboBox4.TabIndex = 48;
            this.comboBox4.ValueMember = "Код_услуги";
            // 
            // comboBox5
            // 
            this.comboBox5.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.услугиBindingSource, "Код_сотрудника", true));
            this.comboBox5.DataSource = this.сотрудникиBindingSource;
            this.comboBox5.DisplayMember = "ФИО";
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Location = new System.Drawing.Point(132, 243);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(656, 24);
            this.comboBox5.TabIndex = 49;
            this.comboBox5.ValueMember = "Код_сотрудника";
            // 
            // клиентыBindingSource
            // 
            this.клиентыBindingSource.DataMember = "Клиенты";
            this.клиентыBindingSource.DataSource = this.brachnoeAgentstvoDataSet;
            // 
            // клиентыTableAdapter
            // 
            this.клиентыTableAdapter.ClearBeforeFill = true;
            // 
            // дополнительныеуслугиBindingSource
            // 
            this.дополнительныеуслугиBindingSource.DataMember = "Дополнительные_услуги";
            this.дополнительныеуслугиBindingSource.DataSource = this.brachnoeAgentstvoDataSet;
            // 
            // дополнительные_услугиTableAdapter
            // 
            this.дополнительные_услугиTableAdapter.ClearBeforeFill = true;
            // 
            // сотрудникиBindingSource
            // 
            this.сотрудникиBindingSource.DataMember = "Сотрудники";
            this.сотрудникиBindingSource.DataSource = this.brachnoeAgentstvoDataSet;
            // 
            // сотрудникиTableAdapter
            // 
            this.сотрудникиTableAdapter.ClearBeforeFill = true;
            // 
            // Form9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBox5);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(код_клиентаLabel);
            this.Controls.Add(датаLabel);
            this.Controls.Add(this.датаDateTimePicker);
            this.Controls.Add(код_услуги_1Label);
            this.Controls.Add(код_услуги_2Label);
            this.Controls.Add(код_услуги_3Label);
            this.Controls.Add(стоимостьLabel);
            this.Controls.Add(this.стоимостьTextBox);
            this.Controls.Add(код_сотрудникаLabel);
            this.Controls.Add(this.услугиBindingNavigator);
            this.Name = "Form9";
            this.Text = "Услуги (заказы)";
            this.Load += new System.EventHandler(this.Form9_Load);
            ((System.ComponentModel.ISupportInitialize)(this.brachnoeAgentstvoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.услугиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.услугиBindingNavigator)).EndInit();
            this.услугиBindingNavigator.ResumeLayout(false);
            this.услугиBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.клиентыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.дополнительныеуслугиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникиBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BrachnoeAgentstvoDataSet brachnoeAgentstvoDataSet;
        private System.Windows.Forms.BindingSource услугиBindingSource;
        private BrachnoeAgentstvoDataSetTableAdapters.УслугиTableAdapter услугиTableAdapter;
        private BrachnoeAgentstvoDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator услугиBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton услугиBindingNavigatorSaveItem;
        private System.Windows.Forms.DateTimePicker датаDateTimePicker;
        private System.Windows.Forms.TextBox стоимостьTextBox;
        private BrachnoeAgentstvoDataSetTableAdapters.КлиентыTableAdapter клиентыTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.BindingSource клиентыBindingSource;
        private BrachnoeAgentstvoDataSetTableAdapters.Дополнительные_услугиTableAdapter дополнительные_услугиTableAdapter;
        private System.Windows.Forms.BindingSource дополнительныеуслугиBindingSource;
        private BrachnoeAgentstvoDataSetTableAdapters.СотрудникиTableAdapter сотрудникиTableAdapter;
        private System.Windows.Forms.BindingSource сотрудникиBindingSource;
    }
}