using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Veranstaltungssoftware
{
    public partial class Table : Form
    {

        public Table()
        {
            InitializeComponent();
        }
        private void chooseTable_Load(object sender, EventArgs e)
        {

        }
        private void btn_createTable_Click(object sender, EventArgs e)
        {
            Manager.NameofTBL = comboBox_Tables.Text;
            Manager.createTBL();
        }
        private void btn_UseTable_Click(object sender, EventArgs e)
        {
            
        }
        private void btn_deleteTable_Click(object sender, EventArgs e)
        {
            Manager.NameofTBL = comboBox_Tables.Text;
            Manager.deleteTBL();
        }




        
        #region _Columns
        private void txtbox_col2_TextChanged(object sender, EventArgs e)
        {
            col2 = txtbox_col2.Text;
        }

        private void txtbox_col3_TextChanged(object sender, EventArgs e)
        {
            col3 = txtbox_col3.Text;
        }

        private void txtbox_col4_TextChanged(object sender, EventArgs e)
        {
            col4 = txtbox_col4.Text;
        }
        #endregion         


        private void Table_Load(object sender, EventArgs e)
        {

        }

        private void btn_Exit1_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }        

       
    }
}
