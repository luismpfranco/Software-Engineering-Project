using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CinemaSocial.Models.Entities;

[Table("likes")]
public class Like
{
    [Key]
    public Guid Id { get; init; }
    public Guid ReviewId { get; init; }
    public int UserId { get; init; }
    public bool IsLike { get; set; }
}