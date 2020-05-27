using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

using Compliance.Domain.Data;

namespace Compliance.Domain
{
 public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<DatabaseContext>
    {
        public DatabaseContext CreateDbContext(string[] args)
        {
            
            var optionsBuilder = new DbContextOptionsBuilder<DatabaseContext>();
                //optionsBuilder.UseSqlite(@"Data Source=..\db\financial.db");

            return new DatabaseContext(optionsBuilder.Options);
        }
    }
}