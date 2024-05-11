using CinemaSocial.Data;
using CinemaSocial.Models.Entities.Watchlists;
using Microsoft.EntityFrameworkCore;

namespace CinemaSocial.Repository;

public class WatchlistRepository(AppDbContext context) : IWatchlistRepository
{
    public async Task<List<WatchlistFavourites>?> GetWatchlistFavouritesAsync(int userId)
    {
        return await context.WatchlistFavourites
            .Where(w => w.UserId == userId)
            .ToListAsync();
    }

    public async Task<List<WatchlistWatched>?> GetWatchlistWatchedAsync(int userId)
    {
        return await context.WatchlistWatched
            .Where(w => w.UserId == userId)
            .ToListAsync();
    }

    public async Task<List<WatchlistToWatch>?> GetWatchlistToWatchAsync(int userId)
    {
        return await context.WatchlistToWatch
            .Where(w => w.UserId == userId)
            .ToListAsync();
    }
    
    public async Task<bool> IsInFavouritesAsync(int userId, Guid movieId)
    {
        return await context.WatchlistFavourites.AnyAsync(f => f.UserId == userId && f.MovieId == movieId);
    }
    
    public async Task<bool> IsInWatchedAsync(int userId, Guid movieId)
    {
        return await context.WatchlistWatched.AnyAsync(f => f.UserId == userId && f.MovieId == movieId);
    }
    
    public async Task<bool> IsInToWatchAsync(int userId, Guid movieId)
    {
        return await context.WatchlistToWatch.AnyAsync(f => f.UserId == userId && f.MovieId == movieId);
    }
}