using Microsoft.EntityFrameworkCore;

namespace Turner_demo_server.Entities.TitleGenre
{
    public class TitleGenreContext: DbContext
    {
        public TitleGenreContext(DbContextOptions<TitleGenreContext> options) 
            : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<TitleGenreModel> TitleGenre { get; set; }
    }
}
