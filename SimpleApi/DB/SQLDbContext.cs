using Microsoft.EntityFrameworkCore;
using SimpleApi.Entities;

namespace SimpleApi.DB
{
    public class SQLDbContext : DbContext
    {
        public SQLDbContext(DbContextOptions<SQLDbContext> options) : base(options)
        {
            
        }

        public DbSet<SimpleObject> SimpleObjects { get; set; }
    }
}
