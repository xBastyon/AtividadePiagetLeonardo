using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PiagetLeonardo.Migrations
{
    /// <inheritdoc />
    public partial class Piaget : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Aluno",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Escola = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pai = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Mae = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RGM = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Idade = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Notas = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Professor = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Aluno", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Aluno");
        }
    }
}
