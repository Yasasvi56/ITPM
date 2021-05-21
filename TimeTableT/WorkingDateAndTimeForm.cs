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
    public partial class WorkingDateAndTimeForm : Form
    {
        public WorkingDateAndTimeForm()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void saveNextbutton_Click(object sender, EventArgs e)
        {
            try
            {
                bool isvalidated = validatefields();
                if (isvalidated)
                {
                    WorkingDateAndTime workingDateAndTime = new WorkingDateAndTime();
                    workingDateAndTime.EmployeeID = textBoxEmployeeID.Text;
                    workingDateAndTime.EmployeeName = textBoxEmployeeName.Text;
                    workingDateAndTime.StartDate = textBoxStartDate.Text;
                    workingDateAndTime.EndDate = textBoxEndDate.Text;
                   
                    string message = WorkingDateAndTimeController.AddWorkingDateAndTime(workingDateAndTime);
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



            //moving to addworkingweek form
            /*
            this.Hide();
            AddWorkingWeek m = new AddWorkingWeek();
            m.ShowDialog();
            this.Close();
            */


        }

        private bool validatefields()
        {
            if (textBoxEmployeeID.Text != "" && textBoxEmployeeName.Text != ""
                && textBoxStartDate.Text != "" && textBoxEndDate.Text != "")
            {
                return true;
            }
            return false;
        }

        private void clear()
        {
            textBoxEmployeeID.Text = string.Empty;
            textBoxEmployeeName.Text = string.Empty;
            textBoxStartDate.Text = string.Empty;
            textBoxEndDate.Text = string.Empty;
          
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            UpdateWorkingDateAndTimeForm m = new UpdateWorkingDateAndTimeForm();
            m.ShowDialog();
            this.Close();
        }
    }
 }
