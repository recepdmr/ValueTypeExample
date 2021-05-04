using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;
using ValueTypeExample.Entities;

namespace ValueTypeExample.DataAccess
{
    class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext([NotNull] DbContextOptions options) : base(options)
        {
        }

        public DbSet<Ticket> Tickets { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);

            base.OnModelCreating(modelBuilder);
        }

    }
}
