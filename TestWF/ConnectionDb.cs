using System.Data.SqlClient;
namespace TestWF
{
    public static class ConnectionDb
    {
        private static string connString = @"Data Source=DIMAS-ПК\SQLEXPRESS;Initial Catalog=testdb;Integrated Security=True";
        static SqlConnection conn;
        static ConnectionDb()
        {
            conn = new SqlConnection(connString);
            conn.Open();
        }

        public static void ChangeConnection() {
            if (conn.State == System.Data.ConnectionState.Open)
            {
                conn.Close();
            }
            else
            {
                conn.Open();
            }
        }

    }
}
