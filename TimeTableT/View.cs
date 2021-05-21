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
    public partial class View : Form
    {
        public View(int sessionid)
        {
            InitializeComponent();
            Session session = SessionController.ViewSessions(sessionid);
            if (session!=null)
            {
                lblsessionid.Text = session.sessionid.ToString();
                lbltag.Text = session.tag;
                lblgroup.Text = session.sgroup;
                lblsubject.Text = session.subject;
                lblnoofstudents.Text = session.noofstudent.ToString();
                lblduration.Text = session.duration.ToString();
            }
            List<MyItem> list = SessionController.SelectedLecturers(sessionid);
            foreach (MyItem item in list) 
            {
                lbllecturers.Text += item.text + " ";
            }
        }
    }
}
