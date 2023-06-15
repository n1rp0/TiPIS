using BD_BeautySaloon.Properties;
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
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = MessageBox.Show("Вы хотите закрыть программу?",
            "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Question) !=
            DialogResult.Yes;
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("©ТУСУР, ФВС, Коблов Артем Николаевич, гр.520, 2023", "О программе",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Settings.Default.Save();
        }

        private void клиентыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormClients.fs.ShowForm();
        }

        private void сотрудникиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPersonal.fs.ShowForm();
        }

        private void товарыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormGoods.fs.ShowForm();
        }

        private void услугиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormServices.fs.ShowForm();
        }

        private void оказаниеУслугиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormRendering.fs.ShowForm();
        }

        private void заказыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormOrders.fs.ShowForm();
        }

        private void запросыSQLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSQL.fs.ShowForm();
        }
    }
}
