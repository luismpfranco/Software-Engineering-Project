using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using CinemaSocial.Models.Entities;

namespace CinemaSocial.Services;

[Table("watchlists")]
public class Watchlist
{
    [Key]
    public int Id { get; set; }
    public string UserId { get; set; }
    public List<Movie> WatchlistMovies { get; set; }
    public string Name { get; set; }
}