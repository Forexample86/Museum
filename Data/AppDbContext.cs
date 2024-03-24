using Microsoft.EntityFrameworkCore;
using Museum.Models;
using System.Collections.Generic;
using Museum.Models;

namespace Museum.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
    }
}
