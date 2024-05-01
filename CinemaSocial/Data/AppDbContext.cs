using CinemaSocial.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace CinemaSocial.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions dbContextOptions) : base(dbContextOptions)
    {
        
    }
    
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
    }

    public DbSet<UserAccount> UserAccounts { get; set; }
    public DbSet<Director> Directors { get; set; }
    public DbSet<Writer> Writers { get; set; }
    public DbSet<Star> Stars { get; set; }
    public DbSet<Image> Images { get; set; }
    public DbSet<Genre> Genres { get; set; }
    public DbSet<Movie> Movies { get; set; }
}