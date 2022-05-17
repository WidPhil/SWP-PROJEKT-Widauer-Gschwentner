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
    public partial class Database : Form
    {
        public static string nameofDB;
        public Database()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void combobox_DB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_create_Click(object sender, EventArgs e)
        {
            nameofDB = combobox_DB.Text;
            Manager.createTable();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            Manager.NameofDB = combobox_DB.Text;
            Manager.deleteDB();

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        
        private void Database_Load(object sender, EventArgs e)
        {

        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }
    }
}
