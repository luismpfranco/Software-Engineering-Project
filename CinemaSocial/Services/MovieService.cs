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
    
    public async Task<List<Movie>> GetMoviesAsyncWithPages(int page = 1)
    {
        int pageSize = 10;
        int skip = ((page - 1) * pageSize) + 10;

        return await _context.Movies
            .Include(m => m.Director)
            .Include(m => m.Writers)
            .Include(m => m.Stars)
            .Include(m => m.Genre)
            .Include(m => m.Images)
            .OrderBy(m => m.Rank)
            .Skip(skip)
            .Take(pageSize)
            .ToListAsync();
    }
    
    public async Task<int> GetTotalPages()
    {
        int pageSize = 10;
        int totalMovies = await _context.Movies.CountAsync();

        return (totalMovies + pageSize - 1) / pageSize;
    }
    
    public async Task<Movie> GetMovieByIdAsync(Guid id)
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