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
    public partial class AddWorkingWeek : Form
    {
        public AddWorkingWeek()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void savebutton_Click(object sender, EventArgs e)
        {
            try
            {
                bool isvalidated = validatefields();
                if (isvalidated)

                {
                    WorkingWeek workingWeek = new WorkingWeek();

                    workingWeek.noofworkingdays = Convert.ToInt32(numericUpDownNoOfWorkingDates.Value);


                    //check box

                    if (checkBoxMonday.Checked)

                    {

                        workingWeek.WorkingDays = workingWeek.WorkingDays + "," + checkBoxMonday.Text;

                    }

                    if (checkBoxTuesday.Checked)

                    {

                        workingWeek.WorkingDays = workingWeek.WorkingDays + "," + checkBoxTuesday.Text;

                    }
                    if (checkBoxWensday.Checked)

                    {

                        workingWeek.WorkingDays = workingWeek.WorkingDays + "," + checkBoxWensday.Text;

                    }
                    if (checkBoxTursday.Checked)

                    {

                        workingWeek.WorkingDays = workingWeek.WorkingDays + "," + checkBoxTursday.Text;

                    }
                    if (checkBoxFriday.Checked)

                    {

                        workingWeek.WorkingDays = workingWeek.WorkingDays + "," + checkBoxFriday.Text;

                    }
                    if (checkBoxSaturday.Checked)

                    {

                        workingWeek.WorkingDays = workingWeek.WorkingDays + "," + checkBoxSaturday.Text;

                    }
                    if (checkBoxSunday.Checked)

                    {

                        workingWeek.WorkingDays = workingWeek.WorkingDays + "," + checkBoxSunday.Text;

                    }
                    workingWeek.WorkingDays = workingWeek.WorkingDays.TrimStart(',');




                    workingWeek.WorkingHours = Convert.ToInt32(numericUpDownHours.Value);
                    workingWeek.WorkingMinutes = Convert.ToInt32(numericUpDownMinutes.Value);
                    string message = WorkingWeekController.AddWorkingWeek(workingWeek);
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
            if ( numericUpDownNoOfWorkingDates.Value != 0 && numericUpDownHours.Value != 0 && numericUpDownMinutes.Value != 0 )
            {
                return true;
            }
            return false;
        }

        private void clear()
        {
            numericUpDownNoOfWorkingDates.Value = 0;
            checkBoxMonday.Checked = false;
            checkBoxTuesday.Checked = false;
            checkBoxWensday.Checked = false;
            checkBoxTursday.Checked = false;
            checkBoxFriday.Checked = false;
            checkBoxSaturday.Checked = false;
            checkBoxSunday.Checked = false;
            numericUpDownHours.Value = 0;
            numericUpDownMinutes.Value = 0;
           
        }

        private void clearbutton_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void AddWorkingWeek_Load(object sender, EventArgs e)
        {

        }
    }
}
