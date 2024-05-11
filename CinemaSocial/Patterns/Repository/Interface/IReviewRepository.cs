using CinemaSocial.Models.Entities;

namespace CinemaSocial.Repository;

public interface IReviewRepository
{
    Task<List<Review>> GetReviewsAsync(int userId);
    Task<List<Review>> GetReviewsAsync();
    Task<UserAccount?> GetUserByIdAsync(int userId);
    Task<List<Review>> GetReviewsAsync(Guid movieId);
    Task RemoveReviewAsync(Review review);
    Task AddReviewAsync(Review review);
}