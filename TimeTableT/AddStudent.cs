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
    public partial class AddStudent : Form
    {
        public AddStudent()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                bool isvalidated = validatefields();
                if (isvalidated)
                {
                    Students students = new Students();
                    students.acadamicYearSem = txtacadamicYearSem.Text;
                    students.programme = comboprogramme.SelectedItem.ToString();
                    students.groupNo = Convert.ToInt32(numericUpDowngroupNo.Value);
                    students.subGroupNo = Convert.ToInt32(numericUpDownsubGroupNo.Value);
                    students.groupId = txtgroupId.Text;
                    students.subGroupId = txtsubGroupId.Text;


                    string message = StudentController.AddStudent(students);
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
            if (txtacadamicYearSem.Text != ""
                && comboprogramme.SelectedIndex != -1
                && numericUpDowngroupNo.Value != 0
                && numericUpDownsubGroupNo.Value != 0
                && txtgroupId.Text != "" 
                && txtsubGroupId.Text != "")

            {
                return true;
            }
            return false;
        }

        private void clear()
        {
            txtacadamicYearSem.Text = string.Empty;
            comboprogramme.SelectedIndex = -1;
            numericUpDowngroupNo.Value = 0;
            numericUpDownsubGroupNo.Value = 0;
            txtgroupId.Text = string.Empty;
            txtsubGroupId.Text = string.Empty;


        }
    }
}
