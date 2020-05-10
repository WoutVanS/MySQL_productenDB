using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MySQL_productenDB
{
    public partial class Form_orderBestellen : Form
    {

        public delegate void BestelOrder(string klant, string product, int hoeveelheid);
        public event BestelOrder bestellen;
        mainForm parent = new mainForm();
        public Form_orderBestellen()
        {
            InitializeComponent();
        }

        public void receive_ProductenComboBox(List<string> producten, List<string> klanten, mainForm main)
        {
            foreach (string product in producten)
            {
                comboBoxProducten.Items.Add(product);
            }

            foreach (string klant in klanten)
            {
                comboBoxKlanten.Items.Add(klant);
            }

            parent = main;
        }

        private void textBoxHoeveelheid_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);         
        }

        private void buttonBestel_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxHoeveelheid.Text) || Convert.ToInt32(textBoxHoeveelheid.Text.ToString()) == 0 || comboBoxProducten.SelectedItem == null)
                MessageBox.Show("kan niet nul items bestellen", "fout", MessageBoxButtons.OK);
            else if( comboBoxKlanten.SelectedItem == null)    
                MessageBox.Show("kan niet geen naam hebben ", "fout", MessageBoxButtons.OK);
            else
            {
                string klant = comboBoxKlanten.SelectedItem.ToString();
                string product = comboBoxProducten.SelectedItem.ToString();
                int hoeveelheid = Convert.ToInt32(textBoxHoeveelheid.Text);

                bestellen += parent.order_bestellen;
                bestellen(klant, product, hoeveelheid);
                this.Close();
            }
                
        }
    }
}
