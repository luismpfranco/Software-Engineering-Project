using CinemaSocial.Patterns.Command;
using CinemaSocial.Patterns.Strategy;
using CinemaSocial.Repository;

namespace CinemaSocial.Patterns;

public class WatchlistService: IWatchlistService
{
    private readonly IWatchlistStrategy _strategy;

    public WatchlistService(IWatchlistStrategy strategy)
    {
        _strategy = strategy;
    }

    public async Task AddToFavourites(int userId, Guid movieId)
    {
        await _strategy.ExecuteAsync(userId, movieId);
    }

    public async Task AddToWatched(int userId, Guid movieId)
    {
        await _strategy.ExecuteAsync(userId, movieId);
    }

    public async Task AddToWatch(int userId, Guid movieId)
    {
        await _strategy.ExecuteAsync(userId, movieId);
    }

    public async Task ExecuteCommand(ICommand command, int userId, Guid movieId)
    {
        await command.ExecuteAsync(userId, movieId);
    }
}