using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Site.Migrations
{
    /// <inheritdoc />
    public partial class CriarConntext : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Livros",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Titulo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Autor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Genero = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Editora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TotalPaginas = table.Column<int>(type: "int", nullable: false),
                    DataPublicacao = table.Column<DateOnly>(type: "date", nullable: false),
                    Avaliacao = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Livros", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Livros");
        }
    }
}
