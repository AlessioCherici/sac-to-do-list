using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Provaliveshare.Migrations
{
    /// <inheritdoc />
    public partial class Fixdatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Attivita_Utenti_UtenteIdUtente",
                table: "Attivita");

            migrationBuilder.DropTable(
                name: "Utenti");

            migrationBuilder.DropIndex(
                name: "IX_Attivita_UtenteIdUtente",
                table: "Attivita");

            migrationBuilder.DropColumn(
                name: "IdUtente",
                table: "Attivita");

            migrationBuilder.DropColumn(
                name: "UtenteIdUtente",
                table: "Attivita");

            migrationBuilder.AddColumn<string>(
                name: "Creatore",
                table: "Attivita",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Creatore",
                table: "Attivita");

            migrationBuilder.AddColumn<int>(
                name: "IdUtente",
                table: "Attivita",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UtenteIdUtente",
                table: "Attivita",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Utenti",
                columns: table => new
                {
                    IdUtente = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    cognome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    numerotelefono = table.Column<string>(name: "numero_telefono", type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Utenti", x => x.IdUtente);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Attivita_UtenteIdUtente",
                table: "Attivita",
                column: "UtenteIdUtente");

            migrationBuilder.AddForeignKey(
                name: "FK_Attivita_Utenti_UtenteIdUtente",
                table: "Attivita",
                column: "UtenteIdUtente",
                principalTable: "Utenti",
                principalColumn: "IdUtente",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
