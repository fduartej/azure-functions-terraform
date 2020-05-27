using Microsoft.EntityFrameworkCore;
using Compliance.Domain.Models;

namespace Compliance.Domain.Data
{
    public class DatabaseContext : DbContext
    {

         public DatabaseContext(DbContextOptions<DatabaseContext> options)
            : base(options)
        {

        }

        public DbSet<Payment> Payments { get; set; }
        public DbSet<Worldcheck> Worldchecks { get; set; }

    }

}