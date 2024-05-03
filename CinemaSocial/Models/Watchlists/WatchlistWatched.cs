using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using CinemaSocial.Models.Entities;

namespace CinemaSocial.Models.Watchlists;

[Table("WatchlistWatched")]
public class WatchlistWatched
{
    [Key]
    public int Id { get; set; }
    public int UserId { get; set; }
    public Movie Movie { get; set; }
    public Guid MovieId { get; set; }
}