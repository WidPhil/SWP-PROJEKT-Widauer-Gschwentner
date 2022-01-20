
namespace Veranstaltungssoftware
{
    partial class Table
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
            this.lbl_Table = new System.Windows.Forms.Label();
            this.comboBox_Tables = new System.Windows.Forms.ComboBox();
            this.lbl_column = new System.Windows.Forms.Label();
            this.comboBox_Tables2 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_Tables3 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_Tables4 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lbl_Table
            // 
            this.lbl_Table.AutoSize = true;
            this.lbl_Table.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Table.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_Table.Location = new System.Drawing.Point(42, 51);
            this.lbl_Table.Name = "lbl_Table";
            this.lbl_Table.Size = new System.Drawing.Size(63, 24);
            this.lbl_Table.TabIndex = 0;
            this.lbl_Table.Text = "Table:";
            // 
            // comboBox_Tables
            // 
            this.comboBox_Tables.FormattingEnabled = true;
            this.comboBox_Tables.Location = new System.Drawing.Point(46, 105);
            this.comboBox_Tables.Name = "comboBox_Tables";
            this.comboBox_Tables.Size = new System.Drawing.Size(159, 21);
            this.comboBox_Tables.TabIndex = 1;
            // 
            // lbl_column
            // 
            this.lbl_column.AutoSize = true;
            this.lbl_column.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_column.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_column.Location = new System.Drawing.Point(43, 140);
            this.lbl_column.Name = "lbl_column";
            this.lbl_column.Size = new System.Drawing.Size(72, 18);
            this.lbl_column.TabIndex = 2;
            this.lbl_column.Text = "Column 2";
            // 
            // comboBox_Tables2
            // 
            this.comboBox_Tables2.FormattingEnabled = true;
            this.comboBox_Tables2.Location = new System.Drawing.Point(46, 173);
            this.comboBox_Tables2.Name = "comboBox_Tables2";
            this.comboBox_Tables2.Size = new System.Drawing.Size(159, 21);
            this.comboBox_Tables2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(43, 213);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Column 3";
            // 
            // comboBox_Tables3
            // 
            this.comboBox_Tables3.FormattingEnabled = true;
            this.comboBox_Tables3.Location = new System.Drawing.Point(46, 246);
            this.comboBox_Tables3.Name = "comboBox_Tables3";
            this.comboBox_Tables3.Size = new System.Drawing.Size(159, 21);
            this.comboBox_Tables3.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(43, 281);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "Column 4";
            // 
            // comboBox_Tables4
            // 
            this.comboBox_Tables4.FormattingEnabled = true;
            this.comboBox_Tables4.Location = new System.Drawing.Point(46, 318);
            this.comboBox_Tables4.Name = "comboBox_Tables4";
            this.comboBox_Tables4.Size = new System.Drawing.Size(159, 21);
            this.comboBox_Tables4.TabIndex = 7;
            // 
            // Table
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(272, 389);
            this.Controls.Add(this.comboBox_Tables4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox_Tables3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox_Tables2);
            this.Controls.Add(this.lbl_column);
            this.Controls.Add(this.comboBox_Tables);
            this.Controls.Add(this.lbl_Table);
            this.Name = "Table";
            this.Text = "Table";
            this.Load += new System.EventHandler(this.Table_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Table;
        private System.Windows.Forms.ComboBox comboBox_Tables;
        private System.Windows.Forms.Label lbl_column;
        private System.Windows.Forms.ComboBox comboBox_Tables2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_Tables3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_Tables4;
    }
}