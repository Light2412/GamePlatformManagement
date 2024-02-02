using GamePlatformManagement.Shared.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GamePlatformManagement.Server.Configurations.Entities
{
    public class GameSeedConfiguration : IEntityTypeConfiguration<Game>
    {
        public void Configure(EntityTypeBuilder<Game> builder)
        {
            builder.HasData(
                new Game
                {
                    Id = 1,
                    Title = "League Of Legends",

                    AgeGroup = "Teenagers",

                    Description = "5v5 team-based multiplayer strategy game where two teams battle out to destroy the other enemy's base.",
                    Genre = "Strategy",
                    Price = 50,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Game
                {
                    Id = 2,
                    Title = "Assassin's Creed",
                    AgeGroup = "Adults",
                    Description = "Assassin's Creed is an open-world, action-adventure, and stealth game franchise published by Ubisoft and developed mainly by its studio Ubisoft Montreal using the game engine Anvil and its more advanced derivatives. ",
                    Genre = "Adventure",
                    Price = 85,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Game
                {
                    Id = 3,
                    Title = "Mario Kart",
                    AgeGroup = "Kids",
                    Description = "Mario Kart is a series of kart racing games and a spin-off Mario franchise developed and published by Nintendo. Players compete in go-kart races while using various power-up items. It features characters and courses mostly from the Mario series as well as other gaming franchises such as The Legend of Zelda, Animal Crossing, F-Zero, Excitebike, and Splatoon.",
                    Genre = "Racing",
                    Price = 46,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Game
                {
                    Id = 4,
                    Title = "FIFA 18",
                    AgeGroup = "Teenagers",
                    Description = "FIFA 18 is a football simulation video game developed and published by Electronic Arts and released worldwide on 29 September 2017 for Microsoft Windows, PlayStation 3, PlayStation 4, Xbox 360, Xbox One and Nintendo Switch. It is the 25th installment in the FIFA series.",
                    Genre = "Football",
                    Price = 90,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Game
                {
                    Id = 5,
                    Title = "Street Fighter Alpha",
                    AgeGroup = "Adults",
                    Description = "Street Fighter Alpha: Warriors' Dreams, known as Street Fighter Zero[a] in Japan, Asia, South America, and Oceania, is a 2D arcade fighting game by Capcom ",
                    Genre = "Fighting",
                    Price = 20,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                }
                );

        }
    }
}