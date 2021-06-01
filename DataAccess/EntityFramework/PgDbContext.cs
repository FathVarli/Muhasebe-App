﻿using Entity.Concrete;
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

    }
}
