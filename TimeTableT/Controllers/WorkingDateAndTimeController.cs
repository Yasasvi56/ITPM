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
    class WorkingDateAndTimeController
    {
        public static string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=itpm;";

        public static string AddWorkingDateAndTime(WorkingDateAndTime workingDateAndTime)
        {
            string query = "INSERT INTO workingdateandtime(`EmployeeID`,`EmployeeName`,`StartDate`,`EndDate`) " +
                           "VALUES " +
                           "('" + workingDateAndTime.EmployeeID + "', '" + workingDateAndTime.EmployeeName + "', '" + workingDateAndTime.StartDate + "', " +
                           "'" + workingDateAndTime.EndDate  + "')";

            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            try
            {
                databaseConnection.Open();
                MySqlDataReader myReader = commandDatabase.ExecuteReader();
                databaseConnection.Close();
                return "User succesfully registered";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public static WorkingDateAndTime SelectedWorkingDateAndTime(int workingDateAndTimeid)
        {
            string query = "SELECT EmployeeID, EmployeeName, StartDate, EndDate " +
                           " FROM workingdateandtime where workingDateAndTimeid  = " + workingDateAndTimeid;
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
                    WorkingDateAndTime workingDateAndTime = new WorkingDateAndTime();
                    if (reader.Read())
                    {
                        workingDateAndTime.EmployeeID = reader.GetString(0);
                        workingDateAndTime.EmployeeName = reader.GetString(1);
                        workingDateAndTime.StartDate = reader.GetString(2);
                        workingDateAndTime.EndDate = reader.GetString(3);
                        
                    }
                    return workingDateAndTime;
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



        public static DataTable FilterWorkingWeek()
        {
            string query = "SELECT WorkingDateAndTimeID, EmployeeID, EmployeeName, StartDate, EndDate  FROM  workingdateandtime "; 
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;
            DataTable dt = new DataTable();
            dt.Clear();
            dt.Columns.AddRange(new DataColumn[4] {
                    new DataColumn("ID", typeof(String)),
                    new DataColumn("EmployeeName", typeof(String)),
                    new DataColumn("Start Date", typeof(String)),
                    new DataColumn("End Date", typeof(String))
                  

            });
            try
            {
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        dt.Rows.Add(reader.GetString(0), reader.GetString(1), reader.GetString(2),
                            reader.GetString(3));
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
        public static string UpdateWorkingDateAndTime(WorkingDateAndTime workingDateAndTime)
        {
            string query = "UPDATE workingdateandtime SET `EmployeeID`='" + workingDateAndTime.EmployeeID + "', " +
                           "`EmployeeName`='" + workingDateAndTime.EmployeeName + "', " +
                           "`StartDate`='" + workingDateAndTime.StartDate + "', " +
                           "`EndDate`='" + workingDateAndTime.EndDate  + "' " +
                           " WHERE `WorkingDateAndTimeID` = " + workingDateAndTime.WorkingDateAndTimeID;
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;
            try
            {
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();
                databaseConnection.Close();
                return "User succesfully updated";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public static string DeleteWorkingDateAndTime(int WorkingDateAndTimeID)
        {
            string query = "DELETE FROM workingdateandtime WHERE `WorkingDateAndTimeID` = " + WorkingDateAndTimeID;
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;
            try
            {
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();
                databaseConnection.Close();
                return "User succesfully removed";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }



    }
}
