using Microsoft.EntityFrameworkCore;

namespace Kartverket2025prosjekt.Data
{
    public class KartverketDbContext : DbContext
    {
        public KartverketDbContext(DbContextOptions<KartverketDbContext> options)
            : base(options)
        {
        }

        
        // Add DbSet for each model you want to store in the database
    }
}
