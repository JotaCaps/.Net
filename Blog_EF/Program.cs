using Blog_EF.Data;
using Blog_EF.Models;


internal class Program
{
    private static void Main(string[] args)
    {
        using(var context = new BlogDataContext())
        {
            var tag = new Tag { Name = "ASP.NET", Slug = "aspnet"};
            context.Tags.Add(tag);
            context.SaveChanges();
        }
    }
}