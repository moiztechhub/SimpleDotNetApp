using System;
using MySql.Data.MySqlClient;

class Program
{
    static void Main()
    {
        string connectionString = "server=localhost;user=admin;password=admin@123pass;database=testdb";

        try
        {
            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                Console.WriteLine("✅ Database connected successfully!");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("❌ Connection failed:");
            Console.WriteLine(ex.Message);
        }
    }
}
