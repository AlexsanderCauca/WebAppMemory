using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class AdminDbContext : DbContext
    {
        private readonly IConfiguration configuration;
        public DbSet<Entitties.AppAdmins> Admins {get; set; }
        public AdminDbContext(IConfiguration configuration)
        {
            this.configuration = configuration;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(configuration.GetConnectionString("AdminDB"));
        }

    }
}