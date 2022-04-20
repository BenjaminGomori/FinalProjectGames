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

            modelBuilder.Entity<Game>().HasData(
                new Game
                {
                    Id = 1,
                    Name = "Rocket League",
                    GameType = "Video",
                    Rating = 5,
                    Description = "Play soccer with cars"
                },
                new Game
                {
                    Id = 2,
                    Name = "Uno",
                    GameType = "Card",
                    Rating = 4,
                    Description = "Get rid of your cards before your opponents"
                },
                new Game
                {
                    Id = 3,
                    Name = "Mortal Kombat",
                    GameType = "Video",
                    Rating = 5,
                    Description = "Fight to the death with your favorite Kombatants"
                });

        }
    }
}
