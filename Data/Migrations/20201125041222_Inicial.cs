using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TodoListEvaluacion.Data.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PRIORIDADES",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    descripcion = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PRIORIDADES", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "TAREAS",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(nullable: false),
                    Detalle = table.Column<string>(nullable: true),
                    fecharegistro = table.Column<DateTime>(nullable: false),
                    idPrioridad = table.Column<int>(nullable: false),
                    Prioridadid = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TAREAS", x => x.id);
                    table.ForeignKey(
                        name: "FK_TAREAS_PRIORIDADES_Prioridadid",
                        column: x => x.Prioridadid,
                        principalTable: "PRIORIDADES",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TAREAS_Prioridadid",
                table: "TAREAS",
                column: "Prioridadid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TAREAS");

            migrationBuilder.DropTable(
                name: "PRIORIDADES");
        }
    }
}
