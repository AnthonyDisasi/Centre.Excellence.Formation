using Centre.Excellence.Formation.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Centre.Excellence.Formation.Data
{
    public class DbAuthentification : IdentityDbContext<ApplicationUSer>
    {
        public DbAuthentification(DbContextOptions<DbAuthentification> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
