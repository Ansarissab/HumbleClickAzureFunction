using System;
using Microsoft.EntityFrameworkCore;

namespace HumbleClick
{
    public class DemoDbContext : DbContext
    {
        public DemoDbContext(DbContextOptions<DemoDbContext> options) : base(options)
        {
        }

        public DbSet<Product> Product { get; set; }
    }
}
