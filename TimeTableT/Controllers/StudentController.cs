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
    class StudentController
    {
        public static string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=itpm;";
        public static string AddStudent(Students students)
        {
            string query = "INSERT INTO students(`acadamicYearSem`,`programme`,`groupNo`,`subGroupNo`,`groupId`,`subGroupId`) " +
                           "VALUES " +
                           "('" + students.acadamicYearSem + "', '" + students.programme + "', '" + students.groupNo + "', " +
                           "'" + students.subGroupNo + "','" + students.groupId + "','" + students.subGroupId + "')";

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

        public static DataTable FilterStudents()
        {
            string query = "SELECT studentId, acadamicYearSem, programme, groupNo, subGroupNo,groupId,subGroupId FROM students";
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;
            DataTable dt = new DataTable();
            dt.Clear();
            dt.Columns.AddRange(new DataColumn[7] {
                    new DataColumn("ID", typeof(int)),
                    new DataColumn("Acadamic Year and Sem", typeof(string)),
                    new DataColumn("Programme", typeof(string)),
                    new DataColumn("Group No", typeof(int)),
                    new DataColumn("Group ID",typeof(int)),
                    new DataColumn("Sub Group No",typeof(string)),
                    new DataColumn("Sub Group ID",typeof(string))
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
                            reader.GetInt32(3), reader.GetInt32(4), reader.GetString(5), reader.GetString(6));
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




        public static Students SelectedStudents(int studentId)
        {
            string query = "SELECT acadamicYearSem, programme, groupNo, subGroupNo, groupId, subGroupId " +
                           " FROM Students where studentId  = " + studentId;
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
                    Students students = new Students();
                    if (reader.Read())
                    {
                        students.acadamicYearSem = reader.GetString(0);
                        students.programme = reader.GetString(1);
                        students.groupNo = reader.GetInt32(2);
                        students.subGroupNo = reader.GetInt32(3);
                        students.groupId = reader.GetString(4);
                        students.subGroupId = reader.GetString(5);

                    }
                    return students;
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

        public static string UpdateStudents(Students students)
        {
            string query = "UPDATE students SET `acadamicYearSem`='" + students.acadamicYearSem + "', " +
                           "`programme`='" + students.programme + "', " +
                           "`groupNo`='" + students.groupNo + "', " +
                           "`subGroupNo`='" + students.subGroupNo + "', " +
                           "`groupId`='" + students.groupId + "', " +
                           "`subGroupId`='" + students.subGroupId + "', " +
                           " WHERE `studentId` =" + students.studentId;
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

        public static string DeleteStudents(int studentId)
        {
            string query = "DELETE FROM Students WHERE `studentId` = " + studentId;
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
