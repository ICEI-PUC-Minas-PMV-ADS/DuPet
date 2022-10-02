using System;
using DuPet.Models;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DuPet.Migrations
{
    public partial class M001 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Pets",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Peso = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Raca = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Sexo = table.Column<string>(type: "nvarchar(1)", nullable: false),
                    Pelagem = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DataDeNascimento = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pets", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Doses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PetId = table.Column<int>(type: "int", nullable: false),
                    NomeDaAplicacao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DataDaAplicacao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ControleDeDose = table.Column<int>(type: "int", nullable: false),
                    TipoDeDose = table.Column<int>(type: "int", nullable: false),                    
                    Fabricante = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CrmvMedicoResponsavel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NomeMedicoResponsavel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CategoriaDaVacina = table.Column<int>(type: "int", nullable: true),
                    QtdeMg = table.Column<int>(type: "int", nullable: true),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Doses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Doses_Pets_PetId",
                        column: x => x.PetId,
                        principalTable: "Pets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Doses_PetId",
                table: "Doses",
                column: "PetId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Doses");

            migrationBuilder.DropTable(
                name: "Pets");
        }
    }
}
