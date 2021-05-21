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
    public partial class AddSubject : Form
    {
        public AddSubject()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                bool isvalidated = validatefields();
                if (isvalidated)
                {
                    Subject subject = new Subject();
                    subject.offeredyear = comboOfferedyear.SelectedItem.ToString();
                    subject.lecturehours = Convert.ToInt32(numericLhrs.Value);
                    subject.offeredsemester = rdbSemester1.Checked ? 1 : 2;
                    subject.tutorialhours = Convert.ToInt32(numericThrs.Value);
                    subject.subjectname = txtSubjectname.Text;
                    subject.labhours = Convert.ToInt32(numericLabhrs.Value);
                    subject.subjectcode = txtSubjectcode.Text;
                    subject.evoluationhours = Convert.ToInt32(numericEhrs.Value);
                    string message = SubjectController.AddSubject(subject);
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
            if (comboOfferedyear.SelectedIndex != -1
                && txtSubjectname.Text != "" 
                && txtSubjectcode.Text != "" 
                 )
            {
                return true;
            }
            return false;
        }
        private void clear()
        {
            comboOfferedyear.SelectedIndex = -1;
            rdbSemester1.Checked = true;
            rdbSemester2.Checked = false;
            txtSubjectname.Text = string.Empty;
            txtSubjectcode.Text = string.Empty;
            numericLhrs.Value = 0;
            numericThrs.Value = 0;
            numericLabhrs.Value = 0;
            numericEhrs.Value = 0;
        }
    }
}
