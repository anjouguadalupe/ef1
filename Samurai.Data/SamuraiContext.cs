using Microsoft.EntityFrameworkCore;
using SamuraiApp.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Samurai.Data
{
    public class SamuraiContext:DbContext
    {
        public DbSet<SamuraiApp.Domain.Samurai> Samurais { get; set; }
        public DbSet<Quote> Quotes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source= 2LK4RC2; Initial Catalog=SamuraiAppData; Trusted_Connection=True;");
        }
    }
}
