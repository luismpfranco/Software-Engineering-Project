using CinemaSocial.Models.Entities;
using CinemaSocial.Models.Entities.Watchlists;
using Microsoft.EntityFrameworkCore;
using Review = CinemaSocial.Models.Entities.Review;

namespace CinemaSocial.Data;

public class AppDbContext(DbContextOptions dbContextOptions) : DbContext(dbContextOptions)
{
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Movie>()
            .HasMany(m => m.Images)
            .WithOne(i => i.Movie)
            .HasForeignKey(i => i.IdMovie);
        
        modelBuilder.Entity<Movie>()
            .HasMany(m => m.Director)
            .WithOne(i => i.Movie)
            .HasForeignKey(i => i.IdMovie);
        
        modelBuilder.Entity<Movie>()
            .HasMany(m => m.Stars)
            .WithOne(i => i.Movie)
            .HasForeignKey(i => i.IdMovie);
        
        modelBuilder.Entity<Movie>()
            .HasMany(m => m.Writers)
            .WithOne(i => i.Movie)
            .HasForeignKey(i => i.IdMovie);
        
        modelBuilder.Entity<Movie>()
            .HasMany(m => m.Genre)
            .WithOne(i => i.Movie)
            .HasForeignKey(i => i.IdMovie);
        
        modelBuilder.Entity<Review>()
            .HasOne(r => r.User)
            .WithMany(u => u.Reviews)
            .HasForeignKey(r => r.UserId);
        
        modelBuilder.Entity<Review>()
            .HasOne(r => r.Movie)
            .WithMany(m => m.Reviews)
            .HasForeignKey(r => r.MovieId);
    }

    public DbSet<UserAccount> UserAccounts { get; init; }
    public DbSet<Director> Directors { get; init; }
    public DbSet<Writer> Writers { get; init; }
    public DbSet<Star> Stars { get; init; }
    public DbSet<Image> Images { get; init; }
    public DbSet<Genre> Genres { get; init; }
    public DbSet<Movie> Movies { get; init; }
    public DbSet<WatchlistFavourites> WatchlistFavourites { get; init; }
    public DbSet<WatchlistWatched> WatchlistWatched { get; init; }
    public DbSet<WatchlistToWatch> WatchlistToWatch { get; init; }
    public DbSet<Like> Likes { get; init; }
    public DbSet<Review> Reviews { get; init; }
}