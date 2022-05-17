using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Veranstaltungssoftware
{
    public partial class Grid : Form
    {
        //public static string ConnectionString = "server = (localdb)\\MSSQLLocalDB;Database =" + NameofDB + ";Integrated Security = true";
        public Grid()
        {
            InitializeComponent();
        }

        private void Grid_Load(object sender, EventArgs e)
        {
            //Tabelle im Gridview ausgeben
            //    try
            //    {
            //        SqlCommand cmd = new SqlCommand();
            //        DataGridView gridView = new DataGridView();
            //        DataTable data = new DataTable();
            //        SqlConnection con = new SqlConnection(ConnectionString);
            //        con.Open();
            //        SqlDataAdapter sqldataAdapter = new SqlDataAdapter(cmd = new SqlCommand("Select * from " + NameofTable + ";", con));
            //        sqldataAdapter.Fill(data);
            //        gridView.DataSource = data;
            //    }
            //    catch (Exception)
            //    {

            //        MessageBox.Show("Das hat nicht funktioniert!");
            //    }
        }

    }
}
