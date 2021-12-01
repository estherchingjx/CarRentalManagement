using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentalManagement.Server.Data.Migrations
{
    public partial class AddedSeededData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "6b656a23-25ab-4bd5-b23e-843075e42297", "Administrator", "ADMINISTRATOR" },
                    { "bd2bcf0c-20db-474f-8407-5a6b159518bb", "8620b9ec-0be7-41a7-8b35-8d999c798954", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "d88c2112-6212-47cc-b800-37a847de4d85", "admin@localhost.com", false, "ASSdmin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN", "AQAAAAEAACcQAAAAEGowFm2VUme/Biq9qlRpbcifYPObhHwP6ZImyYFcvXdVbOOevvj3c02nxweFACXdlQ==", null, false, "e2888fd4-b6bb-416e-a5e0-ae6a6457d759", false, "Admin" });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 11, 24, 10, 38, 33, 832, DateTimeKind.Local).AddTicks(6176), new DateTime(2021, 11, 24, 10, 38, 33, 833, DateTimeKind.Local).AddTicks(8110) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 11, 24, 10, 38, 33, 833, DateTimeKind.Local).AddTicks(9547), new DateTime(2021, 11, 24, 10, 38, 33, 833, DateTimeKind.Local).AddTicks(9555) });

            migrationBuilder.InsertData(
                table: "Makes",
                columns: new[] { "Id", "Createdby", "DateCreated", "DateUpdated", "Name", "Updatedby" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2021, 11, 24, 10, 38, 33, 835, DateTimeKind.Local).AddTicks(5950), new DateTime(2021, 11, 24, 10, 38, 33, 835, DateTimeKind.Local).AddTicks(5968), "BMW", "System" },
                    { 2, "System", new DateTime(2021, 11, 24, 10, 38, 33, 835, DateTimeKind.Local).AddTicks(5973), new DateTime(2021, 11, 24, 10, 38, 33, 835, DateTimeKind.Local).AddTicks(5975), "Toyota", "System" }
                });

            migrationBuilder.InsertData(
                table: "Models",
                columns: new[] { "Id", "Createdby", "DateCreated", "DateUpdated", "Name", "Updatedby" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2021, 11, 24, 10, 38, 33, 836, DateTimeKind.Local).AddTicks(1156), new DateTime(2021, 11, 24, 10, 38, 33, 836, DateTimeKind.Local).AddTicks(1165), "3 Series", "System" },
                    { 2, "System", new DateTime(2021, 11, 24, 10, 38, 33, 836, DateTimeKind.Local).AddTicks(1170), new DateTime(2021, 11, 24, 10, 38, 33, 836, DateTimeKind.Local).AddTicks(1171), "X5", "System" },
                    { 3, "System", new DateTime(2021, 11, 24, 10, 38, 33, 836, DateTimeKind.Local).AddTicks(1173), new DateTime(2021, 11, 24, 10, 38, 33, 836, DateTimeKind.Local).AddTicks(1175), "Prius", "System" },
                    { 4, "System", new DateTime(2021, 11, 24, 10, 38, 33, 836, DateTimeKind.Local).AddTicks(1177), new DateTime(2021, 11, 24, 10, 38, 33, 836, DateTimeKind.Local).AddTicks(1178), "Rav4", "System" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4");

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 11, 23, 16, 35, 10, 278, DateTimeKind.Local).AddTicks(5492), new DateTime(2021, 11, 23, 16, 35, 10, 279, DateTimeKind.Local).AddTicks(8169) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 11, 23, 16, 35, 10, 279, DateTimeKind.Local).AddTicks(9596), new DateTime(2021, 11, 23, 16, 35, 10, 279, DateTimeKind.Local).AddTicks(9604) });
        }
    }
}
