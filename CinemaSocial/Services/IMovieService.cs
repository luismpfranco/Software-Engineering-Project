using CinemaSocial.Models.Entities;

namespace CinemaSocial.Services;

public interface IMovieService
{
    Task<List<Movie?>> GetMoviesAsync();
    Task<Movie?> GetMovieByIdAsync(Guid id);
    Task<List<Movie>> SearchMoviesAsync(string searchTerm);
}