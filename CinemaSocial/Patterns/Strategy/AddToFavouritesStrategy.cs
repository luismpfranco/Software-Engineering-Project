using CinemaSocial.Data;
using CinemaSocial.Models.Entities.Watchlists;
using Microsoft.EntityFrameworkCore;

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
    
    public async Task<bool> IsInWatchlistAsync(int userId, Guid movieId)
    {
        return await _context.WatchlistFavourites.AnyAsync(f => f.UserId == userId && f.MovieId == movieId);
    }
}