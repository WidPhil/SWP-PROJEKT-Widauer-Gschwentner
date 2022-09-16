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
    public partial class VeranstaltungsForm : Form
    {
        #region variables
 Daniel
        public static string NamedesEvents;
        public static string VorliebederGetränke;
        public static string VorliebederSpeisen;
        public static string Strasse;
        public static string ArtderVeranstaltung;
        public static decimal Budget;
        public static string Hausnummer;
        public static string PLZ;



        public static string NameofTable;
        public static string name;
        public static string food;
        public static string drinks;
        public static string DJ;
        public static string Street;
        public static string TypeofEvent;
        public static decimal Budget;
        public static string housecode;
        public static string zip;
        public static decimal guests;
        public static string NameofCreator;
        public static string emailofCreator;
        public DateTime datetime;
 main
        #endregion



        public VeranstaltungsForm()
        {
            InitializeComponent();
        }

      

        private void btn_createEvent_Click_1(object sender, EventArgs e)
        {
                name = txt_nameEvent.Text;
                drinks = textBoxGetränke.Text;
                food = textBoxEssen.Text;
                Street = textBoxStreet.Text;
                housecode = txt_houseNumber.Text;
                zip = txt_PLZ.Text;
                guests = NUD_guests.Value;
                TypeofEvent = textBoxEvent.Text;
                Budget = numericUpDownBudget.Value;
                NameofCreator = txtbox_nameofCreator.Text;
                emailofCreator = txtbox_emailofcreator.Text;
                datetime = dtp_datetime.Value;
                Manager.createTable();
        }

        private void btn_TableGuests_Click(object sender, EventArgs e)
        {
            Grid grid = new Grid();
            grid.Show();

        }

        private void btn_showEvent_Click(object sender, EventArgs e)
        {

        }

        private void btn_showTable_Click(object sender, EventArgs e)
        {
 Daniel
           
        }

        private void btn_createEvent_Click_1(object sender, EventArgs e)
        {
                NamedesEvents = txt_nameEvent.Text;
                VorliebederGetränke = textBoxGetränke.Text;
                VorliebederSpeisen = textBoxEssen.Text;
                Strasse = textBoxStreet.Text;
                Hausnummer = txt_houseNumber.Text;
                PLZ = txt_PLZ.Text;
                ArtderVeranstaltung = textBoxEvent.Text;
                Budget = numericUpDownBudget.Value;
                Manager.createTBL();
            

            cb_NameofTable.Text = NameofTable;
 main
        }
    }
}
