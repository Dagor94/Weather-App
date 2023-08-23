using System.Data.SqlClient;

public static class Database
{
    public static string Server { get; set; } = "";
    public static string Username { get; set; } = "";
    public static string Password { get; set; } = "";

    public static void Execute(string sql)
    {
        using (var conn = new SqlConnection(connectionString))
        {
            conn.Open();
            SqlCommand sql_command = conn.CreateCommand();
            sql_command.CommandText = sql;
            sql_command.ExecuteNonQuery();
        }
    }

    static string connectionString
    {
        get
        {
            return $"Data source={Server}; Integrated Security=true;";
        }
    }
}