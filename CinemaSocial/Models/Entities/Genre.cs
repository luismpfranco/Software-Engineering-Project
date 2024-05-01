using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CinemaSocial.Models.Entities
{
    [Table("genres")]
    public class Genre
    {
        [Key]
        public Guid Id { get; set; }
        public string Description { get; set; }

        public Guid IdMovie { get; set; }
        public Movie Movie { get; set; }
    }
}
