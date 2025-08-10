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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            lblfname.Text = Form1.firstname + " " + Form1.lastname;
            lbldeparturecity.Text = Form1.From;
            lbldestination.Text = Form1.To;
            lbltripdates.Text = Form1.StartTripDate + " to " + Form1.EndTripDate;
            lbldocnum.Text = Form1.DocumentNo;
            lblexpiry.Text = Form1.Expirydate;
            lblweight.Text = Form1.BaggageWeight;

            if (Form1.Passport)
            {
                lblchangedoc.Text = "Passport num:";
                lblchangeexpiry.Text = "Passport expiry:";
            }
            if (Form1.IDcard)
            {
                lblchangedoc.Text = "ID card num:";
                lblchangeexpiry.Text = "ID card expiry:";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
