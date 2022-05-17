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
                Manager.createTBL();
        }

        private void btn_TableGuests_Click(object sender, EventArgs e)
        {
            Grid grid = new Grid();
            grid.Show();

        }
    }
}
