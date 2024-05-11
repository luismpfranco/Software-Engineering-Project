using CinemaSocial.Data;
using Microsoft.EntityFrameworkCore;

namespace CinemaSocial.Patterns.Command;

public class RemoveFromWatchedCommand : ICommand
{
    private readonly AppDbContext _context;

    public RemoveFromWatchedCommand(AppDbContext context)
    {
        _context = context;
    }

    public async Task ExecuteAsync(int userId, Guid movieId)
    {
        var watched = await _context.WatchlistWatched.FirstOrDefaultAsync(w => w.UserId == userId && w.MovieId == movieId);
        if (watched != null)
        {
            _context.WatchlistWatched.Remove(watched);
            await _context.SaveChangesAsync();
        }
    }
}
