namespace BD_BeautySaloon
{
    partial class FormSQL
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
            System.Windows.Forms.Label наименованиеLabel;
            System.Windows.Forms.Label стоимостьLabel;
            System.Windows.Forms.Label составLabel;
            System.Windows.Forms.Label фотоLabel;
            System.Windows.Forms.Label срок_годности_товараLabel;
            this.tabControlSQL = new System.Windows.Forms.TabControl();
            this.tabPagePrimer = new System.Windows.Forms.TabPage();
            this.dataGridViewSelect = new System.Windows.Forms.DataGridView();
            this.groupBoxSelect = new System.Windows.Forms.GroupBox();
            this.radioButtonOrders = new System.Windows.Forms.RadioButton();
            this.radioButtonRendering = new System.Windows.Forms.RadioButton();
            this.radioButtonClients = new System.Windows.Forms.RadioButton();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridViewFSelect = new System.Windows.Forms.DataGridView();
            this.groupBoxFSelect = new System.Windows.Forms.GroupBox();
            this.buttonF_select = new System.Windows.Forms.Button();
            this.checkBoxOrder = new System.Windows.Forms.CheckBox();
            this.textBoxMore = new System.Windows.Forms.TextBox();
            this.checkBoxMore = new System.Windows.Forms.CheckBox();
            this.groupBoxDet = new System.Windows.Forms.GroupBox();
            this.radioButtonDet_NO = new System.Windows.Forms.RadioButton();
            this.radioButtonDet_Type = new System.Windows.Forms.RadioButton();
            this.radioButtonDet_Services = new System.Windows.Forms.RadioButton();
            this.textBoxWorker = new System.Windows.Forms.TextBox();
            this.labelWorker = new System.Windows.Forms.Label();
            this.tabPageSubquery = new System.Windows.Forms.TabPage();
            this.dataGridViewSubquery = new System.Windows.Forms.DataGridView();
            this.groupBoxSubquery = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSubquery = new System.Windows.Forms.Button();
            this.textBoxNumber = new System.Windows.Forms.TextBox();
            this.labelNumber = new System.Windows.Forms.Label();
            this.radioButtonNoCorrelated = new System.Windows.Forms.RadioButton();
            this.radioButtonCorrelated = new System.Windows.Forms.RadioButton();
            this.tabPageDML = new System.Windows.Forms.TabPage();
            this.dataGridViewGood = new System.Windows.Forms.DataGridView();
            this.groupBoxDML = new System.Windows.Forms.GroupBox();
            this.buttonSelectGoods = new System.Windows.Forms.Button();
            this.buttonExecuteDML = new System.Windows.Forms.Button();
            this.panelGood = new System.Windows.Forms.Panel();
            this.buttonOpenPhoto = new System.Windows.Forms.Button();
            this.фотоPictureBox = new System.Windows.Forms.PictureBox();
            this.textBoxName_Product = new System.Windows.Forms.TextBox();
            this.textBoxPrice_Product = new System.Windows.Forms.TextBox();
            this.DateTimePickerExpirationDate = new System.Windows.Forms.DateTimePicker();
            this.textBoxIng_good = new System.Windows.Forms.TextBox();
            this.textBoxId_Product = new System.Windows.Forms.TextBox();
            this.labelId_Good = new System.Windows.Forms.Label();
            this.radioButtonDelete_Good = new System.Windows.Forms.RadioButton();
            this.radioButtonUpdate_Good = new System.Windows.Forms.RadioButton();
            this.radioButtonInsert_Good = new System.Windows.Forms.RadioButton();
            this.openFileDialogPhoto = new System.Windows.Forms.OpenFileDialog();
            наименованиеLabel = new System.Windows.Forms.Label();
            стоимостьLabel = new System.Windows.Forms.Label();
            составLabel = new System.Windows.Forms.Label();
            фотоLabel = new System.Windows.Forms.Label();
            срок_годности_товараLabel = new System.Windows.Forms.Label();
            this.tabControlSQL.SuspendLayout();
            this.tabPagePrimer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSelect)).BeginInit();
            this.groupBoxSelect.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFSelect)).BeginInit();
            this.groupBoxFSelect.SuspendLayout();
            this.groupBoxDet.SuspendLayout();
            this.tabPageSubquery.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSubquery)).BeginInit();
            this.groupBoxSubquery.SuspendLayout();
            this.tabPageDML.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGood)).BeginInit();
            this.groupBoxDML.SuspendLayout();
            this.panelGood.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.фотоPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // наименованиеLabel
            // 
            наименованиеLabel.AutoSize = true;
            наименованиеLabel.Location = new System.Drawing.Point(6, 19);
            наименованиеLabel.Name = "наименованиеLabel";
            наименованиеLabel.Size = new System.Drawing.Size(86, 13);
            наименованиеLabel.TabIndex = 13;
            наименованиеLabel.Text = "Наименование:";
            // 
            // стоимостьLabel
            // 
            стоимостьLabel.AutoSize = true;
            стоимостьLabel.Location = new System.Drawing.Point(6, 45);
            стоимостьLabel.Name = "стоимостьLabel";
            стоимостьLabel.Size = new System.Drawing.Size(65, 13);
            стоимостьLabel.TabIndex = 15;
            стоимостьLabel.Text = "Стоимость:";
            // 
            // составLabel
            // 
            составLabel.AutoSize = true;
            составLabel.Location = new System.Drawing.Point(6, 98);
            составLabel.Name = "составLabel";
            составLabel.Size = new System.Drawing.Size(46, 13);
            составLabel.TabIndex = 19;
            составLabel.Text = "Состав:";
            // 
            // фотоLabel
            // 
            фотоLabel.AutoSize = true;
            фотоLabel.Location = new System.Drawing.Point(388, 16);
            фотоLabel.Name = "фотоLabel";
            фотоLabel.Size = new System.Drawing.Size(38, 13);
            фотоLabel.TabIndex = 21;
            фотоLabel.Text = "Фото:";
            // 
            // срок_годности_товараLabel
            // 
            срок_годности_товараLabel.AutoSize = true;
            срок_годности_товараLabel.Location = new System.Drawing.Point(6, 72);
            срок_годности_товараLabel.Name = "срок_годности_товараLabel";
            срок_годности_товараLabel.Size = new System.Drawing.Size(122, 13);
            срок_годности_товараLabel.TabIndex = 17;
            срок_годности_товараLabel.Text = "Срок годности товара:";
            // 
            // tabControlSQL
            // 
            this.tabControlSQL.Controls.Add(this.tabPagePrimer);
            this.tabControlSQL.Controls.Add(this.tabPage2);
            this.tabControlSQL.Controls.Add(this.tabPageSubquery);
            this.tabControlSQL.Controls.Add(this.tabPageDML);
            this.tabControlSQL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlSQL.Location = new System.Drawing.Point(0, 0);
            this.tabControlSQL.Name = "tabControlSQL";
            this.tabControlSQL.SelectedIndex = 0;
            this.tabControlSQL.Size = new System.Drawing.Size(1002, 651);
            this.tabControlSQL.TabIndex = 0;
            // 
            // tabPagePrimer
            // 
            this.tabPagePrimer.Controls.Add(this.dataGridViewSelect);
            this.tabPagePrimer.Controls.Add(this.groupBoxSelect);
            this.tabPagePrimer.Location = new System.Drawing.Point(4, 22);
            this.tabPagePrimer.Name = "tabPagePrimer";
            this.tabPagePrimer.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePrimer.Size = new System.Drawing.Size(994, 625);
            this.tabPagePrimer.TabIndex = 0;
            this.tabPagePrimer.Text = "Примеры запросов";
            this.tabPagePrimer.UseVisualStyleBackColor = true;
            // 
            // dataGridViewSelect
            // 
            this.dataGridViewSelect.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSelect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewSelect.Location = new System.Drawing.Point(3, 103);
            this.dataGridViewSelect.Name = "dataGridViewSelect";
            this.dataGridViewSelect.Size = new System.Drawing.Size(988, 519);
            this.dataGridViewSelect.TabIndex = 1;
            // 
            // groupBoxSelect
            // 
            this.groupBoxSelect.Controls.Add(this.radioButtonOrders);
            this.groupBoxSelect.Controls.Add(this.radioButtonRendering);
            this.groupBoxSelect.Controls.Add(this.radioButtonClients);
            this.groupBoxSelect.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxSelect.Location = new System.Drawing.Point(3, 3);
            this.groupBoxSelect.Name = "groupBoxSelect";
            this.groupBoxSelect.Size = new System.Drawing.Size(988, 100);
            this.groupBoxSelect.TabIndex = 0;
            this.groupBoxSelect.TabStop = false;
            this.groupBoxSelect.Text = "Запросы по данным";
            // 
            // radioButtonOrders
            // 
            this.radioButtonOrders.AutoSize = true;
            this.radioButtonOrders.Location = new System.Drawing.Point(5, 65);
            this.radioButtonOrders.Name = "radioButtonOrders";
            this.radioButtonOrders.Size = new System.Drawing.Size(64, 17);
            this.radioButtonOrders.TabIndex = 2;
            this.radioButtonOrders.TabStop = true;
            this.radioButtonOrders.Text = "Заказы";
            this.radioButtonOrders.UseVisualStyleBackColor = true;
            this.radioButtonOrders.CheckedChanged += new System.EventHandler(this.radioButtonOrders_CheckedChanged);
            // 
            // radioButtonRendering
            // 
            this.radioButtonRendering.AutoSize = true;
            this.radioButtonRendering.Location = new System.Drawing.Point(6, 42);
            this.radioButtonRendering.Name = "radioButtonRendering";
            this.radioButtonRendering.Size = new System.Drawing.Size(111, 17);
            this.radioButtonRendering.TabIndex = 1;
            this.radioButtonRendering.TabStop = true;
            this.radioButtonRendering.Text = "Оказание услуги";
            this.radioButtonRendering.UseVisualStyleBackColor = true;
            this.radioButtonRendering.CheckedChanged += new System.EventHandler(this.radioButtonRendering_CheckedChanged);
            // 
            // radioButtonClients
            // 
            this.radioButtonClients.AutoSize = true;
            this.radioButtonClients.Location = new System.Drawing.Point(6, 19);
            this.radioButtonClients.Name = "radioButtonClients";
            this.radioButtonClients.Size = new System.Drawing.Size(69, 17);
            this.radioButtonClients.TabIndex = 0;
            this.radioButtonClients.TabStop = true;
            this.radioButtonClients.Text = "Клиенты";
            this.radioButtonClients.UseVisualStyleBackColor = true;
            this.radioButtonClients.CheckedChanged += new System.EventHandler(this.radioButtonClients_CheckedChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridViewFSelect);
            this.tabPage2.Controls.Add(this.groupBoxFSelect);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(994, 625);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Полная запись SELECT";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridViewFSelect
            // 
            this.dataGridViewFSelect.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFSelect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewFSelect.Location = new System.Drawing.Point(3, 203);
            this.dataGridViewFSelect.Name = "dataGridViewFSelect";
            this.dataGridViewFSelect.Size = new System.Drawing.Size(988, 419);
            this.dataGridViewFSelect.TabIndex = 1;
            // 
            // groupBoxFSelect
            // 
            this.groupBoxFSelect.Controls.Add(this.buttonF_select);
            this.groupBoxFSelect.Controls.Add(this.checkBoxOrder);
            this.groupBoxFSelect.Controls.Add(this.textBoxMore);
            this.groupBoxFSelect.Controls.Add(this.checkBoxMore);
            this.groupBoxFSelect.Controls.Add(this.groupBoxDet);
            this.groupBoxFSelect.Controls.Add(this.textBoxWorker);
            this.groupBoxFSelect.Controls.Add(this.labelWorker);
            this.groupBoxFSelect.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxFSelect.Location = new System.Drawing.Point(3, 3);
            this.groupBoxFSelect.Name = "groupBoxFSelect";
            this.groupBoxFSelect.Size = new System.Drawing.Size(988, 200);
            this.groupBoxFSelect.TabIndex = 0;
            this.groupBoxFSelect.TabStop = false;
            this.groupBoxFSelect.Text = "Прибыль сотрудников";
            // 
            // buttonF_select
            // 
            this.buttonF_select.Image = global::BD_BeautySaloon.Properties.Resources.profit;
            this.buttonF_select.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonF_select.Location = new System.Drawing.Point(91, 159);
            this.buttonF_select.Name = "buttonF_select";
            this.buttonF_select.Size = new System.Drawing.Size(170, 23);
            this.buttonF_select.TabIndex = 6;
            this.buttonF_select.Text = "Прибыль сотрудника(-ов)";
            this.buttonF_select.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonF_select.UseVisualStyleBackColor = true;
            this.buttonF_select.Click += new System.EventHandler(this.buttonF_select_Click);
            // 
            // checkBoxOrder
            // 
            this.checkBoxOrder.AutoSize = true;
            this.checkBoxOrder.Location = new System.Drawing.Point(9, 109);
            this.checkBoxOrder.Name = "checkBoxOrder";
            this.checkBoxOrder.Size = new System.Drawing.Size(252, 17);
            this.checkBoxOrder.TabIndex = 5;
            this.checkBoxOrder.Text = "Включить сортировку по убыванию прибыли";
            this.checkBoxOrder.UseVisualStyleBackColor = true;
            // 
            // textBoxMore
            // 
            this.textBoxMore.Location = new System.Drawing.Point(165, 69);
            this.textBoxMore.Name = "textBoxMore";
            this.textBoxMore.Size = new System.Drawing.Size(111, 20);
            this.textBoxMore.TabIndex = 4;
            // 
            // checkBoxMore
            // 
            this.checkBoxMore.AutoSize = true;
            this.checkBoxMore.Location = new System.Drawing.Point(9, 72);
            this.checkBoxMore.Name = "checkBoxMore";
            this.checkBoxMore.Size = new System.Drawing.Size(150, 17);
            this.checkBoxMore.TabIndex = 3;
            this.checkBoxMore.Text = "Выбрать прибыль более";
            this.checkBoxMore.UseVisualStyleBackColor = true;
            // 
            // groupBoxDet
            // 
            this.groupBoxDet.Controls.Add(this.radioButtonDet_NO);
            this.groupBoxDet.Controls.Add(this.radioButtonDet_Type);
            this.groupBoxDet.Controls.Add(this.radioButtonDet_Services);
            this.groupBoxDet.Location = new System.Drawing.Point(464, 19);
            this.groupBoxDet.Name = "groupBoxDet";
            this.groupBoxDet.Size = new System.Drawing.Size(369, 149);
            this.groupBoxDet.TabIndex = 2;
            this.groupBoxDet.TabStop = false;
            this.groupBoxDet.Text = "Детализация прибыли сотрудников";
            // 
            // radioButtonDet_NO
            // 
            this.radioButtonDet_NO.AutoSize = true;
            this.radioButtonDet_NO.Location = new System.Drawing.Point(6, 65);
            this.radioButtonDet_NO.Name = "radioButtonDet_NO";
            this.radioButtonDet_NO.Size = new System.Drawing.Size(138, 17);
            this.radioButtonDet_NO.TabIndex = 2;
            this.radioButtonDet_NO.TabStop = true;
            this.radioButtonDet_NO.Text = "Прибыль сотрудников";
            this.radioButtonDet_NO.UseVisualStyleBackColor = true;
            this.radioButtonDet_NO.Click += new System.EventHandler(this.radioButtonDet_NO_Click);
            // 
            // radioButtonDet_Type
            // 
            this.radioButtonDet_Type.AutoSize = true;
            this.radioButtonDet_Type.Location = new System.Drawing.Point(6, 42);
            this.radioButtonDet_Type.Name = "radioButtonDet_Type";
            this.radioButtonDet_Type.Size = new System.Drawing.Size(211, 17);
            this.radioButtonDet_Type.TabIndex = 1;
            this.radioButtonDet_Type.TabStop = true;
            this.radioButtonDet_Type.Text = "Прибыль сотрудника по типам услуг";
            this.radioButtonDet_Type.UseVisualStyleBackColor = true;
            this.radioButtonDet_Type.Click += new System.EventHandler(this.radioButtonDet_Type_Click);
            // 
            // radioButtonDet_Services
            // 
            this.radioButtonDet_Services.AutoSize = true;
            this.radioButtonDet_Services.Location = new System.Drawing.Point(6, 19);
            this.radioButtonDet_Services.Name = "radioButtonDet_Services";
            this.radioButtonDet_Services.Size = new System.Drawing.Size(288, 17);
            this.radioButtonDet_Services.TabIndex = 0;
            this.radioButtonDet_Services.TabStop = true;
            this.radioButtonDet_Services.Text = "Общая прибыль сотрудника по оказанным услугам";
            this.radioButtonDet_Services.UseVisualStyleBackColor = true;
            this.radioButtonDet_Services.CheckedChanged += new System.EventHandler(this.radioButtonDet_Services_CheckedChanged);
            // 
            // textBoxWorker
            // 
            this.textBoxWorker.Location = new System.Drawing.Point(129, 30);
            this.textBoxWorker.Name = "textBoxWorker";
            this.textBoxWorker.Size = new System.Drawing.Size(147, 20);
            this.textBoxWorker.TabIndex = 1;
            // 
            // labelWorker
            // 
            this.labelWorker.AutoSize = true;
            this.labelWorker.Location = new System.Drawing.Point(6, 33);
            this.labelWorker.Name = "labelWorker";
            this.labelWorker.Size = new System.Drawing.Size(117, 13);
            this.labelWorker.TabIndex = 0;
            this.labelWorker.Text = "Фамилия сотрудника";
            // 
            // tabPageSubquery
            // 
            this.tabPageSubquery.Controls.Add(this.dataGridViewSubquery);
            this.tabPageSubquery.Controls.Add(this.groupBoxSubquery);
            this.tabPageSubquery.Location = new System.Drawing.Point(4, 22);
            this.tabPageSubquery.Name = "tabPageSubquery";
            this.tabPageSubquery.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSubquery.Size = new System.Drawing.Size(994, 625);
            this.tabPageSubquery.TabIndex = 2;
            this.tabPageSubquery.Text = "Примеры подзапросов";
            this.tabPageSubquery.UseVisualStyleBackColor = true;
            // 
            // dataGridViewSubquery
            // 
            this.dataGridViewSubquery.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSubquery.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewSubquery.Location = new System.Drawing.Point(3, 103);
            this.dataGridViewSubquery.Name = "dataGridViewSubquery";
            this.dataGridViewSubquery.Size = new System.Drawing.Size(988, 519);
            this.dataGridViewSubquery.TabIndex = 1;
            // 
            // groupBoxSubquery
            // 
            this.groupBoxSubquery.Controls.Add(this.label1);
            this.groupBoxSubquery.Controls.Add(this.buttonSubquery);
            this.groupBoxSubquery.Controls.Add(this.textBoxNumber);
            this.groupBoxSubquery.Controls.Add(this.labelNumber);
            this.groupBoxSubquery.Controls.Add(this.radioButtonNoCorrelated);
            this.groupBoxSubquery.Controls.Add(this.radioButtonCorrelated);
            this.groupBoxSubquery.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxSubquery.Location = new System.Drawing.Point(3, 3);
            this.groupBoxSubquery.Name = "groupBoxSubquery";
            this.groupBoxSubquery.Size = new System.Drawing.Size(988, 100);
            this.groupBoxSubquery.TabIndex = 0;
            this.groupBoxSubquery.TabStop = false;
            this.groupBoxSubquery.Text = "Подзапросы по данным";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(480, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 26);
            this.label1.TabIndex = 5;
            this.label1.Text = "Какие заказы определенного товара \r\nбыли оформлены сотрудниками мужского пола?";
            // 
            // buttonSubquery
            // 
            this.buttonSubquery.Image = global::BD_BeautySaloon.Properties.Resources.request;
            this.buttonSubquery.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSubquery.Location = new System.Drawing.Point(261, 42);
            this.buttonSubquery.Name = "buttonSubquery";
            this.buttonSubquery.Size = new System.Drawing.Size(148, 23);
            this.buttonSubquery.TabIndex = 4;
            this.buttonSubquery.Text = "Выполнить подзапрос";
            this.buttonSubquery.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonSubquery.UseVisualStyleBackColor = true;
            this.buttonSubquery.Click += new System.EventHandler(this.buttonSubquery_Click);
            // 
            // textBoxNumber
            // 
            this.textBoxNumber.Location = new System.Drawing.Point(330, 16);
            this.textBoxNumber.Name = "textBoxNumber";
            this.textBoxNumber.Size = new System.Drawing.Size(100, 20);
            this.textBoxNumber.TabIndex = 3;
            // 
            // labelNumber
            // 
            this.labelNumber.AutoSize = true;
            this.labelNumber.Location = new System.Drawing.Point(236, 19);
            this.labelNumber.Name = "labelNumber";
            this.labelNumber.Size = new System.Drawing.Size(79, 13);
            this.labelNumber.TabIndex = 2;
            this.labelNumber.Text = "Номер товара";
            // 
            // radioButtonNoCorrelated
            // 
            this.radioButtonNoCorrelated.AutoSize = true;
            this.radioButtonNoCorrelated.Location = new System.Drawing.Point(6, 42);
            this.radioButtonNoCorrelated.Name = "radioButtonNoCorrelated";
            this.radioButtonNoCorrelated.Size = new System.Drawing.Size(188, 17);
            this.radioButtonNoCorrelated.TabIndex = 1;
            this.radioButtonNoCorrelated.TabStop = true;
            this.radioButtonNoCorrelated.Text = "Некоррелированный подзапрос";
            this.radioButtonNoCorrelated.UseVisualStyleBackColor = true;
            // 
            // radioButtonCorrelated
            // 
            this.radioButtonCorrelated.AutoSize = true;
            this.radioButtonCorrelated.Location = new System.Drawing.Point(6, 19);
            this.radioButtonCorrelated.Name = "radioButtonCorrelated";
            this.radioButtonCorrelated.Size = new System.Drawing.Size(175, 17);
            this.radioButtonCorrelated.TabIndex = 0;
            this.radioButtonCorrelated.TabStop = true;
            this.radioButtonCorrelated.Text = "Коррелированный подзапрос";
            this.radioButtonCorrelated.UseVisualStyleBackColor = true;
            // 
            // tabPageDML
            // 
            this.tabPageDML.Controls.Add(this.dataGridViewGood);
            this.tabPageDML.Controls.Add(this.groupBoxDML);
            this.tabPageDML.Location = new System.Drawing.Point(4, 22);
            this.tabPageDML.Name = "tabPageDML";
            this.tabPageDML.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDML.Size = new System.Drawing.Size(994, 625);
            this.tabPageDML.TabIndex = 3;
            this.tabPageDML.Text = "Запросы изменения данных";
            this.tabPageDML.UseVisualStyleBackColor = true;
            // 
            // dataGridViewGood
            // 
            this.dataGridViewGood.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewGood.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewGood.Location = new System.Drawing.Point(3, 418);
            this.dataGridViewGood.Name = "dataGridViewGood";
            this.dataGridViewGood.Size = new System.Drawing.Size(988, 204);
            this.dataGridViewGood.TabIndex = 1;
            // 
            // groupBoxDML
            // 
            this.groupBoxDML.Controls.Add(this.buttonSelectGoods);
            this.groupBoxDML.Controls.Add(this.buttonExecuteDML);
            this.groupBoxDML.Controls.Add(this.panelGood);
            this.groupBoxDML.Controls.Add(this.textBoxId_Product);
            this.groupBoxDML.Controls.Add(this.labelId_Good);
            this.groupBoxDML.Controls.Add(this.radioButtonDelete_Good);
            this.groupBoxDML.Controls.Add(this.radioButtonUpdate_Good);
            this.groupBoxDML.Controls.Add(this.radioButtonInsert_Good);
            this.groupBoxDML.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxDML.Location = new System.Drawing.Point(3, 3);
            this.groupBoxDML.Name = "groupBoxDML";
            this.groupBoxDML.Size = new System.Drawing.Size(988, 415);
            this.groupBoxDML.TabIndex = 0;
            this.groupBoxDML.TabStop = false;
            this.groupBoxDML.Text = "Операторы";
            // 
            // buttonSelectGoods
            // 
            this.buttonSelectGoods.Image = global::BD_BeautySaloon.Properties.Resources.list;
            this.buttonSelectGoods.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSelectGoods.Location = new System.Drawing.Point(416, 386);
            this.buttonSelectGoods.Name = "buttonSelectGoods";
            this.buttonSelectGoods.Size = new System.Drawing.Size(171, 23);
            this.buttonSelectGoods.TabIndex = 2;
            this.buttonSelectGoods.Text = "Показать список товаров";
            this.buttonSelectGoods.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonSelectGoods.UseVisualStyleBackColor = true;
            this.buttonSelectGoods.Click += new System.EventHandler(this.buttonSelectGoods_Click);
            // 
            // buttonExecuteDML
            // 
            this.buttonExecuteDML.Image = global::BD_BeautySaloon.Properties.Resources.inquiry;
            this.buttonExecuteDML.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonExecuteDML.Location = new System.Drawing.Point(436, 51);
            this.buttonExecuteDML.Name = "buttonExecuteDML";
            this.buttonExecuteDML.Size = new System.Drawing.Size(131, 23);
            this.buttonExecuteDML.TabIndex = 6;
            this.buttonExecuteDML.Text = "Выполнить запрос";
            this.buttonExecuteDML.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonExecuteDML.UseVisualStyleBackColor = true;
            this.buttonExecuteDML.Click += new System.EventHandler(this.buttonExecuteDML_Click);
            // 
            // panelGood
            // 
            this.panelGood.Controls.Add(фотоLabel);
            this.panelGood.Controls.Add(this.buttonOpenPhoto);
            this.panelGood.Controls.Add(this.фотоPictureBox);
            this.panelGood.Controls.Add(наименованиеLabel);
            this.panelGood.Controls.Add(this.textBoxName_Product);
            this.panelGood.Controls.Add(стоимостьLabel);
            this.panelGood.Controls.Add(this.textBoxPrice_Product);
            this.panelGood.Controls.Add(срок_годности_товараLabel);
            this.panelGood.Controls.Add(this.DateTimePickerExpirationDate);
            this.panelGood.Controls.Add(составLabel);
            this.panelGood.Controls.Add(this.textBoxIng_good);
            this.panelGood.Location = new System.Drawing.Point(3, 89);
            this.panelGood.Name = "panelGood";
            this.panelGood.Size = new System.Drawing.Size(979, 291);
            this.panelGood.TabIndex = 5;
            // 
            // buttonOpenPhoto
            // 
            this.buttonOpenPhoto.Location = new System.Drawing.Point(479, 236);
            this.buttonOpenPhoto.Name = "buttonOpenPhoto";
            this.buttonOpenPhoto.Size = new System.Drawing.Size(105, 23);
            this.buttonOpenPhoto.TabIndex = 23;
            this.buttonOpenPhoto.Text = "Открыть фото";
            this.buttonOpenPhoto.UseVisualStyleBackColor = true;
            this.buttonOpenPhoto.Click += new System.EventHandler(this.buttonOpenPhoto_Click);
            // 
            // фотоPictureBox
            // 
            this.фотоPictureBox.Location = new System.Drawing.Point(443, 13);
            this.фотоPictureBox.Name = "фотоPictureBox";
            this.фотоPictureBox.Size = new System.Drawing.Size(172, 217);
            this.фотоPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.фотоPictureBox.TabIndex = 22;
            this.фотоPictureBox.TabStop = false;
            // 
            // textBoxName_Product
            // 
            this.textBoxName_Product.Location = new System.Drawing.Point(146, 16);
            this.textBoxName_Product.Name = "textBoxName_Product";
            this.textBoxName_Product.Size = new System.Drawing.Size(200, 20);
            this.textBoxName_Product.TabIndex = 14;
            // 
            // textBoxPrice_Product
            // 
            this.textBoxPrice_Product.Location = new System.Drawing.Point(146, 42);
            this.textBoxPrice_Product.Name = "textBoxPrice_Product";
            this.textBoxPrice_Product.Size = new System.Drawing.Size(200, 20);
            this.textBoxPrice_Product.TabIndex = 16;
            // 
            // DateTimePickerExpirationDate
            // 
            this.DateTimePickerExpirationDate.Location = new System.Drawing.Point(146, 68);
            this.DateTimePickerExpirationDate.Name = "DateTimePickerExpirationDate";
            this.DateTimePickerExpirationDate.Size = new System.Drawing.Size(200, 20);
            this.DateTimePickerExpirationDate.TabIndex = 18;
            // 
            // textBoxIng_good
            // 
            this.textBoxIng_good.Location = new System.Drawing.Point(146, 98);
            this.textBoxIng_good.Multiline = true;
            this.textBoxIng_good.Name = "textBoxIng_good";
            this.textBoxIng_good.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxIng_good.Size = new System.Drawing.Size(200, 157);
            this.textBoxIng_good.TabIndex = 20;
            // 
            // textBoxId_Product
            // 
            this.textBoxId_Product.Location = new System.Drawing.Point(76, 53);
            this.textBoxId_Product.Name = "textBoxId_Product";
            this.textBoxId_Product.Size = new System.Drawing.Size(100, 20);
            this.textBoxId_Product.TabIndex = 4;
            // 
            // labelId_Good
            // 
            this.labelId_Good.AutoSize = true;
            this.labelId_Good.Location = new System.Drawing.Point(6, 56);
            this.labelId_Good.Name = "labelId_Good";
            this.labelId_Good.Size = new System.Drawing.Size(64, 13);
            this.labelId_Good.TabIndex = 3;
            this.labelId_Good.Text = "Код товара";
            // 
            // radioButtonDelete_Good
            // 
            this.radioButtonDelete_Good.AutoSize = true;
            this.radioButtonDelete_Good.Location = new System.Drawing.Point(647, 19);
            this.radioButtonDelete_Good.Name = "radioButtonDelete_Good";
            this.radioButtonDelete_Good.Size = new System.Drawing.Size(260, 17);
            this.radioButtonDelete_Good.TabIndex = 2;
            this.radioButtonDelete_Good.TabStop = true;
            this.radioButtonDelete_Good.Text = "Удалить данные по товару с заданным кодом";
            this.radioButtonDelete_Good.UseVisualStyleBackColor = true;
            this.radioButtonDelete_Good.CheckedChanged += new System.EventHandler(this.radioButtonDelete_Good_CheckedChanged);
            // 
            // radioButtonUpdate_Good
            // 
            this.radioButtonUpdate_Good.AutoSize = true;
            this.radioButtonUpdate_Good.Location = new System.Drawing.Point(357, 19);
            this.radioButtonUpdate_Good.Name = "radioButtonUpdate_Good";
            this.radioButtonUpdate_Good.Size = new System.Drawing.Size(268, 17);
            this.radioButtonUpdate_Good.TabIndex = 1;
            this.radioButtonUpdate_Good.TabStop = true;
            this.radioButtonUpdate_Good.Text = "Изменить данные по товару с заданным кодом";
            this.radioButtonUpdate_Good.UseVisualStyleBackColor = true;
            // 
            // radioButtonInsert_Good
            // 
            this.radioButtonInsert_Good.AutoSize = true;
            this.radioButtonInsert_Good.Location = new System.Drawing.Point(126, 19);
            this.radioButtonInsert_Good.Name = "radioButtonInsert_Good";
            this.radioButtonInsert_Good.Size = new System.Drawing.Size(168, 17);
            this.radioButtonInsert_Good.TabIndex = 0;
            this.radioButtonInsert_Good.TabStop = true;
            this.radioButtonInsert_Good.Text = "Добавить данные по товару";
            this.radioButtonInsert_Good.UseVisualStyleBackColor = true;
            // 
            // openFileDialogPhoto
            // 
            this.openFileDialogPhoto.FileName = "openFileDialog1";
            // 
            // FormSQL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 651);
            this.Controls.Add(this.tabControlSQL);
            this.Name = "FormSQL";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Запросы";
            this.tabControlSQL.ResumeLayout(false);
            this.tabPagePrimer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSelect)).EndInit();
            this.groupBoxSelect.ResumeLayout(false);
            this.groupBoxSelect.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFSelect)).EndInit();
            this.groupBoxFSelect.ResumeLayout(false);
            this.groupBoxFSelect.PerformLayout();
            this.groupBoxDet.ResumeLayout(false);
            this.groupBoxDet.PerformLayout();
            this.tabPageSubquery.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSubquery)).EndInit();
            this.groupBoxSubquery.ResumeLayout(false);
            this.groupBoxSubquery.PerformLayout();
            this.tabPageDML.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGood)).EndInit();
            this.groupBoxDML.ResumeLayout(false);
            this.groupBoxDML.PerformLayout();
            this.panelGood.ResumeLayout(false);
            this.panelGood.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.фотоPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlSQL;
        private System.Windows.Forms.TabPage tabPagePrimer;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridViewSelect;
        private System.Windows.Forms.GroupBox groupBoxSelect;
        private System.Windows.Forms.RadioButton radioButtonOrders;
        private System.Windows.Forms.RadioButton radioButtonRendering;
        private System.Windows.Forms.RadioButton radioButtonClients;
        private System.Windows.Forms.GroupBox groupBoxFSelect;
        private System.Windows.Forms.GroupBox groupBoxDet;
        private System.Windows.Forms.TextBox textBoxWorker;
        private System.Windows.Forms.Label labelWorker;
        private System.Windows.Forms.TextBox textBoxMore;
        private System.Windows.Forms.CheckBox checkBoxMore;
        private System.Windows.Forms.RadioButton radioButtonDet_NO;
        private System.Windows.Forms.RadioButton radioButtonDet_Type;
        private System.Windows.Forms.RadioButton radioButtonDet_Services;
        private System.Windows.Forms.Button buttonF_select;
        private System.Windows.Forms.CheckBox checkBoxOrder;
        private System.Windows.Forms.DataGridView dataGridViewFSelect;
        private System.Windows.Forms.TabPage tabPageSubquery;
        private System.Windows.Forms.DataGridView dataGridViewSubquery;
        private System.Windows.Forms.GroupBox groupBoxSubquery;
        private System.Windows.Forms.Button buttonSubquery;
        private System.Windows.Forms.TextBox textBoxNumber;
        private System.Windows.Forms.Label labelNumber;
        private System.Windows.Forms.RadioButton radioButtonNoCorrelated;
        private System.Windows.Forms.RadioButton radioButtonCorrelated;
        private System.Windows.Forms.TabPage tabPageDML;
        private System.Windows.Forms.GroupBox groupBoxDML;
        private System.Windows.Forms.RadioButton radioButtonInsert_Good;
        private System.Windows.Forms.Panel panelGood;
        private System.Windows.Forms.Label labelId_Good;
        private System.Windows.Forms.RadioButton radioButtonDelete_Good;
        private System.Windows.Forms.RadioButton radioButtonUpdate_Good;
        private System.Windows.Forms.TextBox textBoxId_Product;
        private System.Windows.Forms.TextBox textBoxName_Product;
        private System.Windows.Forms.TextBox textBoxPrice_Product;
        private System.Windows.Forms.TextBox textBoxIng_good;
        private System.Windows.Forms.Button buttonOpenPhoto;
        private System.Windows.Forms.PictureBox фотоPictureBox;
        private System.Windows.Forms.OpenFileDialog openFileDialogPhoto;
        private System.Windows.Forms.Button buttonExecuteDML;
        private System.Windows.Forms.DataGridView dataGridViewGood;
        private System.Windows.Forms.Button buttonSelectGoods;
        private System.Windows.Forms.DateTimePicker DateTimePickerExpirationDate;
        private System.Windows.Forms.Label label1;
    }
}