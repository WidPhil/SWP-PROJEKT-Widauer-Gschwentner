using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Veranstaltungssoftware
{
    class Manager : VeranstaltungsForm
    {
        public static string ConnectionString = "server = (localdb)\\MSSQLLocalDB;Database =" + NameofDB + ";Integrated Security = true";

        public static int iForDatabases;
        public static int iForTables;

 Daniel
        public static string nameofEvent = VeranstaltungsForm.NamedesEvents;
        public static string preferedbeverage = VeranstaltungsForm.VorliebederGetränke;
        public static string preferedfood = VeranstaltungsForm.VorliebederSpeisen;
        public static string street = VeranstaltungsForm.Strasse;
        public static string house = VeranstaltungsForm.Hausnummer;
        public static string postcode = VeranstaltungsForm.PLZ;
        public static string typeofEvent = VeranstaltungsForm.ArtderVeranstaltung;

        public static string nameofEvent = name;
        public static string preferedbeverage = drinks;
        public static string preferedfood = food;
        public static string street = Street;
        public static string house = housecode;
        public static string postcode = zip;
        public static string typeofEvent = TypeofEvent;
        public static string nameofCreator = NameofCreator;
        public static string EmailofCreator = emailofCreator;
        public static decimal budget = Budget;
        
 main
        public static int ID;
        //df


 Daniel
        public static string NameofDB;
        public static string NameofTBL;
        public static SqlConnection con;


        public static SqlConnection con;

   
 main
        //Datenbank erstellen, löschen und verändern
        //Wir brauchen Tabelle Veranstaltung und Tabelle Gäste
        public static void createDatabase()
        {
            try
            {
                con = new SqlConnection(ConnectionString);
                con.Open();
                SqlCommand cmd = new SqlCommand("CREATE DATABASE Event", con);
                cmd.ExecuteNonQuery();
                iForDatabases++;
            }
            catch (ConnectionException cex)
            {
                MessageBox.Show(cex.ToString());
            }
            con.Close();
            MessageBox.Show("Database Successfully created!");
        }

        //Datenbank löschen
        public static void deleteDB()
        {
            try
            {
                con = new SqlConnection(ConnectionString);
                con.Open();
                SqlCommand cmd = new SqlCommand("DROP DATABASE IF EXISTS " + NameofDB, con);
                cmd.ExecuteNonQuery();
                iForDatabases++;

            }
            catch (ConnectionException cex)
            {
                MessageBox.Show(cex.ToString());
            }
            con.Close();
            MessageBox.Show("Database Successfully deleted!");
        }
 Daniel

        //Tabelle
        public static void createTBL()

    
        //Tabelle
        public static void createTable()
        {
            //Funktioniert nicht
            try
            {
                con = new SqlConnection(ConnectionString);
                con.Open();

                SqlCommand com = new SqlCommand("CREATE TABLE guests(ID varchar(200), Vorname varchar(20), Nachname varchar(20), Geburtsdatum varchar(20)", con);
                com.ExecuteNonQuery();
                SqlCommand cmd = new SqlCommand("CREATE TABLE event(ID varchar(200), NamedesEvents varchar(50), AnzahlderGaeste varchar(50), Chef varchar(50)", con);
                cmd.ExecuteNonQuery();
                iForTables++;

            }
            catch (ConnectionException cex)
            {
                MessageBox.Show(cex.ToString());
            }
            con.Close();
            MessageBox.Show("Table Successfully created!");

        }

        public static void InsertintoTable(string nameofTable)
 main
        {
            try
            {
                //if ()
                con = new SqlConnection(ConnectionString);
                con.Open();
 Daniel
                SqlCommand cmd = new SqlCommand("CREATE TABLE " + NameofTBL + " (" + "'" + ID + "' " + "INT PRIMARY KEY," + " '" + nameofEvent + "' " + "VARCHAR NOT NULL," + " '" + street + "' " + "VARCHAR NOT NULL," + " '" + house + "' " + "VARCHAR NOT NULL" + ");", con);
                cmd.ExecuteNonQuery();
                iForTables++;

 main

                SqlCommand cmd = new SqlCommand("Insert into");
            }
            catch (Exception)
            {

                throw;
            }
        }
        public static void deleteTBL()
        {
            //Funktioniert nicht
            try
            {
                con = new SqlConnection(ConnectionString);
                con.Open();
                SqlCommand cmd = new SqlCommand("DROP TABLE " + NameofTBL, con);
                cmd.ExecuteNonQuery();
                iForTables++;

            }
            catch (ConnectionException cex)
            {
                MessageBox.Show(cex.ToString());
            }
            con.Close();
            MessageBox.Show("Table Successfully deleted!");
        }
 Daniel
        

        //public static void AlterTBL()
        //{
        //    con = new SqlConnection(ConnectionString);
        //    con.Open();

        //    SqlCommand cmd = new SqlCommand();
        //    cmd.ExecuteNonQuery();
        //    con.Close();

        //}
        public static void searchData()
        {
        //SELECT CustomerID, CompanyName, ContactName, ContactTitle,
        //Address, City, Region, PostalCode, Country, Phone, Fax
        //FROM Customers
        //WHERE City = @City
        }
 main

        private void InitializeComponent()
        {
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(652, 664);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(305, 24);
            this.comboBox1.TabIndex = 36;
            // 
            // Manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(1250, 784);
            this.Controls.Add(this.comboBox1);
            this.Name = "Manager";
            this.Controls.SetChildIndex(this.comboBox1, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
