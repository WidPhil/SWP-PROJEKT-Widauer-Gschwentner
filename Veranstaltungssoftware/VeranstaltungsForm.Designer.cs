
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxAdresse = new System.Windows.Forms.TextBox();
            this.lbl_Essen = new System.Windows.Forms.Label();
            this.textBoxEssen = new System.Windows.Forms.TextBox();
            this.btn_TableGuests = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lbl_party = new System.Windows.Forms.Label();
            this.textBoxParty = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.lbl_guests.Location = new System.Drawing.Point(13, 146);
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
            this.lbl_dj.Location = new System.Drawing.Point(13, 200);
            this.lbl_dj.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_dj.Name = "lbl_dj";
            this.lbl_dj.Size = new System.Drawing.Size(169, 29);
            this.lbl_dj.TabIndex = 2;
            this.lbl_dj.Text = "DJ auswählen:";
            this.lbl_dj.Click += new System.EventHandler(this.lbl_dj_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(342, 146);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(196, 22);
            this.numericUpDown1.TabIndex = 3;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // textBoxDJ
            // 
            this.textBoxDJ.Location = new System.Drawing.Point(342, 200);
            this.textBoxDJ.Name = "textBoxDJ";
            this.textBoxDJ.Size = new System.Drawing.Size(196, 22);
            this.textBoxDJ.TabIndex = 4;
            this.textBoxDJ.TextChanged += new System.EventHandler(this.textBoxDJ_TextChanged);
            // 
            // lbl_getränke
            // 
            this.lbl_getränke.AutoSize = true;
            this.lbl_getränke.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_getränke.Location = new System.Drawing.Point(13, 253);
            this.lbl_getränke.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_getränke.Name = "lbl_getränke";
            this.lbl_getränke.Size = new System.Drawing.Size(256, 29);
            this.lbl_getränke.TabIndex = 5;
            this.lbl_getränke.Text = "Vorliebe der Getränke:";
            this.lbl_getränke.Click += new System.EventHandler(this.lbl_getränke_Click);
            // 
            // textBoxGetränke
            // 
            this.textBoxGetränke.Location = new System.Drawing.Point(342, 253);
            this.textBoxGetränke.Name = "textBoxGetränke";
            this.textBoxGetränke.Size = new System.Drawing.Size(196, 22);
            this.textBoxGetränke.TabIndex = 6;
            this.textBoxGetränke.TextChanged += new System.EventHandler(this.textBoxGetränke_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 351);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 29);
            this.label1.TabIndex = 7;
            this.label1.Text = "Adresse der Party:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxAdresse
            // 
            this.textBoxAdresse.Location = new System.Drawing.Point(342, 351);
            this.textBoxAdresse.Name = "textBoxAdresse";
            this.textBoxAdresse.Size = new System.Drawing.Size(196, 22);
            this.textBoxAdresse.TabIndex = 8;
            this.textBoxAdresse.TextChanged += new System.EventHandler(this.textBoxAdresse_TextChanged);
            // 
            // lbl_Essen
            // 
            this.lbl_Essen.AutoSize = true;
            this.lbl_Essen.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Essen.Location = new System.Drawing.Point(13, 302);
            this.lbl_Essen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Essen.Name = "lbl_Essen";
            this.lbl_Essen.Size = new System.Drawing.Size(183, 29);
            this.lbl_Essen.TabIndex = 9;
            this.lbl_Essen.Text = "Vorliebe Essen:";
            this.lbl_Essen.Click += new System.EventHandler(this.lbl_Essen_Click);
            // 
            // textBoxEssen
            // 
            this.textBoxEssen.Location = new System.Drawing.Point(342, 302);
            this.textBoxEssen.Name = "textBoxEssen";
            this.textBoxEssen.Size = new System.Drawing.Size(196, 22);
            this.textBoxEssen.TabIndex = 10;
            this.textBoxEssen.TextChanged += new System.EventHandler(this.textBoxEssen_TextChanged);
            // 
            // btn_TableGuests
            // 
            this.btn_TableGuests.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_TableGuests.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TableGuests.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_TableGuests.Location = new System.Drawing.Point(835, 53);
            this.btn_TableGuests.Name = "btn_TableGuests";
            this.btn_TableGuests.Size = new System.Drawing.Size(335, 70);
            this.btn_TableGuests.TabIndex = 11;
            this.btn_TableGuests.Text = "Tabelle Gäste anzeigen";
            this.btn_TableGuests.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(787, 146);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(441, 445);
            this.dataGridView1.TabIndex = 12;
            // 
            // lbl_party
            // 
            this.lbl_party.AutoSize = true;
            this.lbl_party.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_party.Location = new System.Drawing.Point(17, 396);
            this.lbl_party.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_party.Name = "lbl_party";
            this.lbl_party.Size = new System.Drawing.Size(150, 29);
            this.lbl_party.TabIndex = 13;
            this.lbl_party.Text = "Art der Party:";
            this.lbl_party.Click += new System.EventHandler(this.lbl_party_Click);
            // 
            // textBoxParty
            // 
            this.textBoxParty.Location = new System.Drawing.Point(342, 403);
            this.textBoxParty.Name = "textBoxParty";
            this.textBoxParty.Size = new System.Drawing.Size(196, 22);
            this.textBoxParty.TabIndex = 14;
            this.textBoxParty.TextChanged += new System.EventHandler(this.textBoxParty_TextChanged);
            // 
            // VeranstaltungsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1335, 626);
            this.Controls.Add(this.textBoxParty);
            this.Controls.Add(this.lbl_party);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_TableGuests);
            this.Controls.Add(this.textBoxEssen);
            this.Controls.Add(this.lbl_Essen);
            this.Controls.Add(this.textBoxAdresse);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxGetränke);
            this.Controls.Add(this.lbl_getränke);
            this.Controls.Add(this.textBoxDJ);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.lbl_dj);
            this.Controls.Add(this.lbl_guests);
            this.Controls.Add(this.lbl_veranstaltungsform);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "VeranstaltungsForm";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxAdresse;
        private System.Windows.Forms.Label lbl_Essen;
        private System.Windows.Forms.TextBox textBoxEssen;
        private System.Windows.Forms.Button btn_TableGuests;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lbl_party;
        private System.Windows.Forms.TextBox textBoxParty;
    }
}