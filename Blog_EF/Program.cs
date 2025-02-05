using Blog_EF.Data;
using Blog_EF.Models;
using Microsoft.EntityFrameworkCore;


internal class Program
{
    private static void Main(string[] args)
    {
        using var context = new BlogDataContext();
    }
}