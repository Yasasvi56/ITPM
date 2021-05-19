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
    public partial class AddSession : Form
    {
        public AddSession()
        {
            InitializeComponent();
            setsubjectcombodata();
            setalllecturerslist();
        }
        private void setsubjectcombodata()
        {
            comboSubject.Items.Clear();
            DataTable dt = SubjectController.FilterSubjects("");
            comboSubject.DataSource = dt;
            comboSubject.DisplayMember = "Subject Name";
            comboSubject.ValueMember = "ID";
            comboSubject.SelectedValue = 0;
            comboSubject.SelectedIndex = -1;
        }
        private void setalllecturerslist()
        {
            listAllLecturers.Items.Clear();
            DataTable dt = LecturerController.FilterLecturers("");
            listAllLecturers.DataSource = dt;
            listAllLecturers.DisplayMember = "Name";
            listAllLecturers.ValueMember = "ID";
            listAllLecturers.SelectedIndex = -1;
        }
        private void clear()
        {
            comboTag.SelectedIndex = -1;
            comboSubject.SelectedIndex = -1;
            comboSubject.SelectedIndex = -1;
            txtNoOfStudent.Text = string.Empty;
            txtDuration.Text = string.Empty;
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            this.tabSession.SelectedTab = this.selectLecturersTab;
        }
        private void btnSelect_Click(object sender, EventArgs e)
        {
            //selected lecturers from all lecturer list
            var item = listAllLecturers.SelectedItem;
            DataRowView drv = (DataRowView)item;
            //text that visible in list
            string dataText = (string)drv.Row.ItemArray[1];
            //value that engaged with the text
            int dataValue = Convert.ToInt32(drv.Row.ItemArray[0]);
            //object that includes a text and a value
            MyItem ob = new MyItem{ text = dataText, value = dataValue };
            //check if it is already in the selected lecturer list
            if (!listSelectedLecturers.Items.Contains(ob))
            {
                //if not then insert selected lecturer to the selected lecturers list
                listSelectedLecturers.Items.Add(ob);
            }
            listSelectedLecturers.DisplayMember = "Text";
            listSelectedLecturers.ValueMember = "Value";
        }
        private void btnUnselect_Click(object sender, EventArgs e)
        {
            listSelectedLecturers.Items.Remove(listSelectedLecturers.SelectedItem);
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.tabSession.SelectedTab = this.selectGroupTab;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                bool isvalidated = validatefields();
                if (isvalidated)
                {
                    Session session = new Session();
                    session.tag = comboTag.SelectedItem.ToString();
                    session.sgroup = comboGroup.SelectedItem.ToString();
                    //subject start
                    DataRowView drv = (DataRowView)comboSubject.SelectedItem;
                    session.subject = drv.Row.ItemArray[1].ToString();
                    //subject end
                    session.noofstudent = Convert.ToInt32(txtNoOfStudent.Text);
                    session.duration = Convert.ToInt32(txtDuration.Text);
                    List<int> selectedLectList = new List<int>();
                    for (int i = 0; i < listSelectedLecturers.Items.Count; i++)
                    {
                        MyItem myItem = (MyItem)listSelectedLecturers.Items[i];
                        selectedLectList.Add(myItem.value);
                    }
                    string message = SessionController.AddSession(session, selectedLectList);
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
            if (comboTag.SelectedIndex != -1 && comboGroup.SelectedIndex != -1
                && comboSubject.SelectedIndex != -1 && txtNoOfStudent.Text != "" && txtDuration.Text != "")
            {
                return true;
            }
            return false;
        }

        private void AddSession_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'itpmDataSet.lecturer' table. You can move, or remove it, as needed.
            this.lecturerTableAdapter.Fill(this.itpmDataSet.lecturer);
            // TODO: This line of code loads data into the 'itpmDataSet.subject' table. You can move, or remove it, as needed.
            this.subjectTableAdapter.Fill(this.itpmDataSet.subject);

        }
    }
    public class MyItem
    {
        public string text { get; set; }
        public int value { get; set; }
    }
}