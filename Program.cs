using MySql.Data.MySqlClient;
var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () =>
{
    // Replace placeholders with real Oracle MySQL values
    string connectionString = "Server=MYSQL_HOSTNAME;Port=3306;Database=DB_NAME;User ID=DB_USER;Password=DB_PASS;";
    try {
        using var conn = new MySqlConnection(connectionString);
        conn.Open();
        return "Connected to MySQL on Oracle Cloud!";
    } catch (Exception ex) {
        return $"DB connection failed: {ex.Message}";
    }
});

app.Run();
