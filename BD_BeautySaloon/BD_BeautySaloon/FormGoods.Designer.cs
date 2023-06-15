namespace BD_BeautySaloon
{
    partial class FormGoods
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
            System.Windows.Forms.Label серийный_номер_товараLabel;
            System.Windows.Forms.Label наименованиеLabel;
            System.Windows.Forms.Label стоимостьLabel;
            System.Windows.Forms.Label срок_годности_товараLabel;
            System.Windows.Forms.Label составLabel;
            System.Windows.Forms.Label фотоLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGoods));
            this.beautySaloonDataSet = new BD_BeautySaloon.BeautySaloonDataSet();
            this.товарBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.товарTableAdapter = new BD_BeautySaloon.BeautySaloonDataSetTableAdapters.ТоварTableAdapter();
            this.tableAdapterManager = new BD_BeautySaloon.BeautySaloonDataSetTableAdapters.TableAdapterManager();
            this.товарBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.товарBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.серийный_номер_товараTextBox = new System.Windows.Forms.TextBox();
            this.наименованиеTextBox = new System.Windows.Forms.TextBox();
            this.стоимостьTextBox = new System.Windows.Forms.TextBox();
            this.срок_годности_товараDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.составTextBox = new System.Windows.Forms.TextBox();
            this.фотоPictureBox = new System.Windows.Forms.PictureBox();
            this.buttonOpenPhoto = new System.Windows.Forms.Button();
            this.openFileDialogPhoto = new System.Windows.Forms.OpenFileDialog();
            серийный_номер_товараLabel = new System.Windows.Forms.Label();
            наименованиеLabel = new System.Windows.Forms.Label();
            стоимостьLabel = new System.Windows.Forms.Label();
            срок_годности_товараLabel = new System.Windows.Forms.Label();
            составLabel = new System.Windows.Forms.Label();
            фотоLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.beautySaloonDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.товарBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.товарBindingNavigator)).BeginInit();
            this.товарBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.фотоPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // серийный_номер_товараLabel
            // 
            серийный_номер_товараLabel.AutoSize = true;
            серийный_номер_товараLabel.Location = new System.Drawing.Point(12, 35);
            серийный_номер_товараLabel.Name = "серийный_номер_товараLabel";
            серийный_номер_товараLabel.Size = new System.Drawing.Size(134, 13);
            серийный_номер_товараLabel.TabIndex = 1;
            серийный_номер_товараLabel.Text = "Серийный номер товара:";
            // 
            // наименованиеLabel
            // 
            наименованиеLabel.AutoSize = true;
            наименованиеLabel.Location = new System.Drawing.Point(12, 61);
            наименованиеLabel.Name = "наименованиеLabel";
            наименованиеLabel.Size = new System.Drawing.Size(86, 13);
            наименованиеLabel.TabIndex = 3;
            наименованиеLabel.Text = "Наименование:";
            // 
            // стоимостьLabel
            // 
            стоимостьLabel.AutoSize = true;
            стоимостьLabel.Location = new System.Drawing.Point(12, 87);
            стоимостьLabel.Name = "стоимостьLabel";
            стоимостьLabel.Size = new System.Drawing.Size(65, 13);
            стоимостьLabel.TabIndex = 5;
            стоимостьLabel.Text = "Стоимость:";
            // 
            // срок_годности_товараLabel
            // 
            срок_годности_товараLabel.AutoSize = true;
            срок_годности_товараLabel.Location = new System.Drawing.Point(12, 114);
            срок_годности_товараLabel.Name = "срок_годности_товараLabel";
            срок_годности_товараLabel.Size = new System.Drawing.Size(122, 13);
            срок_годности_товараLabel.TabIndex = 7;
            срок_годности_товараLabel.Text = "Срок годности товара:";
            // 
            // составLabel
            // 
            составLabel.AutoSize = true;
            составLabel.Location = new System.Drawing.Point(12, 139);
            составLabel.Name = "составLabel";
            составLabel.Size = new System.Drawing.Size(46, 13);
            составLabel.TabIndex = 9;
            составLabel.Text = "Состав:";
            // 
            // фотоLabel
            // 
            фотоLabel.AutoSize = true;
            фотоLabel.Location = new System.Drawing.Point(12, 315);
            фотоLabel.Name = "фотоLabel";
            фотоLabel.Size = new System.Drawing.Size(38, 13);
            фотоLabel.TabIndex = 11;
            фотоLabel.Text = "Фото:";
            фотоLabel.Click += new System.EventHandler(this.фотоLabel_Click);
            // 
            // beautySaloonDataSet
            // 
            this.beautySaloonDataSet.DataSetName = "BeautySaloonDataSet";
            this.beautySaloonDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // товарBindingSource
            // 
            this.товарBindingSource.DataMember = "Товар";
            this.товарBindingSource.DataSource = this.beautySaloonDataSet;
            // 
            // товарTableAdapter
            // 
            this.товарTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = BD_BeautySaloon.BeautySaloonDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ЗаказTableAdapter = null;
            this.tableAdapterManager.ЗаписьОбУслугеTableAdapter = null;
            this.tableAdapterManager.КлиентTableAdapter = null;
            this.tableAdapterManager.ПерсоналTableAdapter = null;
            this.tableAdapterManager.ТоварTableAdapter = this.товарTableAdapter;
            this.tableAdapterManager.УслугаTableAdapter = null;
            // 
            // товарBindingNavigator
            // 
            this.товарBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.товарBindingNavigator.BindingSource = this.товарBindingSource;
            this.товарBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.товарBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.товарBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.товарBindingNavigatorSaveItem});
            this.товарBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.товарBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.товарBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.товарBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.товарBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.товарBindingNavigator.Name = "товарBindingNavigator";
            this.товарBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.товарBindingNavigator.Size = new System.Drawing.Size(444, 25);
            this.товарBindingNavigator.TabIndex = 0;
            this.товарBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
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
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // товарBindingNavigatorSaveItem
            // 
            this.товарBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.товарBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("товарBindingNavigatorSaveItem.Image")));
            this.товарBindingNavigatorSaveItem.Name = "товарBindingNavigatorSaveItem";
            this.товарBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.товарBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.товарBindingNavigatorSaveItem.Click += new System.EventHandler(this.товарBindingNavigatorSaveItem_Click);
            // 
            // серийный_номер_товараTextBox
            // 
            this.серийный_номер_товараTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.товарBindingSource, "Серийный_номер_товара", true));
            this.серийный_номер_товараTextBox.Location = new System.Drawing.Point(152, 32);
            this.серийный_номер_товараTextBox.Name = "серийный_номер_товараTextBox";
            this.серийный_номер_товараTextBox.Size = new System.Drawing.Size(200, 20);
            this.серийный_номер_товараTextBox.TabIndex = 2;
            // 
            // наименованиеTextBox
            // 
            this.наименованиеTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.товарBindingSource, "Наименование", true));
            this.наименованиеTextBox.Location = new System.Drawing.Point(152, 58);
            this.наименованиеTextBox.Name = "наименованиеTextBox";
            this.наименованиеTextBox.Size = new System.Drawing.Size(200, 20);
            this.наименованиеTextBox.TabIndex = 4;
            // 
            // стоимостьTextBox
            // 
            this.стоимостьTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.товарBindingSource, "Стоимость", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "C0"));
            this.стоимостьTextBox.Location = new System.Drawing.Point(152, 84);
            this.стоимостьTextBox.Name = "стоимостьTextBox";
            this.стоимостьTextBox.Size = new System.Drawing.Size(200, 20);
            this.стоимостьTextBox.TabIndex = 6;
            // 
            // срок_годности_товараDateTimePicker
            // 
            this.срок_годности_товараDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.товарBindingSource, "Срок_годности_товара", true));
            this.срок_годности_товараDateTimePicker.Location = new System.Drawing.Point(152, 110);
            this.срок_годности_товараDateTimePicker.Name = "срок_годности_товараDateTimePicker";
            this.срок_годности_товараDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.срок_годности_товараDateTimePicker.TabIndex = 8;
            // 
            // составTextBox
            // 
            this.составTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.товарBindingSource, "Состав", true));
            this.составTextBox.Location = new System.Drawing.Point(152, 136);
            this.составTextBox.Multiline = true;
            this.составTextBox.Name = "составTextBox";
            this.составTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.составTextBox.Size = new System.Drawing.Size(200, 157);
            this.составTextBox.TabIndex = 10;
            // 
            // фотоPictureBox
            // 
            this.фотоPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.товарBindingSource, "Фото", true));
            this.фотоPictureBox.Location = new System.Drawing.Point(152, 315);
            this.фотоPictureBox.Name = "фотоPictureBox";
            this.фотоPictureBox.Size = new System.Drawing.Size(200, 244);
            this.фотоPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.фотоPictureBox.TabIndex = 12;
            this.фотоPictureBox.TabStop = false;
            this.фотоPictureBox.Click += new System.EventHandler(this.фотоPictureBox_Click);
            // 
            // buttonOpenPhoto
            // 
            this.buttonOpenPhoto.Location = new System.Drawing.Point(202, 565);
            this.buttonOpenPhoto.Name = "buttonOpenPhoto";
            this.buttonOpenPhoto.Size = new System.Drawing.Size(105, 23);
            this.buttonOpenPhoto.TabIndex = 13;
            this.buttonOpenPhoto.Text = "Открыть фото";
            this.buttonOpenPhoto.UseVisualStyleBackColor = true;
            this.buttonOpenPhoto.Click += new System.EventHandler(this.buttonOpenPhoto_Click);
            // 
            // openFileDialogPhoto
            // 
            this.openFileDialogPhoto.FileName = "openFileDialog1";
            // 
            // FormGoods
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 613);
            this.Controls.Add(this.buttonOpenPhoto);
            this.Controls.Add(фотоLabel);
            this.Controls.Add(this.фотоPictureBox);
            this.Controls.Add(серийный_номер_товараLabel);
            this.Controls.Add(this.серийный_номер_товараTextBox);
            this.Controls.Add(наименованиеLabel);
            this.Controls.Add(this.наименованиеTextBox);
            this.Controls.Add(стоимостьLabel);
            this.Controls.Add(this.стоимостьTextBox);
            this.Controls.Add(срок_годности_товараLabel);
            this.Controls.Add(this.срок_годности_товараDateTimePicker);
            this.Controls.Add(составLabel);
            this.Controls.Add(this.составTextBox);
            this.Controls.Add(this.товарBindingNavigator);
            this.Name = "FormGoods";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Товары";
            this.Load += new System.EventHandler(this.FormGoods_Load);
            ((System.ComponentModel.ISupportInitialize)(this.beautySaloonDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.товарBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.товарBindingNavigator)).EndInit();
            this.товарBindingNavigator.ResumeLayout(false);
            this.товарBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.фотоPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BeautySaloonDataSet beautySaloonDataSet;
        private System.Windows.Forms.BindingSource товарBindingSource;
        private BeautySaloonDataSetTableAdapters.ТоварTableAdapter товарTableAdapter;
        private BeautySaloonDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator товарBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton товарBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox серийный_номер_товараTextBox;
        private System.Windows.Forms.TextBox наименованиеTextBox;
        private System.Windows.Forms.TextBox стоимостьTextBox;
        private System.Windows.Forms.DateTimePicker срок_годности_товараDateTimePicker;
        private System.Windows.Forms.TextBox составTextBox;
        private System.Windows.Forms.PictureBox фотоPictureBox;
        private System.Windows.Forms.Button buttonOpenPhoto;
        private System.Windows.Forms.OpenFileDialog openFileDialogPhoto;
    }
}