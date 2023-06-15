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
    public partial class FormGoods : Form
    {
        public FormGoods()
        {
            InitializeComponent();
        }

        private void товарBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.товарBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.beautySaloonDataSet);

        }

        private void FormGoods_Load(object sender, EventArgs e)
        {
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

        private static FormGoods f;

        public static FormGoods fs
        {
            get
            {
                if (f == null || f.IsDisposed) f = new FormGoods();
                return f;
            }
        }

        public void ShowForm()
        {
            Show();
            Activate();
        }

        private void фотоPictureBox_Click(object sender, EventArgs e)
        {

        }

        private void фотоLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
