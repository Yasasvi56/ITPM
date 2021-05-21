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
    public partial class UpdateSession : Form
    {
        public UpdateSession(int sessionid)
        {
            InitializeComponent();
            setsubjectcombodata();
            setalllecturerslist();
            setFetchedData(sessionid);
        }
        private void setsubjectcombodata()
        {
            comboSubject.Items.Clear();
            DataTable dt = SubjectController.FilterSubjects("");
            dt.Rows.Add(0, "Select Subject");
            dt.DefaultView.Sort = "ID asc";
            comboSubject.DataSource = dt;
            comboSubject.DisplayMember = "Subject Name";
            comboSubject.ValueMember = "ID";
            comboSubject.SelectedValue = 0;
        }
        private void setFetchedData(int sessionid)
        {
            Session session = SessionController.ViewSessions(sessionid);
            if (session != null)
            {
                lblsessionid.Text = session.sessionid.ToString();
                comboTag.Text = session.tag;
                comboGroup.Text = session.sgroup;
                comboSubject.Text = session.subject;
                txtNoOfStudent.Text = session.noofstudent.ToString();
                txtDuration.Text = session.duration.ToString();
            }
            List<MyItem> list = SessionController.SelectedLecturers(sessionid);
            listSelectedLecturers.DataSource = list;
            listSelectedLecturers.DisplayMember = "text";
            listSelectedLecturers.ValueMember = "value";
            listSelectedLecturers.SelectedIndex = -1;
        }

        private void setalllecturerslist()
        {
            listAllLecturers.Items.Clear();
            listAllLecturers.DataSource = LecturerController.FilterLecturersSession("");
            listAllLecturers.DisplayMember = "text";
            listAllLecturers.ValueMember = "value";
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                Session session = new Session();
                session.sessionid = Convert.ToInt32(lblsessionid.Text);
                session.tag = comboTag.SelectedItem.ToString();
                session.sgroup = comboGroup.SelectedItem.ToString();
                DataRowView drv = (DataRowView)comboSubject.SelectedItem;
                session.subject = drv.Row.ItemArray[1].ToString();
                session.noofstudent = Convert.ToInt32(txtNoOfStudent.Text);
                session.duration = Convert.ToInt32(txtDuration.Text);
                List<int> selectedLectList = new List<int>();
                for (int i = 0; i < listSelectedLecturers.Items.Count; i++)
                {
                    MyItem myItem = (MyItem)listSelectedLecturers.Items[i];
                    selectedLectList.Add(myItem.value);
                }
                string message = SessionController.UpdateSession(session, selectedLectList);
                MessageBox.Show(message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            MyItem item = (MyItem)listAllLecturers.SelectedItem;
            List<MyItem> selectedleclist = (List<MyItem>)listSelectedLecturers.DataSource;
            bool iscontains = false;
            foreach (MyItem item1 in selectedleclist) 
            {
                iscontains = (item1.value == item.value);
                if (iscontains) break;
            }
            if (!iscontains)
            {
                List<MyItem> selectedLectList = new List<MyItem>();
                for (int i = 0; i < listSelectedLecturers.Items.Count; i++)
                {
                    MyItem myItem = (MyItem)listSelectedLecturers.Items[i];
                    selectedLectList.Add(myItem);
                }
                selectedLectList.Add(item);
                listSelectedLecturers.DataSource = selectedLectList;
            }
            listSelectedLecturers.DisplayMember = "Text";
            listSelectedLecturers.ValueMember = "Value";
            listAllLecturers.SelectedIndex = -1;
        }

        private void btnUnselect_Click(object sender, EventArgs e)
        {
            MyItem item = (MyItem)listSelectedLecturers.SelectedItem;
            int dataValue = item.value;
            List<MyItem> selectedLectList = new List<MyItem>();
            for (int i = 0; i < listSelectedLecturers.Items.Count; i++)
            {
                MyItem myItem = (MyItem)listSelectedLecturers.Items[i];
                if (myItem.value != dataValue) 
                {
                    selectedLectList.Add(myItem);
                }
            }
            listSelectedLecturers.DataSource = selectedLectList;
            listSelectedLecturers.DisplayMember = "Text";
            listSelectedLecturers.ValueMember = "Value";
            listSelectedLecturers.SelectedIndex = -1;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.tabSession.SelectedTab = this.selectGroupTab;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            this.tabSession.SelectedTab = this.selectLecturersTab;
        }
    }
}
