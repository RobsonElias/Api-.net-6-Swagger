using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace swegger.Migrations
{
    public partial class InitialDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TiposDeUsuario",
                columns: table => new
                {
                    ID_TIPOUSUARIO = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ORIGEM = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false),
                    DESCR = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TiposDeUsuario", x => x.ID_TIPOUSUARIO);
                });

            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    ID_USU = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NOME_USU = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    MATR_USU = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    DATA_NASC = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EMAIL = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ORIGEM = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.ID_USU);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TiposDeUsuario");

            migrationBuilder.DropTable(
                name: "Usuario");
        }
    }
}
