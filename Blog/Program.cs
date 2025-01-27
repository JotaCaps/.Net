using BLog.Models;
using Dapper;
using Dapper.Contrib.Extensions;
using Microsoft.Data.SqlClient;

internal class Program
{
    private const string CONNECTION_STRING = "Server=localhost,1433;Database=Blog;User ID=sa;Password=1q2w3e4r@#$;Encrypt=True;TrustServerCertificate=True;";
    private static void Main(string[] args)
    {
        //ReadUsers();
        //ReadUser();
        //CreateUser();
        //UpdateUser();
        DeleteUser();
    }

    static void ReadUsers()
    {
         using (var connection = new SqlConnection(CONNECTION_STRING))
        {
            var users = connection.GetAll<User>();

            foreach (var user in users)
                {
                    Console.WriteLine(user.Name);
                }
        }
    }

    static void ReadUser()
    {
         using (var connection = new SqlConnection(CONNECTION_STRING))
        {
            var user = connection.Get<User>(1);
            Console.WriteLine(user.Name);
        }
    }

    static void CreateUser()
    {
        var user = new User()
        {
            Bio="Equipe balta.Io",
            Email="hello@balta.io",
            Image="https://",
            Name="Equipe balta.io",
            PasswordHash="Hash",
            Slug="equipe_balta"
        };
        
        using (var connection = new SqlConnection(CONNECTION_STRING))
        {
            connection.Insert<User>(user);
            Console.WriteLine("Cadastro realizado com secesso!");
        }
    }

    static void UpdateUser()
    {
        var user = new User()
        {
            Id=2,
            Bio="Equipe | balta.Io",
            Email="hello@balta.io",
            Image="https://",
            Name="Equipe de suporte balta.io",
            PasswordHash="Hash",
            Slug="equipe_balta"
        };
        
        using (var connection = new SqlConnection(CONNECTION_STRING))
        {
            connection.Update<User>(user);
            Console.WriteLine("Atualização realizada com secesso!");
        }
    }

    static void DeleteUser()
    {
        using (var connection = new SqlConnection(CONNECTION_STRING))
        {
            var user = connection.Get<User>(2);
            connection.Delete<User>(user);
            Console.WriteLine("Exclusão realizada com secesso!");
        }
    }

}