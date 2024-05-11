using CinemaSocial.Data;
using CinemaSocial.Repository;
using Microsoft.EntityFrameworkCore;

namespace CinemaSocial.Patterns.Command;

public class RemoveFromWatchCommand : ICommand
{
    private readonly AppDbContext _context;

    public RemoveFromWatchCommand(AppDbContext context)
    {
        _context = context;
    }

    public async Task ExecuteAsync(int userId, Guid movieId)
    {
        var toWatch = await _context.WatchlistToWatch.FirstOrDefaultAsync(t => t.UserId == userId && t.MovieId == movieId);
        if (toWatch != null)
        {
            _context.WatchlistToWatch.Remove(toWatch);
            await _context.SaveChangesAsync();
        }
    }
}