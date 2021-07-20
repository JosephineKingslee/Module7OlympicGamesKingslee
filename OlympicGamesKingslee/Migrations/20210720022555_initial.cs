using Microsoft.EntityFrameworkCore.Migrations;

namespace OlympicGamesKingslee.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryID);
                });

            migrationBuilder.CreateTable(
                name: "GameTypes",
                columns: table => new
                {
                    GameTypeID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GameTypes", x => x.GameTypeID);
                });

            migrationBuilder.CreateTable(
                name: "Olympics",
                columns: table => new
                {
                    CountryID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GameTypeID = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Sport = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CategoryID = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    FlagImage = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Olympics", x => x.CountryID);
                    table.ForeignKey(
                        name: "FK_Olympics_Categories_CategoryID",
                        column: x => x.CategoryID,
                        principalTable: "Categories",
                        principalColumn: "CategoryID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Olympics_GameTypes_GameTypeID",
                        column: x => x.GameTypeID,
                        principalTable: "GameTypes",
                        principalColumn: "GameTypeID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryID", "Name" },
                values: new object[,]
                {
                    { "indoor", "Indoor" },
                    { "outdoor", "Outdoor" }
                });

            migrationBuilder.InsertData(
                table: "GameTypes",
                columns: new[] { "GameTypeID", "Name" },
                values: new object[,]
                {
                    { "winterOlympics", "Winter Olympics" },
                    { "summerOlympics", "Summer Olympics" },
                    { "paralympicsGames", "Paralympic Games" },
                    { "youthOlympicGames", "Youth Olympic Games" }
                });

            migrationBuilder.InsertData(
                table: "Olympics",
                columns: new[] { "CountryID", "CategoryID", "FlagImage", "GameTypeID", "Name", "Sport" },
                values: new object[,]
                {
                    { "can", "indoor", "Canada.png", "winterOlympics", "Canada", "Curling" },
                    { "fin", "outdoor", "Finland.png", "youthOlympicGames", "Finland", "Skate Boarding" },
                    { "rus", "indoor", "Russia.png", "youthOlympicGames", "Russia", "Break Dancing" },
                    { "cyp", "indoor", "Cyprus.png", "youthOlympicGames", "Cyprus", "Break Dancing" },
                    { "fra", "indoor", "France.png", "youthOlympicGames", "France", "Break Dancing" },
                    { "zim", "outdoor", "Zimbabwe.png", "paralympicsGames", "Zimbabwe", "Canoe Sprint" },
                    { "pak", "outdoor", "Pakistan.png", "paralympicsGames", "Pakistan", "Canoe Sprint" },
                    { "aus", "outdoor", "Austria.png", "paralympicsGames", "Austria", "Canoe Sprint" },
                    { "ukr", "indoor", "Ukraine.png", "paralympicsGames", "Ukraine", "Archery" },
                    { "uru", "indoor", "Uruguay.png", "paralympicsGames", "Uruguay", "Archery" },
                    { "tha", "indoor", "Thailand.png", "paralympicsGames", "Thailand", "Archery" },
                    { "usa", "outdoor", "USA.png", "summerOlympics", "USA", "Road Cycling" },
                    { "net", "outdoor", "Netherlands.png", "summerOlympics", "Netherlands", "Road Cycling" },
                    { "bra", "outdoor", "Brazil.png", "summerOlympics", "Brazil", "Road Cycling" },
                    { "mex", "indoor", "Mexico.png", "summerOlympics", "Mexico", "Diving" },
                    { "chi", "indoor", "China.png", "summerOlympics", "China", "Diving" },
                    { "ger", "indoor", "Germany.png", "summerOlympics", "Germany", "Diving" },
                    { "jap", "outdoor", "Japan.png", "winterOlympics", "Japan", "Bobsleigh" },
                    { "ita", "outdoor", "Italy.png", "winterOlympics", "Italy", "Bobsleigh" },
                    { "jam", "outdoor", "Jamaica.png", "winterOlympics", "Jamaica", "Bobsleigh" },
                    { "gre", "indoor", "Great_Britain.png", "winterOlympics", "Great Britain", "Curling" },
                    { "swe", "indoor", "Sweden.png", "winterOlympics", "Sweden", "Curling" },
                    { "slo", "outdoor", "Slovakia.png", "youthOlympicGames", "Slovakia", "Skate Boarding" },
                    { "por", "outdoor", "Portugal.png", "youthOlympicGames", "Portugal", "Skate Boarding" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Olympics_CategoryID",
                table: "Olympics",
                column: "CategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_Olympics_GameTypeID",
                table: "Olympics",
                column: "GameTypeID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Olympics");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "GameTypes");
        }
    }
}
