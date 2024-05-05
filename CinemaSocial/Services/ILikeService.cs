using CinemaSocial.Models.Entities;

namespace CinemaSocial.Services;

public interface ILikeService
{
    Task AddLike(Guid reviewId, int userId);
    Task AddDislike(Guid reviewId, int userId);
    Task<int> GetLikesAsync(Guid reviewId);
    Task<int> GetDislikesAsync(Guid reviewId);
    Task<Like?> GetLike(Guid reviewId, int userId);
}