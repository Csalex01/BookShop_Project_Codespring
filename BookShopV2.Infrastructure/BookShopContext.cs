using BookShopV2.Core.Models;
using BookShopV2.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace BookShopV2.Infrastructure
{
    public class BookShopContext : DbContext
    {
        public DbSet<BookDAL> Books { get; set; }
        public DbSet<AuthorDAL> Authors { get; set; }

        public BookShopContext(DbContextOptions<BookShopContext> options) : base(options) { }

        internal object AsNoTracking()
        {
            throw new NotImplementedException();
        }
    }
}
