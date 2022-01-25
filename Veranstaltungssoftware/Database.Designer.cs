
namespace Veranstaltungssoftware
{
    partial class Database
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
            this.combobox_DB = new System.Windows.Forms.ComboBox();
            this.lbl_DB = new System.Windows.Forms.Label();
            this.btn_create = new System.Windows.Forms.Button();
            this.btn_use = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // combobox_DB
            // 
            this.combobox_DB.FormattingEnabled = true;
            this.combobox_DB.Location = new System.Drawing.Point(134, 15);
            this.combobox_DB.Name = "combobox_DB";
            this.combobox_DB.Size = new System.Drawing.Size(284, 21);
            this.combobox_DB.TabIndex = 0;
            // 
            // lbl_DB
            // 
            this.lbl_DB.AutoSize = true;
            this.lbl_DB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DB.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_DB.Location = new System.Drawing.Point(12, 13);
            this.lbl_DB.Name = "lbl_DB";
            this.lbl_DB.Size = new System.Drawing.Size(88, 20);
            this.lbl_DB.TabIndex = 1;
            this.lbl_DB.Text = "Datenbank";
            // 
            // btn_create
            // 
            this.btn_create.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_create.Location = new System.Drawing.Point(16, 54);
            this.btn_create.Name = "btn_create";
            this.btn_create.Size = new System.Drawing.Size(164, 43);
            this.btn_create.TabIndex = 2;
            this.btn_create.Text = "Create";
            this.btn_create.UseVisualStyleBackColor = true;
            // 
            // btn_use
            // 
            this.btn_use.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_use.Location = new System.Drawing.Point(254, 54);
            this.btn_use.Name = "btn_use";
            this.btn_use.Size = new System.Drawing.Size(164, 43);
            this.btn_use.TabIndex = 3;
            this.btn_use.Text = "use";
            this.btn_use.UseVisualStyleBackColor = true;
            // 
            // btn_delete
            // 
            this.btn_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.Location = new System.Drawing.Point(37, 113);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(351, 48);
            this.btn_delete.TabIndex = 4;
            this.btn_delete.Text = "delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            // 
            // btn_Exit
            // 
            this.btn_Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Exit.Location = new System.Drawing.Point(37, 167);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(351, 48);
            this.btn_Exit.TabIndex = 5;
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // Database
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(430, 244);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_use);
            this.Controls.Add(this.btn_create);
            this.Controls.Add(this.lbl_DB);
            this.Controls.Add(this.combobox_DB);
            this.Name = "Database";
            this.Text = "Database";
            this.Load += new System.EventHandler(this.Database_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox combobox_DB;
        private System.Windows.Forms.Label lbl_DB;
        private System.Windows.Forms.Button btn_create;
        private System.Windows.Forms.Button btn_use;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_Exit;
    }
}