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
    public partial class Host_Event : Form
    {
        public Host_Event()
        {
            InitializeComponent();
        }

        /*When button is clieked, it test it all the textboxes and comboboxes and correctly filled in. Then it
         insert te information in to HostEventTable.*/
        private void btnCreatEvent_Click(object sender, EventArgs e)
        {
            try
            {
                string testDate = "yyyy/MM/dd";

                if (txbEventName.Text != "")
                {
                    if (cbDescription.Text != "")
                    {
                        if (txbDate.Text != "" && DateTime.TryParseExact(txbDate.Text, testDate, System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None,out DateTime datepased))
                        {
                            if (txbTime.Text != "")
                            {
                                if (cbVenue.Text != "")
                                {
                                    if (cbCost.Text != "")
                                    {
                                        string venuechosen = cbVenue.Text;
                                        int capacity = 0, capacityTaken = 0;

                                        capacity = getCapacityValue(venuechosen);

                                        Log_in conect = new Log_in();

                                        conect.conn.Open();

                                        SqlCommand insertComm = new SqlCommand($"INSERT INTO HostEventTable VALUES ('{txbEventName.Text}', '{cbDescription.Text}', '{txbDate.Text}', '{txbTime.Text}', '{cbVenue.Text}', {capacity}, {capacityTaken}, '{cbCost.Text}', '{Log_in.userEmail}')", conect.conn);
                                        SqlDataAdapter adapter = new SqlDataAdapter();

                                        adapter.InsertCommand = insertComm;
                                        adapter.InsertCommand.ExecuteNonQuery();

                                        conect.conn.Close();

                                        MessageBox.Show("Sucsesfull Created Event");

                                        this.Close();
                                    }
                                    else
                                    {
                                        errorProviderHostEvent.SetError(cbCost, "Cant be left blank, please enter cost or select Free");
                                        cbCost.Focus();
                                    }
                                }
                                else
                                {
                                    errorProviderHostEvent.SetError(cbVenue, "Cant be left blank, please select venue");
                                    cbVenue.Focus();
                                }
                            }
                            else
                            {
                                errorProviderHostEvent.SetError(txbTime, "Cant be left blank, please enter time");
                                txbTime.Focus();
                            }
                        }
                        else
                        {
                            errorProviderHostEvent.SetError(txbDate, "Cant be left blank of invalid format, please enter date as follow yyyy/mm/dd");
                            txbDate.Focus();
                        }
                    }
                    else
                    {
                        errorProviderHostEvent.SetError(cbDescription, "Cant be left blank, please select option");
                        cbDescription.Focus();
                    }
                }
                else
                {
                    errorProviderHostEvent.SetError(txbEventName, "Cant be left blank, please enter event name");
                    txbEventName.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        /*Here a methoed was created to use switch statment to test witch venue was chosen and then to set the capatity value to a
         surten value*/
        public int getCapacityValue(string venuechosen)
        {
            int capacity = 0;

            switch (venuechosen)
            {
                case "Crystal Gardens Convention Center - Capacity: 1000":
                    {
                        capacity = 1000;
                        break;
                    }
                case "Starlight Ballroom - Capacity: 500":
                    {
                        capacity = 500;
                        break;
                    }
                case "Serenity Plaza - Capacity: 300":
                    {
                        capacity = 300;
                        break;
                    }
                case "Golden Pavilion - Capacity: 250":
                    {
                        capacity = 250;
                        break;
                    }
                case "Emerald Hall - Capacity: 200":
                    {
                        capacity = 200;
                        break;
                    }
                case "Moonbean Theater - Capacity: 150":
                    {
                        capacity = 150;
                        break;
                    }
                case "Harmony Lounge - Capacity: 100":
                    {
                        capacity = 100;
                        break;
                    }
            }

            return capacity;
        }

        /*Here a method was created to read value stored in HostEvantTable and the storing each of thous values in a sepprate variable 
         readed form the table.Then it used that variables to auto populate the textboxes for updateing a event information, beform user even
        stat to change information is textboxes, to help user*/
        public void EventDetailsSelected()
        {
            try
            {
                string tbEventName = "", tbDescription = "", tbDate = "", tbTime = "", tbVanue = "", tbCost = "";
                string tbId = Track_My_Events.iDTrackEventChosen;

                Log_in conect = new Log_in();

                conect.conn.Open();

                SqlCommand select = new SqlCommand($"SELECT Event_Name, Description, Date, Time, Venue, Cost FROM HostEventTable WHERE Id = '{tbId}'", conect.conn);
                SqlDataReader reader = select.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        tbEventName = reader.GetValue(0).ToString();
                        tbDescription = reader.GetValue(1).ToString();
                        tbDate = reader.GetValue(2).ToString();
                        tbTime = reader.GetValue(3).ToString();
                        tbVanue = reader.GetValue(4).ToString();
                        tbCost = reader.GetValue(5).ToString();
                    }

                    txbEventName.Text = tbEventName;
                    cbDescription.Text = tbDescription;
                    txbDate.Text = tbDate;
                    txbTime.Text = tbTime;
                    cbVenue.Text = tbVanue;
                    cbCost.Text = tbCost;
                }

                conect.conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /*Here some properties of layout get set to true and false so that the
         same forms layout apears diffrent for creat or update*/
        public void updateLayout()
        {
            btnCreatEvent.Visible = false;
            btnUpdateEvent2.Visible = true;
        }

        /*Here some properties of layout get set to true and false so that the
         same forms layout apears diffrent for creat or update*/
        public void updateLayout2()
        {
            btnCreatEvent.Visible = true;
            btnUpdateEvent2.Visible = false;
        }

        /*When button cancel2 is clieked, it close the form*/
        private void btnCancel2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /*When button updateEvent2 is clieked, it test if all the textboxes information is correct and the it update the information
         in both the HostEventTable and EventRegisterTable, and it display a message it sucssesful*/
        private void btnUpdateEvent2_Click(object sender, EventArgs e)
        {
            try
            {
                string testDate = "yyyy/MM/dd";
                
                if (txbEventName.Text != "")
                {
                    if (cbDescription.Text != "")
                    {
                        if (txbDate.Text != "" && DateTime.TryParseExact(txbDate.Text, testDate, System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None, out DateTime datepased))
                        {
                            if (txbTime.Text != "")
                            {
                                if (cbVenue.Text != "")
                                {
                                    if (cbCost.Text != "")
                                    {
                                        DialogResult dailog = MessageBox.Show("Are you Sure you want to update event.", "Update Event", MessageBoxButtons.YesNo);
                                        if (dailog == DialogResult.Yes)
                                        {
                                            string venuechosen2 = cbVenue.Text;
                                            int capacity2 = 0;

                                            capacity2 = getCapacityValue(venuechosen2);

                                            Log_in conect = new Log_in();

                                            conect.conn.Open();

                                            SqlCommand updateComm = new SqlCommand($"UPDATE HostEventTable SET Event_Name = '{txbEventName.Text}', Description = '{cbDescription.Text}', Date = '{txbDate.Text}', Time = '{txbTime.Text}', Venue = '{cbVenue.Text}', Capacity = {capacity2}, Cost = '{cbCost.Text}' WHERE Id = '{Track_My_Events.iDTrackEventChosen}'", conect.conn);
                                            SqlDataAdapter adapter = new SqlDataAdapter();

                                            adapter.UpdateCommand = updateComm;
                                            adapter.UpdateCommand.ExecuteNonQuery();

                                            conect.conn.Close();

                                            conect.conn.Open();

                                            updateComm = new SqlCommand($"UPDATE EventRegisterTable SET Event_Name = '{txbEventName.Text}', Description = '{cbDescription.Text}', Date = '{txbDate.Text}', Time = '{txbTime.Text}', Venue = '{cbVenue.Text}', Capacity = {capacity2}, Cost = '{cbCost.Text}' WHERE Id = '{Track_My_Events.iDTrackEventChosen}'", conect.conn);
                                            adapter = new SqlDataAdapter();

                                            adapter.UpdateCommand = updateComm;
                                            adapter.UpdateCommand.ExecuteNonQuery();

                                            MessageBox.Show("Sucsesfull Updated Event");

                                            this.Close();
                                        }
                                    }
                                    else
                                    {
                                        errorProviderHostEvent.SetError(cbCost, "Cant be left blank, please enter cost or select Free");
                                        cbCost.Focus();
                                    }
                                }
                                else
                                {
                                    errorProviderHostEvent.SetError(cbVenue, "Cant be left blank, please select venue");
                                    cbVenue.Focus();
                                }
                            }
                            else
                            {
                                errorProviderHostEvent.SetError(txbTime, "Cant be left blank, please enter time");
                                txbTime.Focus();
                            }
                        }
                        else
                        {
                            errorProviderHostEvent.SetError(txbDate, "Cant be left blank of invalid format, please enter date as follow yyyy/mm/dd");
                            txbDate.Focus();
                        }
                    }
                    else
                    {
                        errorProviderHostEvent.SetError(cbDescription, "Cant be left blank, please select option");
                        cbDescription.Focus();
                    }
                }
                else
                {
                    errorProviderHostEvent.SetError(txbEventName, "Cant be left blank, please enter event name");
                    txbEventName.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /*the rest of the code below is where all the errorProviders get cleared*/
        private void txbEventName_TextChanged(object sender, EventArgs e)
        {
            errorProviderHostEvent.SetError(txbEventName, "");
        }

        private void cbDescription_SelectedIndexChanged(object sender, EventArgs e)
        {
            errorProviderHostEvent.SetError(cbDescription, "");
        }

        private void txbDate_TextChanged(object sender, EventArgs e)
        {
            errorProviderHostEvent.SetError(txbDate, "");
        }

        private void txbTime_TextChanged(object sender, EventArgs e)
        {
            errorProviderHostEvent.SetError(txbTime, "");
        }

        private void cbVenue_SelectedIndexChanged(object sender, EventArgs e)
        {
            errorProviderHostEvent.SetError(cbVenue, "");
        }

        private void cbCost_SelectedIndexChanged(object sender, EventArgs e)
        {
            errorProviderHostEvent.SetError(cbCost, "");
        }
    }
}
