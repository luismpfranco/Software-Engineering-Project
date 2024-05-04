using CinemaSocial.Data;
using CinemaSocial.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace CinemaSocial.Services;

public class MovieService : IMovieService
{
    private readonly AppDbContext _context;

    public MovieService(AppDbContext context)
    {
        _context = context;
    }
    
    public async Task<List<Movie>> GetMoviesAsync()
    {    
        return await _context.Movies
            .Include(m => m.Director)
            .Include(m => m.Writers)
            .Include(m => m.Stars)
            .Include(m => m.Genre)
            .Include(m => m.Images)
            .ToListAsync();
    }
    
    public async Task<Movie?> GetMovieByIdAsync(Guid id)
    {
        return await _context.Movies
            .Include(m => m.Director)
            .Include(m => m.Writers)
            .Include(m => m.Stars)
            .Include(m => m.Genre)
            .Include(m => m.Images)
            .FirstOrDefaultAsync(m => m.IdMovie == id);
    }
}