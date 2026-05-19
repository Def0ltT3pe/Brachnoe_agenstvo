
namespace практика
{
    partial class Form7
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form7));
            System.Windows.Forms.Label фИОLabel;
            System.Windows.Forms.Label возрастLabel;
            System.Windows.Forms.Label полLabel;
            System.Windows.Forms.Label адресLabel;
            System.Windows.Forms.Label телефонLabel;
            System.Windows.Forms.Label паспортные_данныеLabel;
            System.Windows.Forms.Label код_должностиLabel;
            this.brachnoeAgentstvoDataSet = new практика.BrachnoeAgentstvoDataSet();
            this.дополнительные_услугиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.дополнительные_услугиTableAdapter = new практика.BrachnoeAgentstvoDataSetTableAdapters.Дополнительные_услугиTableAdapter();
            this.tableAdapterManager = new практика.BrachnoeAgentstvoDataSetTableAdapters.TableAdapterManager();
            this.дополнительные_услугиBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.дополнительные_услугиBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.button1 = new System.Windows.Forms.Button();
            this.сотрудникиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.сотрудникиTableAdapter = new практика.BrachnoeAgentstvoDataSetTableAdapters.СотрудникиTableAdapter();
            this.фИОTextBox = new System.Windows.Forms.TextBox();
            this.возрастTextBox = new System.Windows.Forms.TextBox();
            this.полTextBox = new System.Windows.Forms.TextBox();
            this.адресTextBox = new System.Windows.Forms.TextBox();
            this.телефонTextBox = new System.Windows.Forms.TextBox();
            this.паспортные_данныеTextBox = new System.Windows.Forms.TextBox();
            this.код_должностиTextBox = new System.Windows.Forms.TextBox();
            фИОLabel = new System.Windows.Forms.Label();
            возрастLabel = new System.Windows.Forms.Label();
            полLabel = new System.Windows.Forms.Label();
            адресLabel = new System.Windows.Forms.Label();
            телефонLabel = new System.Windows.Forms.Label();
            паспортные_данныеLabel = new System.Windows.Forms.Label();
            код_должностиLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.brachnoeAgentstvoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.дополнительные_услугиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.дополнительные_услугиBindingNavigator)).BeginInit();
            this.дополнительные_услугиBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникиBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // brachnoeAgentstvoDataSet
            // 
            this.brachnoeAgentstvoDataSet.DataSetName = "BrachnoeAgentstvoDataSet";
            this.brachnoeAgentstvoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // дополнительные_услугиBindingSource
            // 
            this.дополнительные_услугиBindingSource.DataMember = "Дополнительные_услуги";
            this.дополнительные_услугиBindingSource.DataSource = this.brachnoeAgentstvoDataSet;
            // 
            // дополнительные_услугиTableAdapter
            // 
            this.дополнительные_услугиTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.СотрудникиTableAdapter = null;
            this.tableAdapterManager.УслугиTableAdapter = null;
            // 
            // дополнительные_услугиBindingNavigator
            // 
            this.дополнительные_услугиBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.дополнительные_услугиBindingNavigator.BindingSource = this.дополнительные_услугиBindingSource;
            this.дополнительные_услугиBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.дополнительные_услугиBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.дополнительные_услугиBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.дополнительные_услугиBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.дополнительные_услугиBindingNavigatorSaveItem});
            this.дополнительные_услугиBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.дополнительные_услугиBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.дополнительные_услугиBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.дополнительные_услугиBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.дополнительные_услугиBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.дополнительные_услугиBindingNavigator.Name = "дополнительные_услугиBindingNavigator";
            this.дополнительные_услугиBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.дополнительные_услугиBindingNavigator.Size = new System.Drawing.Size(800, 27);
            this.дополнительные_услугиBindingNavigator.TabIndex = 0;
            this.дополнительные_услугиBindingNavigator.Text = "bindingNavigator1";
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
            // дополнительные_услугиBindingNavigatorSaveItem
            // 
            this.дополнительные_услугиBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.дополнительные_услугиBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("дополнительные_услугиBindingNavigatorSaveItem.Image")));
            this.дополнительные_услугиBindingNavigatorSaveItem.Name = "дополнительные_услугиBindingNavigatorSaveItem";
            this.дополнительные_услугиBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.дополнительные_услугиBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.дополнительные_услугиBindingNavigatorSaveItem.Click += new System.EventHandler(this.дополнительные_услугиBindingNavigatorSaveItem_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(335, 402);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 36);
            this.button1.TabIndex = 15;
            this.button1.Text = "Закрыть";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            // фИОLabel
            // 
            фИОLabel.AutoSize = true;
            фИОLabel.Location = new System.Drawing.Point(12, 92);
            фИОLabel.Name = "фИОLabel";
            фИОLabel.Size = new System.Drawing.Size(46, 17);
            фИОLabel.TabIndex = 17;
            фИОLabel.Text = "ФИО:";
            // 
            // фИОTextBox
            // 
            this.фИОTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.сотрудникиBindingSource, "ФИО", true));
            this.фИОTextBox.Location = new System.Drawing.Point(166, 89);
            this.фИОTextBox.Name = "фИОTextBox";
            this.фИОTextBox.Size = new System.Drawing.Size(100, 22);
            this.фИОTextBox.TabIndex = 18;
            // 
            // возрастLabel
            // 
            возрастLabel.AutoSize = true;
            возрастLabel.Location = new System.Drawing.Point(12, 120);
            возрастLabel.Name = "возрастLabel";
            возрастLabel.Size = new System.Drawing.Size(66, 17);
            возрастLabel.TabIndex = 19;
            возрастLabel.Text = "Возраст:";
            // 
            // возрастTextBox
            // 
            this.возрастTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.сотрудникиBindingSource, "Возраст", true));
            this.возрастTextBox.Location = new System.Drawing.Point(166, 117);
            this.возрастTextBox.Name = "возрастTextBox";
            this.возрастTextBox.Size = new System.Drawing.Size(100, 22);
            this.возрастTextBox.TabIndex = 20;
            // 
            // полLabel
            // 
            полLabel.AutoSize = true;
            полLabel.Location = new System.Drawing.Point(12, 148);
            полLabel.Name = "полLabel";
            полLabel.Size = new System.Drawing.Size(38, 17);
            полLabel.TabIndex = 21;
            полLabel.Text = "Пол:";
            // 
            // полTextBox
            // 
            this.полTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.сотрудникиBindingSource, "Пол", true));
            this.полTextBox.Location = new System.Drawing.Point(166, 145);
            this.полTextBox.Name = "полTextBox";
            this.полTextBox.Size = new System.Drawing.Size(100, 22);
            this.полTextBox.TabIndex = 22;
            // 
            // адресLabel
            // 
            адресLabel.AutoSize = true;
            адресLabel.Location = new System.Drawing.Point(12, 176);
            адресLabel.Name = "адресLabel";
            адресLabel.Size = new System.Drawing.Size(52, 17);
            адресLabel.TabIndex = 23;
            адресLabel.Text = "Адрес:";
            // 
            // адресTextBox
            // 
            this.адресTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.сотрудникиBindingSource, "Адрес", true));
            this.адресTextBox.Location = new System.Drawing.Point(166, 173);
            this.адресTextBox.Name = "адресTextBox";
            this.адресTextBox.Size = new System.Drawing.Size(100, 22);
            this.адресTextBox.TabIndex = 24;
            // 
            // телефонLabel
            // 
            телефонLabel.AutoSize = true;
            телефонLabel.Location = new System.Drawing.Point(12, 204);
            телефонLabel.Name = "телефонLabel";
            телефонLabel.Size = new System.Drawing.Size(72, 17);
            телефонLabel.TabIndex = 25;
            телефонLabel.Text = "Телефон:";
            // 
            // телефонTextBox
            // 
            this.телефонTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.сотрудникиBindingSource, "Телефон", true));
            this.телефонTextBox.Location = new System.Drawing.Point(166, 201);
            this.телефонTextBox.Name = "телефонTextBox";
            this.телефонTextBox.Size = new System.Drawing.Size(100, 22);
            this.телефонTextBox.TabIndex = 26;
            // 
            // паспортные_данныеLabel
            // 
            паспортные_данныеLabel.AutoSize = true;
            паспортные_данныеLabel.Location = new System.Drawing.Point(12, 232);
            паспортные_данныеLabel.Name = "паспортные_данныеLabel";
            паспортные_данныеLabel.Size = new System.Drawing.Size(148, 17);
            паспортные_данныеLabel.TabIndex = 27;
            паспортные_данныеLabel.Text = "Паспортные данные:";
            // 
            // паспортные_данныеTextBox
            // 
            this.паспортные_данныеTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.сотрудникиBindingSource, "Паспортные_данные", true));
            this.паспортные_данныеTextBox.Location = new System.Drawing.Point(166, 229);
            this.паспортные_данныеTextBox.Name = "паспортные_данныеTextBox";
            this.паспортные_данныеTextBox.Size = new System.Drawing.Size(100, 22);
            this.паспортные_данныеTextBox.TabIndex = 28;
            // 
            // код_должностиLabel
            // 
            код_должностиLabel.AutoSize = true;
            код_должностиLabel.Location = new System.Drawing.Point(12, 260);
            код_должностиLabel.Name = "код_должностиLabel";
            код_должностиLabel.Size = new System.Drawing.Size(112, 17);
            код_должностиLabel.TabIndex = 29;
            код_должностиLabel.Text = "Код должности:";
            // 
            // код_должностиTextBox
            // 
            this.код_должностиTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.сотрудникиBindingSource, "Код_должности", true));
            this.код_должностиTextBox.Location = new System.Drawing.Point(166, 257);
            this.код_должностиTextBox.Name = "код_должностиTextBox";
            this.код_должностиTextBox.Size = new System.Drawing.Size(100, 22);
            this.код_должностиTextBox.TabIndex = 30;
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(фИОLabel);
            this.Controls.Add(this.фИОTextBox);
            this.Controls.Add(возрастLabel);
            this.Controls.Add(this.возрастTextBox);
            this.Controls.Add(полLabel);
            this.Controls.Add(this.полTextBox);
            this.Controls.Add(адресLabel);
            this.Controls.Add(this.адресTextBox);
            this.Controls.Add(телефонLabel);
            this.Controls.Add(this.телефонTextBox);
            this.Controls.Add(паспортные_данныеLabel);
            this.Controls.Add(this.паспортные_данныеTextBox);
            this.Controls.Add(код_должностиLabel);
            this.Controls.Add(this.код_должностиTextBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.дополнительные_услугиBindingNavigator);
            this.Name = "Form7";
            this.Text = "Form7";
            this.Load += new System.EventHandler(this.Form7_Load);
            ((System.ComponentModel.ISupportInitialize)(this.brachnoeAgentstvoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.дополнительные_услугиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.дополнительные_услугиBindingNavigator)).EndInit();
            this.дополнительные_услугиBindingNavigator.ResumeLayout(false);
            this.дополнительные_услугиBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникиBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BrachnoeAgentstvoDataSet brachnoeAgentstvoDataSet;
        private System.Windows.Forms.BindingSource дополнительные_услугиBindingSource;
        private BrachnoeAgentstvoDataSetTableAdapters.Дополнительные_услугиTableAdapter дополнительные_услугиTableAdapter;
        private BrachnoeAgentstvoDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator дополнительные_услугиBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton дополнительные_услугиBindingNavigatorSaveItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource сотрудникиBindingSource;
        private BrachnoeAgentstvoDataSetTableAdapters.СотрудникиTableAdapter сотрудникиTableAdapter;
        private System.Windows.Forms.TextBox фИОTextBox;
        private System.Windows.Forms.TextBox возрастTextBox;
        private System.Windows.Forms.TextBox полTextBox;
        private System.Windows.Forms.TextBox адресTextBox;
        private System.Windows.Forms.TextBox телефонTextBox;
        private System.Windows.Forms.TextBox паспортные_данныеTextBox;
        private System.Windows.Forms.TextBox код_должностиTextBox;
    }
}