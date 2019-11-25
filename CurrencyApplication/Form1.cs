using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CurrencyApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmbCurrencies_SelectedIndexChanged(object sender, EventArgs e)
        {
            int k = 0;
            lstCurrencies.Items.Clear();
            foreach (var item in Currency.Convert(decimal.Parse(txtInputValue.Text),cmbCurrencies.Text))
            {
                ListViewItem viewItem = new ListViewItem(item.Key);
                ListViewItem.ListViewSubItem listViewSubItem = new ListViewItem.ListViewSubItem();
                listViewSubItem.Text =$"{ item.Value:0.##}";
                viewItem.BackColor = (k % 2 == 0) ? Color.LightCoral : Color.Cyan;
                viewItem.SubItems.Add(listViewSubItem);
                lstCurrencies.Items.Add(viewItem);
                k++;
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (var item in Currency.currencies)
            {
                cmbCurrencies.Items.Add(item.Key);
            }
        }
    }
}
