using Microsoft.EntityFrameworkCore;

namespace Turner_demo_server.Entities.Award
{
    public class AwardContext: DbContext
    {
        public AwardContext(DbContextOptions<AwardContext> options) 
            : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<AwardModel> Award { get; set; }
    } 
}
