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
    public partial class Consecutive : Form
    {
        public Consecutive()
        {
            InitializeComponent();
        }

        private void Consecutive_Load(object sender, EventArgs e)
        {
            loadgrid();
        }

        private void loadgrid()
        {
            try
            {
                dataGridView1.DataSource = SessionsController.FilterSessions();
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
                    int sessionsID = Convert.ToInt32(row.Cells[0].Value.ToString());
                    Sessions sessionss = SessionsController.SelectedSessionss(sessionsID);
                    if (sessionss != null)
                    {
                        label2.Text = sessionsID.ToString();
                   
                    }
                    else
                    {
                        label2.Text = string.Empty;
                     
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

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}
