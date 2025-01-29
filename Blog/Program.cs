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

        ReadUsers(connection);
        ReadRoles(connection);
        ReadTags(connection);
        //CreateTag(connection);
        //UpdateTag(connection);
        DeleteTag(connection);

        connection.Close();
    }

    static void ReadUsers(SqlConnection connection)
    {
        var repository = new Repository<User>(connection);
        var items = repository.Get();

        foreach (var item in items)
            Console.WriteLine(item.Name);
    }
    static void ReadRoles(SqlConnection connection)
    {
        var repository = new Repository<Role>(connection);
        var items = repository.Get();

        foreach (var item in items)
            Console.WriteLine(item.Name);
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