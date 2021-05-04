using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace ValueTypeExample.DataAccess
{
    class ApplicationDbContextFactory : IDesignTimeDbContextFactory<ApplicationDbContext>
    {
        public ApplicationDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();
            optionsBuilder.UseNpgsql("Server=localhost;Port=5432;Database=postgres;User Id=postgres;Password=password;");

            return new ApplicationDbContext(optionsBuilder.Options);

        }
    }
}
