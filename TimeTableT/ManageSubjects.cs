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
    public partial class ManageSubjects : Form
    {
        public ManageSubjects()
        {
            InitializeComponent();
        }

        private void ManageSubjects_Load(object sender, EventArgs e)
        {
            loadgrid("");
        }
        private void loadgrid(string filtertext)
        {
            try
            {
                gridSubject.DataSource = SubjectController.FilterSubjects(filtertext);
                gridSubject.RowHeadersVisible = false;
                gridSubject.Columns[0].Width = 50;
                gridSubject.Columns[1].Width = 175;
                gridSubject.Columns[2].Width = 145;
                gridSubject.Columns[3].Width = 145;
                gridSubject.Columns[4].Width = 94;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            btnSearch.PerformClick();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string filtertext = txtSearch.Text;
            loadgrid(filtertext);
        }

        private void gridSubject_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = gridSubject.Rows[e.RowIndex];
                    int subjectid = Convert.ToInt32(row.Cells[0].Value.ToString());
                    Subject subject = SubjectController.SelectedSubject(subjectid);
                    if (subject != null)
                    {
                        label11.Text = subjectid.ToString();
                        comboOffedYear.SelectedItem = subject.offeredyear;
                        rdb2.Checked = subject.offeredsemester == 2;
                        rdb1.Checked = !(rdb2.Checked);
                        textname.Text = subject.subjectname;
                        numericLhours.Value = subject.lecturehours;
                        numericThours.Value = subject.tutorialhours;
                        numericLabhours.Value = subject.labhours;
                        numericEhours.Value = subject.evoluationhours;
                        textCode.Text = subject.subjectcode;
                    }
                    else
                    {
                        label11.Text = string.Empty;
                        textname.Text = string.Empty;
                        comboOffedYear.SelectedIndex = -1;
                        rdb1.Checked = true;
                        rdb2.Checked = false;
                        textCode.Text = string.Empty;
                        numericLhours.Value = 0;
                        numericThours.Value = 0;
                        numericLabhours.Value = 0;
                        numericEhours.Value = 0;
                       
                    }
                }
            }
            catch (FormatException fe)
            {
                clear();
                MessageBox.Show("no data selected");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int subjectid = Convert.ToInt32(label11.Text);
                string message = SubjectController.DeleteSubject(subjectid);
                MessageBox.Show(message);
                loadgrid(txtSearch.Text);
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                bool isvalidated = validatefields();
                if (isvalidated)
                {
                    int subjectid = Convert.ToInt32(label11.Text);
                    Subject subject = new Subject();
                    subject.subjectid = subjectid;
                    subject.offeredyear = comboOffedYear.SelectedItem.ToString();
                    subject.lecturehours = Convert.ToInt32(numericLhours.Value);
                    subject.offeredsemester = rdb1.Checked?1:2;
                    subject.tutorialhours = Convert.ToInt32(numericThours.Value);
                    subject.subjectname = textname.Text;
                    subject.labhours = Convert.ToInt32(numericLabhours.Value);
                    subject.subjectcode = textCode.Text;
                    subject.evoluationhours = Convert.ToInt32(numericEhours.Value);
                    string message = SubjectController.UpdateSubject(subject);
                    MessageBox.Show(message);
                    loadgrid(txtSearch.Text);
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
            if (comboOffedYear.SelectedIndex != -1
                && textname.Text != ""
                && textCode.Text != "")
            {
                return true;
            }
            return false;
        }
        private void clear()
        {
            comboOffedYear.SelectedIndex = -1;
            rdb1.Checked = true;
            rdb2.Checked = false;
            textname.Text = string.Empty;
            textCode.Text = string.Empty;
            numericLhours.Value = 0;
            numericThours.Value = 0;
            numericLabhours.Value = 0;
            numericEhours.Value = 0;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }
    }
}
