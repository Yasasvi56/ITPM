using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeTableT
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            btnaddsubject.Location = btnaddstudent.Location = btnaddtag.Location = btnaddsession.Location = btnaddlocation.Location = btnaddlecturer.Location;
            btnmanagesubjects.Location = btnmanagestudents.Location = btnmanagetag.Location = btnmanagesessions.Location = btnmanagelocation.Location = btnmanagelecture.Location;
        }
        private void btnaddlecturer_Click(object sender, EventArgs e)
        {
            AddLecturer frm = new AddLecturer();
            frm.TopMost = true;
            frm.ShowDialog();
        }
        private void btnmanagelecturer_Click(object sender, EventArgs e)
        {
            ManageLecturers frm = new ManageLecturers();
            frm.TopMost = true;
            frm.ShowDialog();
        }
        private void btnLecturers_Click(object sender, EventArgs e)
        {
            lblheader.Text = "Lecturers";
            btnaddlecturer.Visible = true;
            btnmanagelecture.Visible = true;
            btnaddsubject.Visible = false;
            btnmanagesubjects.Visible = false;
            btnaddsession.Visible = false;
            btnmanagesessions.Visible = false;
            btnaddstudent.Visible = false;
            btnmanagestudents.Visible = false;
            btnaddtag.Visible = false;
            btnmanagetag.Visible = false;
            btnaddlocation.Visible = false;
            btnmanagelocation.Visible = false;
            //panellogo.Visible = false;

            btnCon1.Visible = false;
            btnAddworkingweek1.Visible = false;
            btnListworkingweek1.Visible = false;
            btnManagenotavailable1.Visible = false;
            btnNotAvailable1.Visible = false;
            btnUpdateworkingdate1.Visible = false;
            btnworkingdate1.Visible = false;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            lblheader.Text = "Dashboard/Home";
            btnaddlecturer.Visible = false;
            btnmanagelecture.Visible = false;
            btnaddsubject.Visible = false;
            btnmanagesubjects.Visible = false;
            btnaddsession.Visible = false;
            btnmanagesessions.Visible = false;
            btnaddstudent.Visible = false;
            btnmanagestudents.Visible = false;
            btnaddtag.Visible = false;
            btnmanagetag.Visible = false;
            btnaddlocation.Visible = false;
            btnmanagelocation.Visible = false;
            //panellogo.Visible = true;

            btnCon1.Visible = false;
            btnAddworkingweek1.Visible = false;
            btnListworkingweek1.Visible = false;
            btnManagenotavailable1.Visible = false;
            btnNotAvailable1.Visible = false;
            btnUpdateworkingdate1.Visible = false;
            btnworkingdate1.Visible = false;
        }
        private void buttonSubject_Click(object sender, EventArgs e)
        {
            lblheader.Text = "Subjects";
            btnaddlecturer.Visible = false;
            btnmanagelecture.Visible = false;
            btnaddsubject.Visible = true;
            btnmanagesubjects.Visible = true;
            btnaddsubject.Location = btnaddlecturer.Location;
            btnaddsession.Visible = false;
            btnmanagesessions.Visible = false;
            btnaddstudent.Visible = false;
            btnmanagestudents.Visible = false;
            btnaddtag.Visible = false;
            btnmanagetag.Visible = false;
            btnaddlocation.Visible = false;
            btnmanagelocation.Visible = false;
            //panellogo.Visible = false;

            btnCon1.Visible = false;
            btnAddworkingweek1.Visible = false;
            btnListworkingweek1.Visible = false;
            btnManagenotavailable1.Visible = false;
            btnNotAvailable1.Visible = false;
            btnUpdateworkingdate1.Visible = false;
            btnworkingdate1.Visible = false;
        }
        private void btnSession_Click(object sender, EventArgs e)
        {
            lblheader.Text = "Sessions";
            btnaddlecturer.Visible = false;
            btnmanagelecture.Visible = false;
            btnaddsubject.Visible = false;
            btnmanagesubjects.Visible = false;
            btnaddsession.Visible = true;
            btnmanagesessions.Visible = true;
            btnaddstudent.Visible = false;
            btnmanagestudents.Visible = false;
            btnaddtag.Visible = false;
            btnmanagetag.Visible = false;
            btnaddlocation.Visible = false;
            btnmanagelocation.Visible = false;
            //panellogo.Visible = false;

            btnCon1.Visible = false;
            btnAddworkingweek1.Visible = false;
            btnListworkingweek1.Visible = false;
            btnManagenotavailable1.Visible = false;
            btnNotAvailable1.Visible = false;
            btnUpdateworkingdate1.Visible = false;
            btnworkingdate1.Visible = false;
        }
        private void btnSudent_Click(object sender, EventArgs e)
        {
            lblheader.Text = "Students";
            btnaddlecturer.Visible = false;
            btnmanagelecture.Visible = false;
            btnaddsubject.Visible = false;
            btnmanagesubjects.Visible = false;
            btnaddsession.Visible = false;
            btnmanagesessions.Visible = false;
            btnaddstudent.Visible = true;
            btnmanagestudents.Visible = true;
            btnaddtag.Visible = false;
            btnmanagetag.Visible = false;
            btnaddlocation.Visible = false;
            btnmanagelocation.Visible = false;
            //panellogo.Visible = false;

            btnCon1.Visible = false;
            btnAddworkingweek1.Visible = false;
            btnListworkingweek1.Visible = false;
            btnManagenotavailable1.Visible = false;
            btnNotAvailable1.Visible = false;
            btnUpdateworkingdate1.Visible = false;
            btnworkingdate1.Visible = false;
        }
        private void btnTag_Click(object sender, EventArgs e)
        {
            lblheader.Text = "Tags";
            btnaddlecturer.Visible = false;
            btnmanagelecture.Visible = false;
            btnaddsubject.Visible = false;
            btnmanagesubjects.Visible = false;
            btnaddsession.Visible = false;
            btnmanagesessions.Visible = false;
            btnaddstudent.Visible = false;
            btnmanagestudents.Visible = false;
            btnaddtag.Visible = true;
            btnmanagetag.Visible = true;
            btnaddlocation.Visible = false;
            btnmanagelocation.Visible = false;
            //panellogo.Visible = false;

            btnCon1.Visible = false;
            btnAddworkingweek1.Visible = false;
            btnListworkingweek1.Visible = false;
            btnManagenotavailable1.Visible = false;
            btnNotAvailable1.Visible = false;
            btnUpdateworkingdate1.Visible = false;
            btnworkingdate1.Visible = false;
        }

        private void btnlocation_Click(object sender, EventArgs e)
        {
            lblheader.Text = "Locations";
            btnaddlecturer.Visible = false;
            btnmanagelecture.Visible = false;
            btnaddsubject.Visible = false;
            btnmanagesubjects.Visible = false;
            btnaddsession.Visible = false;
            btnmanagesessions.Visible = false;
            btnaddstudent.Visible = false;
            btnmanagestudents.Visible = false;
            btnaddtag.Visible = false;
            btnmanagetag.Visible = false;
            btnaddlocation.Visible = true;
            //btnmanagelocation.Visible = true;
            //panellogo.Visible = false;

            btnCon1.Visible = false;
            btnAddworkingweek1.Visible = false;
            btnListworkingweek1.Visible = false;
            btnManagenotavailable1.Visible = false;
            btnNotAvailable1.Visible = false;
            btnUpdateworkingdate1.Visible = false;
            btnworkingdate1.Visible = false;
        }
        private void btnallocation_Click(object sender, EventArgs e)
        {
            lblheader.Text = "Allocation";
            btnaddlecturer.Visible = false;
            btnmanagelecture.Visible = false;
            btnaddsubject.Visible = false;
            btnmanagesubjects.Visible = false;
            btnaddsession.Visible = false;
            btnmanagesessions.Visible = false;
            btnaddstudent.Visible = false;
            btnmanagestudents.Visible = false;
            btnaddtag.Visible = false;
            btnmanagetag.Visible = false;
            btnaddlocation.Visible = false;
            btnmanagelocation.Visible = false;
            //panellogo.Visible = false;

            btnCon1.Visible = true;
            btnAddworkingweek1.Visible = true;
            btnListworkingweek1.Visible = true;
            btnManagenotavailable1.Visible = true;
            btnNotAvailable1.Visible = true;
            btnUpdateworkingdate1.Visible = true;
            btnworkingdate1.Visible = true;
        }
        private void btnaddlecturer_Click_1(object sender, EventArgs e)
        {
            AddLecturer frm = new AddLecturer();
            frm.TopMost = true;
            frm.ShowDialog();
        }

        private void btnmanagelecture_Click(object sender, EventArgs e)
        {
            ManageLecturers frm = new ManageLecturers();
            frm.TopMost = true;
            frm.ShowDialog();
        }

        private void btnaddsubject_Click(object sender, EventArgs e)
        {
            AddSubject frm = new AddSubject();
            frm.TopMost = true;
            frm.ShowDialog();
        }

        private void btnmanagesubjects_Click(object sender, EventArgs e)
        {
            ManageSubjects frm = new ManageSubjects();
            frm.TopMost = true;
            frm.ShowDialog();
        }

        private void btnaddsession_Click(object sender, EventArgs e)
        {
            AddSession frm = new AddSession();
            frm.TopMost = true;
            frm.ShowDialog();
        }

        private void btnmanagesessions_Click(object sender, EventArgs e)
        {
            ManageSessionsF frm = new ManageSessionsF();
            frm.TopMost = true;
            frm.ShowDialog();
        }

        private void btnaddstudent_Click(object sender, EventArgs e)
        {
            AddStudent frm = new AddStudent();
            frm.TopMost = true;
            frm.ShowDialog();
        }

        private void btnmanagestudents_Click(object sender, EventArgs e)
        {
            ManageStudent frm = new ManageStudent();
            frm.TopMost = true;
            frm.ShowDialog();
        }
        private void btnmanagetag_Click(object sender, EventArgs e)
        {
            ManageTag frm = new ManageTag();
            frm.TopMost = true;
            frm.ShowDialog();
        }
        private void btnaddtag_Click(object sender, EventArgs e)
        {
            AddTag frm = new AddTag();
            frm.TopMost = true;
            frm.ShowDialog();
        }

        private void btnaddlocation_Click(object sender, EventArgs e)
        {
            AddLocation frm = new AddLocation();
            frm.TopMost = true;
            frm.ShowDialog();
        }

        private void btnCon_Click(object sender, EventArgs e)
        {
            Consecutive frm = new Consecutive();
            frm.TopMost = true;
            frm.ShowDialog();
        }

        private void btnAddworkingweek_Click(object sender, EventArgs e)
        {
            AddWorkingWeek frm = new AddWorkingWeek();
            frm.TopMost = true;
            frm.ShowDialog();
        }

        private void btnListworkingweek_Click(object sender, EventArgs e)
        {
            ListWorkingWeek frm = new ListWorkingWeek();
            frm.TopMost = true;
            frm.ShowDialog();
        }

        private void btnManagenotavailable_Click(object sender, EventArgs e)
        {
            ManageNotAvailableTime frm = new ManageNotAvailableTime();
            frm.TopMost = true;
            frm.ShowDialog();
        }

        private void btnNotAvailable_Click(object sender, EventArgs e)
        {
            NotAvailableTimeAllocation frm = new NotAvailableTimeAllocation();
            frm.TopMost = true;
            frm.ShowDialog();
        }

        private void btnUpdateworkingdate_Click(object sender, EventArgs e)
        {
            UpdateWorkingDateAndTimeForm frm = new UpdateWorkingDateAndTimeForm();
            frm.TopMost = true;
            frm.ShowDialog();
        }

        private void btnworkingdate_Click(object sender, EventArgs e)
        {
            WorkingDateAndTimeForm frm = new WorkingDateAndTimeForm();
            frm.TopMost = true;
            frm.ShowDialog();
        }

        private void btnCon1_Click(object sender, EventArgs e)
        {
            Consecutive frm = new Consecutive();
            frm.TopMost = true;
            frm.ShowDialog();
        }

        private void btnworkingdate1_Click(object sender, EventArgs e)
        {
            WorkingDateAndTimeForm frm = new WorkingDateAndTimeForm();
            frm.TopMost = true;
            frm.ShowDialog();
        }

        private void btnUpdateworkingdate1_Click(object sender, EventArgs e)
        {
            UpdateWorkingDateAndTimeForm frm = new UpdateWorkingDateAndTimeForm();
            frm.TopMost = true;
            frm.ShowDialog();
        }

        private void btnManagenotavailable1_Click(object sender, EventArgs e)
        {
            ManageNotAvailableTime frm = new ManageNotAvailableTime();
            frm.TopMost = true;
            frm.ShowDialog();
        }

        private void btnAddworkingweek1_Click(object sender, EventArgs e)
        {
            AddWorkingWeek frm = new AddWorkingWeek();
            frm.TopMost = true;
            frm.ShowDialog();
        }

        private void btnListworkingweek1_Click(object sender, EventArgs e)
        {
            ListWorkingWeek frm = new ListWorkingWeek();
            frm.TopMost = true;
            frm.ShowDialog();
        }
    }
}
