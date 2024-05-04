using CinemaSocial.Data;
using CinemaSocial.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace CinemaSocial.Services;

public class ReviewService : IReviewService
{
    private readonly AppDbContext _context;

    public ReviewService(AppDbContext context)
    {
        _context = context;
    }

    public async Task<List<Review>> GetReviewsAsync()
    {
        return await _context.Reviews
            .Include(r => r.Movie)
            .Include(r => r.User)
            .ToListAsync();
    }
    
    public async Task AddReviewAsync(Review review)
    {
        _context.Reviews.Add(review);
        await _context.SaveChangesAsync();
    }
    
    public async Task RemoveReviewAsync(Review review)
    {
        _context.Reviews.Remove(review);
        await _context.SaveChangesAsync();
    }
}