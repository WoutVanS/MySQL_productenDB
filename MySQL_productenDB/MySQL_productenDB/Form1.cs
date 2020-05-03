using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Configuration;

namespace MySQL_productenDB
{
    public partial class Form1 : Form
    {
        static MySqlConnection databaseConntecion = null;
        static MySqlDataReader msqlReader = null;
        static MySqlCommand MySqlComm = null;

        string ReadOrdersCommand = "select  orderID, bestelDatum, klanten.klantID, klanten.klantNaam, producten.productID, producten.productNaam, bestelhoeveelheid, afgehandeld from orders inner join klanten on(klanten.klantID = orders.klantID) inner join producten on(producten.productID = orders.productID)";
        string searchOrderID = "select orderID, bestelDatum, klanten.klantID, klanten.klantNaam, producten.productID, producten.productNaam, bestelhoeveelheid, afgehandeld from orders inner join klanten on(klanten.klantID = orders.klantID) inner join producten on(producten.productID = orders.productID) where orderID =";
        public Form1()
        {
            InitializeComponent();
            string connectionString = ConfigurationManager.ConnectionStrings["MySQLConnection"].ConnectionString;
            databaseConntecion = new MySqlConnection(connectionString);
        }

        private void openMySQL_server_Click(object sender, EventArgs e)
        {
            try
            {
                databaseConntecion.Open();
                MessageBox.Show("connecting to server successful", "", MessageBoxButtons.OK);
            }
            catch (MySqlException error)
            {
                MessageBox.Show(error.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void closeMySQL_server_Click(object sender, EventArgs e)
        {
            try
            {
                databaseConntecion.Close();
            }
            catch (MySqlException error)
            {
                MessageBox.Show(error.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void uitlezenTabel_Click(object sender, EventArgs e)
        {
            try
            {
                using (databaseConntecion)
                {
                    databaseConntecion.Open();

                    if (databaseConntecion.State == ConnectionState.Open)
                    {
                        MySqlComm = new MySqlCommand();
                        MySqlComm.Connection = databaseConntecion;
                        MySqlComm.CommandText = ReadOrdersCommand;
                        MySqlComm.CommandType = CommandType.Text;

                        using (msqlReader = MySqlComm.ExecuteReader())
                        {
                            dataGridOrders.Visible = true;
                            groupBoxOrders.Visible = false;
                            dataGridOrders.Rows.Clear();
                            while (msqlReader.Read())
                            {
                                dataGridOrders.Rows.Add();

                                for (int i = 0; i < msqlReader.FieldCount; i++)
                                {
                                    dataGridOrders[i, dataGridOrders.RowCount - 1].Value = msqlReader[i];
                                }
                            }
                            dataGridOrders.AutoResizeRows();
                            dataGridOrders.AutoResizeColumns();
                            dataGridOrders.AutoSize = true;
                            this.AutoSize = true;

                            Size form = this.Size;
                            uitlezen.Size = form;
                            orderZoeken.Visible = false;
                            opnieuwZoeken.Visible = true;

                        }

                    }


                    databaseConntecion.Close();
                }
            }
            catch (MySqlException error)
            {
                MessageBox.Show(error.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TabelProductenUitlezen()
        {
            try
            {
                using (databaseConntecion)
                {
                    databaseConntecion.Open();

                    if (databaseConntecion.State == ConnectionState.Open)
                    {
                        MySqlComm = new MySqlCommand();
                        MySqlComm.Connection = databaseConntecion;
                        MySqlComm.CommandText = "select * from producten;";
                        MySqlComm.CommandType = CommandType.Text;

                        using (msqlReader = MySqlComm.ExecuteReader())
                        {
                            dataGridProducten.Visible = true;
                            dataGridProducten.Rows.Clear();
                            while (msqlReader.Read())
                            {
                                dataGridProducten.Rows.Add();

                                for (int i = 0; i < msqlReader.FieldCount; i++)
                                {
                                    dataGridProducten[i, dataGridProducten.RowCount - 1].Value = msqlReader[i];
                                }
                            }
                            dataGridProducten.AutoResizeRows();
                            dataGridProducten.AutoResizeColumns();
                            dataGridProducten.AutoSize = true;
                            this.AutoSize = true;

                            Size form = this.Size;
                            beheerProducten.Size = form;

                        }

                    }


                    databaseConntecion.Close();
                }
            }
            catch (MySqlException error)
            {
                MessageBox.Show(error.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
 
        private void productenTabel_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {



        }

        private void orderZoeken_Click(object sender, EventArgs e)
        {
            try
            {
                using (databaseConntecion)
                {
                    databaseConntecion.Open();

                    
                    if (databaseConntecion.State == ConnectionState.Open)
                        {
                        MySqlComm = new MySqlCommand();
                        MySqlComm.Connection = databaseConntecion;
                        MySqlComm.Parameters.AddWithValue("@orderID", orderIDText.Text);
                        MySqlComm.CommandText = (searchOrderID + "@orderID;");
                        MySqlComm.CommandType = CommandType.Text;

                        using (msqlReader = MySqlComm.ExecuteReader())
                        {
                            dataGridOrders.Visible = true;
                            groupBoxOrders.Visible = false;
                            dataGridOrders.Rows.Clear();
                            while (msqlReader.Read())
                            {
                                dataGridOrders.Rows.Add();

                                for (int i = 0; i < msqlReader.FieldCount; i++)
                                {
                                    dataGridOrders[i, dataGridOrders.RowCount - 1].Value = msqlReader[i];
                                }
                            }
                            dataGridOrders.AutoResizeRows();
                            dataGridOrders.AutoResizeColumns();
                            dataGridOrders.AutoSize = true;
                            this.AutoSize = true;

                            Size form = this.Size;
                            uitlezen.Size = form;
                            orderZoeken.Visible = false;
                            opnieuwZoeken.Visible = true;

                        }

                    }


                    databaseConntecion.Close();
                }

            }
            catch (MySqlException error)
            {
                MessageBox.Show(error.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void opnieuwZoeken_Click(object sender, EventArgs e)
        {
            orderZoeken.Visible = true;
            opnieuwZoeken.Visible = false;
            dataGridOrders.Visible = false;
            groupBoxOrders.Visible = true;
        }

        private void productToevoegenButtom_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBoxProductNaam.Text) || !string.IsNullOrWhiteSpace(textBoxProductStock.Text))
            {
                try
                {
                    using (databaseConntecion)
                    {
                        databaseConntecion.Open();


                        if (databaseConntecion.State == ConnectionState.Open)
                        {
                            MySqlComm = new MySqlCommand();
                            MySqlComm.Connection = databaseConntecion;
                            MySqlComm.Parameters.AddWithValue("@productNaam", textBoxProductNaam.Text);
                            MySqlComm.Parameters.AddWithValue("@productStock", textBoxProductStock.Text);

                            if (beschikbaar.Checked)
                                MySqlComm.Parameters.AddWithValue("@beschikbaar", "1");
                            else
                                MySqlComm.Parameters.AddWithValue("@beschikbaar", "0");

                            MySqlComm.CommandText = ("insert into producten(productNaam, productStock, beschikbaar) values (" + "@productNaam" + "," + "@productStock" + "," + "@beschikbaar" + ");");
                            MySqlComm.CommandType = CommandType.Text;
                            MySqlComm.ExecuteNonQuery();
                            MessageBox.Show("complete", "x", MessageBoxButtons.OK);

                        }


                        databaseConntecion.Close();
                    }
                }
                catch (MySqlException error)
                {
                    MessageBox.Show(error.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
                MessageBox.Show("gelieve naam of stock hoeveelheid in te geven", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void textBoxProductStock_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void ButtonUitlezenProducten_Click(object sender, EventArgs e)
        {
            TabelProductenUitlezen();
        }

        private void buttonVerwijderProduct_Click(object sender, EventArgs e)
        {
            int row = dataGridProducten.SelectedCells[0].RowIndex;
            string ID = dataGridProducten[0, row].Value.ToString();
            if (MessageBox.Show("bent u zeker dat u het product met ID " + ID + " wilt verwijderen?", "warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    using (databaseConntecion)
                    {
                        databaseConntecion.Open();


                        if (databaseConntecion.State == ConnectionState.Open)
                        {
                            MySqlComm = new MySqlCommand();
                            MySqlComm.Connection = databaseConntecion;

                            MySqlComm.CommandText = ("delete from producten where productID = " + ID +";");
                            MySqlComm.CommandType = CommandType.Text;
                            MySqlComm.ExecuteNonQuery();
                            MessageBox.Show("product verwijderd", "", MessageBoxButtons.OK);
                            
                        }


                        databaseConntecion.Close();
                        TabelProductenUitlezen();
                    }
                }
                catch (MySqlException error)
                {
                    MessageBox.Show(error.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dataGridProducten_SelectionChanged(object sender, EventArgs e)
        {
            buttonVerwijderProduct.Enabled = true;
        }
    }
}
