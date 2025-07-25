using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _42937582_Pieter_Meyer_Exam_2023_CMPG212
{
    public partial class Invoice : Form
    {
        public Invoice()
        {
            InitializeComponent();
        }

        //Here globel field variables is used to get information on a nother form
        public static string invName = "", invSurname = "", invEmail = "", invCellphone = "", invEventName = "", invDecription = "", invDate = "", invTime = "", invVenue = "", invCost = "";
        
        //Here when the form loads it set the labels to the variables.
        private void Invoice_Load(object sender, EventArgs e)
        {
            lblInvName.Text = invName;
            lblInvSurname.Text = invSurname;
            lblInvEmail.Text = invEmail;
            lblInvCellphone.Text = invCellphone;
            lblInvEventName.Text = invEventName;
            lblInvDecription.Text = invDecription;
            lblInvDate.Text = invDate;
            lblInvTime.Text = invTime;
            lblInvVenue.Text = invVenue;
            lblInvCost.Text = invCost;
        }
    }
}
