using Microsoft.EntityFrameworkCore;

namespace Turner_demo_server.Entities.Title
{
    public class TitleContext: DbContext
    {
        public TitleContext(DbContextOptions<TitleContext> options) 
            : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<TitleModel> Title { get; set; }
    }
}
