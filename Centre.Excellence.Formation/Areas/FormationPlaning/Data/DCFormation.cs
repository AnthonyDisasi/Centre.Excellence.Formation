using Centre.Excellence.Formation.Areas.FormationPlaning.Models;
using Microsoft.EntityFrameworkCore;

namespace Centre.Excellence.Formation.Areas.FormationPlaning.Data
{
    public class DCFormation : DbContext
    {
        public DCFormation(DbContextOptions<DCFormation> options) : base(options) { }

        public DbSet<Formateur> Formateurs { get; set; }
        public DbSet<Formations> Formations { get; set; }
        public DbSet<Former> Formers { get; set; }
        public DbSet<NiveauEtude> NiveauEtudes { get; set; }
        public DbSet<Modules> Modules { get; set; }
        public DbSet<Participant> Participants { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
