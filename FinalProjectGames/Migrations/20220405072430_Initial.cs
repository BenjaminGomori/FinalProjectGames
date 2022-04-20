using Microsoft.EntityFrameworkCore.Migrations;

namespace FinalProjectGames.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
            name: "GameTypes",
            columns: table => new
            {
                GameTypeId = table.Column<int>(nullable: false)
                    .Annotation("SqlServer:Identity", "1, 1"),
                Name = table.Column<string>(nullable: true)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_GameTypes", x => x.GameTypeId);
            });

            migrationBuilder.CreateTable(
                name: "Games",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false),
                    GameTypeId = table.Column<int>(nullable: false),
                    GameType = table.Column<string>(nullable: true),
                    Rating = table.Column<int>(nullable: false),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Games", x => x.Id);
                    table.ForeignKey(
                     name: "FK_Games_GameTypes_GameTypeId",
                     column: x => x.GameTypeId,
                     principalTable: "GameTypes",
                     principalColumn: "GameTypeId",
                     onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "GameTypes",
                columns: new[] { "GameTypeId", "Name" },
                values: new object[] { 1, "Video" });

            migrationBuilder.InsertData(
                table: "GameTypes",
                columns: new[] { "GameTypeId", "Name" },
                values: new object[] { 2, "Board" });

            migrationBuilder.InsertData(
                table: "GameTypes",
                columns: new[] { "GameTypeId", "Name" },
                values: new object[] { 3, "Cards" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Games");

            migrationBuilder.DropTable(
                name: "GameTypes");
        }
    }
}
