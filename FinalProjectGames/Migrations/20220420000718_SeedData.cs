using Microsoft.EntityFrameworkCore.Migrations;

namespace FinalProjectGames.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Types",
                table: "Types");

            migrationBuilder.RenameTable(
                name: "Types",
                newName: "GameTypes");

            migrationBuilder.AddPrimaryKey(
                name: "PK_GameTypes",
                table: "GameTypes",
                column: "GameTypeId");

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "Id", "Description", "GameType", "GameTypeId", "Name", "Rating" },
                values: new object[] { 1, "Play soccer with cars", "Video", 0, "Rocket League", 5 });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "Id", "Description", "GameType", "GameTypeId", "Name", "Rating" },
                values: new object[] { 2, "Get rid of your cards before your opponents", "Card", 0, "Uno", 4 });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "Id", "Description", "GameType", "GameTypeId", "Name", "Rating" },
                values: new object[] { 3, "Fight to the death with your favorite Kombatants", "Video", 0, "Mortal Kombat", 5 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_GameTypes",
                table: "GameTypes");

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

            migrationBuilder.RenameTable(
                name: "GameTypes",
                newName: "Types");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Types",
                table: "Types",
                column: "GameTypeId");
        }
    }
}
