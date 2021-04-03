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
    public partial class AddLecturer : Form
    {
        public AddLecturer()
        {
            InitializeComponent();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                bool isvalidated = validatefields();
                if (isvalidated)
                {
                    Lecturer lecturer = new Lecturer();
                    lecturer.lecturername = txtlecturername.Text;
                    lecturer.center = combocenter.SelectedItem.ToString();
                    lecturer.employeeid = txtemployeeid.Text;
                    lecturer.building = combobuilding.SelectedItem.ToString();
                    lecturer.faculty = combofaculty.SelectedItem.ToString();
                    lecturer.level = Convert.ToInt32(combolevel.SelectedItem.ToString());
                    lecturer.department = combodepartment.SelectedItem.ToString();
                    lecturer.rank = txtrank.Text;
                    string message = LecturerController.AddLecturer(lecturer);
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
            if (txtlecturername.Text != "" || combocenter.SelectedIndex != -1 
                || txtemployeeid.Text != "" || combobuilding.SelectedIndex != -1
                || combofaculty.SelectedIndex != -1 || combolevel.SelectedIndex != -1
                || combodepartment.SelectedIndex != -1)
            {
                return true;
            }
            return false;
        }

        private void clear() 
        {
            txtlecturername.Text = string.Empty;
            combocenter.SelectedIndex = -1;
            txtemployeeid.Text = string.Empty;
            combobuilding.SelectedIndex = -1;
            combofaculty.SelectedIndex = -1;
            combolevel.SelectedIndex = -1;
            combodepartment.SelectedIndex = -1;
            txtrank.Text = string.Empty;
        }

        private void txtemployeeid_TextChanged(object sender, EventArgs e)
        {
            if (combolevel.SelectedIndex != -1)
            {
                txtrank.Text = combolevel.SelectedItem.ToString() + "." + txtemployeeid.Text;
            }
            else
            {
                txtrank.Text = string.Empty;
            }
        }

        private void combolevel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combolevel.SelectedIndex != -1)
            {
                txtrank.Text = combolevel.SelectedItem.ToString() + "." + txtemployeeid.Text;
            }
            else
            {
                txtrank.Text = string.Empty;
            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            clear();
        }
    }
}
