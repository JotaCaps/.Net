using Blog.Models;
using Dapper;
using Dapper.Contrib.Extensions;
using Microsoft.Data.SqlClient;
using Blog.Repositories;
using System.Data.Common;
using System.Reflection.Metadata.Ecma335;
using System.Reflection.Metadata;

internal class Program
{
    private const string CONNECTION_STRING = "Server=localhost,1433;Database=Blog;User ID=sa;Password=1q2w3e4r@#$;Encrypt=True;TrustServerCertificate=True;";
    private static void Main(string[] args)
    {
        var connection = new SqlConnection(CONNECTION_STRING);
        connection.Open();

        Console.WriteLine("O que deseja fazer?: ");
        Console.WriteLine("1 - Cadastrar usuário");
        int resp = int.Parse(Console.ReadLine());
        
        switch(resp)
        {
            case 1: 
                CreateUser(connection);
            break;
        }

        connection.Close();
    }

        static void ReadUserWithRoles(SqlConnection connection)
    {
        var repository = new UserRepository(connection);
        var items = repository.GetWithRoles();

        foreach (var item in items){
            Console.WriteLine(item.Name);
            foreach(var role in item.Roles)
            {
                Console.WriteLine($" - {role.Name}");
            }
        }
    }
        static void CreateUser(SqlConnection connection)
    {
        var repository = new Repository<User>(connection);
                
            Console.WriteLine("Nome: ");
            var nome = Console.ReadLine();
            Console.WriteLine("Email: ");
            var email = Console.ReadLine();
            Console.WriteLine("PassWordHash: ");
            var hash = Console.ReadLine();
            Console.WriteLine("Bio: ");
            var bio = Console.ReadLine();
            Console.WriteLine("Image: ");
            var image = Console.ReadLine();
            Console.WriteLine("Slug: ");
            var slug = Console.ReadLine();
        
        var newUser = new User { Name = nome, Email = email, PasswordHash = hash, Bio = bio, Image = image, Slug = slug};

        repository.Create(newUser);
    }
        static void UpdateUser(SqlConnection connection)
    {
        var repository = new Repository<User>(connection);
        var updateUser = new User {Id = 1, Name = "Mobile", Slug = "mobile"};

        repository.Update(updateUser);
    }
        static void DeleteUser(SqlConnection connection)
    {
        var repository = new Repository<User>(connection);
        var deleteUser = new User {Id = 5, Name = "Mobile", Slug = "mobile"};

        repository.Delete(deleteUser);
    }
        
        static void ReadRoles(SqlConnection connection)
    {
        var repository = new Repository<Role>(connection);
        var items = repository.Get();

        foreach (var item in items)
            Console.WriteLine(item.Name);
    }
        static void CreateRole(SqlConnection connection)
    {
        var repository = new Repository<Role>(connection);
        var newRole = new Role { Id = 1, Name = "Mobile", Slug = "mobile" };

        repository.Create(newRole);
    }
        static void UpdateRole(SqlConnection connection)
    {
        var repository = new Repository<Role>(connection);
        var updateRole = new Role {Id = 1, Name = "Mobile", Slug = "mobile"};

        repository.Update(updateRole);
    }
        static void DeleteRole(SqlConnection connection)
    {
        var repository = new Repository<Role>(connection);
        var deleteRole = new Role {Id = 5, Name = "Mobile", Slug = "mobile"};

        repository.Delete(deleteRole);
    }

        static void ReadTags(SqlConnection connection)
    {
        var repository = new Repository<Tag>(connection);
        var items = repository.Get();

        foreach (var item in items)
            Console.WriteLine(item.Name);
    }
        static void CreateTag(SqlConnection connection)
    {
        var repository = new Repository<Tag>(connection);
        var newTag = new Tag { Id = 1, Name = "Mobile", Slug = "mobile" };

        repository.Create(newTag);
    }
        static void UpdateTag(SqlConnection connection)
    {
        var repository = new Repository<Tag>(connection);
        var updateTag = new Tag {Id = 1, Name = "Mobile", Slug = "mobile"};

        repository.Update(updateTag);
    }
        static void DeleteTag(SqlConnection connection)
    {
        var repository = new Repository<Tag>(connection);
        var deleteTag = new Tag {Id = 5, Name = "Mobile", Slug = "mobile"};

        repository.Delete(deleteTag);
    }



}