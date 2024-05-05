using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CinemaSocial.Models.Entities
{
    [Table("genres")]
    public class Genre
    {
        [Key]
        public Guid Id { get; init; }
        public string Description { get; init; }

        public Guid IdMovie { get; init; }
        public Movie? Movie { get; init; }
    }
}
