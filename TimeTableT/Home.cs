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
            panellogo.Visible = false;
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
            panellogo.Visible = true;
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
            panellogo.Visible = false;
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
            panellogo.Visible = false;
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
            panellogo.Visible = false;
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
            panellogo.Visible = false;
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
            btnmanagelocation.Visible = true;
            panellogo.Visible = false;
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
            
        }

        private void btnmanagestudents_Click(object sender, EventArgs e)
        {

        }
    }
}
