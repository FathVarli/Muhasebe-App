using Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using MuhasebeApp.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace MuhasebeApp.DataAccess.EntityFramework
{
    public class PgDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(@"Server = localhost; Port = 5432; Database = Muhasebe_Db; User Id = postgres; Password = admin;");
            optionsBuilder.EnableSensitiveDataLogging(sensitiveDataLoggingEnabled: true);

        }

        public DbSet<Kullanici> Kullanicis { get; set; }
        public DbSet<Gelir> Gelirs { get; set; }
        public DbSet<Gider> Giders { get; set; }
        public DbSet<Malzeme> Malzemes { get; set; }
        public DbSet<V_Malzeme_Chart> v_Malzeme_Charts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
        .Entity<V_Malzeme_Chart>(eb =>
             {
                 eb.HasNoKey();
                 eb.ToView("v_malzeme_chart");
             });


        }

    }
}
