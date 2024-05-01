using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CinemaSocial.Models.Entities
{
    [Table("images")]
    public class Image
    {
        [Key]
        public Guid Id { get; set; }
        public string Url { get; set; }
        public string NumberUrl { get; set; }
        public Guid IdMovie { get; set; }
        public Movie Movie { get; set; }
    }
}
