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
    public partial class UpdateWorkingDateAndTimeForm : Form
    {

        
        public UpdateWorkingDateAndTimeForm()
        {
            InitializeComponent();
        }
        private void UpdateWorkingDateAndTimeForm_Load(object sender, EventArgs e)
        {
            loadgrid();
        }
        private void loadgrid()
        {
            try
            {
                dataGridView2.DataSource = WorkingDateAndTimeController.FilterWorkingWeek();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView2_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = dataGridView2.Rows[e.RowIndex];
                    int WorkingDateAndTimeID = Convert.ToInt32(row.Cells[0].Value.ToString());
                    WorkingDateAndTime workingDateAndTime = WorkingDateAndTimeController.SelectedWorkingDateAndTime(WorkingDateAndTimeID);
                    if (workingDateAndTime != null)
                    {
                        Hidelabel6.Text = workingDateAndTime.WorkingDateAndTimeID.ToString();
                        UpdatetextBoxEmployeeID.Text = workingDateAndTime.EmployeeID;
                        UpdatetextBoxEmployeeName.Text = workingDateAndTime.EmployeeName;
                        UpdatetextBoxStartDate.Text = workingDateAndTime.StartDate;
                        UpdatetextBoxEndDate.Text = workingDateAndTime.EndDate;
                    }
                    else
                    {


                        Hidelabel6.Text = string.Empty;
                        UpdatetextBoxEmployeeID.Text = string.Empty;
                        UpdatetextBoxEmployeeName.Text = string.Empty;
                        UpdatetextBoxEndDate.Text = string.Empty;
                        UpdatetextBoxEndDate.Text = string.Empty;

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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                bool isvalidated = validatefields();
                if (isvalidated)
                {
                    int workiid = Convert.ToInt32(Hidelabel6.Text);
                    WorkingDateAndTime workingDateAndTime = new WorkingDateAndTime();

                    workingDateAndTime.WorkingDateAndTimeID = workiid;
                    workingDateAndTime.EmployeeID = UpdatetextBoxEmployeeID.Text;
                    workingDateAndTime.EmployeeName = UpdatetextBoxEmployeeName.Text;
                    workingDateAndTime.StartDate = UpdatetextBoxStartDate.Text;
                    workingDateAndTime.EndDate = UpdatetextBoxEndDate.Text;

                    string message = WorkingDateAndTimeController.UpdateWorkingDateAndTime(workingDateAndTime);
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
                MessageBox.Show("please select a specific Working Dates and Times");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void deletebutton_Click(object sender, EventArgs e)
        {
            try
            {
                int WorkingDateAndTimeID = Convert.ToInt32(Hidelabel6.Text);
                string message = WorkingDateAndTimeController.DeleteWorkingDateAndTime(WorkingDateAndTimeID);
                MessageBox.Show(message);

                clear();
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

        private bool validatefields()
        {
            if (UpdatetextBoxEmployeeName.Text != "" && UpdatetextBoxStartDate.Text != ""
                && UpdatetextBoxEmployeeID.Text != "" && UpdatetextBoxEndDate.Text != "")
            {
                return true;
            }
            return false;
        }
        private void clear()
        {
            Hidelabel6.Text = string.Empty;
            UpdatetextBoxEmployeeID.Text = string.Empty;
            UpdatetextBoxEmployeeName.Text = string.Empty;
            UpdatetextBoxEndDate.Text = string.Empty;
            UpdatetextBoxEndDate.Text = string.Empty;
        }

        private void clearbutton_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
