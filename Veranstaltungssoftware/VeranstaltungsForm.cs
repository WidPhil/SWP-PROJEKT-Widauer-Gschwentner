﻿using System;
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
        public static string NamedesEvents;
        public static string VorliebederGetränke;
        public static string VorliebederSpeisen;
        public static string Strasse;
        public static string ArtderVeranstaltung;
        public static decimal Budget;
        public static string Hausnummer;
        public static string PLZ;


        #endregion
        public VeranstaltungsForm()
        {
            InitializeComponent();
        }

        private void lbl_veranstaltungsform_Click(object sender, EventArgs e)
        {

        }

        private void lbl_guests_Click(object sender, EventArgs e)
        {

        }

        private void lbl_dj_Click(object sender, EventArgs e)
        {

        }

        private void lbl_getränke_Click(object sender, EventArgs e)
        {

        }

        private void lbl_Essen_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lbl_party_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txt_nameEvent_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_createEvent_Click(object sender, EventArgs e)
        {
           
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
            
        }
    }
}
