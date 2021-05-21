using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using TimeTableT.Models;


namespace TimeTableT.Controllers
{
    class WorkingWeekController
    {
        public static string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=itpm;";

        public static string AddWorkingWeek(WorkingWeek workingWeek)
        {
            string query = "INSERT INTO workingweek(`NoOfWorkingDates`,`WorkingDays`,`WorkingHours`,`WorkingMinutes`) " +
                           "VALUES " +
                           "('" + workingWeek.noofworkingdays + "', '" + workingWeek.WorkingDays + "','" + workingWeek.WorkingHours + "', " +
                           "'" + workingWeek.WorkingMinutes + "')";
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            try
            {
                databaseConnection.Open();
                MySqlDataReader myReader = commandDatabase.ExecuteReader();
                databaseConnection.Close();
                return "succesfully registered";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public static DataTable FilterWorkingWeek()
        {
            string query = "SELECT WorkingWeekID , NoOfWorkingDates, WorkingDays, WorkingHours, WorkingMinutes FROM workingweek " +
                           "where WorkingWeekID"; 
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;
            DataTable dt = new DataTable();
            dt.Clear();
            dt.Columns.AddRange(new DataColumn[5] {
                    new DataColumn("ID", typeof(int)),
                    new DataColumn("No Of Working Dates", typeof(int)),
                    new DataColumn("Working Dates", typeof(string)),
                    new DataColumn("Working Hours", typeof(int)),
                    new DataColumn("Working Minutes", typeof(int))

            });
            try
            {
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        dt.Rows.Add(reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3),
                            reader.GetString(4));
                    }
                }
                else
                {
                    Console.WriteLine("No rows found.");
                }
                databaseConnection.Close();
                return dt;
            }
            catch (Exception ex)
            {
                Console.WriteLine("No rows found.");
                return null;
            }

        }
        public static WorkingWeek SelectedWorkingWeek(int WorkingWeekid)
        {
            string query = "SELECT NoOfWorkingDates, WorkingHours, WorkingMinutes" +
                           " FROM workingweek where WorkingWeekID = " + WorkingWeekid;
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
                    WorkingWeek workingWeek = new WorkingWeek();
                    if (reader.Read())
                    {
                        workingWeek.noofworkingdays = reader.GetInt32(0); 
                        workingWeek.WorkingHours = reader.GetInt32(1);
                        workingWeek.WorkingMinutes = reader.GetInt32(2);
                      
                    }
                    return workingWeek;
                }
                else
                {
                    Console.WriteLine("No rows found.");
                }
                databaseConnection.Close();
                return null;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        public static string UpdateWorkingWeek(WorkingWeek workingWeek)
        {
            string query = "UPDATE workingweek SET `NoOfWorkingDates`='" + workingWeek.noofworkingdays + "', " +    
                           "`WorkingDays`='" + workingWeek.WorkingDays + "'," +
                           "`WorkingHours`='" + workingWeek.WorkingHours + "'," +
                           "`WorkingMinutes`='" + workingWeek.WorkingMinutes + "' " +
                           " WHERE `WorkingWeekID` = " + workingWeek.WorkingWeekID;
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;
            try
            {
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();
                databaseConnection.Close();
                return "succesfully updated";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public static string DeleteWorkingWeek(int workingWeekid)
        {
            string query = "DELETE FROM workingweek WHERE `WorkingWeekID` = " + workingWeekid;
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;
            try
            {
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();
                databaseConnection.Close();
                return "succesfully removed";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

    }
}

