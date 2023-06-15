namespace BD_BeautySaloon
{
    partial class FormServices
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormServices));
            System.Windows.Forms.Label код_услугиLabel;
            System.Windows.Forms.Label типLabel;
            System.Windows.Forms.Label стоимостьLabel;
            this.beautySaloonDataSet = new BD_BeautySaloon.BeautySaloonDataSet();
            this.услугаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.услугаTableAdapter = new BD_BeautySaloon.BeautySaloonDataSetTableAdapters.УслугаTableAdapter();
            this.tableAdapterManager = new BD_BeautySaloon.BeautySaloonDataSetTableAdapters.TableAdapterManager();
            this.услугаBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.услугаBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.код_услугиTextBox = new System.Windows.Forms.TextBox();
            this.типTextBox = new System.Windows.Forms.TextBox();
            this.стоимостьTextBox = new System.Windows.Forms.TextBox();
            код_услугиLabel = new System.Windows.Forms.Label();
            типLabel = new System.Windows.Forms.Label();
            стоимостьLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.beautySaloonDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.услугаBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.услугаBindingNavigator)).BeginInit();
            this.услугаBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // beautySaloonDataSet
            // 
            this.beautySaloonDataSet.DataSetName = "BeautySaloonDataSet";
            this.beautySaloonDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // услугаBindingSource
            // 
            this.услугаBindingSource.DataMember = "Услуга";
            this.услугаBindingSource.DataSource = this.beautySaloonDataSet;
            // 
            // услугаTableAdapter
            // 
            this.услугаTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = BD_BeautySaloon.BeautySaloonDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ЗаказTableAdapter = null;
            this.tableAdapterManager.ЗаписьОбУслугеTableAdapter = null;
            this.tableAdapterManager.КлиентTableAdapter = null;
            this.tableAdapterManager.ПерсоналTableAdapter = null;
            this.tableAdapterManager.ТоварTableAdapter = null;
            this.tableAdapterManager.УслугаTableAdapter = this.услугаTableAdapter;
            // 
            // услугаBindingNavigator
            // 
            this.услугаBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.услугаBindingNavigator.BindingSource = this.услугаBindingSource;
            this.услугаBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.услугаBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.услугаBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.услугаBindingNavigatorSaveItem});
            this.услугаBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.услугаBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.услугаBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.услугаBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.услугаBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.услугаBindingNavigator.Name = "услугаBindingNavigator";
            this.услугаBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.услугаBindingNavigator.Size = new System.Drawing.Size(303, 25);
            this.услугаBindingNavigator.TabIndex = 0;
            this.услугаBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
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
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 15);
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
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
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
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // услугаBindingNavigatorSaveItem
            // 
            this.услугаBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.услугаBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("услугаBindingNavigatorSaveItem.Image")));
            this.услугаBindingNavigatorSaveItem.Name = "услугаBindingNavigatorSaveItem";
            this.услугаBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.услугаBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.услугаBindingNavigatorSaveItem.Click += new System.EventHandler(this.услугаBindingNavigatorSaveItem_Click_1);
            // 
            // код_услугиLabel
            // 
            код_услугиLabel.AutoSize = true;
            код_услугиLabel.Location = new System.Drawing.Point(12, 36);
            код_услугиLabel.Name = "код_услугиLabel";
            код_услугиLabel.Size = new System.Drawing.Size(65, 13);
            код_услугиLabel.TabIndex = 1;
            код_услугиLabel.Text = "Код услуги:";
            // 
            // код_услугиTextBox
            // 
            this.код_услугиTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.услугаBindingSource, "Код_услуги", true));
            this.код_услугиTextBox.Location = new System.Drawing.Point(83, 33);
            this.код_услугиTextBox.Name = "код_услугиTextBox";
            this.код_услугиTextBox.Size = new System.Drawing.Size(142, 20);
            this.код_услугиTextBox.TabIndex = 2;
            // 
            // типLabel
            // 
            типLabel.AutoSize = true;
            типLabel.Location = new System.Drawing.Point(12, 62);
            типLabel.Name = "типLabel";
            типLabel.Size = new System.Drawing.Size(29, 13);
            типLabel.TabIndex = 3;
            типLabel.Text = "Тип:";
            // 
            // типTextBox
            // 
            this.типTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.услугаBindingSource, "Тип", true));
            this.типTextBox.Location = new System.Drawing.Point(83, 59);
            this.типTextBox.Name = "типTextBox";
            this.типTextBox.Size = new System.Drawing.Size(142, 20);
            this.типTextBox.TabIndex = 4;
            // 
            // стоимостьLabel
            // 
            стоимостьLabel.AutoSize = true;
            стоимостьLabel.Location = new System.Drawing.Point(12, 88);
            стоимостьLabel.Name = "стоимостьLabel";
            стоимостьLabel.Size = new System.Drawing.Size(65, 13);
            стоимостьLabel.TabIndex = 5;
            стоимостьLabel.Text = "Стоимость:";
            // 
            // стоимостьTextBox
            // 
            this.стоимостьTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.услугаBindingSource, "Стоимость", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "C0"));
            this.стоимостьTextBox.Location = new System.Drawing.Point(83, 85);
            this.стоимостьTextBox.Name = "стоимостьTextBox";
            this.стоимостьTextBox.Size = new System.Drawing.Size(142, 20);
            this.стоимостьTextBox.TabIndex = 6;
            // 
            // FormServices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 128);
            this.Controls.Add(код_услугиLabel);
            this.Controls.Add(this.код_услугиTextBox);
            this.Controls.Add(типLabel);
            this.Controls.Add(this.типTextBox);
            this.Controls.Add(стоимостьLabel);
            this.Controls.Add(this.стоимостьTextBox);
            this.Controls.Add(this.услугаBindingNavigator);
            this.Name = "FormServices";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Услуги";
            this.Load += new System.EventHandler(this.FormServices_Load);
            ((System.ComponentModel.ISupportInitialize)(this.beautySaloonDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.услугаBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.услугаBindingNavigator)).EndInit();
            this.услугаBindingNavigator.ResumeLayout(false);
            this.услугаBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BeautySaloonDataSet beautySaloonDataSet;
        private System.Windows.Forms.BindingSource услугаBindingSource;
        private BeautySaloonDataSetTableAdapters.УслугаTableAdapter услугаTableAdapter;
        private BeautySaloonDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator услугаBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton услугаBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox код_услугиTextBox;
        private System.Windows.Forms.TextBox типTextBox;
        private System.Windows.Forms.TextBox стоимостьTextBox;
    }
}