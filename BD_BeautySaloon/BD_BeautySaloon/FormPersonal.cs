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
    public partial class FormPersonal : Form
    {
        public FormPersonal()
        {
            InitializeComponent();
        }

        private void персоналBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.персоналBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.beautySaloonDataSet);
        }

        private void FormPersonal_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "beautySaloonDataSet.Персонал". При необходимости она может быть перемещена или удалена.
            this.персоналTableAdapter.Fill(this.beautySaloonDataSet.Персонал);

        }

        private static FormPersonal f;

        public static FormPersonal fs
        {
            get
            {
                if (f == null || f.IsDisposed) f = new FormPersonal();
                return f;
            }
        }

        public void ShowForm()
        {
            toolStripButtonOK.Visible = false;
            персоналBindingSource.Position = 0;
            Show();
            Activate();
        }

        private void персоналDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if ((персоналDataGridView.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumnPol"].Value == null) ||
                (персоналDataGridView.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumnPol"].Value.ToString() 
                == ""))e.CellStyle.BackColor = Color.LightGreen;
            else
            {
                if
                (персоналDataGridView.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumnPol"].Value.ToString() 
                == "Мужской")
                    e.CellStyle.BackColor = Color.SkyBlue;
                else
                    e.CellStyle.BackColor = Color.Pink;
            }
        }

        string GetSelectedFieldName()
        {
            return
            персоналDataGridView.Columns[персоналDataGridView.CurrentCell.ColumnIndex].DataPropertyName;
        }

        private void toolStripButtonFind_Click(object sender, EventArgs e)
        {
            if (toolStripTextBoxFind.Text == "")
            {
                MessageBox.Show("Вы ничего не задали", "Внимание",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            int indexPos;
            try
            {
                indexPos =
                персоналBindingSource.Find(GetSelectedFieldName(),
                toolStripTextBoxFind.Text);
            }
            catch (Exception err)
            {
                MessageBox.Show("Ошибка поиска \n" + err.Message);
                return;
            }
            if (indexPos > -1)
                персоналBindingSource.Position = indexPos;
            else
            {
                MessageBox.Show("Таких сотрудников нет", "Внимание",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                персоналBindingSource.Position = 0;
            }
        }

        private void checkBoxFind_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxFind.Checked)
            {
                if (toolStripTextBoxFind.Text == "")
                    MessageBox.Show("Вы ничего не задали", "Внимание",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    try
                    {
                        персоналBindingSource.Filter =
                        GetSelectedFieldName() + "='" + toolStripTextBoxFind.Text + "'";
                    }
                    catch (Exception err)
                    {
                        MessageBox.Show("Ошибка фильтрации \n" +
                        err.Message);
                    }
            }
            else
                персоналBindingSource.Filter = "";
            if (персоналBindingSource.Count == 0)
            {
                MessageBox.Show("Нет таких");
                персоналBindingSource.Filter = "";
                checkBoxFind.Checked = false;
            }
        }

        private void toolStripButtonOK_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        int idCurrent = -1;

        public int ShowSelectForm(int id)
        {
            toolStripButtonOK.Visible = true;
            idCurrent = id;
            if (ShowDialog() == DialogResult.OK)
                return
                (int)((DataRowView)персоналBindingSource.Current)["Код_сотрудника"];
            else
                return -1;
        }

        private void FormPersonal_Shown(object sender, EventArgs e)
        {
            персоналBindingSource.Position = персоналBindingSource.Find("Код_сотрудника", idCurrent);
        }
    }
}
