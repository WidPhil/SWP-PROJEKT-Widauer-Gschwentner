using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Veranstaltungssoftware
{
    class Manager
    {
        public static string ConnectionString = "server = (localdb)\\MSSQLLocalDB;Database =" + NameofDB + ";Integrated Security = true";

    
        //public static List<string> colList = new List<string>(3);

        public static int iForDatabases;
        public static int iForTables;

        public static string preferedbeverage = Veranstaltung.VorliebederGetränke;
        public static string preferedfood = Veranstaltung.VorliebederSpeisen;
        public static string street = Veranstaltung.Strasse;
        public static string house = Veranstaltung.Hausnummer;
        public static string postcode = Veranstaltung.PLZ;
        public static string typeofEvent = Veranstaltung.TypeofEvent;
       

        //public static Login connect = new Login();
        public static string NameofDB;
        public static string NewNameofDB;
        public static string NameofTBL;
        public static SqlConnection con;



        //cmd.ExecuteNonQuery();
   
        //Datenbank erstellen, löschen und verändern

        public static void createDB()
        {
            try
            {
                con = new SqlConnection(ConnectionString);
                con.Open();
                SqlCommand cmd = new SqlCommand("CREATE DATABASE " + NameofDB, con);
                cmd.ExecuteNonQuery();
                iForDatabases++;
                SqlCommand com = new SqlCommand("USE DATABASE " + NameofDB, con);
                com.ExecuteNonQuery();

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
        public static void createTBL()
        {
            //Funktioniert nicht
            try
            {
                con = new SqlConnection(ConnectionString);
                con.Open();
                SqlCommand cmd = new SqlCommand("CREATE TABLE " + NameofTBL + " (" + "'" + Column1 + "' " + "INT PRIMARY KEY," + " '" + Column2 + "' " + "VARCHAR NOT NULL," + " '" + Column3 + "' " + "VARCHAR NOT NULL," + " '" + Column4 + "' " + "VARCHAR NOT NULL" + ");", con);
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
        public static void AlterTBL()
        {
            con = new SqlConnection(ConnectionString);
            con.Open();
          
            SqlCommand cmd = new SqlCommand();
            cmd.ExecuteNonQuery();
            con.Close();

        }

    }
}
