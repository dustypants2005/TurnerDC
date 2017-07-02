using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Turner_demo_server.Entities.Title
{
    public class TitleModel
    {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TitleId { get; set; }
        [MaxLength(100)]
        public string TitleName { get; set; }
        [MaxLength(100)]
        public string TitleNameSortable { get; set; }
        public int? TitleTypeId { get; set; }
        public int? ReleaseYear { get; set; }
        public DateTime ProcessedDateTimeUTC { get; set; }
    }
}
