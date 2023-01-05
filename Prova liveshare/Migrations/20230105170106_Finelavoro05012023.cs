using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Provaliveshare.Migrations
{
    /// <inheritdoc />
    public partial class Finelavoro05012023 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ListaAttivitaIdLista",
                table: "Attivita",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "ListaAttivita",
                columns: table => new
                {
                    IdLista = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeLista = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AttivitaIdAttivita = table.Column<int>(type: "int", nullable: false),
                    IdAttivita = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ListaAttivita", x => x.IdLista);
                    table.ForeignKey(
                        name: "FK_ListaAttivita_Attivita_AttivitaIdAttivita",
                        column: x => x.AttivitaIdAttivita,
                        principalTable: "Attivita",
                        principalColumn: "IdAttivita",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Attivita_ListaAttivitaIdLista",
                table: "Attivita",
                column: "ListaAttivitaIdLista");

            migrationBuilder.CreateIndex(
                name: "IX_ListaAttivita_AttivitaIdAttivita",
                table: "ListaAttivita",
                column: "AttivitaIdAttivita");

            migrationBuilder.AddForeignKey(
                name: "FK_Attivita_ListaAttivita_ListaAttivitaIdLista",
                table: "Attivita",
                column: "ListaAttivitaIdLista",
                principalTable: "ListaAttivita",
                principalColumn: "IdLista");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Attivita_ListaAttivita_ListaAttivitaIdLista",
                table: "Attivita");

            migrationBuilder.DropTable(
                name: "ListaAttivita");

            migrationBuilder.DropIndex(
                name: "IX_Attivita_ListaAttivitaIdLista",
                table: "Attivita");

            migrationBuilder.DropColumn(
                name: "ListaAttivitaIdLista",
                table: "Attivita");
        }
    }
}
