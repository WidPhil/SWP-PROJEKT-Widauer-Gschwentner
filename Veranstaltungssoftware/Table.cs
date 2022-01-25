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
            //Gridview GV = new Gridview();
            //GV.Show();
        }
        private void btn_deleteTable_Click(object sender, EventArgs e)
        {
            Manager.NameofTBL = comboBox_Tables.Text;
            Manager.deleteTBL();
        }


        private void Table_Load(object sender, EventArgs e)
        {

        }
    }
}
