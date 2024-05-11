using CinemaSocial.Models.Entities;

namespace CinemaSocial.Repository;

public interface IMovieRepository
{
    Task<List<Movie?>> GetMoviesAsync();
    Task<Movie?> GetMovieByIdAsync(Guid id);
}