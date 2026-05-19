
namespace практика
{
    partial class Form12
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form12));
            this.brachnoeAgentstvoDataSet = new практика.BrachnoeAgentstvoDataSet();
            this.список_услугBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.список_услугTableAdapter = new практика.BrachnoeAgentstvoDataSetTableAdapters.Список_услугTableAdapter();
            this.tableAdapterManager = new практика.BrachnoeAgentstvoDataSetTableAdapters.TableAdapterManager();
            this.дополнительные_услугиTableAdapter = new практика.BrachnoeAgentstvoDataSetTableAdapters.Дополнительные_услугиTableAdapter();
            this.сотрудникиTableAdapter = new практика.BrachnoeAgentstvoDataSetTableAdapters.СотрудникиTableAdapter();
            this.услугиTableAdapter = new практика.BrachnoeAgentstvoDataSetTableAdapters.УслугиTableAdapter();
            this.список_услугBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.список_услугBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.список_услугDataGridView = new System.Windows.Forms.DataGridView();
            this.датаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.клиентDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.услуга1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.услуга2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.услуга3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.стоимостьDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.сотрудникDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.должностьDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePickerFilter = new System.Windows.Forms.DateTimePicker();
            this.checkBoxUseDate = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxEmployee = new System.Windows.Forms.ComboBox();
            this.buttonApplyFilter = new System.Windows.Forms.Button();
            this.buttonResetFilters = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxService = new System.Windows.Forms.ComboBox();
            this.дополнительные_услугиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.услугиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.сотрудникиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.brachnoeAgentstvoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.список_услугBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.список_услугBindingNavigator)).BeginInit();
            this.список_услугBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.список_услугDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.дополнительные_услугиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.услугиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникиBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // brachnoeAgentstvoDataSet
            // 
            this.brachnoeAgentstvoDataSet.DataSetName = "BrachnoeAgentstvoDataSet";
            this.brachnoeAgentstvoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // список_услугBindingSource
            // 
            this.список_услугBindingSource.DataMember = "Список_услуг";
            this.список_услугBindingSource.DataSource = this.brachnoeAgentstvoDataSet;
            // 
            // список_услугTableAdapter
            // 
            this.список_услугTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = практика.BrachnoeAgentstvoDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ДолжностиTableAdapter = null;
            this.tableAdapterManager.Дополнительные_услугиTableAdapter = this.дополнительные_услугиTableAdapter;
            this.tableAdapterManager.Знаки_зодиакаTableAdapter = null;
            this.tableAdapterManager.КлиентыTableAdapter = null;
            this.tableAdapterManager.НациональностиTableAdapter = null;
            this.tableAdapterManager.ОтношенияTableAdapter = null;
            this.tableAdapterManager.СотрудникиTableAdapter = this.сотрудникиTableAdapter;
            this.tableAdapterManager.УслугиTableAdapter = this.услугиTableAdapter;
            // 
            // дополнительные_услугиTableAdapter
            // 
            this.дополнительные_услугиTableAdapter.ClearBeforeFill = true;
            // 
            // сотрудникиTableAdapter
            // 
            this.сотрудникиTableAdapter.ClearBeforeFill = true;
            // 
            // услугиTableAdapter
            // 
            this.услугиTableAdapter.ClearBeforeFill = true;
            // 
            // список_услугBindingNavigator
            // 
            this.список_услугBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.список_услугBindingNavigator.BindingSource = this.список_услугBindingSource;
            this.список_услугBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.список_услугBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.список_услугBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.список_услугBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.список_услугBindingNavigatorSaveItem});
            this.список_услугBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.список_услугBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.список_услугBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.список_услугBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.список_услугBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.список_услугBindingNavigator.Name = "список_услугBindingNavigator";
            this.список_услугBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.список_услугBindingNavigator.Size = new System.Drawing.Size(1041, 27);
            this.список_услугBindingNavigator.TabIndex = 0;
            this.список_услугBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(55, 24);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
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
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
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
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // список_услугBindingNavigatorSaveItem
            // 
            this.список_услугBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.список_услугBindingNavigatorSaveItem.Enabled = false;
            this.список_услугBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("список_услугBindingNavigatorSaveItem.Image")));
            this.список_услугBindingNavigatorSaveItem.Name = "список_услугBindingNavigatorSaveItem";
            this.список_услугBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.список_услугBindingNavigatorSaveItem.Text = "Сохранить данные";
            // 
            // список_услугDataGridView
            // 
            this.список_услугDataGridView.AutoGenerateColumns = false;
            this.список_услугDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.список_услугDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.датаDataGridViewTextBoxColumn,
            this.клиентDataGridViewTextBoxColumn,
            this.услуга1DataGridViewTextBoxColumn,
            this.услуга2DataGridViewTextBoxColumn,
            this.услуга3DataGridViewTextBoxColumn,
            this.стоимостьDataGridViewTextBoxColumn,
            this.сотрудникDataGridViewTextBoxColumn,
            this.должностьDataGridViewTextBoxColumn});
            this.список_услугDataGridView.DataSource = this.список_услугBindingSource;
            this.список_услугDataGridView.Location = new System.Drawing.Point(12, 111);
            this.список_услугDataGridView.Name = "список_услугDataGridView";
            this.список_услугDataGridView.RowHeadersWidth = 51;
            this.список_услугDataGridView.RowTemplate.Height = 24;
            this.список_услугDataGridView.Size = new System.Drawing.Size(1028, 335);
            this.список_услугDataGridView.TabIndex = 1;
            // 
            // датаDataGridViewTextBoxColumn
            // 
            this.датаDataGridViewTextBoxColumn.DataPropertyName = "Дата";
            this.датаDataGridViewTextBoxColumn.HeaderText = "Дата";
            this.датаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.датаDataGridViewTextBoxColumn.Name = "датаDataGridViewTextBoxColumn";
            this.датаDataGridViewTextBoxColumn.Width = 125;
            // 
            // клиентDataGridViewTextBoxColumn
            // 
            this.клиентDataGridViewTextBoxColumn.DataPropertyName = "Клиент";
            this.клиентDataGridViewTextBoxColumn.HeaderText = "Клиент";
            this.клиентDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.клиентDataGridViewTextBoxColumn.Name = "клиентDataGridViewTextBoxColumn";
            this.клиентDataGridViewTextBoxColumn.Width = 125;
            // 
            // услуга1DataGridViewTextBoxColumn
            // 
            this.услуга1DataGridViewTextBoxColumn.DataPropertyName = "Услуга_1";
            this.услуга1DataGridViewTextBoxColumn.HeaderText = "Услуга_1";
            this.услуга1DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.услуга1DataGridViewTextBoxColumn.Name = "услуга1DataGridViewTextBoxColumn";
            this.услуга1DataGridViewTextBoxColumn.Width = 125;
            // 
            // услуга2DataGridViewTextBoxColumn
            // 
            this.услуга2DataGridViewTextBoxColumn.DataPropertyName = "Услуга_2";
            this.услуга2DataGridViewTextBoxColumn.HeaderText = "Услуга_2";
            this.услуга2DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.услуга2DataGridViewTextBoxColumn.Name = "услуга2DataGridViewTextBoxColumn";
            this.услуга2DataGridViewTextBoxColumn.Width = 125;
            // 
            // услуга3DataGridViewTextBoxColumn
            // 
            this.услуга3DataGridViewTextBoxColumn.DataPropertyName = "Услуга_3";
            this.услуга3DataGridViewTextBoxColumn.HeaderText = "Услуга_3";
            this.услуга3DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.услуга3DataGridViewTextBoxColumn.Name = "услуга3DataGridViewTextBoxColumn";
            this.услуга3DataGridViewTextBoxColumn.Width = 125;
            // 
            // стоимостьDataGridViewTextBoxColumn
            // 
            this.стоимостьDataGridViewTextBoxColumn.DataPropertyName = "Стоимость";
            this.стоимостьDataGridViewTextBoxColumn.HeaderText = "Стоимость";
            this.стоимостьDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.стоимостьDataGridViewTextBoxColumn.Name = "стоимостьDataGridViewTextBoxColumn";
            this.стоимостьDataGridViewTextBoxColumn.Width = 125;
            // 
            // сотрудникDataGridViewTextBoxColumn
            // 
            this.сотрудникDataGridViewTextBoxColumn.DataPropertyName = "Сотрудник";
            this.сотрудникDataGridViewTextBoxColumn.HeaderText = "Сотрудник";
            this.сотрудникDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.сотрудникDataGridViewTextBoxColumn.Name = "сотрудникDataGridViewTextBoxColumn";
            this.сотрудникDataGridViewTextBoxColumn.Width = 125;
            // 
            // должностьDataGridViewTextBoxColumn
            // 
            this.должностьDataGridViewTextBoxColumn.DataPropertyName = "Должность";
            this.должностьDataGridViewTextBoxColumn.HeaderText = "Должность";
            this.должностьDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.должностьDataGridViewTextBoxColumn.Name = "должностьDataGridViewTextBoxColumn";
            this.должностьDataGridViewTextBoxColumn.Width = 125;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(343, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Дата заказа:";
            // 
            // dateTimePickerFilter
            // 
            this.dateTimePickerFilter.Location = new System.Drawing.Point(445, 9);
            this.dateTimePickerFilter.Name = "dateTimePickerFilter";
            this.dateTimePickerFilter.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerFilter.TabIndex = 3;
            // 
            // checkBoxUseDate
            // 
            this.checkBoxUseDate.AutoSize = true;
            this.checkBoxUseDate.Location = new System.Drawing.Point(652, 9);
            this.checkBoxUseDate.Name = "checkBoxUseDate";
            this.checkBoxUseDate.Size = new System.Drawing.Size(230, 21);
            this.checkBoxUseDate.TabIndex = 4;
            this.checkBoxUseDate.Text = "Использовать фильтр по дате";
            this.checkBoxUseDate.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(343, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Сотрудник:";
            // 
            // comboBoxEmployee
            // 
            this.comboBoxEmployee.FormattingEnabled = true;
            this.comboBoxEmployee.Location = new System.Drawing.Point(445, 41);
            this.comboBoxEmployee.Name = "comboBoxEmployee";
            this.comboBoxEmployee.Size = new System.Drawing.Size(200, 24);
            this.comboBoxEmployee.TabIndex = 6;
            // 
            // buttonApplyFilter
            // 
            this.buttonApplyFilter.Location = new System.Drawing.Point(888, 9);
            this.buttonApplyFilter.Name = "buttonApplyFilter";
            this.buttonApplyFilter.Size = new System.Drawing.Size(152, 26);
            this.buttonApplyFilter.TabIndex = 7;
            this.buttonApplyFilter.Text = "Применить фильтр";
            this.buttonApplyFilter.UseVisualStyleBackColor = true;
            this.buttonApplyFilter.Click += new System.EventHandler(this.buttonApplyFilter_Click);
            // 
            // buttonResetFilters
            // 
            this.buttonResetFilters.Location = new System.Drawing.Point(888, 37);
            this.buttonResetFilters.Name = "buttonResetFilters";
            this.buttonResetFilters.Size = new System.Drawing.Size(152, 25);
            this.buttonResetFilters.TabIndex = 8;
            this.buttonResetFilters.Text = "Сброс";
            this.buttonResetFilters.UseVisualStyleBackColor = true;
            this.buttonResetFilters.Click += new System.EventHandler(this.buttonResetFilters_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(888, 68);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(117, 26);
            this.buttonClose.TabIndex = 9;
            this.buttonClose.Text = "Закрыть";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(343, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Услуга:";
            // 
            // comboBoxService
            // 
            this.comboBoxService.FormattingEnabled = true;
            this.comboBoxService.Location = new System.Drawing.Point(445, 73);
            this.comboBoxService.Name = "comboBoxService";
            this.comboBoxService.Size = new System.Drawing.Size(200, 24);
            this.comboBoxService.TabIndex = 12;
            // 
            // дополнительные_услугиBindingSource
            // 
            this.дополнительные_услугиBindingSource.DataMember = "Дополнительные_услуги";
            this.дополнительные_услугиBindingSource.DataSource = this.brachnoeAgentstvoDataSet;
            // 
            // услугиBindingSource
            // 
            this.услугиBindingSource.DataMember = "Услуги";
            this.услугиBindingSource.DataSource = this.brachnoeAgentstvoDataSet;
            // 
            // сотрудникиBindingSource
            // 
            this.сотрудникиBindingSource.DataMember = "Сотрудники";
            this.сотрудникиBindingSource.DataSource = this.brachnoeAgentstvoDataSet;
            // 
            // Form12
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1041, 450);
            this.Controls.Add(this.comboBoxService);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonResetFilters);
            this.Controls.Add(this.buttonApplyFilter);
            this.Controls.Add(this.comboBoxEmployee);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.checkBoxUseDate);
            this.Controls.Add(this.dateTimePickerFilter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.список_услугDataGridView);
            this.Controls.Add(this.список_услугBindingNavigator);
            this.Name = "Form12";
            this.Text = "Список клиентов";
            this.Load += new System.EventHandler(this.Form12_Load);
            ((System.ComponentModel.ISupportInitialize)(this.brachnoeAgentstvoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.список_услугBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.список_услугBindingNavigator)).EndInit();
            this.список_услугBindingNavigator.ResumeLayout(false);
            this.список_услугBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.список_услугDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.дополнительные_услугиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.услугиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникиBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BrachnoeAgentstvoDataSet brachnoeAgentstvoDataSet;
        private System.Windows.Forms.BindingSource список_услугBindingSource;
        private BrachnoeAgentstvoDataSetTableAdapters.Список_услугTableAdapter список_услугTableAdapter;
        private BrachnoeAgentstvoDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator список_услугBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton список_услугBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView список_услугDataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePickerFilter;
        private System.Windows.Forms.CheckBox checkBoxUseDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxEmployee;
        private System.Windows.Forms.Button buttonApplyFilter;
        private System.Windows.Forms.Button buttonResetFilters;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxService;
        private BrachnoeAgentstvoDataSetTableAdapters.Дополнительные_услугиTableAdapter дополнительные_услугиTableAdapter;
        private System.Windows.Forms.BindingSource дополнительные_услугиBindingSource;
        private BrachnoeAgentstvoDataSetTableAdapters.УслугиTableAdapter услугиTableAdapter;
        private System.Windows.Forms.BindingSource услугиBindingSource;
        private BrachnoeAgentstvoDataSetTableAdapters.СотрудникиTableAdapter сотрудникиTableAdapter;
        private System.Windows.Forms.BindingSource сотрудникиBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn клиентDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn услуга1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn услуга2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn услуга3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn стоимостьDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn сотрудникDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn должностьDataGridViewTextBoxColumn;
    }
}