using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Turner_demo_server.Entities.Title;

namespace Turner_demo_server.Entities.OtherName
{
    public class OtherNameModel
    {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [MaxLength(100)]
        public string TitleNameType { get; set; }

        [MaxLength(100)]
        public string TitleNameSortable { get; set; }

        [MaxLength(100)]
        public string TitleName { get; set; }

        [ForeignKey("TitleId")]
        public TitleModel Title { get; set; }
        public int? TitleId { get; set; }
    }
}
