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
    public partial class ManageSessionsF : Form
    {
        private static int staticsessionid = 0;
        public ManageSessionsF()
        {
            InitializeComponent();
        }
        private void ManageSessions_Load(object sender, EventArgs e)
        {
            loadgrid("","");
        }
        private void loadgrid(string lecturer, string year)
        {
            try
            {
                staticsessionid = 0;
                gridSession.DataSource = SessionController.FilterSessions(lecturer, year);
                gridSession.RowHeadersVisible = false;
                gridSession.Columns[0].Width = 50;
                gridSession.Columns[1].Width = 150;
                gridSession.Columns[2].Width = 120;
                gridSession.Columns[3].Width = 120;
                gridSession.Columns[4].Width = 95;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnAddSession_Click(object sender, EventArgs e)
        {
            AddSession frm = new AddSession ();
            frm.TopMost = true;
            frm.ShowDialog();
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int sessionid = Convert.ToInt32(lblsessionid.Text);
                string message = SessionController.DeleteSession(sessionid);
                MessageBox.Show(message);
                loadgrid(txtLec.Text, comboYear.SelectedIndex.ToString());
                //clear();
            }
            catch (FormatException fe)
            {
                MessageBox.Show("please select a specific session");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void gridSession_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = gridSession.Rows[e.RowIndex];
                    int sessionid = staticsessionid = Convert.ToInt32(row.Cells[0].Value.ToString());
                    List<MyItem> list = SessionController.SelectedLecturers(sessionid);
                    if (list != null)
                    {
                        lblsessionid.Text = sessionid.ToString();
                        listLecturers.DataSource = list;
                        listLecturers.DisplayMember = "text";
                        listLecturers.ValueMember = "value";
                    }
                }
            }
            catch (FormatException fe)
            {
                //clear();
                MessageBox.Show("no data selected");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void txtLec_TextChanged(object sender, EventArgs e)
        {

        }
        private void comboYear_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            staticsessionid = 0;
            string lecturer = txtLec.Text;
            string year = comboYear.SelectedIndex.ToString();
            loadgrid(lecturer, year);
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            View frm = new View(staticsessionid);
            //frm.TopMost = true;
            frm.ShowDialog();
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateSession frm = new UpdateSession(staticsessionid);
            //frm.TopMost = true;
            frm.ShowDialog();

        }
    }
}
