using CentreFormation.Areas.Inventaire.Models;
using Microsoft.EntityFrameworkCore;

namespace CentreFormation.Areas.Inventaire.Data
{
    public class DCInventaire : DbContext
    {
        public DCInventaire(DbContextOptions<DCInventaire> options) : base(options) { }

        public DbSet<Mobilier> Mobiliers { get; set; }
        public DbSet<Fourniture> Fournitures { get; set; }
        public DbSet<Localisation> Localisations { get; set; }
        public DbSet<Materiel> Materiels { get; set; }
        public DbSet<Diagnostique> Diagnostiques { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
