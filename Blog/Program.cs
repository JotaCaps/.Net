using Blog.Models;
using Dapper;
using Dapper.Contrib.Extensions;
using Microsoft.Data.SqlClient;
using Blog.Repositories;

internal class Program
{
    private const string CONNECTION_STRING = "Server=localhost,1433;Database=Blog;User ID=sa;Password=1q2w3e4r@#$;Encrypt=True;TrustServerCertificate=True;";
    private static void Main(string[] args)
    {
        var connection = new SqlConnection(CONNECTION_STRING);
        connection.Open();
        
        ReadUsers(connection);
        ReadRoles(connection);
        //ReadUser();
        //CreateUser();
        //UpdateUser();
        //DeleteUser();

        connection.Close();
    }

    static void ReadUsers(SqlConnection connection)
    {     
        var repository = new Repository<User>(connection);
        var users = repository.Get();
        
        foreach (var user in users)
            Console.WriteLine(user.Name);   
    }

        static void ReadRoles(SqlConnection connection)
    {
        var repository = new RoleRepository(connection);
        var roles = repository.Get();
        
        foreach (var role in roles)
            Console.WriteLine(role.Name);   
    }

}