using Microsoft.EntityFrameworkCore.Migrations;

namespace EtudiantProject.Migrations
{
    public partial class AddEtudiant : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "etudiants",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nom = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    adresse = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    dateNaiss = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    niveau = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_etudiants", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "etudiants");
        }
    }
}
