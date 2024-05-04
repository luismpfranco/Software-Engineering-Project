using System.Collections.Generic;
using System.Threading.Tasks;
using CinemaSocial.Models.Entities;

public interface IReviewService
{
    Task<List<Review>> GetReviewsAsync();
    Task AddReviewAsync(Review review);
    Task RemoveReviewAsync(Review review);
}