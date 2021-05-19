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
    class LecturerController
    {
        public static string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=itpm;";
        public static string AddLecturer(Lecturer lecturer)
        {
            string query = "INSERT INTO Lecturer(`lecturername`,`center`,`employeeid`,`building`,`faculty`,`level`," +
                           "`department`,`rank`) " +
                           "VALUES " +
                           "('" + lecturer.lecturername + "', '" + lecturer.center + "', '" + lecturer.employeeid + "', " +
                           "'" + lecturer.building + "','" + lecturer.faculty + "','" + lecturer.level + "'," +
                           "'" + lecturer.department + "','" + lecturer.rank + "')";
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            try
            {
                databaseConnection.Open();
                MySqlDataReader myReader = commandDatabase.ExecuteReader();
                databaseConnection.Close();
                return "Lecturer succesfully registered";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public static DataTable FilterLecturers(string filtertext)
        {
            string query = "SELECT lecturerid, lecturername, employeeid, faculty, level FROM Lecturer " +
                           "where lecturername like '%" + filtertext + "%'";
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;
            DataTable dt = new DataTable();
            dt.Clear();
            dt.Columns.AddRange(new DataColumn[5] {
                    new DataColumn("ID", typeof(int)),
                    new DataColumn("Name", typeof(string)),
                    new DataColumn("Emp ID", typeof(string)),
                    new DataColumn("Faculty", typeof(string)),
                    new DataColumn("Level",typeof(string))
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

        public static List<MyItem> FilterLecturersSession(string filtertext)
        {
            string query = "SELECT lecturerid, lecturername FROM Lecturer " +
                           "where lecturername like '%" + filtertext + "%'";
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;
            List<MyItem> list = new List<MyItem>();
            try
            {
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        MyItem item = new MyItem();
                        item.value = reader.GetInt32(0);
                        item.text = reader.GetString(1);
                        list.Add(item);
                    }
                }
                else
                {
                    Console.WriteLine("No rows found.");
                    return null;
                }
                databaseConnection.Close();
                return list;
            }
            catch (Exception ex)
            {
                Console.WriteLine("No rows found.");
                return null;
            }
        }

        public static Lecturer SelectedLecturer(int lecturerid)
        {
            string query = "SELECT lecturername, center, employeeid, building, faculty, level, department, rank " +
                           " FROM Lecturer where lecturerid  = " + lecturerid;
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
                    Lecturer lecturer = new Lecturer();
                    if (reader.Read())
                    {
                        lecturer.lecturername = reader.GetString(0);
                        lecturer.center = reader.GetString(1);
                        lecturer.employeeid = reader.GetString(2);
                        lecturer.building = reader.GetString(3);
                        lecturer.faculty = reader.GetString(4);
                        lecturer.level = reader.GetInt32(5);
                        lecturer.department = reader.GetString(6);
                        lecturer.rank = reader.GetString(7);
                    }
                    return lecturer;
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

        public static string UpdateLecturer(Lecturer lecturer)
        {
            string query = "UPDATE Lecturer SET `lecturername`='" + lecturer.lecturername + "', " +
                           "`center`='" + lecturer.center + "', " +
                           "`employeeid`='" + lecturer.employeeid + "', " +
                           "`building`='" + lecturer.building + "', " +
                           "`faculty`='" + lecturer.faculty + "', " +
                           "`level`='" + lecturer.level + "', " +
                           "`department`='" + lecturer.department + "', " +
                           "`rank`='" + lecturer.rank + "' " +
                           " WHERE `lecturerid` = " + lecturer.lecturerid;
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;
            try
            {
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();
                databaseConnection.Close();
                return "Lecturer succesfully updated";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public static string DeleteLecturer(int lecturerid)
        {
            string query = "DELETE FROM Lecturer WHERE `lecturerid` = " + lecturerid;
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;
            try
            {
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();
                databaseConnection.Close();
                return "Lecturer succesfully removed";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

    }
}
