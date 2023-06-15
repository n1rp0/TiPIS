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
    public partial class FormRendering : Form
    {
        public FormRendering()
        {
            InitializeComponent();
        }

        private void услугаBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.услугаBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.beautySaloonDataSet);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Ошибка", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }

        }

        private void FormRendering_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "beautySaloonDataSet.Клиент". При необходимости она может быть перемещена или удалена.
            this.клиентTableAdapter.Fill(this.beautySaloonDataSet.Клиент);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "beautySaloonDataSet.Персонал". При необходимости она может быть перемещена или удалена.
            this.персоналTableAdapter.Fill(this.beautySaloonDataSet.Персонал);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "beautySaloonDataSet.ЗаписьОбУслуге". При необходимости она может быть перемещена или удалена.
            this.записьОбУслугеTableAdapter.Fill(this.beautySaloonDataSet.ЗаписьОбУслуге);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "beautySaloonDataSet.Услуга". При необходимости она может быть перемещена или удалена.
            this.услугаTableAdapter.Fill(this.beautySaloonDataSet.Услуга);
            beautySaloonDataSet.ЗаписьОбУслуге.Columns["Дата_и_время"].DefaultValue = DateTime.Now;
        }

        private void записьОбУслугеBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.записьОбУслугеBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.beautySaloonDataSet);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Ошибка", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
        }

        private static FormRendering f;

        public static FormRendering fs
        {
            get
            {
                if (f == null || f.IsDisposed) f = new FormRendering();
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
            if (((DataRowView)записьОбУслугеBindingSource.Current)["Код_сотрудника"].ToString() != "")
            {
                object idd = (((DataRowView)записьОбУслугеBindingSource.Current)["Код_сотрудника"]);
                id = Convert.ToInt32(idd.ToString());
            }
            id = FormPersonal.fs.ShowSelectForm(id);
            if (id >= 0)
            {
                MessageBox.Show(id.ToString(), "Вы выбрали сотрудника с кодом:");
                ((DataRowView)записьОбУслугеBindingSource.Current)["Код_сотрудника"] = id;
                записьОбУслугеBindingSource.EndEdit();
                персоналTableAdapter.Fill(this.beautySaloonDataSet.Персонал);
            }
        }

        private void buttonClient_Click(object sender, EventArgs e)
        {
            int id = -1;
            if (((DataRowView)записьОбУслугеBindingSource.Current)["Код_клиента"].ToString() != "")
            {
                object idd = (((DataRowView)записьОбУслугеBindingSource.Current)["Код_клиента"]);
                id = Convert.ToInt32(idd.ToString());
            }
            id = FormClients.fs.ShowSelectForm(id);
            if (id >= 0)
            {
                MessageBox.Show(id.ToString(), "Вы выбрали клиента с кодом:");
                ((DataRowView)записьОбУслугеBindingSource.Current)["Код_клиента"] = id;
                записьОбУслугеBindingSource.EndEdit();
                клиентTableAdapter.Fill(this.beautySaloonDataSet.Клиент);
            }
        }
    }
}
