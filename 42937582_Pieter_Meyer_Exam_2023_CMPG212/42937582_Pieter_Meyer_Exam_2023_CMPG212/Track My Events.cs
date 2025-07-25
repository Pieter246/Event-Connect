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
    public partial class Track_My_Events : Form
    {
        public Track_My_Events()
        {
            InitializeComponent();
        }

        //created global field variable
        public static string iDTrackEventChosen = "";

        //When form loads it calls methods and clear textbox
        private void Track_My_Events_Load(object sender, EventArgs e)
        {
            fillComboBox();
            showYourCreatedEvents();
            cbIdTrackEvents.Text = "";
        }

        /*Here a method was created to populate the combocboxes with date by 
         using select statment and table HostEventTable*/
        public void fillComboBox()
        {
            try
            {

                Log_in conect = new Log_in();

                conect.conn.Open();

                SqlCommand fillNameSearch = new SqlCommand($"SELECT Id From HostEventTable WHERE Host_Email = '{Log_in.userEmail}'", conect.conn);
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = fillNameSearch;

                DataTable table = new DataTable();
                adapter.Fill(table);
                cbIdTrackEvents.DataSource = table;
                cbIdTrackEvents.DisplayMember = "Id";
                cbIdTrackEvents.ValueMember = "Id";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /*Here method was created to select date form table HostEventTable and then
         display the data in a data grid view*/
        public void showYourCreatedEvents()
        {
            try
            {
                Log_in conect = new Log_in();

                conect.conn.Open();

                SqlCommand selectComm = new SqlCommand($"SELECT Id, Event_Name, Description, Date, Time, Venue, Capacity, Capacity_Taken, Cost FROM HostEventTable WHERE Host_Email = '{Log_in.userEmail}'", conect.conn);
                SqlDataAdapter adapter = new SqlDataAdapter();
                DataSet ds = new DataSet();

                adapter.SelectCommand = selectComm;
                adapter.Fill(ds, "HostEventTable");

                dgvDisplayHostingEvents.DataSource = ds;
                dgvDisplayHostingEvents.DataMember = "HostEventTable";

                conect.conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /*When button is clieked, it sets if combobox is not emty and then it loads a nother form
         and calls other methods*/
        private void btnUpdateEvent_Click(object sender, EventArgs e)
        {
            if (cbIdTrackEvents.Text != "")
            {
                iDTrackEventChosen = cbIdTrackEvents.Text;
                Host_Event myform = new Host_Event();
                myform.EventDetailsSelected();
                myform.updateLayout();
                myform.ShowDialog();

                fillComboBox();
                showYourCreatedEvents();
            }
            else
            {
                MessageBox.Show("Please select id in comboBox");
            }
            
        }

        /*When button is clieked, it cheked combobox and then it ask with message it you are sure to
         deliet. And if yes, then it use delete statment to delete row from tabels HostEventTabel and EventRegisterTable*/
        private void btnDeleteEvent_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbIdTrackEvents.Text != "")
                {
                    DialogResult dailog = MessageBox.Show("Are you Sure you want to Delete event.", "Delete Event", MessageBoxButtons.YesNo);
                    if (dailog == DialogResult.Yes)
                    {
                        iDTrackEventChosen = cbIdTrackEvents.Text;

                        Log_in conect = new Log_in();

                        conect.conn.Open();

                        SqlCommand updateComm = new SqlCommand($"DELETE FROM HostEventTable WHERE Id = '{iDTrackEventChosen}'", conect.conn);
                        SqlDataAdapter adapter = new SqlDataAdapter();

                        adapter.DeleteCommand = updateComm;
                        adapter.DeleteCommand.ExecuteNonQuery();

                        conect.conn.Close();

                        conect.conn.Open();

                        updateComm = new SqlCommand($"DELETE FROM EventRegisterTable WHERE Id = '{iDTrackEventChosen}'", conect.conn);
                        adapter = new SqlDataAdapter();

                        adapter.DeleteCommand = updateComm;
                        adapter.DeleteCommand.ExecuteNonQuery();

                        conect.conn.Close();

                        fillComboBox();
                        showYourCreatedEvents();

                        MessageBox.Show("Sucsesfull Deleted Event");
                    }
                }
                else
                {
                    MessageBox.Show("Please select id in comboBox");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //When button cancel is clieked, the form closes
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //When button is clieked, it check combocox and then it load a nother form
        private void btnViewParticipants_Click(object sender, EventArgs e)
        {
            if (cbIdTrackEvents.Text != "")
            {
                iDTrackEventChosen = cbIdTrackEvents.Text;
                Participants myform = new Participants();
                myform.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please select id in comboBox");
            }
        }
    }
}
