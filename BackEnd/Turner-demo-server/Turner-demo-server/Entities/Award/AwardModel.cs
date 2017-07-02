using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Turner_demo_server.Entities.Title;

namespace Turner_demo_server.Entities.Award
{
    public class AwardModel
    {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public bool? AwardWon { get; set; }
        public int? AwardYear { get; set; }
        [MaxLength(100)]
        public string Award { get; set; }
        [MaxLength(100)]
        public string AwardCompany { get; set; }
        
        [ForeignKey("TitleId")]
        public TitleModel TitleModel { get; set; }
        public int TitleId { get; set; }
    }
}
