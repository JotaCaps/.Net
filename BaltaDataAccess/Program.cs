// See https://aka.ms/new-console-template for more information

using System.Data;
using Microsoft.Data.SqlClient;

internal class Program
{
    private static void Main(string[] args)
    {
        const string connectionString = "Server=localhost,1433;Database=balta;User ID=sa;Password=1q2w3e4r@#$";

        using (var connection = new SqlConnection(connectionString))
        {
            Console.WriteLine("Conectado");
            connection.Open();

            using var command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = CommandType.Text;
            command.CommandText = "SELECT [Id], [Title] FROM [Category]";

            var reader = command.ExecuteReader();
            while (reader.Read())
            {
                Console.WriteLine($"{reader.GetGuid(0)} - {reader.GetString(1)}");
            }
        }
    }
}