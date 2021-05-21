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
    class NotAvailableTimeController
    {
        public static string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=itpm;";
        public static string AddNotAvailableTime(NotAvailableTime notavailabletime)
        {
            string query = "INSERT INTO notavailabletime(`Lecturer`,`GroupID`,`SubGroupID`," +
                           "`SessionID`,`Time`) " +
                           "VALUES " +
                           "('" + notavailabletime.Lecturer + "', '" + notavailabletime.GroupID + "', '" + notavailabletime.SubGroupID + "', '" + notavailabletime.SessionID + "', " +
                           "'" + notavailabletime.Time + "')";
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


        public static NotAvailableTime SelectedNotAvailableTime(int notAvailableTimeid)
        {
            string query = "SELECT NotAvailableTimeID, Lecturer, GroupID, SubGroupID, SessionID, Time " +
                           " FROM notavailabletime where NotAvailableTimeID  = " + notAvailableTimeid;
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
                    NotAvailableTime notAvailableTime = new NotAvailableTime();
                    if (reader.Read())
                    {
                        notAvailableTime.NotAvailableTimeID = reader.GetInt32(0);
                        notAvailableTime.Lecturer = reader.GetString(1);
                        notAvailableTime.GroupID = reader.GetString(2);
                        notAvailableTime.SubGroupID = reader.GetString(3);
                        notAvailableTime.SessionID = reader.GetString(4);
                        notAvailableTime.Time = reader.GetString(5);

                    }
                    return notAvailableTime;
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


        public static DataTable FilterNotAvailableTime()
        {
            string query = "SELECT NotAvailableTimeID, Lecturer, GroupID, SubGroupID, SessionID, Time  FROM  notavailabletime ";
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;
            DataTable dt = new DataTable();
            dt.Clear();
            dt.Columns.AddRange(new DataColumn[6] {
                    new DataColumn("ID", typeof(int)),
                    new DataColumn("Lecturer", typeof(String)),
                    new DataColumn("GroupID", typeof(String)),
                    new DataColumn("SubGroupID", typeof(String)),
                    new DataColumn("SessionID", typeof(String)),
                    new DataColumn("Duration", typeof(String))


            });
            try
            {
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        dt.Rows.Add(reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4),
                            reader.GetString(5));
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


        public static string DeleteNotAvailableTime(int NotAvailableTimeID)
        {
            string query = "DELETE FROM notavailabletime WHERE `NotAvailableTimeID` = " + NotAvailableTimeID;
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
