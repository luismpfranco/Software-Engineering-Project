using CinemaSocial.Data;
using CinemaSocial.Models.Entities.Watchlists;

namespace CinemaSocial.Patterns.Strategy;

public class AddToFavouritesStrategy : IWatchlistStrategy
{
    private readonly AppDbContext _context;

    public AddToFavouritesStrategy(AppDbContext context)
    {
        _context = context;
    }

    public async Task ExecuteAsync(int userId, Guid movieId)
    {
        var favourite = new WatchlistFavourites { UserId = userId, MovieId = movieId };
        _context.WatchlistFavourites.Add(favourite);
        await _context.SaveChangesAsync();
    }
}