using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace proyectoef.Migrations
{
    /// <inheritdoc />
    public partial class initialData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Comentarios",
                table: "Tarea");

            migrationBuilder.AlterColumn<string>(
                name: "Descripción",
                table: "Tarea",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Descripción",
                table: "Categoria",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.InsertData(
                table: "Categoria",
                columns: new[] { "CategoriaId", "Descripción", "Nombre", "Peso" },
                values: new object[,]
                {
                    { new Guid("540f2590-9c6d-4f2e-8bab-8f3629720a02"), null, "Actividade personales", 50 },
                    { new Guid("540f2590-9c6d-4f2e-8bab-8f3629720a34"), null, "Actividades pendientes", 20 }
                });

            migrationBuilder.InsertData(
                table: "Tarea",
                columns: new[] { "TareaId", "CategoriaId", "Descripción", "FechaCreacion", "PrioridadTarea", "Titulo" },
                values: new object[,]
                {
                    { new Guid("540f2590-9c6d-4f2e-8bab-8f3629720a10"), new Guid("540f2590-9c6d-4f2e-8bab-8f3629720a34"), null, new DateTime(2023, 8, 9, 14, 46, 47, 278, DateTimeKind.Local).AddTicks(1386), 1, "Pago Servicios Publicos" },
                    { new Guid("540f2590-9c6d-4f2e-8bab-8f3629720a11"), new Guid("540f2590-9c6d-4f2e-8bab-8f3629720a02"), null, new DateTime(2023, 8, 9, 14, 46, 47, 278, DateTimeKind.Local).AddTicks(1412), 0, "Pago Gastos" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Tarea",
                keyColumn: "TareaId",
                keyValue: new Guid("540f2590-9c6d-4f2e-8bab-8f3629720a10"));

            migrationBuilder.DeleteData(
                table: "Tarea",
                keyColumn: "TareaId",
                keyValue: new Guid("540f2590-9c6d-4f2e-8bab-8f3629720a11"));

            migrationBuilder.DeleteData(
                table: "Categoria",
                keyColumn: "CategoriaId",
                keyValue: new Guid("540f2590-9c6d-4f2e-8bab-8f3629720a02"));

            migrationBuilder.DeleteData(
                table: "Categoria",
                keyColumn: "CategoriaId",
                keyValue: new Guid("540f2590-9c6d-4f2e-8bab-8f3629720a34"));

            migrationBuilder.AlterColumn<string>(
                name: "Descripción",
                table: "Tarea",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Comentarios",
                table: "Tarea",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "Descripción",
                table: "Categoria",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }
    }
}
