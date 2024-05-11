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
}