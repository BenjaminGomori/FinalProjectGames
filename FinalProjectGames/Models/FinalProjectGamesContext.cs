using Microsoft.EntityFrameworkCore;

namespace FinalProjectGames.Models
{
    public class FinalProjectGamesContext : DbContext
    {
        public FinalProjectGamesContext(DbContextOptions<FinalProjectGamesContext> options)
            : base(options)
        { }

        public DbSet<Game> Games { get; set; }
        public DbSet<GameType> GameTypes { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<GameType>().HasData(
                new GameType { GameTypeId=1, Name = "Video" },
                new GameType { GameTypeId = 2, Name = "Board" },
                new GameType { GameTypeId = 3, Name = "Cards" }
            );

        }
    }
}
