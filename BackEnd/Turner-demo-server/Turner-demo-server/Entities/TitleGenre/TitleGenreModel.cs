using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Turner_demo_server.Entities.Genre;
using Turner_demo_server.Entities.Title;

namespace Turner_demo_server.Entities.TitleGenre
{
    public class TitleGenreModel
    {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [ForeignKey("TitleId")]
        public TitleModel Title { get; set; }
        public int TitleId { get; set; }

        [ForeignKey("GenreId")]
        public GenreModel Genre { get; set; }
        public int GenreId { get; set; }
    }
}
