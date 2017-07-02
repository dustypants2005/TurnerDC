using Microsoft.EntityFrameworkCore;

namespace Turner_demo_server.Entities.OtherName
{
    public class OtherNameContext: DbContext
    {

        public OtherNameContext(DbContextOptions<OtherNameContext> context): base(context)
        {
            Database.EnsureCreated();
        }

        public DbSet<OtherNameModel> OtherName { get; set; }
    }
}
