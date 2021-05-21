using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TimeTableT.Controllers;
using TimeTableT.Models;

namespace TimeTableT
{
    public partial class AddLocation : Form
    {
        public AddLocation()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AddSessionButton_Click(object sender, EventArgs e)
        {
            try
            {
                bool isvalidated = validatefields();
                if (isvalidated)
                {
                    Location location = new Location();
                    location.room = SelectRoomtextBox.Text;
                    location.day = SelectDaytextBox.Text;
                    location.StartTime = StartTimeetextBox.Text;
                    location.EndTime = EndTimetextBox.Text;
                    
                    string message = LocationController.AddLocation(location);
                    MessageBox.Show(message);
                    clear();
                }
                else
                {
                    MessageBox.Show("please fill in all fields!");
                }
            }
            catch (NullReferenceException nre)
            {
                MessageBox.Show("please fill in all fields!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private bool validatefields()
        {
            if(SelectRoomtextBox.Text != "" || StartTimeetextBox.Text != ""
                ||EndTimetextBox.Text != "" || SelectDaytextBox.Text != "")
            {
                return true;
            }

            return false;
        }

        private void clear()
        {
            SelectRoomtextBox.Text = string.Empty;
            SelectDaytextBox.Text = string.Empty;
            StartTimeetextBox.Text = string.Empty;
            EndTimetextBox.Text = string.Empty;
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
