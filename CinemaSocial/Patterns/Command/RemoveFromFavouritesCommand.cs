using CinemaSocial.Data;
using Microsoft.EntityFrameworkCore;

namespace CinemaSocial.Patterns.Command;

public class RemoveFromFavouritesCommand : ICommand
{
    private readonly AppDbContext _context;

    public RemoveFromFavouritesCommand(AppDbContext context)
    {
        _context = context;
    }
    public async Task ExecuteAsync(int userId, Guid movieId)
    {
        var favourite = await _context.WatchlistFavourites.FirstOrDefaultAsync(f => f.UserId == userId && f.MovieId == movieId);
        if (favourite != null)
        {
            _context.WatchlistFavourites.Remove(favourite);
            await _context.SaveChangesAsync();
        }
    }
}