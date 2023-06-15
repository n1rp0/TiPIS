using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BD_BeautySaloon
{
    public partial class FormOrders : Form
    {
        public FormOrders()
        {
            InitializeComponent();
        }

        private void товарBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.товарBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.beautySaloonDataSet);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Ошибка", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
        }

        private void FormOrders_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "beautySaloonDataSet.Клиент". При необходимости она может быть перемещена или удалена.
            this.клиентTableAdapter.Fill(this.beautySaloonDataSet.Клиент);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "beautySaloonDataSet.Персонал". При необходимости она может быть перемещена или удалена.
            this.персоналTableAdapter.Fill(this.beautySaloonDataSet.Персонал);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "beautySaloonDataSet.Заказ". При необходимости она может быть перемещена или удалена.
            this.заказTableAdapter.Fill(this.beautySaloonDataSet.Заказ);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "beautySaloonDataSet.Товар". При необходимости она может быть перемещена или удалена.
            this.товарTableAdapter.Fill(this.beautySaloonDataSet.Товар);

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

        private void заказыBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.заказBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.beautySaloonDataSet);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Ошибка", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
        }

        private static FormOrders f;

        public static FormOrders fs
        {
            get
            {
                if (f == null || f.IsDisposed) f = new FormOrders();
                return f;
            }
        }

        public void ShowForm()
        {
            Show();
            Activate();
        }

        private void buttonWorker_Click(object sender, EventArgs e)
        {
            int id = -1;
            if (((DataRowView)заказBindingSource.Current)["Код_сотрудника"].ToString() != "")
            {
                object idd = (((DataRowView)заказBindingSource.Current)["Код_сотрудника"]);
                id = Convert.ToInt32(idd.ToString());
            }
            id = FormPersonal.fs.ShowSelectForm(id);
            if (id >= 0)
            {
                MessageBox.Show(id.ToString(), "Вы выбрали сотрудника с кодом:");
                ((DataRowView)заказBindingSource.Current)["Код_сотрудника"] = id;
                заказBindingSource.EndEdit();
                персоналTableAdapter.Fill(this.beautySaloonDataSet.Персонал);
            }
        }

        private void buttonClient_Click(object sender, EventArgs e)
        {
            int id = -1;
            if (((DataRowView)заказBindingSource.Current)["Код_клиента"].ToString() != "")
            {
                object idd = (((DataRowView)заказBindingSource.Current)["Код_клиента"]);
                id = Convert.ToInt32(idd.ToString());
            }
            id = FormClients.fs.ShowSelectForm(id);
            if (id >= 0)
            {
                MessageBox.Show(id.ToString(), "Вы выбрали клиента с кодом:");
                ((DataRowView)заказBindingSource.Current)["Код_клиента"] = id;
                заказBindingSource.EndEdit();
                клиентTableAdapter.Fill(this.beautySaloonDataSet.Клиент);
            }
        }
    }
}
