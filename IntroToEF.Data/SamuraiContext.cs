using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IntroToEF.Data.Entities;

namespace IntroToEF.Data
{
    internal class SamuraiContext : DbContext
    {
        public DbSet<Quote> Quotes { get; set; }
        public DbSet<Samurai> SamuraiMV { get; set; }
        public DbSet<Horse> Horses { get; set; }

        private const string CONNECTION = @"Server=.\SQLEXPRESS;Database=SamuraiDB;Trusted_Connection=True;";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(CONNECTION);
        }
    }
}