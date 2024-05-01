using System.Collections.Generic;
using System.Threading.Tasks;
using CinemaSocial.Models.Entities;

namespace CinemaSocial.Services;

public interface IMovieService
{
    Task<List<Movie>> GetMoviesAsync();
    Task<List<Movie>> GetMoviesAsyncWithPages(int page);
    Task<int> GetTotalPages();
    Task<Movie> GetMovieByIdAsync(Guid id);
}