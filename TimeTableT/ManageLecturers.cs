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
    public partial class ManageLecturers : Form
    {
        public ManageLecturers()
        {
            InitializeComponent();
        }

        private void ManageLecturers_Load(object sender, EventArgs e)
        {
            loadgrid("");
        }

        private void loadgrid(string filtertext)
        {
            try
            {
                gridlecturers.DataSource = LecturerController.FilterLecturers(filtertext);
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void txtlecturerfilter_TextChanged(object sender, EventArgs e)
        {
            btnsearch.PerformClick();
        }
        private void btnsearch_Click(object sender, EventArgs e)
        {
            string filtertext = txtlecturerfilter.Text;
            loadgrid(filtertext);
        }
        private void gridlecturers_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = gridlecturers.Rows[e.RowIndex];
                    int lecturerid = Convert.ToInt32(row.Cells[0].Value.ToString());
                    Lecturer lecturer = LecturerController.SelectedLecturer(lecturerid);
                    if (lecturer != null)
                    {
                        lbllecturerid.Text = lecturerid.ToString();
                        txtlecturername.Text = lecturer.lecturername;
                        combocenter.SelectedItem = lecturer.center;
                        txtemployeeid.Text = lecturer.employeeid;
                        combobuilding.Text = lecturer.building;
                        combofaculty.SelectedItem = lecturer.faculty;
                        combolevel.SelectedItem = lecturer.level.ToString();
                        combodepartment.SelectedItem = lecturer.department;
                        txtrank.Text = lecturer.rank;
                    }
                    else
                    {
                        lbllecturerid.Text = string.Empty;
                        txtlecturername.Text = string.Empty;
                        combocenter.SelectedIndex = -1;
                        txtemployeeid.Text = string.Empty;
                        combobuilding.SelectedIndex = -1;
                        combofaculty.SelectedIndex = -1;
                        combolevel.SelectedIndex = -1;
                        combodepartment.SelectedIndex = -1;
                        txtrank.Text = string.Empty;
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
        private void btnclear_Click(object sender, EventArgs e)
        {
            clear();
        }
        private void btndelete_Click(object sender, EventArgs e)
        {
            try
            {
                int lecturerid = Convert.ToInt32(lbllecturerid.Text);
                string message = LecturerController.DeleteLecturer(lecturerid);
                MessageBox.Show(message);
                loadgrid(txtlecturerfilter.Text);
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
        private void btnupdate_Click(object sender, EventArgs e)
        {
            try
            {
                bool isvalidated = validatefields();
                if (isvalidated)
                {
                    int lecturerid = Convert.ToInt32(lbllecturerid.Text);
                    Lecturer lecturer = new Lecturer();
                    lecturer.lecturerid = lecturerid;
                    lecturer.lecturername = txtlecturername.Text;
                    lecturer.center = combocenter.SelectedItem.ToString();
                    lecturer.employeeid = txtemployeeid.Text;
                    lecturer.building = combobuilding.SelectedItem.ToString();
                    lecturer.faculty = combofaculty.SelectedItem.ToString();
                    lecturer.level = Convert.ToInt32(combolevel.SelectedItem.ToString());
                    lecturer.department = combodepartment.SelectedItem.ToString();
                    lecturer.rank = txtrank.Text;
                    string message = LecturerController.UpdateLecturer(lecturer);
                    MessageBox.Show(message);
                    loadgrid(txtlecturerfilter.Text);
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
            lbllecturerid.Text = string.Empty;
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
    }
}
