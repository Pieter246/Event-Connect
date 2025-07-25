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
    public partial class Log_in : Form
    {

        /*This is were the connection sting is coded and database connection string must be insurted here and userEmail variable is used as global variable*/
        public SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\NWU Studies\Jaar 2\NWU CPMG 212\42937582_Pieter_Meyer_Exam_2023_CMPG212\42937582_Pieter_Meyer_Exam_2023_CMPG212\dbClientRegistered.mdf;Integrated Security = True");
        public static string userEmail = "", tablePremuim = "";

        public Log_in()
        {
            InitializeComponent();
        }

        /*When button login is clieked, it set the userEmail variable. Then it gets the user password in client table and test it
         agianst the textbox login password entered by user. if it is the same it load the MainForm*/
        private void btnLogIn_Click(object sender, EventArgs e)
        {
            try
            {
                userEmail = txbUserEmail.Text;
                string userPassword = txbPassword.Text;
                string tablePassword = "";

                conn.Open();

                SqlCommand select = new SqlCommand($"SELECT Email, Password, Premuim FROM ClientInfo WHERE Email = '{userEmail}'", conn);
                SqlDataReader reader = select.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        tablePassword = reader.GetValue(1).ToString();
                        tablePremuim = reader.GetValue(2).ToString();
                    }
                }

                if (tablePassword != "")
                {
                    if (userPassword == tablePassword)
                    {
                        MainForm main = new MainForm();
                        main.ShowDialog();

                        txbUserEmail.Text = "";
                        txbPassword.Text = "";
                        txbUserEmail.Focus();

                    }
                    else
                    {
                        MessageBox.Show("Email or Password enter incorectly, try again.");
                    }
                }
                else
                {
                    MessageBox.Show("Email or Password enter incorectly, try again.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        /*When button register is clieked it call a method and load form register, then when it return
         it clear textboxes of login and set focus to textbox userEmail*/
        private void btnRegister_Click(object sender, EventArgs e)
        {
            Register myform = new Register();
            myform.updateLayoutRegister2();
            myform.ShowDialog();

            txbUserEmail.Text = "";
            txbPassword.Text = "";
            txbUserEmail.Focus();
        }

        /*When form is loaded it make sure that textboxes of login is cleared and set focus to textbox userEmail*/
        private void Log_in_Load(object sender, EventArgs e)
        {
            txbUserEmail.Text = "";
            txbPassword.Text = "";
            txbUserEmail.Focus();
        }
    }
}
