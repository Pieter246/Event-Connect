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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        /*When button is clieked, it test all the txtxboxes and comboboxes value entered and then it
         insert the data into the clientinfo table*/
        private void btnNewRegister_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(txbName.Text))
                {
                    if (txbSurname.Text != "")
                    {
                        if (!string.IsNullOrWhiteSpace(txbCellphoneNr.Text) && txbCellphoneNr.Text.All(char.IsDigit) && txbCellphoneNr.Text.Length == 10)
                        {
                            if (cbGender.Text != "")
                            {
                                if (cbPremuimMember.Text != "")
                                {
                                    if (!string.IsNullOrWhiteSpace(txbEmail.Text))
                                    {
                                        if (testEmailAdress() == true)
                                        {
                                            if (!string.IsNullOrWhiteSpace(txbCreatePasword.Text))
                                            {
                                                if (testPassword() == true)
                                                {
                                                    
                                                    Log_in conect = new Log_in();

                                                    conect.conn.Open();

                                                    SqlCommand insertComm = new SqlCommand($"INSERT INTO ClientInfo VALUES ('{txbName.Text}', '{txbSurname.Text}', '{txbCellphoneNr.Text}', '{txbEmail.Text}', '{cbGender.Text}', '{txbCreatePasword.Text}', '{cbPremuimMember.Text}')", conect.conn);
                                                    SqlDataAdapter adapter = new SqlDataAdapter();

                                                    adapter.InsertCommand = insertComm;
                                                    adapter.InsertCommand.ExecuteNonQuery();

                                                    conect.conn.Close();

                                                    MessageBox.Show("Sucsesfull registerd");

                                                    this.Close();
                                                }
                                                else
                                                {
                                                    errorProviderRegister.SetError(txbCreatePasword, "invalid password");
                                                    txbCreatePasword.Focus();
                                                }
                                            }
                                            else
                                            {
                                                errorProviderRegister.SetError(txbCreatePasword, "Cant be blank or have whiteSpaces, must have one capatil leters and two numbers and one symbol and must be 6 characters long or more");
                                                txbCreatePasword.Focus();
                                            }
                                        }
                                        else
                                        {
                                            errorProviderRegister.SetError(txbEmail, "invalid email address");
                                            txbEmail.Focus();
                                        }
                                    }
                                    else
                                    {
                                        errorProviderRegister.SetError(txbEmail, "Cant be blank or have whiteSpaces, please enter your email address");
                                        txbEmail.Focus();
                                    }
                                }
                                else
                                {
                                    errorProviderRegister.SetError(cbPremuimMember, "Cant be blank, please select choice");
                                    cbPremuimMember.Focus();
                                }
                            }
                            else
                            {
                                errorProviderRegister.SetError(cbGender, "Cant be blank, please select your gender");
                                cbGender.Focus();
                            }
                        }
                        else
                        {
                            errorProviderRegister.SetError(txbCellphoneNr, "Cant be blank, please enter your cellphone number and must be 10 digits long");
                            txbCellphoneNr.Focus();
                        }
                    }
                    else
                    {
                        errorProviderRegister.SetError(txbSurname, "Cant be blank, please enter a your surname");
                        txbSurname.Focus();
                    }
                }
                else
                {
                    errorProviderRegister.SetError(txbName, "Cant be blank, please enter a your name");
                    txbName.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Here method was used to help test for valid email adress
        public bool testEmailAdress()
        {
            bool test = false;
            string userEmail = txbEmail.Text;
            int number = 0;
            foreach (char character in userEmail)
            {
                if (character == '@')
                {
                    number++;
                }
            }

            if (number == 1)
            {
                test = true;
            }

            return test;
        }

        //Here method is created to test is password is a valid password
        public bool testPassword()
        {
            bool test = false;
            string userPassword = txbCreatePasword.Text;
            int digit = 0, upperLetter = 0, lowerLetter = 0, symbol = 0;

            if (userPassword.Length >= 6)
            {
                foreach (char character in userPassword)
                {
                    if (char.IsDigit(character))
                    {
                        digit++;
                    }
                    else if (char.IsUpper(character))
                    {
                        upperLetter++;
                    }
                    else if (char.IsLower(character))
                    {
                        lowerLetter++;
                    }
                    else if (char.IsSymbol(character) || char.IsPunctuation(character))
                    {
                        symbol++;
                    }
                }

                if (digit >= 2 && upperLetter >= 1 && lowerLetter >= 1 && symbol >= 1)
                {
                    test = true;
                }
            }

            return test;
        }

        //Here a method is used to change some property visabilaty to use same form, but looks diffrent
        public void updateLayoutRegister()
        {
            txbCreatePasword.Visible = false;
            lblPassword.Visible = false;
            cbPremuimMember.Visible = false;
            lblPremuimMember.Visible = false;
            btnNewRegister.Visible = false;
            btnUpdatClientInfo.Visible = true;
        }

        //Here a method is used to change some property visabilaty to use same form, but looks diffrent
        public void updateLayoutRegister2()
        {
            txbCreatePasword.Visible = true;
            lblPassword.Visible = true;
            cbPremuimMember.Visible = true;
            lblPremuimMember.Visible = true;
            btnNewRegister.Visible = true;
            btnUpdatClientInfo.Visible = false;
        }

        /*Here method is used to select data in table clientinfo and store the data in variable
         after reading it. textboxes and comboboxes it also autofilled for user, to make it faster and
        user can only change that it wants to change*/
        public void ClientInfoDetailsSelected()
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
                    txbEmail.Text = Log_in.userEmail;
                }

                conect.conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //When button cancel is clieked, it close the form
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /*When button update client info is clieked it ask use it thay want to update with message.
         then it test all the textboxes and comboboxes. then is update the tables clientinfo, HostEventTable and
        EventRegisterTable, by using the value in textboxes and combocoxes*/
        private void btnUpdatClientInfo_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dailog = MessageBox.Show("Are you Sure you want to update Info.", "Update Info", MessageBoxButtons.YesNo);
                if (dailog == DialogResult.Yes)
                {
                    if (!string.IsNullOrWhiteSpace(txbName.Text))
                    {
                        if (txbSurname.Text != "")
                        {
                            if (!string.IsNullOrWhiteSpace(txbCellphoneNr.Text) && txbCellphoneNr.Text.All(char.IsDigit) && txbCellphoneNr.Text.Length == 10)
                            {
                                if (cbGender.Text != "")
                                {
                                    if (!string.IsNullOrWhiteSpace(txbEmail.Text))
                                    {
                                        if (testEmailAdress() == true)
                                        {
                                            Log_in conect = new Log_in();

                                            conect.conn.Open();

                                            SqlCommand updateComm = new SqlCommand($"UPDATE ClientInfo SET Name = '{txbName.Text}', Surname = '{txbSurname.Text}', Cellphone = '{txbCellphoneNr.Text}', Email = '{txbEmail.Text}', Geneder = '{cbGender.Text}' WHERE Email = '{Log_in.userEmail}'", conect.conn);
                                            SqlDataAdapter adapter = new SqlDataAdapter();

                                            adapter.UpdateCommand = updateComm;
                                            adapter.UpdateCommand.ExecuteNonQuery();

                                            conect.conn.Close();

                                            conect.conn.Open();

                                            updateComm = new SqlCommand($"UPDATE EventRegisterTable SET Register_Email = '{txbEmail.Text}', Name = '{txbName.Text}', Surname = '{txbSurname.Text}', CellphoneNr = '{txbCellphoneNr.Text}', Gender = '{cbGender.Text}' WHERE Register_Email = '{Log_in.userEmail}'", conect.conn);
                                            adapter = new SqlDataAdapter();

                                            adapter.UpdateCommand = updateComm;
                                            adapter.UpdateCommand.ExecuteNonQuery();

                                            conect.conn.Close();

                                            conect.conn.Open();

                                            updateComm = new SqlCommand($"UPDATE HostEventTable SET Host_Email = '{txbEmail.Text}' WHERE Host_Email = '{Log_in.userEmail}'", conect.conn);
                                            adapter = new SqlDataAdapter();

                                            adapter.UpdateCommand = updateComm;
                                            adapter.UpdateCommand.ExecuteNonQuery();

                                            conect.conn.Close();

                                            Log_in.userEmail = txbEmail.Text;

                                            MessageBox.Show("Sucsesfull Updated Info");

                                            this.Close();   
                                        }
                                        else
                                        {
                                            errorProviderRegister.SetError(txbEmail, "invalid email address");
                                            txbEmail.Focus();
                                        }
                                    }
                                    else
                                    {
                                        errorProviderRegister.SetError(txbEmail, "Cant be blank or have whiteSpaces, please enter your email address");
                                        txbEmail.Focus();
                                    }
                                    
                                }
                                else
                                {
                                    errorProviderRegister.SetError(cbGender, "Cant be blank, please select your gender");
                                    cbGender.Focus();
                                }
                            }
                            else
                            {
                                errorProviderRegister.SetError(txbCellphoneNr, "Cant be blank, please enter your cellphone number and must be 10 digits long");
                                txbCellphoneNr.Focus();
                            }
                        }
                        else
                        {
                            errorProviderRegister.SetError(txbSurname, "Cant be blank, please enter a your surname");
                            txbSurname.Focus();
                        }
                    }
                    else
                    {
                        errorProviderRegister.SetError(txbName, "Cant be blank, please enter a your name");
                        txbName.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /*the rest of the code below is where all the errorProviders gets cleared*/
        private void txbName_TextChanged(object sender, EventArgs e)
        {
            errorProviderRegister.SetError(txbName, "");
        }

        private void txbSurname_TextChanged(object sender, EventArgs e)
        {
            errorProviderRegister.SetError(txbSurname, "");
        }

        private void txbCellphoneNr_TextChanged(object sender, EventArgs e)
        {
            errorProviderRegister.SetError(txbCellphoneNr, "");
        }

        private void txbEmail_TextChanged(object sender, EventArgs e)
        {
            errorProviderRegister.SetError(txbEmail, "");
        }

        private void cbGender_SelectedIndexChanged(object sender, EventArgs e)
        {
            errorProviderRegister.SetError(cbGender, "");
        }

        private void txbCreatePasword_TextChanged(object sender, EventArgs e)
        {
            errorProviderRegister.SetError(txbCreatePasword, "");
        }

        private void cbPremuimMember_SelectedIndexChanged(object sender, EventArgs e)
        {
            errorProviderRegister.SetError(cbPremuimMember, "");
        }
    }
}
