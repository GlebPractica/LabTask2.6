using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Task1.Forms;

namespace Task1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private async Task ShowForm(Button bttn, Form forma)
        {
            try
            {
                bttn.Enabled = false;

                forma.FormClosed += (sender, args) =>
                {
                    if (bttn.InvokeRequired)
                        bttn.Invoke(new MethodInvoker(() => bttn.Enabled = true));
                    else
                        bttn.Enabled = false;
                };

                await Task.Run(() =>
                {
                    forma.ShowDialog();
                    forma.Dispose();
                });
            }
            finally
            {
                if (forma != null)
                {
                    forma.Close();
                    forma.Dispose();
                    bttn.Enabled = true;
                }
            }
        }

        private async void BttnShowProducts_Click(object sender, EventArgs e)
        {
            await ShowForm(BttnShowProducts, new WorkWithShop());
        }

        private async void BttnShowCart_Click(object sender, EventArgs e)
        {
            await ShowForm(BttnShowCart, new WorkWithCart());
        }
    }
}
