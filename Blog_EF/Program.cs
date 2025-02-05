using Blog_EF.Data;
using Blog_EF.Models;
using Microsoft.EntityFrameworkCore;


internal class Program
{
    private static void Main(string[] args)
    {
        using var context = new BlogDataContext();

        context.Users.Add(new User{
            Bio = "9x Microsoft MVP",
            Email = "andre@balta.com",
            Image = "https://balta.io",
            Name = "André Baltieri",
            PassWordHash = "1234",
            Slug = "andre-baltieri"
        });
        context.SaveChanges();
    }
}