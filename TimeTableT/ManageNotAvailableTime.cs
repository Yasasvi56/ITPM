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
    public partial class ManageNotAvailableTime : Form
    {
        public ManageNotAvailableTime()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            NotAvailableTimeAllocation m = new NotAvailableTimeAllocation();
            m.ShowDialog();
            this.Close();
        }

        private void ManageNotAvailableTime_Load(object sender, EventArgs e)
        {
            loadgrid();
        }

        private void loadgrid()
        {
            try
            {
                dataGridView6.DataSource = NotAvailableTimeController.FilterNotAvailableTime();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView6_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView6_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = dataGridView6.Rows[e.RowIndex];
                    int NotAvailableTimeID = Convert.ToInt32(row.Cells[0].Value.ToString());
                    NotAvailableTime notAvailableTime = NotAvailableTimeController.SelectedNotAvailableTime(NotAvailableTimeID);
                    if (notAvailableTime != null)
                    {
                        Hidelabel55.Text = notAvailableTime.NotAvailableTimeID.ToString();

                    }
                    else
                    {
                        Hidelabel55.Text = string.Empty;

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

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int nid = Convert.ToInt32(Hidelabel55.Text);
                string message = NotAvailableTimeController.DeleteNotAvailableTime(nid);
                MessageBox.Show(message);

                
            }
            catch (FormatException fe)
            {
                MessageBox.Show("please select a specific record");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ManageNotAvailableTime_Load_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            loadgrid();
        }
    }

}


