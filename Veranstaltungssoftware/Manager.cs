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
        
        public static int ID;
        //df


        public static string NameofDB;
        public static string NameofTBL;
        public static SqlConnection con;

   
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
    
        //Tabelle
        public static void createTable()
        {
            //Funktioniert nicht
            try
            {
                con = new SqlConnection(ConnectionString);
                con.Open();

                SqlCommand com = new SqlCommand("CREATE TABLE guests(ID varchar(200), Vorname varchar(20), Nachname varchar(20), Geburtsdatum varchar(20)");
                com.ExecuteNonQuery();
                SqlCommand cmd = new SqlCommand("CREATE TABLE event(ID varchar(200), NamedesEvents varchar(50), AnzahlderGaeste varchar(50), ", con);
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

    }
}
