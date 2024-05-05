using CinemaSocial.Data;
using CinemaSocial.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace CinemaSocial.Services;

public class LikeService(AppDbContext context) : ILikeService
{
    public async Task AddLike(Guid reviewId, int userId)
    {
        var existingLike = await context.Likes.FirstOrDefaultAsync(l => l.ReviewId == reviewId && l.UserId == userId);

        if (existingLike != null)
        {
            if (existingLike.IsLike)
            {
                context.Likes.Remove(existingLike);
            }
            else
            {
                existingLike.IsLike = true;
            }
        }
        else
        {
            var like = new Like
            {
                ReviewId = reviewId,
                UserId = userId,
                IsLike = true
            };

            context.Likes.Add(like);
        }

        await context.SaveChangesAsync();
    }

    public async Task AddDislike(Guid reviewId, int userId)
    {
        var existingLike = await context.Likes.FirstOrDefaultAsync(l => l.ReviewId == reviewId && l.UserId == userId);

        if (existingLike != null)
        {
            if (!existingLike.IsLike)
            {
                context.Likes.Remove(existingLike);
            }
            else
            {
                existingLike.IsLike = false;
            }
        }
        else
        {
            var like = new Like
            {
                ReviewId = reviewId,
                UserId = userId,
                IsLike = false
            };

            context.Likes.Add(like);
        }

        await context.SaveChangesAsync();
    }

    public async Task<int> GetLikesAsync(Guid reviewId)
    {
        return await context.Likes.CountAsync(l => l.ReviewId == reviewId && l.IsLike);
    }

    public async Task<int> GetDislikesAsync(Guid reviewId)
    {
        return await context.Likes.CountAsync(l => l.ReviewId == reviewId && !l.IsLike);
    }
    
    public async Task<Like?> GetLike(Guid reviewId, int userId)
    {
        return await context.Likes.FirstOrDefaultAsync(l => l.ReviewId == reviewId && l.UserId == userId);
    }
}