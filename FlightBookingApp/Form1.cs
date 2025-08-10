using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlightBookingApp
{
    public partial class Form1 : Form
    {

        public static bool Passport, IDcard;
        public static string To, From, StartTripDate, EndTripDate, firstname, lastname, DocumentNo, Issuedate, Expirydate, BaggageWeight;

        private void btnbook_Click(object sender, EventArgs e)
        {
            
            To = txtto.Text;
            From = txtfrom.Text;

            StartTripDate = monthCalendar1.SelectionStart.ToString("dd MMM yyyy");
            EndTripDate = monthCalendar1.SelectionEnd.ToString("dd MMM yyyy");

            firstname = txtfname.Text;
            lastname = txtlname.Text;
            DocumentNo = txtdocnum.Text;

            Issuedate = dateTimePicker1.Value.ToString("dd MMM yyyy");
            Expirydate = dateTimePicker2.Value.ToString("dd MMM yyyy");

            BaggageWeight = numericUpDown1.Value.ToString();

            this.Hide();
            Form2 ff2 = new Form2();
            ff2.Show();
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            numericUpDown1.Increment = 5;
            numericUpDown1.ReadOnly = true;
            monthCalendar1.MaxSelectionCount = 100;
            monthCalendar1.ShowToday = true;


        }

        private void rbid_CheckedChanged(object sender, EventArgs e)
        {
            if (rbid.Checked)
            {
                lbldocnum.Text = "ID No:";
                dateTimePicker1.Text = "ID Issue Date:";
                dateTimePicker2.Text = "ID Expiry Date:";

                IDcard = true;
            }
            else 
            {
                IDcard = false;
            }
        }

        private void lblissuedate_ValueChanged(object sender, EventArgs e)
        {
            DateTime dt = dateTimePicker1.Value;
            dateTimePicker2.MinDate = dt;
        }

        private void rbpassport_CheckedChanged(object sender, EventArgs e)
        {
            if (rbpassport.Checked)
            {
                lbldocnum.Text = "Passport No:";
                lblissuedate.Text = "Passport Issue Date:";
                lblexpirydate.Text = "Passport Expiry Date:";

                Passport = true;
            }
            else
            {
                Passport = false;
            }
        }
    }
}
