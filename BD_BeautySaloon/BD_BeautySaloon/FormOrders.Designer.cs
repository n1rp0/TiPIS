namespace BD_BeautySaloon
{
    partial class FormOrders
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOrders));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.товарBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.товарBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.beautySaloonDataSet = new BD_BeautySaloon.BeautySaloonDataSet();
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
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.серийный_номер_товараTextBox = new System.Windows.Forms.TextBox();
            this.наименованиеTextBox = new System.Windows.Forms.TextBox();
            this.стоимостьTextBox = new System.Windows.Forms.TextBox();
            this.срок_годности_товараDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.составTextBox = new System.Windows.Forms.TextBox();
            this.buttonOpenPhoto = new System.Windows.Forms.Button();
            this.openFileDialogPhoto = new System.Windows.Forms.OpenFileDialog();
            this.groupBoxOrders = new System.Windows.Forms.GroupBox();
            this.заказыbindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.заказыBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.заказDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumnID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Сотрудник = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Клиент = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.заказBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.фотоPictureBox = new System.Windows.Forms.PictureBox();
            this.buttonClient = new System.Windows.Forms.Button();
            this.buttonWorker = new System.Windows.Forms.Button();
            this.товарTableAdapter = new BD_BeautySaloon.BeautySaloonDataSetTableAdapters.ТоварTableAdapter();
            this.tableAdapterManager = new BD_BeautySaloon.BeautySaloonDataSetTableAdapters.TableAdapterManager();
            this.заказTableAdapter = new BD_BeautySaloon.BeautySaloonDataSetTableAdapters.ЗаказTableAdapter();
            this.персоналBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.персоналTableAdapter = new BD_BeautySaloon.BeautySaloonDataSetTableAdapters.ПерсоналTableAdapter();
            this.клиентBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.клиентTableAdapter = new BD_BeautySaloon.BeautySaloonDataSetTableAdapters.КлиентTableAdapter();
            серийный_номер_товараLabel = new System.Windows.Forms.Label();
            наименованиеLabel = new System.Windows.Forms.Label();
            стоимостьLabel = new System.Windows.Forms.Label();
            срок_годности_товараLabel = new System.Windows.Forms.Label();
            составLabel = new System.Windows.Forms.Label();
            фотоLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.товарBindingNavigator)).BeginInit();
            this.товарBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.товарBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.beautySaloonDataSet)).BeginInit();
            this.groupBoxOrders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.заказыbindingNavigator)).BeginInit();
            this.заказыbindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.заказDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.заказBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.фотоPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.персоналBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.клиентBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // серийный_номер_товараLabel
            // 
            серийный_номер_товараLabel.AutoSize = true;
            серийный_номер_товараLabel.Location = new System.Drawing.Point(12, 37);
            серийный_номер_товараLabel.Name = "серийный_номер_товараLabel";
            серийный_номер_товараLabel.Size = new System.Drawing.Size(134, 13);
            серийный_номер_товараLabel.TabIndex = 1;
            серийный_номер_товараLabel.Text = "Серийный номер товара:";
            // 
            // наименованиеLabel
            // 
            наименованиеLabel.AutoSize = true;
            наименованиеLabel.Location = new System.Drawing.Point(12, 63);
            наименованиеLabel.Name = "наименованиеLabel";
            наименованиеLabel.Size = new System.Drawing.Size(86, 13);
            наименованиеLabel.TabIndex = 3;
            наименованиеLabel.Text = "Наименование:";
            // 
            // стоимостьLabel
            // 
            стоимостьLabel.AutoSize = true;
            стоимостьLabel.Location = new System.Drawing.Point(12, 89);
            стоимостьLabel.Name = "стоимостьLabel";
            стоимостьLabel.Size = new System.Drawing.Size(65, 13);
            стоимостьLabel.TabIndex = 5;
            стоимостьLabel.Text = "Стоимость:";
            // 
            // срок_годности_товараLabel
            // 
            срок_годности_товараLabel.AutoSize = true;
            срок_годности_товараLabel.Location = new System.Drawing.Point(12, 116);
            срок_годности_товараLabel.Name = "срок_годности_товараLabel";
            срок_годности_товараLabel.Size = new System.Drawing.Size(122, 13);
            срок_годности_товараLabel.TabIndex = 7;
            срок_годности_товараLabel.Text = "Срок годности товара:";
            // 
            // составLabel
            // 
            составLabel.AutoSize = true;
            составLabel.Location = new System.Drawing.Point(12, 141);
            составLabel.Name = "составLabel";
            составLabel.Size = new System.Drawing.Size(99, 13);
            составLabel.TabIndex = 9;
            составLabel.Text = "Состав/описание:";
            // 
            // фотоLabel
            // 
            фотоLabel.AutoSize = true;
            фотоLabel.Location = new System.Drawing.Point(398, 37);
            фотоLabel.Name = "фотоLabel";
            фотоLabel.Size = new System.Drawing.Size(38, 13);
            фотоLabel.TabIndex = 11;
            фотоLabel.Text = "Фото:";
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
            this.товарBindingNavigatorSaveItem,
            this.toolStripSeparator4});
            this.товарBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.товарBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.товарBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.товарBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.товарBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.товарBindingNavigator.Name = "товарBindingNavigator";
            this.товарBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.товарBindingNavigator.Size = new System.Drawing.Size(1438, 25);
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
            // товарBindingSource
            // 
            this.товарBindingSource.DataMember = "Товар";
            this.товарBindingSource.DataSource = this.beautySaloonDataSet;
            // 
            // beautySaloonDataSet
            // 
            this.beautySaloonDataSet.DataSetName = "BeautySaloonDataSet";
            this.beautySaloonDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.товарBindingNavigatorSaveItem.Click += new System.EventHandler(this.товарBindingNavigatorSaveItem_Click_1);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // серийный_номер_товараTextBox
            // 
            this.серийный_номер_товараTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.товарBindingSource, "Серийный_номер_товара", true));
            this.серийный_номер_товараTextBox.Location = new System.Drawing.Point(152, 34);
            this.серийный_номер_товараTextBox.Name = "серийный_номер_товараTextBox";
            this.серийный_номер_товараTextBox.Size = new System.Drawing.Size(200, 20);
            this.серийный_номер_товараTextBox.TabIndex = 2;
            // 
            // наименованиеTextBox
            // 
            this.наименованиеTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.товарBindingSource, "Наименование", true));
            this.наименованиеTextBox.Location = new System.Drawing.Point(152, 60);
            this.наименованиеTextBox.Name = "наименованиеTextBox";
            this.наименованиеTextBox.Size = new System.Drawing.Size(200, 20);
            this.наименованиеTextBox.TabIndex = 4;
            // 
            // стоимостьTextBox
            // 
            this.стоимостьTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.товарBindingSource, "Стоимость", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "C0"));
            this.стоимостьTextBox.Location = new System.Drawing.Point(152, 86);
            this.стоимостьTextBox.Name = "стоимостьTextBox";
            this.стоимостьTextBox.Size = new System.Drawing.Size(200, 20);
            this.стоимостьTextBox.TabIndex = 6;
            // 
            // срок_годности_товараDateTimePicker
            // 
            this.срок_годности_товараDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.товарBindingSource, "Срок_годности_товара", true));
            this.срок_годности_товараDateTimePicker.Location = new System.Drawing.Point(152, 112);
            this.срок_годности_товараDateTimePicker.Name = "срок_годности_товараDateTimePicker";
            this.срок_годности_товараDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.срок_годности_товараDateTimePicker.TabIndex = 8;
            // 
            // составTextBox
            // 
            this.составTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.товарBindingSource, "Состав", true));
            this.составTextBox.Location = new System.Drawing.Point(152, 138);
            this.составTextBox.Multiline = true;
            this.составTextBox.Name = "составTextBox";
            this.составTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.составTextBox.Size = new System.Drawing.Size(200, 112);
            this.составTextBox.TabIndex = 10;
            // 
            // buttonOpenPhoto
            // 
            this.buttonOpenPhoto.Location = new System.Drawing.Point(493, 227);
            this.buttonOpenPhoto.Name = "buttonOpenPhoto";
            this.buttonOpenPhoto.Size = new System.Drawing.Size(105, 23);
            this.buttonOpenPhoto.TabIndex = 14;
            this.buttonOpenPhoto.Text = "Открыть фото";
            this.buttonOpenPhoto.UseVisualStyleBackColor = true;
            this.buttonOpenPhoto.Click += new System.EventHandler(this.buttonOpenPhoto_Click);
            // 
            // openFileDialogPhoto
            // 
            this.openFileDialogPhoto.FileName = "openFileDialog1";
            // 
            // groupBoxOrders
            // 
            this.groupBoxOrders.Controls.Add(this.заказыbindingNavigator);
            this.groupBoxOrders.Controls.Add(this.заказDataGridView);
            this.groupBoxOrders.Location = new System.Drawing.Point(15, 265);
            this.groupBoxOrders.Name = "groupBoxOrders";
            this.groupBoxOrders.Size = new System.Drawing.Size(1413, 357);
            this.groupBoxOrders.TabIndex = 15;
            this.groupBoxOrders.TabStop = false;
            this.groupBoxOrders.Text = "Заказы";
            // 
            // заказыbindingNavigator
            // 
            this.заказыbindingNavigator.AddNewItem = this.toolStripButton1;
            this.заказыbindingNavigator.BindingSource = this.заказBindingSource;
            this.заказыbindingNavigator.CountItem = this.toolStripLabel1;
            this.заказыbindingNavigator.DeleteItem = this.toolStripButton2;
            this.заказыbindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton3,
            this.toolStripButton4,
            this.toolStripSeparator1,
            this.toolStripTextBox1,
            this.toolStripLabel1,
            this.toolStripSeparator2,
            this.toolStripButton5,
            this.toolStripButton6,
            this.toolStripSeparator3,
            this.toolStripButton1,
            this.toolStripButton2,
            this.заказыBindingNavigatorSaveItem});
            this.заказыbindingNavigator.Location = new System.Drawing.Point(3, 16);
            this.заказыbindingNavigator.MoveFirstItem = this.toolStripButton3;
            this.заказыbindingNavigator.MoveLastItem = this.toolStripButton6;
            this.заказыbindingNavigator.MoveNextItem = this.toolStripButton5;
            this.заказыbindingNavigator.MovePreviousItem = this.toolStripButton4;
            this.заказыbindingNavigator.Name = "заказыbindingNavigator";
            this.заказыbindingNavigator.PositionItem = this.toolStripTextBox1;
            this.заказыbindingNavigator.Size = new System.Drawing.Size(1407, 25);
            this.заказыbindingNavigator.TabIndex = 1;
            this.заказыbindingNavigator.Text = "bindingNavigator1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.RightToLeftAutoMirrorImage = true;
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "Добавить";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(43, 22);
            this.toolStripLabel1.Text = "для {0}";
            this.toolStripLabel1.ToolTipText = "Общее число элементов";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.RightToLeftAutoMirrorImage = true;
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "Удалить";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.RightToLeftAutoMirrorImage = true;
            this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton3.Text = "Переместить в начало";
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.RightToLeftAutoMirrorImage = true;
            this.toolStripButton4.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton4.Text = "Переместить назад";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.AccessibleName = "Положение";
            this.toolStripTextBox1.AutoSize = false;
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(50, 23);
            this.toolStripTextBox1.Text = "0";
            this.toolStripTextBox1.ToolTipText = "Текущее положение";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.RightToLeftAutoMirrorImage = true;
            this.toolStripButton5.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton5.Text = "Переместить вперед";
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton6.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton6.Image")));
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.RightToLeftAutoMirrorImage = true;
            this.toolStripButton6.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton6.Text = "Переместить в конец";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // заказыBindingNavigatorSaveItem
            // 
            this.заказыBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.заказыBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("заказыBindingNavigatorSaveItem.Image")));
            this.заказыBindingNavigatorSaveItem.Name = "заказыBindingNavigatorSaveItem";
            this.заказыBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.заказыBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.заказыBindingNavigatorSaveItem.Click += new System.EventHandler(this.заказыBindingNavigatorSaveItem_Click);
            // 
            // заказDataGridView
            // 
            this.заказDataGridView.AutoGenerateColumns = false;
            this.заказDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.заказDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumnID,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewCheckBoxColumn1,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.Сотрудник,
            this.Клиент});
            this.заказDataGridView.DataSource = this.заказBindingSource;
            this.заказDataGridView.Location = new System.Drawing.Point(3, 44);
            this.заказDataGridView.Name = "заказDataGridView";
            this.заказDataGridView.Size = new System.Drawing.Size(1401, 307);
            this.заказDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumnID
            // 
            this.dataGridViewTextBoxColumnID.DataPropertyName = "ID_заказа";
            this.dataGridViewTextBoxColumnID.HeaderText = "ID_заказа";
            this.dataGridViewTextBoxColumnID.Name = "dataGridViewTextBoxColumnID";
            this.dataGridViewTextBoxColumnID.Width = 70;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Серийный_номер_товара";
            this.dataGridViewTextBoxColumn2.HeaderText = "Серийный_номер_товара";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 140;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Код_клиента";
            this.dataGridViewTextBoxColumn3.HeaderText = "Код_клиента";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 80;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Код_сотрудника";
            this.dataGridViewTextBoxColumn4.HeaderText = "Код_сотрудника";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Статус_заказа";
            this.dataGridViewTextBoxColumn5.HeaderText = "Статус_заказа";
            this.dataGridViewTextBoxColumn5.Items.AddRange(new object[] {
            "Оформлен",
            "Подтвержден",
            "В пути",
            "Выполнен"});
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Дата_доставки";
            this.dataGridViewTextBoxColumn6.HeaderText = "Дата_доставки";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "Статус_уведомления";
            this.dataGridViewCheckBoxColumn1.HeaderText = "Статус_уведомления";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.Width = 120;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Количество";
            this.dataGridViewTextBoxColumn7.HeaderText = "Количество";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 70;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Суммарная_стоимость";
            dataGridViewCellStyle1.Format = "C0";
            dataGridViewCellStyle1.NullValue = null;
            this.dataGridViewTextBoxColumn8.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewTextBoxColumn8.HeaderText = "Суммарная_стоимость";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 130;
            // 
            // Сотрудник
            // 
            this.Сотрудник.DataPropertyName = "Сотрудник";
            this.Сотрудник.HeaderText = "Сотрудник";
            this.Сотрудник.Name = "Сотрудник";
            this.Сотрудник.ReadOnly = true;
            this.Сотрудник.Width = 210;
            // 
            // Клиент
            // 
            this.Клиент.DataPropertyName = "Клиент";
            this.Клиент.HeaderText = "Клиент";
            this.Клиент.Name = "Клиент";
            this.Клиент.ReadOnly = true;
            this.Клиент.Width = 220;
            // 
            // заказBindingSource
            // 
            this.заказBindingSource.DataMember = "FK_Заказ_Товар";
            this.заказBindingSource.DataSource = this.товарBindingSource;
            // 
            // фотоPictureBox
            // 
            this.фотоPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.товарBindingSource, "Фото", true));
            this.фотоPictureBox.Location = new System.Drawing.Point(442, 37);
            this.фотоPictureBox.Name = "фотоPictureBox";
            this.фотоPictureBox.Size = new System.Drawing.Size(200, 184);
            this.фотоPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.фотоPictureBox.TabIndex = 12;
            this.фотоPictureBox.TabStop = false;
            // 
            // buttonClient
            // 
            this.buttonClient.Image = global::BD_BeautySaloon.Properties.Resources.client;
            this.buttonClient.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonClient.Location = new System.Drawing.Point(384, 0);
            this.buttonClient.Name = "buttonClient";
            this.buttonClient.Size = new System.Drawing.Size(69, 23);
            this.buttonClient.TabIndex = 11;
            this.buttonClient.Text = "Клиент";
            this.buttonClient.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonClient.UseVisualStyleBackColor = true;
            this.buttonClient.Click += new System.EventHandler(this.buttonClient_Click);
            // 
            // buttonWorker
            // 
            this.buttonWorker.Image = global::BD_BeautySaloon.Properties.Resources.personal;
            this.buttonWorker.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonWorker.Location = new System.Drawing.Point(292, 0);
            this.buttonWorker.Name = "buttonWorker";
            this.buttonWorker.Size = new System.Drawing.Size(86, 23);
            this.buttonWorker.TabIndex = 10;
            this.buttonWorker.Text = "Сотрудник";
            this.buttonWorker.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonWorker.UseVisualStyleBackColor = true;
            this.buttonWorker.Click += new System.EventHandler(this.buttonWorker_Click);
            // 
            // товарTableAdapter
            // 
            this.товарTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = BD_BeautySaloon.BeautySaloonDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ЗаказTableAdapter = this.заказTableAdapter;
            this.tableAdapterManager.ЗаписьОбУслугеTableAdapter = null;
            this.tableAdapterManager.КлиентTableAdapter = null;
            this.tableAdapterManager.ПерсоналTableAdapter = null;
            this.tableAdapterManager.ТоварTableAdapter = this.товарTableAdapter;
            this.tableAdapterManager.УслугаTableAdapter = null;
            // 
            // заказTableAdapter
            // 
            this.заказTableAdapter.ClearBeforeFill = true;
            // 
            // персоналBindingSource
            // 
            this.персоналBindingSource.DataMember = "Персонал";
            this.персоналBindingSource.DataSource = this.beautySaloonDataSet;
            // 
            // персоналTableAdapter
            // 
            this.персоналTableAdapter.ClearBeforeFill = true;
            // 
            // клиентBindingSource
            // 
            this.клиентBindingSource.DataMember = "Клиент";
            this.клиентBindingSource.DataSource = this.beautySaloonDataSet;
            // 
            // клиентTableAdapter
            // 
            this.клиентTableAdapter.ClearBeforeFill = true;
            // 
            // FormOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1438, 642);
            this.Controls.Add(this.buttonClient);
            this.Controls.Add(this.groupBoxOrders);
            this.Controls.Add(this.buttonWorker);
            this.Controls.Add(this.buttonOpenPhoto);
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
            this.Controls.Add(фотоLabel);
            this.Controls.Add(this.фотоPictureBox);
            this.Controls.Add(this.товарBindingNavigator);
            this.Name = "FormOrders";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Заказы";
            this.Load += new System.EventHandler(this.FormOrders_Load);
            ((System.ComponentModel.ISupportInitialize)(this.товарBindingNavigator)).EndInit();
            this.товарBindingNavigator.ResumeLayout(false);
            this.товарBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.товарBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.beautySaloonDataSet)).EndInit();
            this.groupBoxOrders.ResumeLayout(false);
            this.groupBoxOrders.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.заказыbindingNavigator)).EndInit();
            this.заказыbindingNavigator.ResumeLayout(false);
            this.заказыbindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.заказDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.заказBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.фотоPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.персоналBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.клиентBindingSource)).EndInit();
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
        private BeautySaloonDataSetTableAdapters.ЗаказTableAdapter заказTableAdapter;
        private System.Windows.Forms.BindingSource заказBindingSource;
        private System.Windows.Forms.GroupBox groupBoxOrders;
        private System.Windows.Forms.DataGridView заказDataGridView;
        private System.Windows.Forms.BindingNavigator заказыbindingNavigator;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton заказыBindingNavigatorSaveItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.Button buttonClient;
        private System.Windows.Forms.Button buttonWorker;
        private System.Windows.Forms.BindingSource персоналBindingSource;
        private BeautySaloonDataSetTableAdapters.ПерсоналTableAdapter персоналTableAdapter;
        private System.Windows.Forms.BindingSource клиентBindingSource;
        private BeautySaloonDataSetTableAdapters.КлиентTableAdapter клиентTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumnID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Сотрудник;
        private System.Windows.Forms.DataGridViewTextBoxColumn Клиент;
    }
}