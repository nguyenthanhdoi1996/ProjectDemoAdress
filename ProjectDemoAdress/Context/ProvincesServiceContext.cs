using Microsoft.EntityFrameworkCore;
using ProjectDemoAdress.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectDemoAdress.Context
{
    public class ProvincesServiceContext : DbContext
    {
        public ProvincesServiceContext(DbContextOptions<ProvincesServiceContext> options) : base(options)
        {

        }

        public ProvincesServiceContext() : this(GetOptions(Startup.ConnectionString))
        { }

        public ProvincesServiceContext(string connectionString) : this(GetOptions(connectionString))
        { }

        private static DbContextOptions<ProvincesServiceContext> GetOptions(string connectionString)
        {
            return SqlServerDbContextOptionsExtensions
                .UseSqlServer(new DbContextOptionsBuilder<ProvincesServiceContext>(), connectionString).Options;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }
        public DbSet<Provinces> Provinces { get; set; }
    }
}
