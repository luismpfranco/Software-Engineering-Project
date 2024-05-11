using CinemaSocial.Data;
using CinemaSocial.Models.Entities.Watchlists;
using Microsoft.EntityFrameworkCore;

namespace CinemaSocial.Patterns.Strategy;

public class AddToWatchedStrategy : IWatchlistStrategy
{
    private readonly AppDbContext _context;
    
    public AddToWatchedStrategy(AppDbContext context)
    {
        _context = context;
    }
    public async Task ExecuteAsync(int userId, Guid movieId)
    {
        var watched = new WatchlistWatched { UserId = userId, MovieId = movieId };
        _context.WatchlistWatched.Add(watched);
        await _context.SaveChangesAsync();
    }
    
    public async Task<bool> IsInWatchlistAsync(int userId, Guid movieId)
    {
        return await _context.WatchlistWatched.AnyAsync(f => f.UserId == userId && f.MovieId == movieId);
    }
}