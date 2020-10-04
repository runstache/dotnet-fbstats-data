using FbStats.Data.Configuration;
using FbStats.Data.DataObjects;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FbStats.Data.Contexts
{
    public class SqlContext : DbContext
    {
        public SqlContext(string connString):base(connString)
        {
            Configuration.LazyLoadingEnabled = false;
            Configuration.ProxyCreationEnabled = false;
        }

        public DbSet<Team> Teams { get; set; }
        public DbSet<GameStat> Stats { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new GameStatConfiguration());
            modelBuilder.Configurations.Add(new TeamConfiguration());
            base.OnModelCreating(modelBuilder);
        }

    }
}
