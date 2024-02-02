using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GamePlatformManagement.Server.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddedDefaultDataAndUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "Id", "AgeGroup", "CreatedBy", "DateCreated", "DateUpdated", "Description", "Genre", "Price", "Title", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "Teenagers", "System", new DateTime(2024, 2, 3, 0, 17, 28, 754, DateTimeKind.Local).AddTicks(4488), new DateTime(2024, 2, 3, 0, 17, 28, 754, DateTimeKind.Local).AddTicks(4502), "5v5 team-based multiplayer strategy game where two teams battle out to destroy the other enemy's base.", "Strategy", 50.0, "League Of Legends", "System" },
                    { 2, "Adults", "System", new DateTime(2024, 2, 3, 0, 17, 28, 754, DateTimeKind.Local).AddTicks(4506), new DateTime(2024, 2, 3, 0, 17, 28, 754, DateTimeKind.Local).AddTicks(4506), "Assassin's Creed is an open-world, action-adventure, and stealth game franchise published by Ubisoft and developed mainly by its studio Ubisoft Montreal using the game engine Anvil and its more advanced derivatives. ", "Adventure", 85.0, "Assassin's Creed", "System" },
                    { 3, "Kids", "System", new DateTime(2024, 2, 3, 0, 17, 28, 754, DateTimeKind.Local).AddTicks(4509), new DateTime(2024, 2, 3, 0, 17, 28, 754, DateTimeKind.Local).AddTicks(4509), "Mario Kart is a series of kart racing games and a spin-off Mario franchise developed and published by Nintendo. Players compete in go-kart races while using various power-up items. It features characters and courses mostly from the Mario series as well as other gaming franchises such as The Legend of Zelda, Animal Crossing, F-Zero, Excitebike, and Splatoon.", "Racing", 46.0, "Mario Kart", "System" },
                    { 4, "Teenagers", "System", new DateTime(2024, 2, 3, 0, 17, 28, 754, DateTimeKind.Local).AddTicks(4512), new DateTime(2024, 2, 3, 0, 17, 28, 754, DateTimeKind.Local).AddTicks(4512), "FIFA 18 is a football simulation video game developed and published by Electronic Arts and released worldwide on 29 September 2017 for Microsoft Windows, PlayStation 3, PlayStation 4, Xbox 360, Xbox One and Nintendo Switch. It is the 25th installment in the FIFA series.", "Football", 90.0, "FIFA 18", "System" },
                    { 5, "Adults", "System", new DateTime(2024, 2, 3, 0, 17, 28, 754, DateTimeKind.Local).AddTicks(4515), new DateTime(2024, 2, 3, 0, 17, 28, 754, DateTimeKind.Local).AddTicks(4515), "Street Fighter Alpha: Warriors' Dreams, known as Street Fighter Zero[a] in Japan, Asia, South America, and Oceania, is a 2D arcade fighting game by Capcom ", "Fighting", 20.0, "Street Fighter Alpha", "System" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
