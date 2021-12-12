using KnightOnlineDropTakipV2.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnightOnlineDropTakipV2.Data
{
    public class DataContext : DbContext
    {
        public DbSet<Drop> Drops { get; set; }

        public string DbPath { get; private set; }

        public DataContext()
        {
            DbPath = $"kodrop.db";
            Database.EnsureCreated();
        }

        // The following configures EF to create a Sqlite database file in the
        // special "local" folder for your platform.
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite($"Data Source={DbPath}");
    }
}
