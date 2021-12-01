using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentalManagement.Server.Data.Migrations
{
    public partial class AddedDefaultDataAndUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Colours",
                columns: new[] { "Id", "Createdby", "DateCreated", "DateUpdated", "Name", "Updatedby" },
                values: new object[] { 1, "System", new DateTime(2021, 11, 23, 16, 35, 10, 278, DateTimeKind.Local).AddTicks(5492), new DateTime(2021, 11, 23, 16, 35, 10, 279, DateTimeKind.Local).AddTicks(8169), "Black", "System" });

            migrationBuilder.InsertData(
                table: "Colours",
                columns: new[] { "Id", "Createdby", "DateCreated", "DateUpdated", "Name", "Updatedby" },
                values: new object[] { 2, "System", new DateTime(2021, 11, 23, 16, 35, 10, 279, DateTimeKind.Local).AddTicks(9596), new DateTime(2021, 11, 23, 16, 35, 10, 279, DateTimeKind.Local).AddTicks(9604), "Blue", "System" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
