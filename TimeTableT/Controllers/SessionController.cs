using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeTableT.Models;

namespace TimeTableT.Controllers
{
    class SessionController
    {
        public static string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=itpm;";
        public static string AddSession(Session session, List<int> lecturerids)
        {
            string query = "INSERT INTO Session(`tag`,`sgroup`,`subject`,`noofstudent`,`duration`) " +
                           "VALUES " +
                           "('" + session.tag + "', '" + session.sgroup + "', '" + session.subject + "', " +
                           "'" + session.noofstudent + "','" + session.duration + "')";
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            try
            {
                databaseConnection.Open();
                MySqlDataReader myReader = commandDatabase.ExecuteReader();
                databaseConnection.Close();
                if (myReader.RecordsAffected>0)
                {
                    foreach (int lecturerid in lecturerids) 
                    {
                        query = "INSERT INTO Sessionlec(`sessionid`,`lecturerid`) " +
                            "VALUES ((select max(sessionid) from session), " + lecturerid + ")";
                        commandDatabase = new MySqlCommand(query, databaseConnection);
                        commandDatabase.CommandTimeout = 60;
                        databaseConnection.Open();
                        myReader = commandDatabase.ExecuteReader();
                        databaseConnection.Close();
                    }
                }
                return "Session succesfully added";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public static DataTable FilterSessions(string lecturer, string year)
        {
            string query = "SELECT distinct Session.sessionid, subject, subjectcode, sgroup, tag FROM Session left outer join Subject " + 
                            "on Session.subject = Subject.subjectname " +
                            "left outer join sessionlec on session.sessionid = sessionlec.sessionid left outer join lecturer " +
                            "on sessionlec.lecturerid = lecturer.lecturerid where " +
                            "Subject.offeredyear like '%"+year+"%' and lecturername like '%"+lecturer+"%'";
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;
            DataTable dt = new DataTable();
            dt.Clear();
            dt.Columns.AddRange(new DataColumn[5] {
                    new DataColumn("ID", typeof(int)),
                    new DataColumn("Subject Name", typeof(string)),
                    new DataColumn("Subject Code", typeof(string)),
                    new DataColumn("Group ID", typeof(string)),
                    new DataColumn("Tag",typeof(string))
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
                            reader.GetString(3), reader.GetString(4));
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
        public static List<MyItem> SelectedLecturers(int sessionid)
        {
            string query = "SELECT Lecturer.lecturername, Lecturer.lecturerid FROM Lecturer left outer join sessionlec on " +
                           "Lecturer.lecturerid = sessionlec.lecturerid where sessionlec.sessionid  = " + sessionid;
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;
            try
            {
                List<MyItem> list = new List<MyItem>();
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        MyItem item = new MyItem { text= reader.GetString(0) ,value = reader.GetInt32(1)};
                        list.Add(item);
                    }   
                }
                else
                {
                    Console.WriteLine("No rows found.");
                }
                databaseConnection.Close();
                return list;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        public static Session ViewSessions(int sessionid)
        {
            string query = "SELECT sessionid, subject, sgroup, tag, noofstudent, duration FROM Session " +
                           "where sessionid = " + sessionid;
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;
            Session session = new Session();
            try
            {
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        session.sessionid = sessionid;
                        session.subject = reader.GetString(1);
                        session.sgroup = reader.GetString(2);
                        session.tag = reader.GetString(3);
                        session.noofstudent = reader.GetInt32(4);
                        session.duration = reader.GetInt32(5);
                    }
                }
                else
                {
                    Console.WriteLine("No rows found.");
                    return null;
                }
                databaseConnection.Close();
                return session;
            }
            catch (Exception ex)
            {
                Console.WriteLine("No rows found.");
                return null;
            }
        }
        public static string DeleteSession(int sessionid)
        {
            string query = "DELETE FROM session WHERE `sessionid` = " + sessionid;
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;
            try
            {
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();
                databaseConnection.Close();
                return "Session succesfully removed";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public static string UpdateSession(Session session, List<int> lecturerids)
        {
            string query = "UPDATE Session SET `tag`='" + session.tag + "', " +
                           "`sgroup`='" + session.sgroup + "', " +
                           "`subject`='" + session.subject + "', " +
                           "`noofstudent`=" + session.noofstudent + ", " +
                           "`duration`=" + session.duration +
                           " WHERE `sessionid` = " + session.sessionid;
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;
            try
            {
                databaseConnection.Open();
                MySqlDataReader myReader = commandDatabase.ExecuteReader();
                databaseConnection.Close();
                //delete existing session records start
                query = "DELETE from Sessionlec WHERE `sessionid` = " + session.sessionid;
                commandDatabase = new MySqlCommand(query, databaseConnection);
                commandDatabase.CommandTimeout = 60;
                databaseConnection.Open();
                myReader = commandDatabase.ExecuteReader();
                databaseConnection.Close();
                //delete existing session records end
                if (myReader.RecordsAffected > 0)
                {
                    foreach (int lecturerid in lecturerids)
                    {
                        query = "INSERT INTO Sessionlec(`sessionid`,`lecturerid`) " +
                                "VALUES (" + session.sessionid + ", " + lecturerid + ")";
                        commandDatabase = new MySqlCommand(query, databaseConnection);
                        commandDatabase.CommandTimeout = 60;
                        databaseConnection.Open();
                        myReader = commandDatabase.ExecuteReader();
                        databaseConnection.Close();
                    }
                }
                return "Session succesfully updated";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
