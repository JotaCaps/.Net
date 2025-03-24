using BookManagement.API.Entities;
using Microsoft.EntityFrameworkCore;

namespace BookManagement.API.Persistence
{
    public class BookManagementDbContext : DbContext
    {
        public BookManagementDbContext(DbContextOptions<BookManagementDbContext> options)
            : base(options)
        {
            
        }

        public DbSet<Book> Books { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder
                .Entity<Book>(e =>
                {
                    e.HasKey(b => b.Id);
                });

            builder
                .Entity<User>(e =>
                {
                    e.HasKey(u => u.Id);
                });

            base.OnModelCreating(builder);
        }
    }
}
