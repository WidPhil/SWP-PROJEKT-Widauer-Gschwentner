
namespace Veranstaltungssoftware
{
    partial class VeranstaltungsForm
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
            this.lbl_veranstaltungsform = new System.Windows.Forms.Label();
            this.lbl_guests = new System.Windows.Forms.Label();
            this.lbl_dj = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.textBoxDJ = new System.Windows.Forms.TextBox();
            this.lbl_getränke = new System.Windows.Forms.Label();
            this.textBoxGetränke = new System.Windows.Forms.TextBox();
            this.lbl_street = new System.Windows.Forms.Label();
            this.textBoxStreet = new System.Windows.Forms.TextBox();
            this.lbl_Essen = new System.Windows.Forms.Label();
            this.textBoxEssen = new System.Windows.Forms.TextBox();
            this.btn_TableGuests = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lbl_event = new System.Windows.Forms.Label();
            this.textBoxEvent = new System.Windows.Forms.TextBox();
            this.lbl_budget = new System.Windows.Forms.Label();
            this.btn_createEvent = new System.Windows.Forms.Button();
            this.btn_editTable = new System.Windows.Forms.Button();
            this.lbl_plz = new System.Windows.Forms.Label();
            this.txt_PLZ = new System.Windows.Forms.TextBox();
            this.lbl_houseNumber = new System.Windows.Forms.Label();
            this.txt_houseNumber = new System.Windows.Forms.TextBox();
            this.lbl_eventName = new System.Windows.Forms.Label();
            this.txt_nameEvent = new System.Windows.Forms.TextBox();
            this.numericUpDownBudget = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBudget)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_veranstaltungsform
            // 
            this.lbl_veranstaltungsform.AutoSize = true;
            this.lbl_veranstaltungsform.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_veranstaltungsform.Location = new System.Drawing.Point(16, 11);
            this.lbl_veranstaltungsform.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_veranstaltungsform.Name = "lbl_veranstaltungsform";
            this.lbl_veranstaltungsform.Size = new System.Drawing.Size(300, 31);
            this.lbl_veranstaltungsform.TabIndex = 0;
            this.lbl_veranstaltungsform.Text = "Veranstaltungssoftware";
            this.lbl_veranstaltungsform.Click += new System.EventHandler(this.lbl_veranstaltungsform_Click);
            // 
            // lbl_guests
            // 
            this.lbl_guests.AutoSize = true;
            this.lbl_guests.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_guests.Location = new System.Drawing.Point(12, 184);
            this.lbl_guests.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_guests.Name = "lbl_guests";
            this.lbl_guests.Size = new System.Drawing.Size(201, 29);
            this.lbl_guests.TabIndex = 1;
            this.lbl_guests.Text = "Anzahl der Gäste:";
            this.lbl_guests.Click += new System.EventHandler(this.lbl_guests_Click);
            // 
            // lbl_dj
            // 
            this.lbl_dj.AutoSize = true;
            this.lbl_dj.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dj.Location = new System.Drawing.Point(12, 227);
            this.lbl_dj.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_dj.Name = "lbl_dj";
            this.lbl_dj.Size = new System.Drawing.Size(169, 29);
            this.lbl_dj.TabIndex = 2;
            this.lbl_dj.Text = "DJ auswählen:";
            this.lbl_dj.Click += new System.EventHandler(this.lbl_dj_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(342, 184);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(196, 22);
            this.numericUpDown1.TabIndex = 3;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // textBoxDJ
            // 
            this.textBoxDJ.Location = new System.Drawing.Point(342, 227);
            this.textBoxDJ.Name = "textBoxDJ";
            this.textBoxDJ.Size = new System.Drawing.Size(196, 22);
            this.textBoxDJ.TabIndex = 4;
            // 
            // lbl_getränke
            // 
            this.lbl_getränke.AutoSize = true;
            this.lbl_getränke.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_getränke.Location = new System.Drawing.Point(12, 256);
            this.lbl_getränke.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_getränke.Name = "lbl_getränke";
            this.lbl_getränke.Size = new System.Drawing.Size(256, 29);
            this.lbl_getränke.TabIndex = 5;
            this.lbl_getränke.Text = "Vorliebe der Getränke:";
            this.lbl_getränke.Click += new System.EventHandler(this.lbl_getränke_Click);
            // 
            // textBoxGetränke
            // 
            this.textBoxGetränke.Location = new System.Drawing.Point(342, 256);
            this.textBoxGetränke.Name = "textBoxGetränke";
            this.textBoxGetränke.Size = new System.Drawing.Size(196, 22);
            this.textBoxGetränke.TabIndex = 6;
            // 
            // lbl_street
            // 
            this.lbl_street.AutoSize = true;
            this.lbl_street.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_street.Location = new System.Drawing.Point(12, 334);
            this.lbl_street.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_street.Name = "lbl_street";
            this.lbl_street.Size = new System.Drawing.Size(202, 29);
            this.lbl_street.TabIndex = 7;
            this.lbl_street.Text = "Strasse der Party:";
            this.lbl_street.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxStreet
            // 
            this.textBoxStreet.Location = new System.Drawing.Point(342, 334);
            this.textBoxStreet.Name = "textBoxStreet";
            this.textBoxStreet.Size = new System.Drawing.Size(196, 22);
            this.textBoxStreet.TabIndex = 8;
            // 
            // lbl_Essen
            // 
            this.lbl_Essen.AutoSize = true;
            this.lbl_Essen.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Essen.Location = new System.Drawing.Point(13, 291);
            this.lbl_Essen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Essen.Name = "lbl_Essen";
            this.lbl_Essen.Size = new System.Drawing.Size(183, 29);
            this.lbl_Essen.TabIndex = 9;
            this.lbl_Essen.Text = "Vorliebe Essen:";
            this.lbl_Essen.Click += new System.EventHandler(this.lbl_Essen_Click);
            // 
            // textBoxEssen
            // 
            this.textBoxEssen.Location = new System.Drawing.Point(342, 291);
            this.textBoxEssen.Name = "textBoxEssen";
            this.textBoxEssen.Size = new System.Drawing.Size(196, 22);
            this.textBoxEssen.TabIndex = 10;
            // 
            // btn_TableGuests
            // 
            this.btn_TableGuests.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_TableGuests.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TableGuests.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_TableGuests.Location = new System.Drawing.Point(717, 55);
            this.btn_TableGuests.Name = "btn_TableGuests";
            this.btn_TableGuests.Size = new System.Drawing.Size(335, 70);
            this.btn_TableGuests.TabIndex = 11;
            this.btn_TableGuests.Text = "Tabelle Gäste anzeigen";
            this.btn_TableGuests.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(656, 146);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(441, 359);
            this.dataGridView1.TabIndex = 12;
            // 
            // lbl_event
            // 
            this.lbl_event.AutoSize = true;
            this.lbl_event.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_event.Location = new System.Drawing.Point(13, 432);
            this.lbl_event.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_event.Name = "lbl_event";
            this.lbl_event.Size = new System.Drawing.Size(172, 29);
            this.lbl_event.TabIndex = 13;
            this.lbl_event.Text = "Art des Events:";
            this.lbl_event.Click += new System.EventHandler(this.lbl_party_Click);
            // 
            // textBoxEvent
            // 
            this.textBoxEvent.Location = new System.Drawing.Point(342, 439);
            this.textBoxEvent.Name = "textBoxEvent";
            this.textBoxEvent.Size = new System.Drawing.Size(196, 22);
            this.textBoxEvent.TabIndex = 14;
            // 
            // lbl_budget
            // 
            this.lbl_budget.AutoSize = true;
            this.lbl_budget.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_budget.Location = new System.Drawing.Point(17, 476);
            this.lbl_budget.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_budget.Name = "lbl_budget";
            this.lbl_budget.Size = new System.Drawing.Size(96, 29);
            this.lbl_budget.TabIndex = 15;
            this.lbl_budget.Text = "Budget:";
            this.lbl_budget.Click += new System.EventHandler(this.label2_Click);
            // 
            // btn_createEvent
            // 
            this.btn_createEvent.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_createEvent.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_createEvent.Location = new System.Drawing.Point(18, 548);
            this.btn_createEvent.Name = "btn_createEvent";
            this.btn_createEvent.Size = new System.Drawing.Size(520, 43);
            this.btn_createEvent.TabIndex = 17;
            this.btn_createEvent.Text = "Veranstaltung hinzufügen";
            this.btn_createEvent.UseVisualStyleBackColor = false;
            this.btn_createEvent.Click += new System.EventHandler(this.btn_createEvent_Click_1);
            // 
            // btn_editTable
            // 
            this.btn_editTable.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_editTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_editTable.Location = new System.Drawing.Point(577, 548);
            this.btn_editTable.Name = "btn_editTable";
            this.btn_editTable.Size = new System.Drawing.Size(520, 43);
            this.btn_editTable.TabIndex = 18;
            this.btn_editTable.Text = "Gästetabelle bearbeiten";
            this.btn_editTable.UseVisualStyleBackColor = false;
            // 
            // lbl_plz
            // 
            this.lbl_plz.AutoSize = true;
            this.lbl_plz.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_plz.Location = new System.Drawing.Point(13, 363);
            this.lbl_plz.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_plz.Name = "lbl_plz";
            this.lbl_plz.Size = new System.Drawing.Size(62, 29);
            this.lbl_plz.TabIndex = 19;
            this.lbl_plz.Text = "PLZ:";
            // 
            // txt_PLZ
            // 
            this.txt_PLZ.Location = new System.Drawing.Point(342, 363);
            this.txt_PLZ.Name = "txt_PLZ";
            this.txt_PLZ.Size = new System.Drawing.Size(196, 22);
            this.txt_PLZ.TabIndex = 20;
            // 
            // lbl_houseNumber
            // 
            this.lbl_houseNumber.AutoSize = true;
            this.lbl_houseNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_houseNumber.Location = new System.Drawing.Point(13, 392);
            this.lbl_houseNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_houseNumber.Name = "lbl_houseNumber";
            this.lbl_houseNumber.Size = new System.Drawing.Size(162, 29);
            this.lbl_houseNumber.TabIndex = 21;
            this.lbl_houseNumber.Text = "Hausnummer:";
            // 
            // txt_houseNumber
            // 
            this.txt_houseNumber.Location = new System.Drawing.Point(342, 392);
            this.txt_houseNumber.Name = "txt_houseNumber";
            this.txt_houseNumber.Size = new System.Drawing.Size(196, 22);
            this.txt_houseNumber.TabIndex = 22;
            // 
            // lbl_eventName
            // 
            this.lbl_eventName.AutoSize = true;
            this.lbl_eventName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_eventName.Location = new System.Drawing.Point(13, 126);
            this.lbl_eventName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_eventName.Name = "lbl_eventName";
            this.lbl_eventName.Size = new System.Drawing.Size(208, 29);
            this.lbl_eventName.TabIndex = 23;
            this.lbl_eventName.Text = "Name des Events:";
            // 
            // txt_nameEvent
            // 
            this.txt_nameEvent.Location = new System.Drawing.Point(342, 133);
            this.txt_nameEvent.Name = "txt_nameEvent";
            this.txt_nameEvent.Size = new System.Drawing.Size(196, 22);
            this.txt_nameEvent.TabIndex = 24;
            this.txt_nameEvent.TextChanged += new System.EventHandler(this.txt_nameEvent_TextChanged);
            // 
            // numericUpDownBudget
            // 
            this.numericUpDownBudget.Location = new System.Drawing.Point(342, 476);
            this.numericUpDownBudget.Name = "numericUpDownBudget";
            this.numericUpDownBudget.Size = new System.Drawing.Size(196, 22);
            this.numericUpDownBudget.TabIndex = 25;
            // 
            // VeranstaltungsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1111, 626);
            this.Controls.Add(this.numericUpDownBudget);
            this.Controls.Add(this.txt_nameEvent);
            this.Controls.Add(this.lbl_eventName);
            this.Controls.Add(this.txt_houseNumber);
            this.Controls.Add(this.lbl_houseNumber);
            this.Controls.Add(this.txt_PLZ);
            this.Controls.Add(this.lbl_plz);
            this.Controls.Add(this.btn_editTable);
            this.Controls.Add(this.btn_createEvent);
            this.Controls.Add(this.lbl_budget);
            this.Controls.Add(this.textBoxEvent);
            this.Controls.Add(this.lbl_event);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_TableGuests);
            this.Controls.Add(this.textBoxEssen);
            this.Controls.Add(this.lbl_Essen);
            this.Controls.Add(this.textBoxStreet);
            this.Controls.Add(this.lbl_street);
            this.Controls.Add(this.textBoxGetränke);
            this.Controls.Add(this.lbl_getränke);
            this.Controls.Add(this.textBoxDJ);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.lbl_dj);
            this.Controls.Add(this.lbl_guests);
            this.Controls.Add(this.lbl_veranstaltungsform);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "VeranstaltungsForm";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBudget)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_veranstaltungsform;
        private System.Windows.Forms.Label lbl_guests;
        private System.Windows.Forms.Label lbl_dj;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.TextBox textBoxDJ;
        private System.Windows.Forms.Label lbl_getränke;
        private System.Windows.Forms.TextBox textBoxGetränke;
        private System.Windows.Forms.Label lbl_street;
        private System.Windows.Forms.TextBox textBoxStreet;
        private System.Windows.Forms.Label lbl_Essen;
        private System.Windows.Forms.TextBox textBoxEssen;
        private System.Windows.Forms.Button btn_TableGuests;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lbl_event;
        private System.Windows.Forms.TextBox textBoxEvent;
        private System.Windows.Forms.Label lbl_budget;
        private System.Windows.Forms.Button btn_createEvent;
        private System.Windows.Forms.Button btn_editTable;
        private System.Windows.Forms.Label lbl_plz;
        private System.Windows.Forms.TextBox txt_PLZ;
        private System.Windows.Forms.Label lbl_houseNumber;
        private System.Windows.Forms.TextBox txt_houseNumber;
        private System.Windows.Forms.Label lbl_eventName;
        private System.Windows.Forms.TextBox txt_nameEvent;
        private System.Windows.Forms.NumericUpDown numericUpDownBudget;
    }
}