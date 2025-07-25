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
    public partial class Register_For_Event : Form
    {
        public Register_For_Event()
        {
            InitializeComponent();
        }

        //create globle field variable
        public static string testForInvoice = "";

        /*When button is clieked it test information entered into txtboxes and comboboxes. after that it
         it auto fill it the textboxes and so of waht it was and help the user to only change what they want.
        then it read data into variables from table HostEventTable. Then it test if the event still has a opening
        left by looking at capacity_taken, and if it does. it increment capacity_Taken coulom. if full a message pop up.
        if it was not full it also load user and event data into EventRegisterTable*/
        private void btnRegisterForEvent_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dailog = MessageBox.Show("Are you Sure to register for this Event.", "Register Event", MessageBoxButtons.YesNo);
                if(dailog == DialogResult.Yes)
                {
                    if (!string.IsNullOrWhiteSpace(txbName.Text))
                    {
                        if (txbSurname.Text != "")
                        {
                            if (!string.IsNullOrWhiteSpace(txbCellphoneNr.Text) && txbCellphoneNr.Text.All(char.IsDigit) && txbCellphoneNr.Text.Length == 10)
                            {
                                if (cbGender.Text != "")
                                {
                                    string tbEventName = "", tbDescription = "", tbDate = "", tbTime = "", tbVanue = "", tbCapacity2 = "", tbCost = "", Name = "", Surname = "", Cellphone = "", Gender = "", tbCapacity_Taken2 = "";
                                    int tbCapacity = 0, tbCapacity_Taken = 0;

                                    Name = txbName.Text;
                                    Surname = txbSurname.Text;
                                    Cellphone = txbCellphoneNr.Text;
                                    Gender = cbGender.Text;

                                    Log_in conect = new Log_in();

                                    conect.conn.Open();

                                    SqlCommand select = new SqlCommand($"SELECT Event_Name, Description, Date, Time, Venue, Capacity, Capacity_Taken, Cost FROM HostEventTable WHERE Id = '{MainForm.NumberID}'", conect.conn);
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
                                            tbCapacity = (int)reader.GetValue(5);
                                            tbCapacity_Taken = (int)reader.GetValue(6);
                                            tbCost = reader.GetValue(7).ToString();
                                        }
                                    }

                                    conect.conn.Close();

                                    if (tbCapacity_Taken < tbCapacity)
                                    {
                                        tbCapacity_Taken += 1;

                                        conect.conn.Open();

                                        SqlCommand updateComm = new SqlCommand($"UPDATE HostEventTable SET Capacity_Taken = {tbCapacity_Taken} WHERE Id = '{MainForm.NumberID}'", conect.conn);
                                        SqlDataAdapter adapter = new SqlDataAdapter();

                                        adapter.UpdateCommand = updateComm;
                                        adapter.UpdateCommand.ExecuteNonQuery();

                                        conect.conn.Close();

                                        conect.conn.Open();

                                        SqlCommand insertComm = new SqlCommand($"INSERT INTO EventRegisterTable VALUES ('{MainForm.NumberID}', '{tbEventName}', '{tbDescription}', '{tbDate}', '{tbTime}', '{tbVanue}', {tbCapacity}, {tbCapacity_Taken}, '{tbCost}', '{Log_in.userEmail}', '{Name}', '{Surname}', '{Cellphone}', '{Gender}')", conect.conn);
                                        adapter = new SqlDataAdapter();

                                        adapter.InsertCommand = insertComm;
                                        adapter.InsertCommand.ExecuteNonQuery();

                                        conect.conn.Close();

                                        MessageBox.Show("Sucsesfull Registered for Event");

                                        Invoice.invName = Name;
                                        Invoice.invSurname = Surname;
                                        Invoice.invEmail = Log_in.userEmail;
                                        Invoice.invCellphone = Cellphone;
                                        Invoice.invEventName = tbEventName;
                                        Invoice.invDecription = tbDescription;
                                        Invoice.invDate = tbDate;
                                        Invoice.invTime = tbTime;
                                        Invoice.invVenue = tbVanue;
                                        Invoice.invCost = tbCost;

                                        testForInvoice = "Yes";

                                        this.Close();
                                    }
                                    else
                                    {
                                        MessageBox.Show("Event Capasity is full");
                                    }

                                }
                                else
                                {
                                    errorProviderRegisterForEvent.SetError(cbGender, "Cant be blank, please select your gender");
                                    cbGender.Focus();
                                }
                            }
                            else
                            {
                                errorProviderRegisterForEvent.SetError(txbCellphoneNr, "Cant be blank, please enter your cellphone number and must be 10 digits long");
                                txbCellphoneNr.Focus();
                            }
                        }
                        else
                        {
                            errorProviderRegisterForEvent.SetError(txbSurname, "Cant be blank, please enter a your surname");
                            txbSurname.Focus();
                        }
                    }
                    else
                    {
                        errorProviderRegisterForEvent.SetError(txbName, "Cant be blank, please enter a your name");
                        txbName.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //when button cancel is clieked it close the form
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //When form load it calls a method
        private void Register_For_Event_Load(object sender, EventArgs e)
        {
            AutoFillTxbBoxes();
        }

        /*Here a method was used to select data form clientinfo and then autofilled the txtboxes and comcoboxes 
         * with data and to store the data in veriables*/
        public void AutoFillTxbBoxes()
        {
            try
            {
                string tbName = "", tbSurname = "", tbCellphone = "", tbGender = "";

                Log_in conect = new Log_in();

                conect.conn.Open();

                SqlCommand select = new SqlCommand($"SELECT Name, Surname, Cellphone, Geneder FROM ClientInfo WHERE Email = '{Log_in.userEmail}'", conect.conn);
                SqlDataReader reader = select.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        tbName = reader.GetValue(0).ToString();
                        tbSurname = reader.GetValue(1).ToString();
                        tbCellphone = reader.GetValue(2).ToString();
                        tbGender = reader.GetValue(3).ToString();
                    }

                    txbName.Text = tbName;
                    txbSurname.Text = tbSurname;
                    txbCellphoneNr.Text = tbCellphone;
                    cbGender.Text = tbGender;
                }

                conect.conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /*the rest of the code below is where all the errorProviders gets cleared*/
        private void txbName_TextChanged(object sender, EventArgs e)
        {
            errorProviderRegisterForEvent.SetError(txbName, "");
        }

        private void txbSurname_TextChanged(object sender, EventArgs e)
        {
            errorProviderRegisterForEvent.SetError(txbSurname, "");
        }

        private void txbCellphoneNr_TextChanged(object sender, EventArgs e)
        {
            errorProviderRegisterForEvent.SetError(txbCellphoneNr, "");
        }

        private void cbGender_SelectedIndexChanged(object sender, EventArgs e)
        {
            errorProviderRegisterForEvent.SetError(cbGender, "");
        }
    }
}
