using Microsoft.EntityFrameworkCore;

namespace Turner_demo_server.Entities.Participant
{
    public class ParticipantContext: DbContext
    {
        public ParticipantContext(DbContextOptions<ParticipantContext> context): base(context)
        {
            Database.EnsureCreated();
        }

        public DbSet<ParticipantModel> Participant { get; set; }
    }
}
