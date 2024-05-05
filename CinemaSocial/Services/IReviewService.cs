using CinemaSocial.Models.Entities;

namespace CinemaSocial.Services;

public interface IReviewService
{
    Task<List<Review>> GetReviewsAsync(int userId);
    Task<List<Review>> GetReviewsAsync(Guid movieId);
    Task RemoveReviewAsync(Review review);
}