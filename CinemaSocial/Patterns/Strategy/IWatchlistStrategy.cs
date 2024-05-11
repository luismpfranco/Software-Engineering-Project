namespace CinemaSocial.Patterns.Strategy;

public interface IWatchlistStrategy
{
    Task ExecuteAsync(int userId, Guid movieId);
    Task<bool> IsInWatchlistAsync(int userId, Guid movieId);
}