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
    public partial class ManageStudent : Form
    {
        public ManageStudent()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

       
        private void loadgrid()
        {
            try
            {
                dataGridView1.DataSource = StudentController.FilterStudents();
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
                    int studentId = Convert.ToInt32(row.Cells[0].Value.ToString());
                    Students students = StudentController.SelectedStudents(studentId);
                    if (students != null)
                    {
                        lblstudentId.Text = studentId.ToString();
                        txtacadamicYearSem.Text = students.acadamicYearSem;
                        comboprogramme.SelectedItem = students.programme;
                        numericUpDowngroupNo.Value = students.groupNo;
                        numericUpDownsubGroupNo.Value = students.subGroupNo;
                        txtgroupId.Text = students.groupId;
                        txtsubGroupId.Text = students.subGroupId;
                    }
                    else
                    {
                        lblstudentId.Text = string.Empty;
                        txtacadamicYearSem.Text = string.Empty;
                        comboprogramme.SelectedIndex = -1;
                        numericUpDowngroupNo.Value = 0;
                        numericUpDownsubGroupNo.Value = 0;
                        txtgroupId.Text = string.Empty;
                        txtsubGroupId.Text = string.Empty;
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
                    int studentId = Convert.ToInt32(lblstudentId.Text);
                    Students students = new Students();
                    students.studentId = studentId;
                    students.acadamicYearSem = txtacadamicYearSem.Text;
                    students.programme = comboprogramme.SelectedItem.ToString();
                    students.groupNo = Convert.ToInt32(numericUpDowngroupNo.Value);
                    students.subGroupNo = Convert.ToInt32(numericUpDownsubGroupNo.Value);
                    students.groupId = txtgroupId.Text;
                    students.subGroupId = txtsubGroupId.Text;
                    string message = StudentController.UpdateStudents(students);
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
                MessageBox.Show("please select a specific student Group");
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

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int studentId = Convert.ToInt32(lblstudentId.Text);
                string message = StudentController.DeleteStudents(studentId);
                MessageBox.Show(message);
                loadgrid();
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

        private void button3_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void ManageStudent_Load_1(object sender, EventArgs e)
        {
            loadgrid();
        }
    }
}

