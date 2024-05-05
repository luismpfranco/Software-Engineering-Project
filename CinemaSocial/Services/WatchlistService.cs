using CinemaSocial.Data;
using CinemaSocial.Models.Entities.Watchlists;
using Microsoft.EntityFrameworkCore;

namespace CinemaSocial.Services;

public class WatchlistService(AppDbContext context)
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
    
    public async Task AddToFavouritesAsync(int userId, Guid movieId)
    {
        var favourite = new WatchlistFavourites { UserId = userId, MovieId = movieId };
        context.WatchlistFavourites.Add(favourite);
        await context.SaveChangesAsync();
    }

    public async Task RemoveFromFavouritesAsync(int userId, Guid movieId)
    {
        var favourite = await context.WatchlistFavourites.FirstOrDefaultAsync(f => f.UserId == userId && f.MovieId == movieId);
        if (favourite != null)
        {
            context.WatchlistFavourites.Remove(favourite);
            await context.SaveChangesAsync();
        }
    }
    
    public async Task<bool> IsInFavouritesAsync(int userId, Guid movieId)
    {
        return await context.WatchlistFavourites.AnyAsync(f => f.UserId == userId && f.MovieId == movieId);
    }

    public async Task AddWatchedAsync(int userId, Guid movieId)
    {
        var watched = new WatchlistWatched { UserId = userId, MovieId = movieId };
        context.WatchlistWatched.Add(watched);
        await context.SaveChangesAsync();
    }

    public async Task RemoveFromWatchedAsync(int userId, Guid movieId)
    {
        var watched = await context.WatchlistWatched.FirstOrDefaultAsync(w => w.UserId == userId && w.MovieId == movieId);
        if (watched != null)
        {
            context.WatchlistWatched.Remove(watched);
            await context.SaveChangesAsync();
        }
    }
    
    public async Task<bool> IsInWatchedAsync(int userId, Guid movieId)
    {
        return await context.WatchlistWatched.AnyAsync(f => f.UserId == userId && f.MovieId == movieId);
    }

    public async Task AddToWatchAsync(int userId, Guid movieId)
    {
        var toWatch = new WatchlistToWatch { UserId = userId, MovieId = movieId };
        context.WatchlistToWatch.Add(toWatch);
        await context.SaveChangesAsync();
    }

    public async Task RemoveFromWatchAsync(int userId, Guid movieId)
    {
        var toWatch = await context.WatchlistToWatch.FirstOrDefaultAsync(t => t.UserId == userId && t.MovieId == movieId);
        if (toWatch != null)
        {
            context.WatchlistToWatch.Remove(toWatch);
            await context.SaveChangesAsync();
        }
    }
    
    public async Task<bool> IsInToWatchAsync(int userId, Guid movieId)
    {
        return await context.WatchlistToWatch.AnyAsync(f => f.UserId == userId && f.MovieId == movieId);
    }
}