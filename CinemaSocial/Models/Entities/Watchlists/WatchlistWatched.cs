using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CinemaSocial.Models.Entities.Watchlists;

[Table("WatchlistWatched")]
public class WatchlistWatched
{
    [Key]
    public int Id { get; init; }
    public int UserId { get; init; }
    public Movie Movie { get; init; } = null!;
    public Guid MovieId { get; init; }
}