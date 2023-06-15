using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace BD_BeautySaloon
{
    public partial class FormSQL : Form
    {
        public FormSQL()
        {
            InitializeComponent();
        }

        //объявляем метод, на вход подаем строку запроса, а возвращаем объект DataTable
        DataTable FillDataGridView(string sqlSelect)
        {
            SqlConnection connection = new
           SqlConnection(Properties.Settings.Default.BeautySaloonConnectionString);
            //Создаем объект command для SQL команды
            SqlCommand command = connection.CreateCommand();
            //Заносим текст SQL запроса через параметр sqlSelect
            command.CommandText = sqlSelect;
            //Создаем объект adapter класса SqlDataAdapter
            SqlDataAdapter adapter = new SqlDataAdapter();
            //Задаем адаптеру нужную команду, в данном случае команду Select
            adapter.SelectCommand = command;
            //Создаем объект table для последующего отображения результата запроса
            DataTable table = new DataTable();
            //заполним набор данных результатом запроса
            adapter.Fill(table);
            return table;
        }

        private static FormSQL f;

        public static FormSQL fs
        {
            get
            {
                if (f == null || f.IsDisposed) f = new FormSQL();
                return f;
            }
        }

        public void ShowForm()
        {
            Show();
            Activate();
        }

        private void radioButtonClients_CheckedChanged(object sender, EventArgs e)
        {
            dataGridViewSelect.DataSource = FillDataGridView("SELECT Код_клиента, Фамилия + ' ' + Имя " +
                "+ ' ' + Отчество AS [ФИО Клиента] FROM Клиент");
        }

        private void radioButtonRendering_CheckedChanged(object sender, EventArgs e)
        {
            dataGridViewSelect.DataSource = FillDataGridView("SELECT ЗаписьОбУслуге.ID_записи, Услуга.Тип, " +
                "Услуга.Стоимость, Персонал.Фамилия + ' ' + Персонал.Имя + ' ' + Персонал.Отчество AS [ФИО Сотрудника], " +
                "\r\n Клиент.Фамилия + ' ' + Клиент.Имя + ' ' + Клиент.Отчество AS [ФИО Клиента]\r\nFROM ЗаписьОбУслуге " +
                "INNER JOIN\r\n Клиент ON ЗаписьОбУслуге.Код_клиента = Клиент.Код_клиента INNER JOIN\r\n Персонал ON " +
                "ЗаписьОбУслуге.Код_сотрудника = Персонал.Код_сотрудника INNER JOIN\r\n Услуга ON " +
                "ЗаписьОбУслуге.Код_услуги = Услуга.Код_услуги");
        }

        private void radioButtonOrders_CheckedChanged(object sender, EventArgs e)
        {
            dataGridViewSelect.DataSource = FillDataGridView("SELECT Заказ.ID_заказа, Товар.Наименование AS [Наименование товара], " +
        "Товар.Стоимость, Заказ.Количество, Заказ.Суммарная_стоимость, Клиент.Фамилия + ' ' + Клиент.Имя " +
        "+ ' ' + Клиент.Отчество AS [ФИО Клиента], \r\nПерсонал.Фамилия + ' ' + Персонал.Имя " +
        "+ ' ' + Персонал.Отчество AS [ФИО Сотрудника]\r\nFROM Заказ INNER JOIN\r\nПерсонал ON " +
        "Заказ.Код_сотрудника = Персонал.Код_сотрудника INNER JOIN\r\nКлиент ON " +
        "Заказ.Код_клиента = Клиент.Код_клиента INNER JOIN\r\nТовар ON " +
        "Заказ.Серийный_номер_товара = Товар.Серийный_номер_товара");
        }

        private void buttonF_select_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxWorker.Text) && !radioButtonDet_NO.Checked)
            {
                MessageBox.Show("Обязательно укажите фамилию необходимого сотрудника." +
                    "\nДопустим ввод первых символов.", "Внимание", MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
                return;
            }
            if (checkBoxMore.Checked && String.IsNullOrEmpty(textBoxMore.Text))
            {
                MessageBox.Show("Не указана прибыль в условии", "Внимание",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                checkBoxMore.Checked = false;
                return;
            }
            string sqlSelect = "";
            if (radioButtonDet_Services.Checked)
                sqlSelect = @"SELECT ЗаписьОбУслуге.Код_сотрудника, Персонал.Имя, 
                Персонал.Фамилия, Персонал.Отчество, 
                SUM(Услуга.Стоимость) AS Прибыль
                FROM ЗаписьОбУслуге INNER JOIN
                Услуга ON ЗаписьОбУслуге.Код_услуги = Услуга.Код_услуги INNER JOIN
                Персонал ON ЗаписьОбУслуге.Код_сотрудника = Персонал.Код_сотрудника
                WHERE Фамилия LIKE @last_name
                GROUP BY ЗаписьОбУслуге.Код_сотрудника, Персонал.Имя, 
                Персонал.Фамилия, Персонал.Отчество";
            else if (radioButtonDet_Type.Checked)
                sqlSelect = @"SELECT ЗаписьОбУслуге.Код_сотрудника, Персонал.Имя, 
                Персонал.Фамилия, Персонал.Отчество, 
                Услуга.Тип AS Услуга,SUM(Услуга.Стоимость) AS Прибыль FROM ЗаписьОбУслуге INNER JOIN
                Услуга ON ЗаписьОбУслуге.Код_услуги = Услуга.Код_услуги INNER JOIN
                Персонал ON ЗаписьОбУслуге.Код_сотрудника = Персонал.Код_сотрудника 
                WHERE Фамилия LIKE @last_name
                GROUP BY ЗаписьОбУслуге.Код_сотрудника, 
                Персонал.Имя, Персонал.Фамилия, Персонал.Отчество, Услуга.Тип";
            else
            {
                sqlSelect = @"SELECT ЗаписьОбУслуге.Код_сотрудника, Персонал.Имя, 
                Персонал.Фамилия, Персонал.Отчество, 
                SUM(Услуга.Стоимость) AS Прибыль
                FROM ЗаписьОбУслуге INNER JOIN
                Услуга ON ЗаписьОбУслуге.Код_услуги = Услуга.Код_услуги INNER JOIN
                Персонал ON ЗаписьОбУслуге.Код_сотрудника = Персонал.Код_сотрудника
                GROUP BY ЗаписьОбУслуге.Код_сотрудника, Персонал.Имя, 
                Персонал.Фамилия, Персонал.Отчество";
            }

            if (checkBoxMore.Checked)
                sqlSelect += " HAVING Sum(Услуга.Стоимость) >@amount";
            if (checkBoxOrder.Checked)

                sqlSelect += " ORDER BY Sum(Услуга.Стоимость) desc";

            else if (!radioButtonDet_NO.Checked) sqlSelect += " ORDER BY Sum(Услуга.Стоимость)";
            SqlConnection connection = new
            SqlConnection(Properties.Settings.Default.BeautySaloonConnectionString);
            SqlCommand command = connection.CreateCommand();
            command.CommandText = sqlSelect;
            command.Parameters.AddWithValue("@last_name", textBoxWorker.Text +"%");
            if (checkBoxMore.Checked)
                try
                {
                    command.Parameters.Add("@amount", SqlDbType.Money).Value =
                    Double.Parse(textBoxMore.Text);
                }
                catch
                {
                    MessageBox.Show("Прибыль в условии должна быть задана числом", "ошибка", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    checkBoxMore.Checked = false;
                    return;
                }
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridViewFSelect.DataSource = table;
            if (table.Rows.Count == 0) MessageBox.Show("Нет значений!",
            "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void radioButtonDet_NO_Click(object sender, EventArgs e)
        {
            textBoxWorker.Enabled = false;
            checkBoxMore.Enabled = true;
            textBoxMore.Enabled = true;
            checkBoxOrder.Enabled = true;
        }

        private void radioButtonDet_Services_CheckedChanged(object sender, EventArgs e)
        {
            textBoxWorker.Enabled = true;
            checkBoxMore.Enabled = false;
            textBoxMore.Enabled = false;
            checkBoxOrder.Enabled = false;
        }

        private void radioButtonDet_Type_Click(object sender, EventArgs e)
        {
            textBoxWorker.Enabled = true;
            checkBoxMore.Enabled = true;
            textBoxMore.Enabled = true;
            checkBoxOrder.Enabled = true;
        }

        private void buttonSubquery_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxNumber.Text))
            {
                MessageBox.Show("Обязательно укажите номер необходимой продажи",
                "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string sqlSelect = "";
            if (radioButtonCorrelated.Checked)

                sqlSelect = "SELECT Заказ.Серийный_номер_товара, Заказ.ID_заказа, " +
                    "Заказ.Код_сотрудника\r\nFROM Заказ\r\nWHERE 'Мужской' " +
                    "IN (SELECT Персонал.Пол FROM Персонал WHERE " +
                    "Заказ.Код_сотрудника=Персонал.Код_сотрудника) " +
                    "AND Заказ.Серийный_номер_товара = @number";

            else if (radioButtonNoCorrelated.Checked)
                sqlSelect = "SELECT Заказ.Серийный_номер_товара, Заказ.ID_заказа, " +
                    "Заказ.Код_сотрудника\r\n" +
                    "FROM Заказ\r\nWHERE Заказ.Серийный_номер_товара = @number " +
                    "AND Заказ.Код_сотрудника " +
                    "IN (SELECT Код_сотрудника FROM Персонал WHERE Персонал.Пол='Мужской') ";
            else
            {
                MessageBox.Show("Не выбрали вид подзапроса", "Ошибка", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            SqlConnection connection = new 
                SqlConnection(Properties.Settings.Default.BeautySaloonConnectionString);
            SqlCommand command = connection.CreateCommand();
            command.CommandText = sqlSelect;
            try
            {
                command.Parameters.Add("@number", SqlDbType.Int).Value =
                int.Parse(textBoxNumber.Text);
            }
            catch
            {
                MessageBox.Show("Номер продажи в условии должен быть задан числом", "Ошибка", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
            }
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridViewSubquery.DataSource = table;
            if (table.Rows.Count == 0) MessageBox.Show("Нет значений!",
            "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        string fileImage = "";

        private void buttonOpenPhoto_Click(object sender, EventArgs e)
        {
            openFileDialogPhoto.Title = "Укажите файл для фото";
            if (openFileDialogPhoto.ShowDialog() == DialogResult.OK)
            {
                fileImage = openFileDialogPhoto.FileName;
                try
                {
                    фотоPictureBox.Image = new
                    Bitmap(openFileDialogPhoto.FileName);
                }
                catch
                {
                    MessageBox.Show("Выбран не тот формат файла", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else fileImage = "";
        }

        void InsertGood()
        {
            if (String.IsNullOrEmpty(textBoxId_Product.Text) || 
                (String.IsNullOrEmpty(textBoxName_Product.Text)
            || (String.IsNullOrEmpty(textBoxPrice_Product.Text))))
            {
                MessageBox.Show("Обязательно введите серийный номер товара, " +
                    "его наименование и стоимость", "Внимание",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int id;
            if (!int.TryParse(textBoxId_Product.Text, out id))
            {
                MessageBox.Show("Некоректное значение серийного номера товара!", 
                    "Внимание",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            double price = 0; /*возможно сменить тип переменной*/
            if (!double.TryParse(textBoxPrice_Product.Text, out price))
            {
                MessageBox.Show("Некоректное значение стоимость!", "Внимание",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string sqlInsert = @"INSERT INTO Товар (Серийный_номер_товара, Наименование, 
            Стоимость, Срок_годности_товара, Состав, Фото)
            VALUES (@id, @Name, @Price, @ExpirationDate, @Sostav, @Photo)";
            SqlConnection connection = 
                new SqlConnection(Properties.Settings.Default.BeautySaloonConnectionString);
            connection.Open();
            SqlCommand command = connection.CreateCommand();
            command.CommandText = sqlInsert;

            command.Parameters.AddWithValue("@id", id);
            command.Parameters.AddWithValue("@Name", textBoxName_Product.Text);         
            command.Parameters.AddWithValue("@Price", price);
            command.Parameters.AddWithValue("@ExpirationDate", 
                DateTimePickerExpirationDate.Value.Date);
            command.Parameters.AddWithValue("@Sostav", textBoxIng_good.Text);

            if (!String.IsNullOrEmpty(fileImage))
                command.Parameters.AddWithValue("@Photo", 
                    File.ReadAllBytes(fileImage));
            else
            {
                command.Parameters.Add("@Photo", SqlDbType.VarBinary);
                command.Parameters["@Photo"].Value = DBNull.Value;
            }

            try
            {
                command.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                MessageBox.Show("Ошибка выполнения запроса.\n" + err.Message,
                "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            connection.Close();
            buttonSelectGoods_Click(this, EventArgs.Empty);
        }

        void UpdateGood()
        {
            if (String.IsNullOrEmpty(textBoxId_Product.Text))
            {
                MessageBox.Show("Обязательно укажите серийный номер товара, " +
                    "для будете менять данные", 
                    "Внимание", MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }

            int id;
            if (!int.TryParse(textBoxId_Product.Text, out id))
            {
                MessageBox.Show("Некоректное значение серийного номера товара!", 
                    "Внимание", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            double price = 0;
            if ((!String.IsNullOrEmpty(textBoxPrice_Product.Text)) &&
            (!double.TryParse(textBoxPrice_Product.Text, out price)))
            {
                MessageBox.Show("Некоректное значение цены!", "Внимание",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string sqlUpdate = "UPDATE Товар SET Наименование=@Name, Стоимость=@Price, " +
                "Срок_годности_товара=@ExpirationDate,Состав=@Sostav ," +
                "Фото=@Photo WHERE Серийный_номер_товара=@Id_good";
            SqlConnection connection = new 
                SqlConnection(Properties.Settings.Default.BeautySaloonConnectionString);
            connection.Open();
            SqlCommand command = connection.CreateCommand();
            string sqlValues = "";

            command.CommandText = String.Format(sqlUpdate, sqlValues);

            command.Parameters.AddWithValue("@Id_good", id);
            command.Parameters.AddWithValue("@Name", textBoxName_Product.Text);
            command.Parameters.AddWithValue("@Price", price);
            command.Parameters.AddWithValue("@ExpirationDate", 
                DateTimePickerExpirationDate.Value.Date);
            command.Parameters.AddWithValue("@Sostav", textBoxIng_good.Text);
            command.Parameters.AddWithValue("@Photo", File.ReadAllBytes(fileImage));
            
            try
            {
                command.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                MessageBox.Show("Ошибка выполнения запроса:\n" + err.Message,
                "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            connection.Close();
            buttonSelectGoods_Click(this, EventArgs.Empty);
        }

        void DeleteGood()
        {
            if (String.IsNullOrEmpty(textBoxId_Product.Text))
            {
                MessageBox.Show("Обязательно укажите серийный номер товара, " +
                    "данные которого необходимо удалить",
                    "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int id;
            if (!int.TryParse(textBoxId_Product.Text, out id))
            {
                MessageBox.Show("Некоректное значение серийного номера товара!", 
                    "Внимание",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string sqlDelete = @"DELETE FROM Товар WHERE Серийный_номер_товара=@Id_good"; 
            SqlConnection connection = new 
                SqlConnection(Properties.Settings.Default.BeautySaloonConnectionString);
            connection.Open();
            SqlCommand command = connection.CreateCommand();
            command.CommandText = sqlDelete;
            command.Parameters.AddWithValue("@Id_good", id);

            try
            {
                command.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Ошибка удаления");
            }
            connection.Close();
            buttonSelectGoods_Click(this, EventArgs.Empty);
        }

        private void buttonSelectGoods_Click(object sender, EventArgs e)
        {
            dataGridViewGood.DataSource = FillDataGridView("SELECT * FROM Товар");
            DataGridViewImageColumn column = 
                (DataGridViewImageColumn)dataGridViewGood.Columns["Фото"];
            column.ImageLayout = DataGridViewImageCellLayout.Stretch;
        }
         
        private void radioButtonDelete_Good_CheckedChanged(object sender, EventArgs e)
        {
            panelGood.Visible = !radioButtonDelete_Good.Checked;
        }

        private void buttonExecuteDML_Click(object sender, EventArgs e)
        {
            if (radioButtonInsert_Good.Checked) InsertGood();
            else
                if (radioButtonUpdate_Good.Checked) UpdateGood();
            else
                if (radioButtonDelete_Good.Checked) DeleteGood();
            else
                MessageBox.Show("Вы не выбрали действие", "Внимание",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }     
}
