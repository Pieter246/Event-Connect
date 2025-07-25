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
    public partial class Upgrade_to_Premuim : Form
    {
        public Upgrade_to_Premuim()
        {
            InitializeComponent();
        }

        /*When button id clieked it check witch radio button was selected and store
         a value in a variable. then it ased with message are to sure you want to upgrade and if yes it
        use the update statment to update data in clientinfo*/
        private void btnUpgrade_Click(object sender, EventArgs e)
        {
            try
            {
                string answer = "";

                if (radYes.Checked)
                {
                    answer = "Yes";
                }
                else if (radNo.Checked)
                {
                    answer = "No";
                }

                DialogResult dailog = MessageBox.Show("Are you Sure you want to Upgrade to Premium.", "Upgrade to Premium", MessageBoxButtons.YesNo);
                if (dailog == DialogResult.Yes)
                {

                    Log_in conect = new Log_in();

                    conect.conn.Open();

                    SqlCommand updateComm = new SqlCommand($"UPDATE ClientInfo SET Premuim = '{answer}' WHERE Email = '{Log_in.userEmail}'", conect.conn);
                    SqlDataAdapter adapter = new SqlDataAdapter();

                    adapter.UpdateCommand = updateComm;
                    adapter.UpdateCommand.ExecuteNonQuery();

                    conect.conn.Close();

                    MessageBox.Show("Successfully Upgraded to Premium");

                    this.Close();
                }
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
    }
}
