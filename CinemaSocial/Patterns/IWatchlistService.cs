using CinemaSocial.Patterns.Command;

namespace CinemaSocial.Patterns;

public interface IWatchlistService
{
    Task AddToFavourites(int userId, Guid movieId);
    Task AddToWatched(int userId, Guid movieId);
    Task AddToWatch(int userId, Guid movieId);
    Task ExecuteCommand(ICommand command, int userId, Guid movieId);
}