using CinemaSocial.Patterns.Command;
using CinemaSocial.Patterns.Strategy;
using CinemaSocial.Repository;

namespace CinemaSocial.Patterns;

public class WatchlistService
{
    private readonly IWatchlistStrategy _strategy;
    private readonly IWatchlistRepository _repository;

    public WatchlistService(IWatchlistStrategy strategy, IWatchlistRepository repository)
    {
        _strategy = strategy;
        _repository = repository;
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