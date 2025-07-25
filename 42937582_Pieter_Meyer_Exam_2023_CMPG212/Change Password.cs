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
    public partial class Change_Password : Form
    {
        public Change_Password()
        {
            InitializeComponent();
        }

        /*When buton is clieked it first gets the user old pasword in client info table and store it in a variable.
         Then it do all the checks to see if user entered old and new and confirm paswords are correctly, before
        it upate the user pasword in client table*/
        private void btnChange_Click(object sender, EventArgs e)
        {
            try
            {
                string tbPassword = "";

                Log_in conect = new Log_in();

                conect.conn.Open();

                SqlCommand select = new SqlCommand($"SELECT Password FROM ClientInfo WHERE Email = '{Log_in.userEmail}'", conect.conn);
                SqlDataReader reader = select.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        tbPassword = reader.GetValue(0).ToString(); 
                    }
                }

                conect.conn.Close();

                if (!string.IsNullOrWhiteSpace(txbCurrentPassword.Text))
                {
                    if (txbCurrentPassword.Text == tbPassword)
                    {
                        if (!string.IsNullOrWhiteSpace(txbNewPassword.Text))
                        {
                            if (testNewPassword() == true)
                            {
                                if (!string.IsNullOrWhiteSpace(txbConfirmPassword.Text))
                                {
                                    if (txbConfirmPassword.Text == txbNewPassword.Text)
                                    {
                                        DialogResult dailog = MessageBox.Show("Are you Sure you want to Change Password.", "Change Password", MessageBoxButtons.YesNo);
                                        if (dailog == DialogResult.Yes)
                                        {
                                            conect.conn.Open();

                                            SqlCommand updateComm = new SqlCommand($"UPDATE ClientInfo SET PassWord = '{txbNewPassword.Text}' WHERE Email = '{Log_in.userEmail}'", conect.conn);
                                            SqlDataAdapter adapter = new SqlDataAdapter();

                                            adapter.UpdateCommand = updateComm;
                                            adapter.UpdateCommand.ExecuteNonQuery();

                                            conect.conn.Close();

                                            MessageBox.Show("Successfully changed password");

                                            this.Close();
                                        }
                                    }
                                    else
                                    {
                                        errorProviderChangePassword.SetError(txbConfirmPassword, "Confirm Password not maching New Password");
                                        txbConfirmPassword.Focus();
                                    }
                                }
                                else
                                {
                                    errorProviderChangePassword.SetError(txbConfirmPassword, "Cant be blank or have whiteSpaces");
                                    txbConfirmPassword.Focus();
                                }
                            }
                            else
                            {
                                errorProviderChangePassword.SetError(txbNewPassword, "invalid password");
                                txbNewPassword.Focus();
                            }
                        }
                        else
                        {
                            errorProviderChangePassword.SetError(txbNewPassword, "Cant be blank or have whiteSpaces, must have one capatil leters and two numbers and one symbol and must be 6 characters long or more");
                            txbNewPassword.Focus();
                        }
                    }
                    else
                    {
                        errorProviderChangePassword.SetError(txbCurrentPassword, "Incorrect Password, not the same as old Password");
                        txbCurrentPassword.Focus();
                    }
                }
                else
                {
                    errorProviderChangePassword.SetError(txbCurrentPassword, "Cant be blank or have whiteSpaces");
                    txbCurrentPassword.Focus();
                }
            }
            catch
            {

            }
        }

        /*Here a method is created to test if the password entered has all the requerments, beforem
         it is passed as true else a error message will pop up to say it dit not pass as a errorprovider.*/
        public bool testNewPassword()
        {
            bool test = false;
            string userPassword = txbNewPassword.Text;
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

        /*when button cancel is clieked it will close this form*/
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /*the rest of the code below is where all the errorProviders get cleared*/
        private void txbCurrentPassword_TextChanged(object sender, EventArgs e)
        {
            errorProviderChangePassword.SetError(txbCurrentPassword, "");
        }

        private void txbNewPassword_TextChanged(object sender, EventArgs e)
        {
            errorProviderChangePassword.SetError(txbNewPassword, "");
        }

        private void txbConfirmPassword_TextChanged(object sender, EventArgs e)
        {
            errorProviderChangePassword.SetError(txbConfirmPassword, "");
        }
    }
}
