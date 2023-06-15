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
    public partial class FormServices : Form
    {
        public FormServices()
        {
            InitializeComponent();
        }

        private void услугаBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.услугаBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.beautySaloonDataSet);

        }

        private void услугаBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.услугаBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.beautySaloonDataSet);

        }

        private void FormServices_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "beautySaloonDataSet.Услуга". При необходимости она может быть перемещена или удалена.
            this.услугаTableAdapter.Fill(this.beautySaloonDataSet.Услуга);

        }

        private static FormServices f;

        public static FormServices fs
        {
            get
            {
                if (f == null || f.IsDisposed) f = new FormServices();
                return f;
            }
        }

        public void ShowForm()
        {
            Show();
            Activate();
        }
    }
}
