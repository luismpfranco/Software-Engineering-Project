using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CinemaSocial.Models.Entities
{
    [Table("images")]
    public class Image
    {
        [Key]
        public Guid Id { get; init; }
        public string Url { get; init; }
        public string NumberUrl { get; init; }
        public Guid IdMovie { get; init; }
        public Movie? Movie { get; init; }
    }
}
