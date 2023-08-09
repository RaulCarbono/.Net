using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace proyectoef.Migrations
{
    /// <inheritdoc />
    public partial class initialDataNew : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Comentarios",
                table: "Tarea",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Tarea",
                keyColumn: "TareaId",
                keyValue: new Guid("540f2590-9c6d-4f2e-8bab-8f3629720a10"),
                columns: new[] { "Comentarios", "FechaCreacion" },
                values: new object[] { null, new DateTime(2023, 8, 9, 14, 48, 50, 29, DateTimeKind.Local).AddTicks(3591) });

            migrationBuilder.UpdateData(
                table: "Tarea",
                keyColumn: "TareaId",
                keyValue: new Guid("540f2590-9c6d-4f2e-8bab-8f3629720a11"),
                columns: new[] { "Comentarios", "FechaCreacion" },
                values: new object[] { null, new DateTime(2023, 8, 9, 14, 48, 50, 29, DateTimeKind.Local).AddTicks(3604) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Comentarios",
                table: "Tarea");

            migrationBuilder.UpdateData(
                table: "Tarea",
                keyColumn: "TareaId",
                keyValue: new Guid("540f2590-9c6d-4f2e-8bab-8f3629720a10"),
                column: "FechaCreacion",
                value: new DateTime(2023, 8, 9, 14, 46, 47, 278, DateTimeKind.Local).AddTicks(1386));

            migrationBuilder.UpdateData(
                table: "Tarea",
                keyColumn: "TareaId",
                keyValue: new Guid("540f2590-9c6d-4f2e-8bab-8f3629720a11"),
                column: "FechaCreacion",
                value: new DateTime(2023, 8, 9, 14, 46, 47, 278, DateTimeKind.Local).AddTicks(1412));
        }
    }
}
