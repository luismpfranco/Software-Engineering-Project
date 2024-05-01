
/*
using CinemaSocial.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace CinemaSocial.Models.Repositories
{
    public class GameContext: DbContext
    {
        public DbSet<UserAccount> Profiles { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseSqlite("Data Source=cinema.db");
        }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<UserAccount>().HasData(
                new UserAccount()
                {
                    Id = 1,
                    Name = "Luis"
                }
            );
        }
    }
}
*/
