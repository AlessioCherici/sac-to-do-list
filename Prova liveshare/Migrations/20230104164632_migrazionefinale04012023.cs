using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Provaliveshare.Migrations
{
    /// <inheritdoc />
    public partial class migrazionefinale04012023 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "cognome",
                table: "Utenti",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "email",
                table: "Utenti",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "nome",
                table: "Utenti",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "numero_telefono",
                table: "Utenti",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "DataAttivita",
                table: "Attivita",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Descrizione",
                table: "Attivita",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "IdUtente",
                table: "Attivita",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Nome",
                table: "Attivita",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Stato",
                table: "Attivita",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "UtenteIdUtente",
                table: "Attivita",
                type: "int",
                nullable: false,
                defaultValue: 0);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Attivita_Utenti_UtenteIdUtente",
                table: "Attivita");

            migrationBuilder.DropIndex(
                name: "IX_Attivita_UtenteIdUtente",
                table: "Attivita");

            migrationBuilder.DropColumn(
                name: "cognome",
                table: "Utenti");

            migrationBuilder.DropColumn(
                name: "email",
                table: "Utenti");

            migrationBuilder.DropColumn(
                name: "nome",
                table: "Utenti");

            migrationBuilder.DropColumn(
                name: "numero_telefono",
                table: "Utenti");

            migrationBuilder.DropColumn(
                name: "DataAttivita",
                table: "Attivita");

            migrationBuilder.DropColumn(
                name: "Descrizione",
                table: "Attivita");

            migrationBuilder.DropColumn(
                name: "IdUtente",
                table: "Attivita");

            migrationBuilder.DropColumn(
                name: "Nome",
                table: "Attivita");

            migrationBuilder.DropColumn(
                name: "Stato",
                table: "Attivita");

            migrationBuilder.DropColumn(
                name: "UtenteIdUtente",
                table: "Attivita");
        }
    }
}
