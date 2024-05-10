using CinemaSocial.Data;
using CinemaSocial.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace CinemaSocial.Repository;

public class ReviewRepository(AppDbContext context) : IReviewRepository
{
    public async Task<List<Review>> GetReviewsAsync(int userId)
    {
        return await context.Reviews
            .Include(r => r.Movie)
            .Include(r => r.User)
            .Where(r => r.UserId == userId)
            .ToListAsync();
    }
    
    public async Task<List<Review>> GetReviewsAsync()
    {
        return await context.Reviews
            .Include(r => r.Movie)
            .Include(r => r.User)
            .ToListAsync();
    }
    
    public async Task<List<Review>> GetReviewsAsync(Guid movieId)
    {
        return await context.Reviews
            .Include(r => r.Movie)
            .Include(r => r.User)
            .Where(r => r.MovieId == movieId)
            .ToListAsync();
    }
    
    public async Task<UserAccount?> GetUserByIdAsync(int userId)
    {
        return await context.UserAccounts.FindAsync(userId);
    }
    
    public async Task AddReviewAsync(Review review)
    {
        context.Reviews.Add(review);
        await context.SaveChangesAsync();
    }
    
    public async Task RemoveReviewAsync(Review review)
    {
        context.Reviews.Remove(review);
        await context.SaveChangesAsync();
    }
}