using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CinemaSocial.Models.Entities
{
    [Table("diretors")]
    public class Director
    {
        [Key]
        public Guid Id { get; init; }
        public string Name { get; init; }
        public Guid IdMovie { get; init; }
        public Movie? Movie { get; init; }
    }
}
