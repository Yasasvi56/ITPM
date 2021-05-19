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
    class SubjectController
    {
        public static string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=itpm;";
        public static string AddSubject(Subject subject)
        {
            string query = "INSERT INTO Subject(`offeredyear`,`lecturehours`,`offeredsemester`,`tutorialhours`,`subjectname`,`labhours`," +
                           "`subjectcode`,`evoluationhours`) " +
                           "VALUES " +
                           "('" + subject.offeredyear + "', '" + subject.lecturehours + "', '" + subject.offeredsemester + "', " +
                           "'" + subject.tutorialhours + "','" + subject.subjectname + "','" + subject.labhours + "'," +
                           "'" + subject.subjectcode + "','" + subject.evoluationhours + "')";
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            try
            {
                databaseConnection.Open();
                MySqlDataReader myReader = commandDatabase.ExecuteReader();
                databaseConnection.Close();
                return "Subject succesfully registered";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public static DataTable FilterSubjects(string filtertext)
        {
            string query = "SELECT subjectid, subjectname, subjectcode, offeredyear, offeredsemester FROM Subject " +
                           "where subjectname like '%" + filtertext + "%'";
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
                    new DataColumn("Offered Year", typeof(string)),
                    new DataColumn("Offered Sem",typeof(string))
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

        public static Subject SelectedSubject(int subjectid)
        {
            string query = "SELECT offeredyear, lecturehours, offeredsemester, tutorialhours, subjectname, labhours, subjectcode, evoluationhours " +
                           " FROM Subject where subjectid  = " + subjectid;
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
                    Subject subject = new Subject();
                    if (reader.Read())
                    {
                        subject.offeredyear = reader.GetString(0);
                        subject.lecturehours = reader.GetInt32(1);
                        subject.offeredsemester = reader.GetInt32(2);
                        subject.tutorialhours = reader.GetInt32(3);
                        subject.subjectname = reader.GetString(4);
                        subject.labhours = reader.GetInt32(5);
                        subject.subjectcode = reader.GetString(6);
                        subject.evoluationhours = reader.GetInt32(7);
                    }
                    return subject;
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

        public static string UpdateSubject(Subject subject)
        {
            string query = "UPDATE Subject SET `offeredyear`='" + subject.offeredyear + "', " +
                           "`lecturehours`='" + subject.lecturehours + "', " +
                           "`offeredsemester`='" + subject.offeredsemester + "', " +
                           "`tutorialhours`='" + subject.tutorialhours + "', " +
                           "`subjectname`='" + subject.subjectname + "', " +
                           "`labhours`='" + subject.labhours + "', " +
                           "`subjectcode`='" + subject.subjectcode + "', " +
                           "`evoluationhours`='" + subject.evoluationhours + "' " +
                           " WHERE `subjectid` = " + subject.subjectid;
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;
            try
            {
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();
                databaseConnection.Close();
                return "Subject succesfully updated";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public static string DeleteSubject(int subjectid)
        {
            string query = "DELETE FROM Subject WHERE `subjectid` = " + subjectid;
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;
            try
            {
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();
                databaseConnection.Close();
                return "Subject succesfully removed";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

    }
}

