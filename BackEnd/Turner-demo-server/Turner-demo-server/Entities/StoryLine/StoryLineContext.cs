using Microsoft.EntityFrameworkCore;

namespace Turner_demo_server.Entities.StoryLine
{
    public class StoryLineContext: DbContext
    {
        public StoryLineContext(DbContextOptions<StoryLineContext> context): base(context)
        {
            Database.EnsureCreated();
        }

        public DbSet<StoryLineModel> StoryLine { get; set; }
    }
}
