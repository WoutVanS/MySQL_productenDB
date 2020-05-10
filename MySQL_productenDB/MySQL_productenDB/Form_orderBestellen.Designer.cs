namespace MySQL_productenDB
{
    partial class Form_orderBestellen
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
            this.comboBoxProducten = new System.Windows.Forms.ComboBox();
            this.groupBoxOrder = new System.Windows.Forms.GroupBox();
            this.buttonBestel = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxHoeveelheid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxKlanten = new System.Windows.Forms.ComboBox();
            this.groupBoxOrder.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxProducten
            // 
            this.comboBoxProducten.BackColor = System.Drawing.Color.White;
            this.comboBoxProducten.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxProducten.FormattingEnabled = true;
            this.comboBoxProducten.Location = new System.Drawing.Point(32, 121);
            this.comboBoxProducten.Name = "comboBoxProducten";
            this.comboBoxProducten.Size = new System.Drawing.Size(211, 24);
            this.comboBoxProducten.TabIndex = 0;
            // 
            // groupBoxOrder
            // 
            this.groupBoxOrder.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBoxOrder.Controls.Add(this.comboBoxKlanten);
            this.groupBoxOrder.Controls.Add(this.label3);
            this.groupBoxOrder.Controls.Add(this.buttonBestel);
            this.groupBoxOrder.Controls.Add(this.label2);
            this.groupBoxOrder.Controls.Add(this.textBoxHoeveelheid);
            this.groupBoxOrder.Controls.Add(this.label1);
            this.groupBoxOrder.Controls.Add(this.comboBoxProducten);
            this.groupBoxOrder.Location = new System.Drawing.Point(149, 38);
            this.groupBoxOrder.Name = "groupBoxOrder";
            this.groupBoxOrder.Size = new System.Drawing.Size(453, 325);
            this.groupBoxOrder.TabIndex = 1;
            this.groupBoxOrder.TabStop = false;
            this.groupBoxOrder.Text = "order";
            // 
            // buttonBestel
            // 
            this.buttonBestel.BackColor = System.Drawing.Color.White;
            this.buttonBestel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonBestel.Location = new System.Drawing.Point(112, 273);
            this.buttonBestel.Name = "buttonBestel";
            this.buttonBestel.Size = new System.Drawing.Size(228, 46);
            this.buttonBestel.TabIndex = 4;
            this.buttonBestel.Text = "bestel";
            this.buttonBestel.UseVisualStyleBackColor = false;
            this.buttonBestel.Click += new System.EventHandler(this.buttonBestel_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "hoeveelheid:";
            // 
            // textBoxHoeveelheid
            // 
            this.textBoxHoeveelheid.Location = new System.Drawing.Point(32, 182);
            this.textBoxHoeveelheid.Name = "textBoxHoeveelheid";
            this.textBoxHoeveelheid.Size = new System.Drawing.Size(100, 22);
            this.textBoxHoeveelheid.TabIndex = 2;
            this.textBoxHoeveelheid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxHoeveelheid_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "producten:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "naam + achternaam:";
            // 
            // comboBoxKlanten
            // 
            this.comboBoxKlanten.BackColor = System.Drawing.Color.White;
            this.comboBoxKlanten.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxKlanten.FormattingEnabled = true;
            this.comboBoxKlanten.Location = new System.Drawing.Point(32, 62);
            this.comboBoxKlanten.Name = "comboBoxKlanten";
            this.comboBoxKlanten.Size = new System.Drawing.Size(211, 24);
            this.comboBoxKlanten.TabIndex = 6;
            // 
            // Form_orderBestellen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBoxOrder);
            this.Name = "Form_orderBestellen";
            this.Text = "Form_orderBestellen";
            this.groupBoxOrder.ResumeLayout(false);
            this.groupBoxOrder.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxProducten;
        private System.Windows.Forms.GroupBox groupBoxOrder;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxHoeveelheid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonBestel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxKlanten;
    }
}