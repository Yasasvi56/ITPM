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
    class SessionsController
    {
        public static string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=itpm;";

        public static DataTable FilterSessions()
        {
            string query = "SELECT sessionsID, lecturer1, lecturer2, subjectCode, subject,groupId,relatedTag FROM sessions";
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;
            DataTable dt = new DataTable();
            dt.Clear();
            dt.Columns.AddRange(new DataColumn[7] {
                    new DataColumn("ID", typeof(int)),
                    new DataColumn("lecturer 1", typeof(string)),
                    new DataColumn("lecturer 2", typeof(string)),
                    new DataColumn("subject Code", typeof(string)),
                    new DataColumn("subject",typeof(string)),
                    new DataColumn("group Id",typeof(string)),
                    new DataColumn("related Tag",typeof(string))
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
                            reader.GetString(3), reader.GetString(4), reader.GetString(5), reader.GetString(6));
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

        public static Sessions SelectedSessionss(int sessionsID)
        {
            string query = "SELECT lecturer1, lecturer2, subjectCode, subject, groupId, relatedTag " +
                           " FROM sessions where sessionsID  = " + sessionsID;
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
                    Sessions sessions = new Sessions();
                    if (reader.Read())
                    {
                        sessions.lecturer1 = reader.GetString(0);
                        sessions.lecturer2 = reader.GetString(1);
                        sessions.subjectCode = reader.GetString(2);
                        sessions.subject = reader.GetString(3);
                        sessions.groupId = reader.GetString(4);
                        sessions.relatedTag = reader.GetString(5);

                    }
                    return sessions;
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


    }
}
