using Microsoft.EntityFrameworkCore;

namespace Turner_demo_server.Entities.TitleParticipant
{
    public class TitleParticipantContext: DbContext
    {
        public TitleParticipantContext(DbContextOptions<TitleParticipantContext> options) 
            : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<TitleParticipantModel> TitleParticipant { get; set; }
    }
}
