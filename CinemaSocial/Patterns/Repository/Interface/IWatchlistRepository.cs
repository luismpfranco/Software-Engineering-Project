using CinemaSocial.Models.Entities.Watchlists;

namespace CinemaSocial.Repository;

public interface IWatchlistRepository
{
    Task<List<WatchlistFavourites>?> GetWatchlistFavouritesAsync(int userId);
    Task<List<WatchlistWatched>?> GetWatchlistWatchedAsync(int userId);
    Task<List<WatchlistToWatch>?> GetWatchlistToWatchAsync(int userId);
}