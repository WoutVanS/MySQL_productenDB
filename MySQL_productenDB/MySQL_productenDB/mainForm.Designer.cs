namespace MySQL_productenDB
{
    partial class mainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.openMySQL_server = new System.Windows.Forms.Button();
            this.closeMySQL_server = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.verbindingTesten = new System.Windows.Forms.TabPage();
            this.uitlezen = new System.Windows.Forms.TabPage();
            this.opnieuwZoeken = new System.Windows.Forms.Button();
            this.groupBoxOrders = new System.Windows.Forms.GroupBox();
            this.orderIDText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.orderZoeken = new System.Windows.Forms.Button();
            this.dataGridOrders = new System.Windows.Forms.DataGridView();
            this.orderID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bestelDatum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.klantID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.klantNaam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productNaam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bestelhoeveelheid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.afgehandeld = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uitlezenTabel = new System.Windows.Forms.Button();
            this.productToevoegen = new System.Windows.Forms.TabPage();
            this.groepPProductToevoegen = new System.Windows.Forms.GroupBox();
            this.productToevoegenButtom = new System.Windows.Forms.Button();
            this.beschikbaar = new System.Windows.Forms.CheckBox();
            this.textBoxProductStock = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxProductNaam = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.beheerProducten = new System.Windows.Forms.TabPage();
            this.buttonVerwijderProduct = new System.Windows.Forms.Button();
            this.ButtonUitlezenProducten = new System.Windows.Forms.Button();
            this.dataGridProducten = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.buttonOrder = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.verbindingTesten.SuspendLayout();
            this.uitlezen.SuspendLayout();
            this.groupBoxOrders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridOrders)).BeginInit();
            this.productToevoegen.SuspendLayout();
            this.groepPProductToevoegen.SuspendLayout();
            this.beheerProducten.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProducten)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // openMySQL_server
            // 
            this.openMySQL_server.Location = new System.Drawing.Point(14, 51);
            this.openMySQL_server.Margin = new System.Windows.Forms.Padding(4);
            this.openMySQL_server.Name = "openMySQL_server";
            this.openMySQL_server.Size = new System.Drawing.Size(247, 61);
            this.openMySQL_server.TabIndex = 0;
            this.openMySQL_server.Text = "open";
            this.openMySQL_server.UseVisualStyleBackColor = true;
            this.openMySQL_server.Click += new System.EventHandler(this.openMySQL_server_Click);
            // 
            // closeMySQL_server
            // 
            this.closeMySQL_server.Location = new System.Drawing.Point(14, 120);
            this.closeMySQL_server.Margin = new System.Windows.Forms.Padding(4);
            this.closeMySQL_server.Name = "closeMySQL_server";
            this.closeMySQL_server.Size = new System.Drawing.Size(247, 61);
            this.closeMySQL_server.TabIndex = 1;
            this.closeMySQL_server.Text = "close";
            this.closeMySQL_server.UseVisualStyleBackColor = true;
            this.closeMySQL_server.Click += new System.EventHandler(this.closeMySQL_server_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.verbindingTesten);
            this.tabControl1.Controls.Add(this.uitlezen);
            this.tabControl1.Controls.Add(this.productToevoegen);
            this.tabControl1.Controls.Add(this.beheerProducten);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(-5, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1091, 577);
            this.tabControl1.TabIndex = 2;
            // 
            // verbindingTesten
            // 
            this.verbindingTesten.Controls.Add(this.openMySQL_server);
            this.verbindingTesten.Controls.Add(this.closeMySQL_server);
            this.verbindingTesten.Location = new System.Drawing.Point(4, 25);
            this.verbindingTesten.Margin = new System.Windows.Forms.Padding(4);
            this.verbindingTesten.Name = "verbindingTesten";
            this.verbindingTesten.Padding = new System.Windows.Forms.Padding(4);
            this.verbindingTesten.Size = new System.Drawing.Size(1083, 548);
            this.verbindingTesten.TabIndex = 0;
            this.verbindingTesten.Text = "verbinding testen";
            this.verbindingTesten.UseVisualStyleBackColor = true;
            // 
            // uitlezen
            // 
            this.uitlezen.CausesValidation = false;
            this.uitlezen.Controls.Add(this.opnieuwZoeken);
            this.uitlezen.Controls.Add(this.groupBoxOrders);
            this.uitlezen.Controls.Add(this.orderZoeken);
            this.uitlezen.Controls.Add(this.dataGridOrders);
            this.uitlezen.Controls.Add(this.uitlezenTabel);
            this.uitlezen.Location = new System.Drawing.Point(4, 25);
            this.uitlezen.Margin = new System.Windows.Forms.Padding(0);
            this.uitlezen.Name = "uitlezen";
            this.uitlezen.Size = new System.Drawing.Size(1083, 548);
            this.uitlezen.TabIndex = 1;
            this.uitlezen.Text = "uitlezen tabel orders";
            this.uitlezen.UseVisualStyleBackColor = true;
            // 
            // opnieuwZoeken
            // 
            this.opnieuwZoeken.AutoSize = true;
            this.opnieuwZoeken.BackColor = System.Drawing.Color.Transparent;
            this.opnieuwZoeken.Location = new System.Drawing.Point(522, 455);
            this.opnieuwZoeken.Margin = new System.Windows.Forms.Padding(0);
            this.opnieuwZoeken.Name = "opnieuwZoeken";
            this.opnieuwZoeken.Size = new System.Drawing.Size(224, 65);
            this.opnieuwZoeken.TabIndex = 4;
            this.opnieuwZoeken.Text = "opnieuw zoeken";
            this.opnieuwZoeken.UseVisualStyleBackColor = false;
            this.opnieuwZoeken.Visible = false;
            this.opnieuwZoeken.Click += new System.EventHandler(this.opnieuwZoeken_Click);
            // 
            // groupBoxOrders
            // 
            this.groupBoxOrders.BackColor = System.Drawing.SystemColors.Control;
            this.groupBoxOrders.Controls.Add(this.orderIDText);
            this.groupBoxOrders.Controls.Add(this.label1);
            this.groupBoxOrders.Location = new System.Drawing.Point(352, 121);
            this.groupBoxOrders.Name = "groupBoxOrders";
            this.groupBoxOrders.Size = new System.Drawing.Size(302, 189);
            this.groupBoxOrders.TabIndex = 3;
            this.groupBoxOrders.TabStop = false;
            this.groupBoxOrders.Text = "order controle";
            // 
            // orderIDText
            // 
            this.orderIDText.Location = new System.Drawing.Point(23, 79);
            this.orderIDText.Name = "orderIDText";
            this.orderIDText.Size = new System.Drawing.Size(257, 22);
            this.orderIDText.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "orderID";
            // 
            // orderZoeken
            // 
            this.orderZoeken.AutoSize = true;
            this.orderZoeken.BackColor = System.Drawing.Color.Transparent;
            this.orderZoeken.Location = new System.Drawing.Point(522, 455);
            this.orderZoeken.Margin = new System.Windows.Forms.Padding(0);
            this.orderZoeken.Name = "orderZoeken";
            this.orderZoeken.Size = new System.Drawing.Size(224, 65);
            this.orderZoeken.TabIndex = 2;
            this.orderZoeken.Text = "order zoeken";
            this.orderZoeken.UseVisualStyleBackColor = false;
            this.orderZoeken.Click += new System.EventHandler(this.orderZoeken_Click);
            // 
            // dataGridOrders
            // 
            this.dataGridOrders.AllowUserToAddRows = false;
            this.dataGridOrders.AllowUserToDeleteRows = false;
            this.dataGridOrders.AllowUserToOrderColumns = true;
            this.dataGridOrders.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridOrders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridOrders.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridOrders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderID,
            this.bestelDatum,
            this.klantID,
            this.klantNaam,
            this.productID,
            this.productNaam,
            this.bestelhoeveelheid,
            this.afgehandeld});
            this.dataGridOrders.Location = new System.Drawing.Point(11, 21);
            this.dataGridOrders.Name = "dataGridOrders";
            this.dataGridOrders.RowHeadersWidth = 51;
            this.dataGridOrders.RowTemplate.Height = 24;
            this.dataGridOrders.Size = new System.Drawing.Size(926, 26);
            this.dataGridOrders.TabIndex = 1;
            this.dataGridOrders.Visible = false;
            this.dataGridOrders.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.productenTabel_CellContentClick);
            // 
            // orderID
            // 
            this.orderID.HeaderText = "orderID";
            this.orderID.MinimumWidth = 6;
            this.orderID.Name = "orderID";
            this.orderID.Width = 84;
            // 
            // bestelDatum
            // 
            this.bestelDatum.HeaderText = "bestelDatum";
            this.bestelDatum.MinimumWidth = 6;
            this.bestelDatum.Name = "bestelDatum";
            this.bestelDatum.Width = 116;
            // 
            // klantID
            // 
            this.klantID.HeaderText = "klantID";
            this.klantID.MinimumWidth = 6;
            this.klantID.Name = "klantID";
            this.klantID.Width = 80;
            // 
            // klantNaam
            // 
            this.klantNaam.HeaderText = "klantNaam";
            this.klantNaam.MinimumWidth = 6;
            this.klantNaam.Name = "klantNaam";
            this.klantNaam.Width = 104;
            // 
            // productID
            // 
            this.productID.HeaderText = "productID";
            this.productID.MinimumWidth = 6;
            this.productID.Name = "productID";
            this.productID.Width = 98;
            // 
            // productNaam
            // 
            this.productNaam.HeaderText = "productNaam";
            this.productNaam.MinimumWidth = 6;
            this.productNaam.Name = "productNaam";
            this.productNaam.Width = 122;
            // 
            // bestelhoeveelheid
            // 
            this.bestelhoeveelheid.HeaderText = "bestelhoeveelheid";
            this.bestelhoeveelheid.MinimumWidth = 6;
            this.bestelhoeveelheid.Name = "bestelhoeveelheid";
            this.bestelhoeveelheid.Width = 152;
            // 
            // afgehandeld
            // 
            this.afgehandeld.HeaderText = "afgehandeld";
            this.afgehandeld.MinimumWidth = 6;
            this.afgehandeld.Name = "afgehandeld";
            this.afgehandeld.Width = 116;
            // 
            // uitlezenTabel
            // 
            this.uitlezenTabel.AutoSize = true;
            this.uitlezenTabel.BackColor = System.Drawing.Color.Transparent;
            this.uitlezenTabel.Location = new System.Drawing.Point(273, 455);
            this.uitlezenTabel.Margin = new System.Windows.Forms.Padding(0);
            this.uitlezenTabel.Name = "uitlezenTabel";
            this.uitlezenTabel.Size = new System.Drawing.Size(224, 65);
            this.uitlezenTabel.TabIndex = 0;
            this.uitlezenTabel.Text = "uitlezen volledige tabel";
            this.uitlezenTabel.UseVisualStyleBackColor = false;
            this.uitlezenTabel.Click += new System.EventHandler(this.uitlezenTabel_Click);
            // 
            // productToevoegen
            // 
            this.productToevoegen.Controls.Add(this.groepPProductToevoegen);
            this.productToevoegen.Location = new System.Drawing.Point(4, 25);
            this.productToevoegen.Name = "productToevoegen";
            this.productToevoegen.Padding = new System.Windows.Forms.Padding(3);
            this.productToevoegen.Size = new System.Drawing.Size(1083, 548);
            this.productToevoegen.TabIndex = 2;
            this.productToevoegen.Text = "product toevoegen";
            this.productToevoegen.UseVisualStyleBackColor = true;
            // 
            // groepPProductToevoegen
            // 
            this.groepPProductToevoegen.BackColor = System.Drawing.SystemColors.Control;
            this.groepPProductToevoegen.Controls.Add(this.productToevoegenButtom);
            this.groepPProductToevoegen.Controls.Add(this.beschikbaar);
            this.groepPProductToevoegen.Controls.Add(this.textBoxProductStock);
            this.groepPProductToevoegen.Controls.Add(this.label3);
            this.groepPProductToevoegen.Controls.Add(this.textBoxProductNaam);
            this.groepPProductToevoegen.Controls.Add(this.label2);
            this.groepPProductToevoegen.Location = new System.Drawing.Point(176, 60);
            this.groepPProductToevoegen.Name = "groepPProductToevoegen";
            this.groepPProductToevoegen.Size = new System.Drawing.Size(655, 312);
            this.groepPProductToevoegen.TabIndex = 1;
            this.groepPProductToevoegen.TabStop = false;
            this.groepPProductToevoegen.Text = "Product toevoegen";
            // 
            // productToevoegenButtom
            // 
            this.productToevoegenButtom.Location = new System.Drawing.Point(23, 263);
            this.productToevoegenButtom.Name = "productToevoegenButtom";
            this.productToevoegenButtom.Size = new System.Drawing.Size(218, 32);
            this.productToevoegenButtom.TabIndex = 6;
            this.productToevoegenButtom.Text = "product toevoegen";
            this.productToevoegenButtom.UseVisualStyleBackColor = true;
            this.productToevoegenButtom.Click += new System.EventHandler(this.productToevoegenButtom_Click);
            // 
            // beschikbaar
            // 
            this.beschikbaar.AutoSize = true;
            this.beschikbaar.Location = new System.Drawing.Point(23, 210);
            this.beschikbaar.Name = "beschikbaar";
            this.beschikbaar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.beschikbaar.Size = new System.Drawing.Size(107, 21);
            this.beschikbaar.TabIndex = 5;
            this.beschikbaar.Text = "beschikbaar";
            this.beschikbaar.UseVisualStyleBackColor = true;
            // 
            // textBoxProductStock
            // 
            this.textBoxProductStock.Location = new System.Drawing.Point(23, 154);
            this.textBoxProductStock.Multiline = true;
            this.textBoxProductStock.Name = "textBoxProductStock";
            this.textBoxProductStock.Size = new System.Drawing.Size(126, 28);
            this.textBoxProductStock.TabIndex = 3;
            this.textBoxProductStock.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxProductStock_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "product stock:";
            // 
            // textBoxProductNaam
            // 
            this.textBoxProductNaam.Location = new System.Drawing.Point(23, 56);
            this.textBoxProductNaam.Multiline = true;
            this.textBoxProductNaam.Name = "textBoxProductNaam";
            this.textBoxProductNaam.Size = new System.Drawing.Size(610, 60);
            this.textBoxProductNaam.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Product naam:";
            // 
            // beheerProducten
            // 
            this.beheerProducten.Controls.Add(this.buttonVerwijderProduct);
            this.beheerProducten.Controls.Add(this.ButtonUitlezenProducten);
            this.beheerProducten.Controls.Add(this.dataGridProducten);
            this.beheerProducten.Location = new System.Drawing.Point(4, 25);
            this.beheerProducten.Name = "beheerProducten";
            this.beheerProducten.Padding = new System.Windows.Forms.Padding(3);
            this.beheerProducten.Size = new System.Drawing.Size(1083, 548);
            this.beheerProducten.TabIndex = 3;
            this.beheerProducten.Text = "beheer tabel producten";
            this.beheerProducten.UseVisualStyleBackColor = true;
            // 
            // buttonVerwijderProduct
            // 
            this.buttonVerwijderProduct.AutoSize = true;
            this.buttonVerwijderProduct.BackColor = System.Drawing.Color.Transparent;
            this.buttonVerwijderProduct.Enabled = false;
            this.buttonVerwijderProduct.Location = new System.Drawing.Point(553, 455);
            this.buttonVerwijderProduct.Margin = new System.Windows.Forms.Padding(0);
            this.buttonVerwijderProduct.Name = "buttonVerwijderProduct";
            this.buttonVerwijderProduct.Size = new System.Drawing.Size(224, 65);
            this.buttonVerwijderProduct.TabIndex = 4;
            this.buttonVerwijderProduct.Text = "product verwijderen";
            this.buttonVerwijderProduct.UseVisualStyleBackColor = false;
            this.buttonVerwijderProduct.Click += new System.EventHandler(this.buttonVerwijderProduct_Click);
            // 
            // ButtonUitlezenProducten
            // 
            this.ButtonUitlezenProducten.AutoSize = true;
            this.ButtonUitlezenProducten.BackColor = System.Drawing.Color.Transparent;
            this.ButtonUitlezenProducten.Location = new System.Drawing.Point(302, 455);
            this.ButtonUitlezenProducten.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonUitlezenProducten.Name = "ButtonUitlezenProducten";
            this.ButtonUitlezenProducten.Size = new System.Drawing.Size(224, 65);
            this.ButtonUitlezenProducten.TabIndex = 3;
            this.ButtonUitlezenProducten.Text = "uitlezen volledige tabel";
            this.ButtonUitlezenProducten.UseVisualStyleBackColor = false;
            this.ButtonUitlezenProducten.Click += new System.EventHandler(this.ButtonUitlezenProducten_Click);
            // 
            // dataGridProducten
            // 
            this.dataGridProducten.AllowUserToAddRows = false;
            this.dataGridProducten.AllowUserToDeleteRows = false;
            this.dataGridProducten.AllowUserToOrderColumns = true;
            this.dataGridProducten.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridProducten.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridProducten.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridProducten.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridProducten.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.dataGridProducten.Location = new System.Drawing.Point(6, 21);
            this.dataGridProducten.Name = "dataGridProducten";
            this.dataGridProducten.RowHeadersWidth = 51;
            this.dataGridProducten.RowTemplate.Height = 24;
            this.dataGridProducten.Size = new System.Drawing.Size(544, 26);
            this.dataGridProducten.TabIndex = 2;
            this.dataGridProducten.Visible = false;
            this.dataGridProducten.SelectionChanged += new System.EventHandler(this.dataGridProducten_SelectionChanged);
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "productID";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 98;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "productNaam";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 122;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "bestelhoeveelheid";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 152;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.HeaderText = "afgehandeld";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 116;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.buttonOrder);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1083, 548);
            this.tabPage1.TabIndex = 4;
            this.tabPage1.Text = "order bestellen";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // buttonOrder
            // 
            this.buttonOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOrder.Location = new System.Drawing.Point(343, 150);
            this.buttonOrder.Name = "buttonOrder";
            this.buttonOrder.Size = new System.Drawing.Size(397, 142);
            this.buttonOrder.TabIndex = 0;
            this.buttonOrder.Text = "bestel een order";
            this.buttonOrder.UseVisualStyleBackColor = true;
            this.buttonOrder.Click += new System.EventHandler(this.buttonOrder_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1083, 554);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "mainForm";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.verbindingTesten.ResumeLayout(false);
            this.uitlezen.ResumeLayout(false);
            this.uitlezen.PerformLayout();
            this.groupBoxOrders.ResumeLayout(false);
            this.groupBoxOrders.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridOrders)).EndInit();
            this.productToevoegen.ResumeLayout(false);
            this.groepPProductToevoegen.ResumeLayout(false);
            this.groepPProductToevoegen.PerformLayout();
            this.beheerProducten.ResumeLayout(false);
            this.beheerProducten.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProducten)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button openMySQL_server;
        private System.Windows.Forms.Button closeMySQL_server;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage uitlezen;
        private System.Windows.Forms.Button uitlezenTabel;
        private System.Windows.Forms.TabPage verbindingTesten;
        private System.Windows.Forms.DataGridView dataGridOrders;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderID;
        private System.Windows.Forms.DataGridViewTextBoxColumn bestelDatum;
        private System.Windows.Forms.DataGridViewTextBoxColumn klantID;
        private System.Windows.Forms.DataGridViewTextBoxColumn klantNaam;
        private System.Windows.Forms.DataGridViewTextBoxColumn productID;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNaam;
        private System.Windows.Forms.DataGridViewTextBoxColumn bestelhoeveelheid;
        private System.Windows.Forms.DataGridViewTextBoxColumn afgehandeld;
        private System.Windows.Forms.GroupBox groupBoxOrders;
        private System.Windows.Forms.TextBox orderIDText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button orderZoeken;
        private System.Windows.Forms.Button opnieuwZoeken;
        private System.Windows.Forms.TabPage productToevoegen;
        private System.Windows.Forms.GroupBox groepPProductToevoegen;
        private System.Windows.Forms.Button productToevoegenButtom;
        private System.Windows.Forms.CheckBox beschikbaar;
        private System.Windows.Forms.TextBox textBoxProductStock;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxProductNaam;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage beheerProducten;
        private System.Windows.Forms.Button ButtonUitlezenProducten;
        private System.Windows.Forms.DataGridView dataGridProducten;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.Button buttonVerwijderProduct;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button buttonOrder;
    }
}

