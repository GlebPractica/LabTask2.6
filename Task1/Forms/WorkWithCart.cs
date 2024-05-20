using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task1.Forms
{
    public partial class WorkWithCart : Form
    {
        public WorkWithCart()
        {
            InitializeComponent();
        }

        private void cartBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.cartBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.shopDataSet);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void WorkWithCart_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "shopDataSet.Cart". При необходимости она может быть перемещена или удалена.
            this.cartTableAdapter.Fill(this.shopDataSet.Cart);

        }
    }
}
