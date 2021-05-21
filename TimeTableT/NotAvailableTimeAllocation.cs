using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using TimeTableT.Models;
using TimeTableT.Controllers;

namespace TimeTableT
{
    public partial class NotAvailableTimeAllocation : Form
    {
        public static string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=itpm;";
        public NotAvailableTimeAllocation()
        {
            InitializeComponent();
        }

        private void NotAvailableTimeAllocation_Load(object sender, EventArgs e)
        {
            
            //Select Lecture Combobox
            string query = "SELECT lecturername FROM Lecturer ";
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;
            try
            {
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();
                if (reader.HasRows)
                {
                    
                    while (reader.Read())
                    {
                        string Lname = reader.GetString("lecturername");
                        LectuercomboBox.Items.Add(Lname);
                    }
                    
                }
                else
                {
                    Console.WriteLine("No rows found.");
                }
                databaseConnection.Close();
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                
            }

            


            //Select Groups Combobox
            string query2 = "SELECT groupId, subGroupId FROM students";
            MySqlConnection databaseConnection2 = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase2 = new MySqlCommand(query2, databaseConnection2);
            commandDatabase2.CommandTimeout = 60;
            MySqlDataReader reader2;
            try
            {
                databaseConnection2.Open();
                reader2 = commandDatabase2.ExecuteReader();
                if (reader2.HasRows)
                {

                    while (reader2.Read())
                    {
                        

                        string group = reader2.GetString("groupId");
                        GroupcomboBox.Items.Add(group);

                        string subgroup = reader2.GetString("subGroupId");
                        SubGroupcomboBox.Items.Add(subgroup);
                    }

                }
                else
                {
                    Console.WriteLine("No rows found.");
                }
                databaseConnection2.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                bool isvalidated = validatefields();
                if (isvalidated)
                {
                    NotAvailableTime notAvailableTime = new NotAvailableTime();
                    notAvailableTime.Lecturer = LectuercomboBox.SelectedItem.ToString();
                    notAvailableTime.GroupID = GroupcomboBox.SelectedItem.ToString();
                    notAvailableTime.SubGroupID = SubGroupcomboBox.SelectedItem.ToString();
                    notAvailableTime.SessionID = SessionIDtextBox.Text;
                    notAvailableTime.Time = TimetextBox.Text;
         

                    string message = NotAvailableTimeController.AddNotAvailableTime(notAvailableTime);
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
            if (TimetextBox.Text != "" || SessionIDtextBox.Text != ""
                || LectuercomboBox.SelectedIndex != -1 || GroupcomboBox.SelectedIndex != -1
                || SubGroupcomboBox.SelectedIndex != -1)
            {
                return true;
            }

            return false;
        }

        private void clear()
        {
            LectuercomboBox.SelectedIndex = -1;
            GroupcomboBox.SelectedIndex = -1;
            SubGroupcomboBox.SelectedIndex = -1;
            SessionIDtextBox.Text = string.Empty;
            TimetextBox.Text = string.Empty;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManageNotAvailableTime m = new ManageNotAvailableTime();
            m.ShowDialog();
            this.Close();
        }
    }
}
