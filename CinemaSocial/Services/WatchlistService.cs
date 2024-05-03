using CinemaSocial.Data;
using CinemaSocial.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using CinemaSocial.Models.Watchlists;
using Microsoft.JSInterop;

namespace CinemaSocial.Services;

public class WatchlistService
{
    private readonly AppDbContext _context;
    private IJSRuntime JSRuntime;

    public WatchlistService(AppDbContext context)
    {
        _context = context;
    }
    
    public async Task<List<WatchlistFavourites>> GetWatchlistFavouritesAsync(int userId)
    {
        return await _context.WatchlistFavourites
            .Where(w => w.UserId == userId)
            .ToListAsync();
    }

    public async Task<List<WatchlistWatched>> GetWatchlistWatchedAsync(int userId)
    {
        return await _context.WatchlistWatched
            .Where(w => w.UserId == userId)
            .ToListAsync();
    }

    public async Task<List<WatchlistToWatch>> GetWatchlistToWatchAsync(int userId)
    {
        return await _context.WatchlistToWatch
            .Where(w => w.UserId == userId)
            .ToListAsync();
    }
    
    public async Task AddToFavouritesAsync(int userId, Guid movieId)
    {
        Console.WriteLine($"AddToFavouritesAsync called with userId: {userId} and movieId: {movieId}");
        try
        {
            var favourite = new WatchlistFavourites { UserId = userId, MovieId = movieId };
            _context.WatchlistFavourites.Add(favourite);
            await _context.SaveChangesAsync();
            Console.WriteLine($"{userId} added {movieId} to favourites.");

            // Notify the component that the state has changed
            await JSRuntime.InvokeVoidAsync("alert", "Added to favourites");
        }
        catch (Exception e)
        {
            Console.WriteLine($"An error occurred: {e.Message}");
        }
    }

    public async Task RemoveFromFavouritesAsync(int userId, Guid movieId)
    {
        var favourite = await _context.WatchlistFavourites.FirstOrDefaultAsync(f => f.UserId == userId && f.MovieId == movieId);
        if (favourite != null)
        {
            _context.WatchlistFavourites.Remove(favourite);
            await _context.SaveChangesAsync();
        }
    }

    public async Task AddToWatchedAsync(int userId, Guid movieId)
    {
        var watched = new WatchlistWatched { UserId = userId, MovieId = movieId };
        _context.WatchlistWatched.Add(watched);
        await _context.SaveChangesAsync();
    }

    public async Task RemoveFromWatchedAsync(int userId, Guid movieId)
    {
        var watched = await _context.WatchlistWatched.FirstOrDefaultAsync(w => w.UserId == userId && w.MovieId == movieId);
        if (watched != null)
        {
            _context.WatchlistWatched.Remove(watched);
            await _context.SaveChangesAsync();
        }
    }

    public async Task AddToWatchlistAsync(int userId, Guid movieId)
    {
        var toWatch = new WatchlistToWatch { UserId = userId, MovieId = movieId };
        _context.WatchlistToWatch.Add(toWatch);
        await _context.SaveChangesAsync();
    }

    public async Task RemoveFromWatchlistAsync(int userId, Guid movieId)
    {
        var toWatch = await _context.WatchlistToWatch.FirstOrDefaultAsync(t => t.UserId == userId && t.MovieId == movieId);
        if (toWatch != null)
        {
            _context.WatchlistToWatch.Remove(toWatch);
            await _context.SaveChangesAsync();
        }
    }
    
}