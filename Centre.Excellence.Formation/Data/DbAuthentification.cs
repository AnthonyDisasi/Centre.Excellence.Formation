using Centre.Excellence.Formation.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Centre.Excellence.Formation.Data
{
    public class DbAuthentification : DbContext
    {
        public DbAuthentification(DbContextOptions<DbAuthentification> options) : base(options) { }

        public virtual DbSet<Personne> Personnes { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
