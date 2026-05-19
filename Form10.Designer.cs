
namespace практика
{
    partial class Form10
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form10));
            this.brachnoeAgentstvoDataSet = new практика.BrachnoeAgentstvoDataSet();
            this.отдел_кадровBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.отдел_кадровTableAdapter = new практика.BrachnoeAgentstvoDataSetTableAdapters.Отдел_кадровTableAdapter();
            this.tableAdapterManager = new практика.BrachnoeAgentstvoDataSetTableAdapters.TableAdapterManager();
            this.отдел_кадровBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.отдел_кадровBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.labelSort = new System.Windows.Forms.Label();
            this.comboBoxSortField = new System.Windows.Forms.ComboBox();
            this.radioButtonAsc = new System.Windows.Forms.RadioButton();
            this.radioButtonDesc = new System.Windows.Forms.RadioButton();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.отдел_кадровDataGridView = new System.Windows.Forms.DataGridView();
            this.buttonSort = new System.Windows.Forms.Button();
            this.labelFind = new System.Windows.Forms.Label();
            this.textBoxFind = new System.Windows.Forms.TextBox();
            this.buttonFind = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.labelFilter = new System.Windows.Forms.Label();
            this.comboBoxFilter = new System.Windows.Forms.ComboBox();
            this.buttonClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.brachnoeAgentstvoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.отдел_кадровBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.отдел_кадровBindingNavigator)).BeginInit();
            this.отдел_кадровBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.отдел_кадровDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // brachnoeAgentstvoDataSet
            // 
            this.brachnoeAgentstvoDataSet.DataSetName = "BrachnoeAgentstvoDataSet";
            this.brachnoeAgentstvoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // отдел_кадровBindingSource
            // 
            this.отдел_кадровBindingSource.DataMember = "Отдел_кадров";
            this.отдел_кадровBindingSource.DataSource = this.brachnoeAgentstvoDataSet;
            // 
            // отдел_кадровTableAdapter
            // 
            this.отдел_кадровTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.UpdateOrder = практика.BrachnoeAgentstvoDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ДолжностиTableAdapter = null;
            this.tableAdapterManager.Дополнительные_услугиTableAdapter = null;
            this.tableAdapterManager.Знаки_зодиакаTableAdapter = null;
            this.tableAdapterManager.КлиентыTableAdapter = null;
            this.tableAdapterManager.НациональностиTableAdapter = null;
            this.tableAdapterManager.ОтношенияTableAdapter = null;
            this.tableAdapterManager.СотрудникиTableAdapter = null;
            this.tableAdapterManager.УслугиTableAdapter = null;
            // 
            // отдел_кадровBindingNavigator
            // 
            this.отдел_кадровBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.отдел_кадровBindingNavigator.BindingSource = this.отдел_кадровBindingSource;
            this.отдел_кадровBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.отдел_кадровBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.отдел_кадровBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.отдел_кадровBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.отдел_кадровBindingNavigatorSaveItem});
            this.отдел_кадровBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.отдел_кадровBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.отдел_кадровBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.отдел_кадровBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.отдел_кадровBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.отдел_кадровBindingNavigator.Name = "отдел_кадровBindingNavigator";
            this.отдел_кадровBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.отдел_кадровBindingNavigator.Size = new System.Drawing.Size(1976, 27);
            this.отдел_кадровBindingNavigator.TabIndex = 0;
            this.отдел_кадровBindingNavigator.Text = "bindingNavigator1";
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
            // отдел_кадровBindingNavigatorSaveItem
            // 
            this.отдел_кадровBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.отдел_кадровBindingNavigatorSaveItem.Enabled = false;
            this.отдел_кадровBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("отдел_кадровBindingNavigatorSaveItem.Image")));
            this.отдел_кадровBindingNavigatorSaveItem.Name = "отдел_кадровBindingNavigatorSaveItem";
            this.отдел_кадровBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.отдел_кадровBindingNavigatorSaveItem.Text = "Сохранить данные";
            // 
            // labelSort
            // 
            this.labelSort.AutoSize = true;
            this.labelSort.Location = new System.Drawing.Point(371, 6);
            this.labelSort.Name = "labelSort";
            this.labelSort.Size = new System.Drawing.Size(117, 17);
            this.labelSort.TabIndex = 2;
            this.labelSort.Text = "Сортировать по:";
            // 
            // comboBoxSortField
            // 
            this.comboBoxSortField.FormattingEnabled = true;
            this.comboBoxSortField.Location = new System.Drawing.Point(494, 3);
            this.comboBoxSortField.Name = "comboBoxSortField";
            this.comboBoxSortField.Size = new System.Drawing.Size(121, 24);
            this.comboBoxSortField.TabIndex = 3;
            // 
            // radioButtonAsc
            // 
            this.radioButtonAsc.AutoSize = true;
            this.radioButtonAsc.Checked = true;
            this.radioButtonAsc.Location = new System.Drawing.Point(621, 5);
            this.radioButtonAsc.Name = "radioButtonAsc";
            this.radioButtonAsc.Size = new System.Drawing.Size(137, 21);
            this.radioButtonAsc.TabIndex = 4;
            this.radioButtonAsc.TabStop = true;
            this.radioButtonAsc.Text = "По возрастанию";
            this.radioButtonAsc.UseVisualStyleBackColor = true;
            this.radioButtonAsc.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButtonDesc
            // 
            this.radioButtonDesc.AutoSize = true;
            this.radioButtonDesc.Location = new System.Drawing.Point(764, 5);
            this.radioButtonDesc.Name = "radioButtonDesc";
            this.radioButtonDesc.Size = new System.Drawing.Size(117, 21);
            this.radioButtonDesc.TabIndex = 5;
            this.radioButtonDesc.Text = "По убыванию";
            this.radioButtonDesc.UseVisualStyleBackColor = true;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Требования";
            this.dataGridViewTextBoxColumn11.HeaderText = "Требования";
            this.dataGridViewTextBoxColumn11.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.Width = 125;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Обязанности";
            this.dataGridViewTextBoxColumn10.HeaderText = "Обязанности";
            this.dataGridViewTextBoxColumn10.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.Width = 125;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Оклад";
            this.dataGridViewTextBoxColumn9.HeaderText = "Оклад";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Width = 125;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Должность";
            this.dataGridViewTextBoxColumn8.HeaderText = "Должность";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 125;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Паспортные_данные";
            this.dataGridViewTextBoxColumn7.HeaderText = "Паспортные_данные";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Телефон";
            this.dataGridViewTextBoxColumn6.HeaderText = "Телефон";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Адрес";
            this.dataGridViewTextBoxColumn5.HeaderText = "Адрес";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Пол";
            this.dataGridViewTextBoxColumn4.HeaderText = "Пол";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Возраст";
            this.dataGridViewTextBoxColumn3.HeaderText = "Возраст";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Сотрудник";
            this.dataGridViewTextBoxColumn2.HeaderText = "Сотрудник";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // отдел_кадровDataGridView
            // 
            this.отдел_кадровDataGridView.AutoGenerateColumns = false;
            this.отдел_кадровDataGridView.ColumnHeadersHeight = 29;
            this.отдел_кадровDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11});
            this.отдел_кадровDataGridView.DataSource = this.отдел_кадровBindingSource;
            this.отдел_кадровDataGridView.Location = new System.Drawing.Point(0, 36);
            this.отдел_кадровDataGridView.Name = "отдел_кадровDataGridView";
            this.отдел_кадровDataGridView.RowHeadersWidth = 51;
            this.отдел_кадровDataGridView.RowTemplate.Height = 24;
            this.отдел_кадровDataGridView.Size = new System.Drawing.Size(1976, 781);
            this.отдел_кадровDataGridView.TabIndex = 1;
            this.отдел_кадровDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.отдел_кадровDataGridView_CellContentClick);
            // 
            // buttonSort
            // 
            this.buttonSort.Location = new System.Drawing.Point(887, -1);
            this.buttonSort.Name = "buttonSort";
            this.buttonSort.Size = new System.Drawing.Size(116, 31);
            this.buttonSort.TabIndex = 6;
            this.buttonSort.Text = "Сортировать";
            this.buttonSort.UseVisualStyleBackColor = true;
            this.buttonSort.Click += new System.EventHandler(this.buttonSort_Click);
            // 
            // labelFind
            // 
            this.labelFind.AutoSize = true;
            this.labelFind.Location = new System.Drawing.Point(1009, 6);
            this.labelFind.Name = "labelFind";
            this.labelFind.Size = new System.Drawing.Size(52, 17);
            this.labelFind.TabIndex = 7;
            this.labelFind.Text = "Поиск:";
            // 
            // textBoxFind
            // 
            this.textBoxFind.Location = new System.Drawing.Point(1067, 3);
            this.textBoxFind.Name = "textBoxFind";
            this.textBoxFind.Size = new System.Drawing.Size(100, 22);
            this.textBoxFind.TabIndex = 8;
            // 
            // buttonFind
            // 
            this.buttonFind.Location = new System.Drawing.Point(1182, 3);
            this.buttonFind.Name = "buttonFind";
            this.buttonFind.Size = new System.Drawing.Size(75, 23);
            this.buttonFind.TabIndex = 9;
            this.buttonFind.Text = "Найти";
            this.buttonFind.UseVisualStyleBackColor = true;
            this.buttonFind.Click += new System.EventHandler(this.buttonFind_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(1263, 3);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(75, 23);
            this.buttonReset.TabIndex = 10;
            this.buttonReset.Text = "Сброс фильтра";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // labelFilter
            // 
            this.labelFilter.AutoSize = true;
            this.labelFilter.Location = new System.Drawing.Point(1344, 6);
            this.labelFilter.Name = "labelFilter";
            this.labelFilter.Size = new System.Drawing.Size(158, 17);
            this.labelFilter.TabIndex = 11;
            this.labelFilter.Text = "Фильтр по должности:";
            // 
            // comboBoxFilter
            // 
            this.comboBoxFilter.FormattingEnabled = true;
            this.comboBoxFilter.Location = new System.Drawing.Point(1508, 3);
            this.comboBoxFilter.Name = "comboBoxFilter";
            this.comboBoxFilter.Size = new System.Drawing.Size(121, 24);
            this.comboBoxFilter.TabIndex = 12;
            this.comboBoxFilter.SelectedIndexChanged += new System.EventHandler(this.comboBoxFilter_SelectedIndexChanged_1);
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(1862, 3);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(102, 23);
            this.buttonClose.TabIndex = 13;
            this.buttonClose.Text = "Закрыть";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // Form10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1976, 814);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.comboBoxFilter);
            this.Controls.Add(this.labelFilter);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonFind);
            this.Controls.Add(this.textBoxFind);
            this.Controls.Add(this.labelFind);
            this.Controls.Add(this.buttonSort);
            this.Controls.Add(this.radioButtonDesc);
            this.Controls.Add(this.radioButtonAsc);
            this.Controls.Add(this.comboBoxSortField);
            this.Controls.Add(this.labelSort);
            this.Controls.Add(this.отдел_кадровDataGridView);
            this.Controls.Add(this.отдел_кадровBindingNavigator);
            this.Name = "Form10";
            this.Text = "Form10";
            this.Load += new System.EventHandler(this.Form10_Load);
            ((System.ComponentModel.ISupportInitialize)(this.brachnoeAgentstvoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.отдел_кадровBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.отдел_кадровBindingNavigator)).EndInit();
            this.отдел_кадровBindingNavigator.ResumeLayout(false);
            this.отдел_кадровBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.отдел_кадровDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BrachnoeAgentstvoDataSet brachnoeAgentstvoDataSet;
        private System.Windows.Forms.BindingSource отдел_кадровBindingSource;
        private BrachnoeAgentstvoDataSetTableAdapters.Отдел_кадровTableAdapter отдел_кадровTableAdapter;
        private BrachnoeAgentstvoDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator отдел_кадровBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton отдел_кадровBindingNavigatorSaveItem;
        private System.Windows.Forms.Label labelSort;
        private System.Windows.Forms.ComboBox comboBoxSortField;
        private System.Windows.Forms.RadioButton radioButtonAsc;
        private System.Windows.Forms.RadioButton radioButtonDesc;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridView отдел_кадровDataGridView;
        private System.Windows.Forms.Button buttonSort;
        private System.Windows.Forms.Label labelFind;
        private System.Windows.Forms.TextBox textBoxFind;
        private System.Windows.Forms.Button buttonFind;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Label labelFilter;
        private System.Windows.Forms.ComboBox comboBoxFilter;
        private System.Windows.Forms.Button buttonClose;
    }
}