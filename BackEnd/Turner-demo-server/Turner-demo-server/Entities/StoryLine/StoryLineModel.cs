using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Turner_demo_server.Entities.Title;

namespace Turner_demo_server.Entities.StoryLine
{
    public class StoryLineModel
    {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [MaxLength(100)]
        public string Language { get; set; }

        [MaxLength(100)]
        public string Type { get; set; }

        public string Description { get; set; }

        [ForeignKey("TitleId")]
        public TitleModel Title { get; set; }
        public int TitleId { get; set; }
    }
}
