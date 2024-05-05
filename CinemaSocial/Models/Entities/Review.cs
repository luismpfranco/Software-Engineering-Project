using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CinemaSocial.Models.Entities;

[Table("reviews")]
public class Review
{
    [Key]
    public Guid Id { get; init; }
    public Guid MovieId { get; init; }
    public int UserId { get; init; }
    public int Rate { get; init; }
    public string Description { get; init; }
    public Movie Movie { get; }
    public UserAccount User { get; set; }
}