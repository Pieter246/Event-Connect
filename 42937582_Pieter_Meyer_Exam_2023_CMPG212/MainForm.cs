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

namespace _42937582_Pieter_Meyer_Exam_2023_CMPG212
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        //create globle field variable
        public static string NumberID = "";

        /*When your upcoming event is clieked in menustrip, it change some of the controns visabilaty
         on form, so that same form is used. Then it selects all the data in table EventRegisterTable,
        where it is then displayed in a datagridvied to user*/
        private void yourUpcomingEventsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                gbSearch.Visible = false;
                btnRegForEvent.Visible = false;
                cbId.Visible = false;
                lblId.Visible = false;
                lblSumery.Text = "Your upcoming events";

                Log_in conect = new Log_in();

                conect.conn.Open();

                SqlCommand selectComm = new SqlCommand($"SELECT Id, Event_Name, Description, Date, Time, Venue, Capacity, Cost FROM EventRegisterTable WHERE Register_Email = '{Log_in.userEmail}'", conect.conn);
                SqlDataAdapter adapter = new SqlDataAdapter();
                DataSet ds = new DataSet();

                adapter.SelectCommand = selectComm;
                adapter.Fill(ds, "HostEventTable");

                dgvDisplay.DataSource = ds;
                dgvDisplay.DataMember = "HostEventTable";

                conect.conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //When Upcomming event is clieked in menustrip it calles twe methods
        private void upcomingEventsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fillSearchDropBoxes();
            showUpcomingEvents();
        }

        /*When your event History is clieked in menustrip, it change some of the controns visabilaty
         on form, so that same form is used. Then it selects all the data in table EventRegisterTable,
        where it is then displayed in a datagridvied to user*/
        private void eventHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                gbSearch.Visible = false;
                btnRegForEvent.Visible = false;
                cbId.Visible = false;
                lblId.Visible = false;
                lblSumery.Text = "Events History";

                DateTime currentDate = DateTime.Now;
                string toDaysDate = currentDate.ToString("yyyy/MM/dd");

                Log_in conect = new Log_in();

                conect.conn.Open();

                SqlCommand selectComm = new SqlCommand($"SELECT Id, Event_Name, Description, Date, Time, Venue, Capacity, Capacity_Taken, Cost FROM HostEventTable WHERE DATE < '{toDaysDate}'", conect.conn);
                SqlDataAdapter adapter = new SqlDataAdapter();
                DataSet ds = new DataSet();

                adapter.SelectCommand = selectComm;
                adapter.Fill(ds, "HostEventTable");

                dgvDisplay.DataSource = ds;
                dgvDisplay.DataMember = "HostEventTable";

                conect.conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /*When create event menustrip is clieked it loads a form Host_Event and calls other
         methods.*/
        private void createEventToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Host_Event myform = new Host_Event();
            myform.updateLayout2();
            myform.ShowDialog();
            
            fillSearchDropBoxes();
            showUpcomingEvents();
        }

        //When mainform load it calles methods
        private void MainForm_Load(object sender, EventArgs e)
        {
            premuimMember();
            fillSearchDropBoxes();
            showUpcomingEvents();
        }

        /*Here a method ia created to test if user is premium or not. And if
         the user is premium it will enable user to be able to host events*/
        public void premuimMember()
        {
            if (Log_in.tablePremuim == "Yes")
            {
                hostEventsToolStripMenuItem.Enabled = true;
            }
        }

        /*Here a method was created to set some visibality property of controls to
         use the same form and then to select data form table HostEventTable, where it
        then populated the comboboxes with data from table*/
        public void fillSearchDropBoxes()
        {
            try
            {
                gbSearch.Visible = true;
                btnRegForEvent.Visible = true;
                cbId.Visible = true;
                lblId.Visible = true;

                DateTime currentDate = DateTime.Now;
                string toDaysDate = currentDate.ToString("yyyy/MM/dd");

                Log_in conect = new Log_in();

                conect.conn.Open();

                SqlCommand fillNameSearch = new SqlCommand($"SELECT Id, Event_Name, Date From HostEventTable WHERE DATE >= '{toDaysDate}'", conect.conn);
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = fillNameSearch;

                DataTable table = new DataTable();
                adapter.Fill(table);
                cbNameSearch.DataSource = table;
                cbNameSearch.DisplayMember = "Event_Name";
                cbNameSearch.ValueMember = "Event_Name";

                cbDateSearch.DataSource = table;
                cbDateSearch.DisplayMember = "Date";
                cbDateSearch.ValueMember = "Date";

                cbId.DataSource = table;
                cbId.DisplayMember = "Id";
                cbId.ValueMember = "Id";

                conect.conn.Close();

                cbNameSearch.Text = "";
                cbDateSearch.Text = "";
                cbVenueSearch.Text = "";
                cbDescSearch.Text = "";
                cbId.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /*Here a method was used to display upcoming events the moment the form load, and it 
         used the select statment to get data from table HostEventTable*/
        public void showUpcomingEvents()
        {
            try
            {
                lblSumery.Text = "Upcoming Events";
                DateTime currentDate = DateTime.Now;
                string toDaysDate = currentDate.ToString("yyyy/MM/dd");

                Log_in conect = new Log_in();

                conect.conn.Open();

                SqlCommand selectComm = new SqlCommand($"SELECT Id, Event_Name, Description, Date, Time, Venue, Capacity, Capacity_Taken, Cost FROM HostEventTable WHERE DATE >= '{toDaysDate}'", conect.conn);
                SqlDataAdapter adapter = new SqlDataAdapter();
                DataSet ds = new DataSet();

                adapter.SelectCommand = selectComm;
                adapter.Fill(ds, "HostEventTable");

                dgvDisplay.DataSource = ds;
                dgvDisplay.DataMember = "HostEventTable";

                conect.conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /*When the search button is clieked, it use the textboxed information to
         search form data equwalent to to data in text boxes, by using select statment
        and table HostEventTable*/
        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime currentDate = DateTime.Now;
                string toDaysDate = currentDate.ToString("yyyy/MM/dd");

                Log_in conect = new Log_in();

                conect.conn.Open();

                SqlCommand selectComm = new SqlCommand($"SELECT Id, Event_Name, Description, Date, Time, Venue, Capacity, Capacity_Taken, Cost FROM HostEventTable WHERE Event_Name LIKE '%{cbNameSearch.Text}%' and Date LIKE '%{cbDateSearch.Text}%'and DATE >= '{toDaysDate}' and Venue LIKE '%{cbVenueSearch.Text}%' and Description LIKE '%{cbDescSearch.Text}%'", conect.conn);
                SqlDataAdapter adapter = new SqlDataAdapter();
                DataSet ds = new DataSet();

                adapter.SelectCommand = selectComm;
                adapter.Fill(ds, "HostEventTable");

                dgvDisplay.DataSource = ds;
                dgvDisplay.DataMember = "HostEventTable";

                conect.conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /*When button register for event is clieked, it load a new form and after it return. It 
         calles methods and test if user wants to se invoice for event, witch loades a nothes form then*/
        private void btnRegForEvent_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbId.Text != "")
                {
                    NumberID = cbId.Text;
                    Register_For_Event myform = new Register_For_Event();
                    myform.ShowDialog();

                    fillSearchDropBoxes();
                    showUpcomingEvents();

                    if (Register_For_Event.testForInvoice == "Yes")
                    {
                        DialogResult dailog = MessageBox.Show("Do you want a Invoice", "Invoice", MessageBoxButtons.YesNo);
                        if (dailog == DialogResult.Yes)
                        {
                            Invoice myinvoice = new Invoice();
                            myinvoice.ShowDialog();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("id drobdownBox not selected, please select a id namber for row to want to register for");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /*when view event created menustrip is clieked it loads a nother form and call methods*/
        private void viewEventsCreatedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Track_My_Events myform = new Track_My_Events();
            myform.ShowDialog();

            fillSearchDropBoxes();
            showUpcomingEvents();
        }

        /*when view update menustrip is clieked it loads a nother form and call methods*/
        private void viewUpdateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Register myform = new Register();
            myform.ClientInfoDetailsSelected();
            myform.updateLayoutRegister();
            myform.ShowDialog();
        }

        //when log out menustrip is clieked it close the form
        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //When change password menustrip is clieked, it load a nother form
        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Change_Password myform = new Change_Password();
            myform.ShowDialog();
        }

        /*when upgrade to premium is clieked in menustrip, it test if user and not a premium member.
         if not it loads a nother form where user must chose yes or no and it yes was chosen it change the
        enable on hosting events in menustrip. if user alredy a premium member it only show pop up message*/
        private void membershipInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                string tbPremium = "", testAnswer = "";

                tbPremium = CheckPremium();

                if (tbPremium == "No")
                {
                    Upgrade_to_Premuim myform = new Upgrade_to_Premuim();
                    myform.ShowDialog();
                }
                else
                {
                    MessageBox.Show("You are already a premium member");
                }

                testAnswer = CheckPremium();

                if (testAnswer == "Yes")
                {
                    hostEventsToolStripMenuItem.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /*here n method was used to store user update premium choce and use it for testing*/
        public string CheckPremium()
        {
            string tbPremium = "";

            Log_in conect = new Log_in();

            conect.conn.Open();

            SqlCommand select = new SqlCommand($"SELECT Premuim FROM ClientInfo WHERE Email = '{Log_in.userEmail}'", conect.conn);
            SqlDataReader reader = select.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    tbPremium = reader.GetValue(0).ToString();
                }
            }

            return tbPremium;
        }
    }
}
