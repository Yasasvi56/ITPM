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
    class TagController
    {
        public static string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=itpm;";
        public static string AddTag(Tag tag)
        {
            string query = "INSERT INTO tag(`tagName`,`tagCode`,`relatedTag`) " +
                           "VALUES " +
                           "('" + tag.tagName + "', '" + tag.tagCode + "', '" + tag.relatedTag + "')";

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

        public static DataTable FilterTag()
        {
            string query = "select tagId,tagName,tagCode,relatedTag FROM tag";
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;
            DataTable dt = new DataTable();
            dt.Clear();
            dt.Columns.AddRange(new DataColumn[4] {
                    new DataColumn("ID", typeof(string)),
                    new DataColumn("Tag Name", typeof(string)),
                    new DataColumn("Tag Code", typeof(string)),
                    new DataColumn("Related Tag", typeof(string)),
            });
            try
            {
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        dt.Rows.Add(reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3));
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





        public static Tag SelectedTag(int tagId)
        {
            string query = "SELECT tagName, tagCode, relatedTag " +
                           " FROM Tag where tagId  = " + tagId;
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
                    Tag tag = new Tag();
                    if (reader.Read())
                    {
                        tag.tagName = reader.GetString(0);
                        tag.tagCode = reader.GetString(1);
                        tag.relatedTag = reader.GetString(2);

                    }
                    return tag;
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

        public static string UpdateTag(Tag tag)
        {
            string query = "UPDATE tag SET `tagName`='" + tag.tagName + "', " +
                           "`tagCode`='" + tag.tagCode + "', " +
                           "`relatedTag`='" + tag.relatedTag + "', " +
                           " WHERE `tagId` = " + tag.tagId;
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

        public static string DeleteTag(int tagId)
        {
            string query = "DELETE FROM Students WHERE `tagId` = " + tagId;
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
