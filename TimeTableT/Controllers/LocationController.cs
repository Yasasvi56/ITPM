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
    class LocationController
    {
        public static string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=itpm;";
        public static string AddLocation(Location location)
        {
            string query = "INSERT INTO Location(`room`,`day`,`StartTime`," +
                           "`EndTime`) " +
                           "VALUES " +
                           "('" + location.room + "', '" + location.day + "', '" + location.StartTime + "', " +
                           "'" + location.EndTime + "')";
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
    }
}
