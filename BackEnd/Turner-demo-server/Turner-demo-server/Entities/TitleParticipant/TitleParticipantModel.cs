using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Turner_demo_server.Entities.Participant;
using Turner_demo_server.Entities.Title;

namespace Turner_demo_server.Entities.TitleParticipant
{
    public class TitleParticipantModel
    {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public bool IsKey { get; set; }

        [MaxLength(100)]
        public string RoleType{ get; set; }

        public bool IsOnScreen { get; set; }

        [ForeignKey("TitleId")]
        public TitleModel Title { get; set; }
        public int TitleId { get; set; }

        [ForeignKey("ParticipantId")]
        public ParticipantModel Participant { get; set; }
        public int ParticipantId  { get; set; }
    }
}
