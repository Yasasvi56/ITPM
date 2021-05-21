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
    public partial class ListWorkingWeek : Form
    {
        public ListWorkingWeek()
        {
            InitializeComponent();
        }


        private void ListWorkingWeek_Load(object sender, EventArgs e)
        {
            loadgrid();
        }

        private void loadgrid()
        {
            try
            {
                dataGridView1.DataSource = WorkingWeekController.FilterWorkingWeek();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                bool isvalidated = validatefields();
                if (isvalidated)
                {
                    int workingWeekIDid = Convert.ToInt32(hideLable.Text);

                    WorkingWeek workingWeek = new WorkingWeek();


                    workingWeek.WorkingWeekID = workingWeekIDid;

                    workingWeek.noofworkingdays = Convert.ToInt32(numericUpDownUpadeNoOfWDaytes.Value);
                    
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

                    workingWeek.WorkingHours = Convert.ToInt32(numericUpDownUpdateHours.Value);
                    workingWeek.WorkingMinutes =Convert.ToInt32 (numericUpDownUpdateMinutes.Value);
                   
                    string message = WorkingWeekController.UpdateWorkingWeek(workingWeek);
                    MessageBox.Show(message);
                    loadgrid();
                    clear();
                }
                else
                {
                    MessageBox.Show("please fill in all fields!");
                }
            }
            catch (FormatException fe)
            {
                MessageBox.Show("please select a specific lecturer");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                    int workingWeekid = Convert.ToInt32(row.Cells[0].Value.ToString());
                    WorkingWeek workingWeek = WorkingWeekController.SelectedWorkingWeek(workingWeekid);  
                    if (workingWeek != null)
                    {
                        hideLable.Text = workingWeek.WorkingWeekID.ToString();
                        numericUpDownUpadeNoOfWDaytes.Value = workingWeek.noofworkingdays;
                        numericUpDownUpdateHours.Value = workingWeek.WorkingHours;
                        numericUpDownUpdateMinutes.Value = workingWeek.WorkingMinutes;
                        
                    }
                    else
                    {

                        hideLable.Text = string.Empty;
                        numericUpDownUpadeNoOfWDaytes.Value = 0;
                        numericUpDownUpdateHours.Value = 0;
                        numericUpDownUpdateMinutes.Value = 0;
                    }
                }
            }
            catch (FormatException fe)
            {
                MessageBox.Show("no data selected");
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }

        }



        private void button3_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int workingWeekIDid = Convert.ToInt32(hideLable.Text);
                string message = WorkingWeekController.DeleteWorkingWeek(workingWeekIDid);
                MessageBox.Show(message);
                loadgrid();
                clear();
            }
            catch (FormatException fe)
            {
                MessageBox.Show("please select a specific Record");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private bool validatefields()
        {
            if (numericUpDownUpadeNoOfWDaytes.Value != 0 && numericUpDownUpdateHours.Value != 0 && numericUpDownUpdateMinutes.Value != 0)
            {
                return true;
            }
            return false;
        }

        private void clear()
        {
            /*
            lbllecturerid.Text = string.Empty;
            txtlecturername.Text = string.Empty;
            combocenter.SelectedIndex = -1;
            txtemployeeid.Text = string.Empty;
            combobuilding.SelectedIndex = -1;
            combofaculty.SelectedIndex = -1;
            combolevel.SelectedIndex = -1;
            combodepartment.SelectedIndex = -1;
            txtrank.Text = string.Empty;
            */
        }

        private void btnsearch_Click_TextChanged(object sender, EventArgs e)
        {
            string filtertext = txtlecturerfilter.Text;
            loadgrid();
        }

        private void txtlecturerfilter_TextChanged(object sender, EventArgs e)
        {
            btnsearch.PerformClick();
        }
    }
}
