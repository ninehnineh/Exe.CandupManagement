using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exe.CandupManagement.Persistence
{
    public class CandupManagementDbContextFactory : IDesignTimeDbContextFactory<CandupManagementDbContext>
    {
        public CandupManagementDbContext CreateDbContext(string[] args)
        {
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "..\\Exe.CandupManagement.Api"))
                .AddJsonFile("appsettings.json")
                .Build();

            var builder = new DbContextOptionsBuilder<CandupManagementDbContext>();

            var connectionString = configuration.GetConnectionString("CandupManagementConnectionString");
            builder.UseSqlServer(connectionString);

            return new CandupManagementDbContext(builder.Options);
        }
    }
}
