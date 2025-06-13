using MySql.Data.MySqlClient;

namespace inventryUI
{
    public class DBConnection
    {
        private static string connectionString = "server=localhost;user=root;password=;database=inventory_db;";

        public static MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }
    }
}
