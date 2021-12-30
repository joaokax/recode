using Microsoft.EntityFrameworkCore.Migrations;

namespace AgenciaViagens.Migrations
{
    public partial class builder : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Destinos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Partida = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Chegada = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ida = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Volta = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Destinos", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
               name: "Destinos");
        }
    }
}
