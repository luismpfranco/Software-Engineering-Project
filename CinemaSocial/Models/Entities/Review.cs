using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CinemaSocial.Models.Entities;

[Table("reviews")]
public class Review
{
    [Key]
    public Guid Id { get; set; }
    public Guid MovieId { get; set; }
    public int UserId { get; set; }
    public int Rate { get; set; }
    public string Description { get; set; }
    public Movie Movie { get; set; }
    public UserAccount User { get; set; }
}