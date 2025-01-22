using System.Data;
using Dapper;
using Microsoft.Data.SqlClient;
using BaltaDataAccess.Models;

internal class Program
{
    private static void Main(string[] args)
    {
        const string connectionString = "Server=localhost,1433;Database=balta;User ID=sa;Password=1q2w3e4r@#$;TrustServerCertificate=True";


        using (var connection = new SqlConnection(connectionString))
        {
           var categories = connection.Query<Category>("SELECT [Id], [Title] FROM [Category]");
           foreach(var category in categories)
           {
                Console.WriteLine($"{category.Id} - {category.Title}");
           }
        }
    }
}