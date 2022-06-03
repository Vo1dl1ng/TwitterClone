using Microsoft.EntityFrameworkCore;
using TwitterClone.Models;

namespace TwitterClone.Data
{
    public class TweetDbContext : DbContext
    {


        public DbSet<Tweet> Tweets { get; set; }

        public DbSet<User> Users { get; set; }
        


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=TweetDb");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Tweet>().HasData(
                new Tweet { Id = 1, Message = "Hello World!", Likes = 3, Shares = 1, UserId = 1},
                new Tweet { Id = 2, Message = "What website is this?", Likes = 2, Shares = 6, UserId = 2},
                new Tweet { Id = 3, Message = "It's sunny today", Likes = 6, Shares = 5, UserId = 3},
                new Tweet { Id = 4, Message = "aaaannd it started raining T_T", Likes = 9, Shares = 7, UserId = 3},
                new Tweet { Id= 5, Message = "went hiking today", Likes=5, Shares=6, UserId = 4}
                );
            modelBuilder.Entity<User>().HasData(
                new User { Id = 1, ImageURL = "ExampleUrl", TwitterHandle = "ExampleHandle", UserName = "ExampleName"},
                new User { Id = 2, ImageURL = "TesteUrl", TwitterHandle = "TestHandle", UserName = "TestName" },
                new User { Id = 3, ImageURL = "TesterUrl", TwitterHandle = "TesterHandle", UserName = "TesterName"},
                new User { Id = 4, ImageURL = "BetaUrl", TwitterHandle = "BetaHandle", UserName = "BetaName"}
                );
        }

    }
}
