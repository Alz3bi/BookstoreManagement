using BookstoreManagement.Models;
using Microsoft.EntityFrameworkCore;

namespace BookstoreManagement.Data
{
    public class BookstoreDbContext : DbContext
    {
        public DbSet<Book> Book { get; set; }
        public BookstoreDbContext(DbContextOptions options) : base(options)
        {
        }
    }
}
