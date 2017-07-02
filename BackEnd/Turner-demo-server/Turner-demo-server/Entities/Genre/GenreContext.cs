using Microsoft.EntityFrameworkCore;

namespace Turner_demo_server.Entities.Genre
{
    public class GenreContext: DbContext
    {
        public GenreContext(DbContextOptions<GenreContext> options) 
            : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<GenreModel> Genre { get; set; }
    }
}
