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
    public partial class Participants : Form
    {
        public Participants()
        {
            InitializeComponent();
        }

        //When button close is clieked it close the form
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //When form load it calls method
        private void Participants_Load(object sender, EventArgs e)
        {
            listOfParticipants();
        }

        /*Here method is used to select data form table EventRegister and display date in a listbox*/
        public void listOfParticipants()
        {
            try
            {
                string idChosen = Track_My_Events.iDTrackEventChosen;

                Log_in conect = new Log_in();

                conect.conn.Open();

                lbParticipants.Items.Clear();

                SqlCommand select = new SqlCommand($"SELECT Name, Surname, CellphoneNr, Gender, Register_Email FROM EventRegisterTable WHERE Id = '{idChosen}'", conect.conn);
                SqlDataReader reader = select.ExecuteReader();

                lbParticipants.Items.Add("Name\tSurname\tCellphoneNr\tGeneder\tRegister\tEmail");
                lbParticipants.Items.Add("-------------------------------------------------------------------------------------------------------------------");

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        lbParticipants.Items.Add(reader.GetValue(0) + "\t" + reader.GetValue(1) +"\t" + reader.GetValue(2) + "\t" + reader.GetValue(3) + "\t" + reader.GetValue(4));
                    }
                }

                conect.conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
