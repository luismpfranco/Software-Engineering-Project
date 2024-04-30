using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CinemaSocial.Models.Entities
{
    [Table("diretors")]
    public class Director
    {
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Guid IdMovie { get; set; }
    }
}
