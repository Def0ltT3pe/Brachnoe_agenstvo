
namespace практика
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            System.Windows.Forms.Label наименованиеLabel;
            System.Windows.Forms.Label описаниеLabel;
            this.brachnoeAgentstvoDataSet = new практика.BrachnoeAgentstvoDataSet();
            this.отношенияBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.отношенияTableAdapter = new практика.BrachnoeAgentstvoDataSetTableAdapters.ОтношенияTableAdapter();
            this.tableAdapterManager = new практика.BrachnoeAgentstvoDataSetTableAdapters.TableAdapterManager();
            this.отношенияBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.отношенияBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.наименованиеTextBox = new System.Windows.Forms.TextBox();
            this.описаниеTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            наименованиеLabel = new System.Windows.Forms.Label();
            описаниеLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.brachnoeAgentstvoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.отношенияBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.отношенияBindingNavigator)).BeginInit();
            this.отношенияBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // brachnoeAgentstvoDataSet
            // 
            this.brachnoeAgentstvoDataSet.DataSetName = "BrachnoeAgentstvoDataSet";
            this.brachnoeAgentstvoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // отношенияBindingSource
            // 
            this.отношенияBindingSource.DataMember = "Отношения";
            this.отношенияBindingSource.DataSource = this.brachnoeAgentstvoDataSet;
            // 
            // отношенияTableAdapter
            // 
            this.отношенияTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = практика.BrachnoeAgentstvoDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ДолжностиTableAdapter = null;
            this.tableAdapterManager.Дополнительные_услугиTableAdapter = null;
            this.tableAdapterManager.Знаки_зодиакаTableAdapter = null;
            this.tableAdapterManager.КлиентыTableAdapter = null;
            this.tableAdapterManager.НациональностиTableAdapter = null;
            this.tableAdapterManager.ОтношенияTableAdapter = this.отношенияTableAdapter;
            this.tableAdapterManager.СотрудникиTableAdapter = null;
            this.tableAdapterManager.УслугиTableAdapter = null;
            // 
            // отношенияBindingNavigator
            // 
            this.отношенияBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.отношенияBindingNavigator.BindingSource = this.отношенияBindingSource;
            this.отношенияBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.отношенияBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.отношенияBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.отношенияBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.отношенияBindingNavigatorSaveItem});
            this.отношенияBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.отношенияBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.отношенияBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.отношенияBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.отношенияBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.отношенияBindingNavigator.Name = "отношенияBindingNavigator";
            this.отношенияBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.отношенияBindingNavigator.Size = new System.Drawing.Size(800, 31);
            this.отношенияBindingNavigator.TabIndex = 0;
            this.отношенияBindingNavigator.Text = "bindingNavigator1";
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
            // отношенияBindingNavigatorSaveItem
            // 
            this.отношенияBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.отношенияBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("отношенияBindingNavigatorSaveItem.Image")));
            this.отношенияBindingNavigatorSaveItem.Name = "отношенияBindingNavigatorSaveItem";
            this.отношенияBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.отношенияBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.отношенияBindingNavigatorSaveItem.Click += new System.EventHandler(this.отношенияBindingNavigatorSaveItem_Click);
            // 
            // наименованиеLabel
            // 
            наименованиеLabel.AutoSize = true;
            наименованиеLabel.Location = new System.Drawing.Point(14, 179);
            наименованиеLabel.Name = "наименованиеLabel";
            наименованиеLabel.Size = new System.Drawing.Size(110, 17);
            наименованиеLabel.TabIndex = 3;
            наименованиеLabel.Text = "Наименование:";
            // 
            // наименованиеTextBox
            // 
            this.наименованиеTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.отношенияBindingSource, "Наименование", true));
            this.наименованиеTextBox.Location = new System.Drawing.Point(135, 176);
            this.наименованиеTextBox.Name = "наименованиеTextBox";
            this.наименованиеTextBox.Size = new System.Drawing.Size(642, 22);
            this.наименованиеTextBox.TabIndex = 4;
            // 
            // описаниеLabel
            // 
            описаниеLabel.AutoSize = true;
            описаниеLabel.Location = new System.Drawing.Point(14, 207);
            описаниеLabel.Name = "описаниеLabel";
            описаниеLabel.Size = new System.Drawing.Size(78, 17);
            описаниеLabel.TabIndex = 5;
            описаниеLabel.Text = "Описание:";
            // 
            // описаниеTextBox
            // 
            this.описаниеTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.отношенияBindingSource, "Описание", true));
            this.описаниеTextBox.Location = new System.Drawing.Point(135, 204);
            this.описаниеTextBox.Name = "описаниеTextBox";
            this.описаниеTextBox.Size = new System.Drawing.Size(642, 22);
            this.описаниеTextBox.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(344, 285);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 36);
            this.button1.TabIndex = 13;
            this.button1.Text = "Закрыть";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(наименованиеLabel);
            this.Controls.Add(this.наименованиеTextBox);
            this.Controls.Add(описаниеLabel);
            this.Controls.Add(this.описаниеTextBox);
            this.Controls.Add(this.отношенияBindingNavigator);
            this.Name = "Form5";
            this.Text = "Отношения";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.brachnoeAgentstvoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.отношенияBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.отношенияBindingNavigator)).EndInit();
            this.отношенияBindingNavigator.ResumeLayout(false);
            this.отношенияBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BrachnoeAgentstvoDataSet brachnoeAgentstvoDataSet;
        private System.Windows.Forms.BindingSource отношенияBindingSource;
        private BrachnoeAgentstvoDataSetTableAdapters.ОтношенияTableAdapter отношенияTableAdapter;
        private BrachnoeAgentstvoDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator отношенияBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton отношенияBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox наименованиеTextBox;
        private System.Windows.Forms.TextBox описаниеTextBox;
        private System.Windows.Forms.Button button1;
    }
}