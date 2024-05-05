using CinemaSocial.Data;
using CinemaSocial.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace CinemaSocial.Services;

public class MovieService(AppDbContext context) : IMovieService
{
    public async Task<List<Movie?>> GetMoviesAsync()
    {    
        return (await context.Movies
            .Include(m => m.Director)
            .Include(m => m.Writers)
            .Include(m => m.Stars)
            .Include(m => m.Genre)
            .Include(m => m.Images)
            .ToListAsync())!;
    }
    
    public async Task<Movie?> GetMovieByIdAsync(Guid id)
    {
        return await context.Movies
            .Include(m => m.Director)
            .Include(m => m.Writers)
            .Include(m => m.Stars)
            .Include(m => m.Genre)
            .Include(m => m.Images)
            .FirstOrDefaultAsync(m => m.IdMovie == id);
    }
    
    public async Task<List<Movie>> SearchMoviesAsync(string searchTerm)
    {
        return await context.Movies
            .Where(m => m.Title.Contains(searchTerm))
            .ToListAsync();
    }
}