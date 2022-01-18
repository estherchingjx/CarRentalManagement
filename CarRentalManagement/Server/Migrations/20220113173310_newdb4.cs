using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentalManagement.Server.Migrations
{
    public partial class newdb4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba",
                column: "ConcurrencyStamp",
                value: "91cc31b8-72a7-4b45-8e51-00adfa28aed5");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb",
                column: "ConcurrencyStamp",
                value: "35b63d63-5a65-4a12-a8d9-db971507ec16");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d6424e6c-6c4a-4198-9ac7-1477e63a7ca9", "AQAAAAEAACcQAAAAEHEX1ksfU4KBzwFfi6SJMbpM9XQjpXdhTor7W6hc0qWs98z8CiYeKjZvnRAeo1u2kA==", "d83150a4-f48a-4c3a-b1ab-23dd2d0232da" });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 14, 1, 33, 9, 860, DateTimeKind.Local).AddTicks(3743), new DateTime(2022, 1, 14, 1, 33, 9, 861, DateTimeKind.Local).AddTicks(2982) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 14, 1, 33, 9, 861, DateTimeKind.Local).AddTicks(4008), new DateTime(2022, 1, 14, 1, 33, 9, 861, DateTimeKind.Local).AddTicks(4014) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 14, 1, 33, 9, 862, DateTimeKind.Local).AddTicks(6696), new DateTime(2022, 1, 14, 1, 33, 9, 862, DateTimeKind.Local).AddTicks(6711) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 14, 1, 33, 9, 862, DateTimeKind.Local).AddTicks(6716), new DateTime(2022, 1, 14, 1, 33, 9, 862, DateTimeKind.Local).AddTicks(6717) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 14, 1, 33, 9, 863, DateTimeKind.Local).AddTicks(663), new DateTime(2022, 1, 14, 1, 33, 9, 863, DateTimeKind.Local).AddTicks(671) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 14, 1, 33, 9, 863, DateTimeKind.Local).AddTicks(675), new DateTime(2022, 1, 14, 1, 33, 9, 863, DateTimeKind.Local).AddTicks(676) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 14, 1, 33, 9, 863, DateTimeKind.Local).AddTicks(677), new DateTime(2022, 1, 14, 1, 33, 9, 863, DateTimeKind.Local).AddTicks(678) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 14, 1, 33, 9, 863, DateTimeKind.Local).AddTicks(680), new DateTime(2022, 1, 14, 1, 33, 9, 863, DateTimeKind.Local).AddTicks(681) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba",
                column: "ConcurrencyStamp",
                value: "bf635b26-8781-4f49-aa7a-c01613f84172");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb",
                column: "ConcurrencyStamp",
                value: "082f0d5a-5cd1-462e-95d6-2cd9db1938b3");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6ae495a2-8548-46fd-b354-f55d21c6c5b7", "AQAAAAEAACcQAAAAEATSNbsWM2p48YtXm3D/wsU7LHuEo6uRCQE/Hc8CVmWKfT5MG7MnJlCA+z79eVA81g==", "348fcbe6-1951-425f-b9a0-0ef7a47c33c9" });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 13, 21, 27, 43, 899, DateTimeKind.Local).AddTicks(1199), new DateTime(2022, 1, 13, 21, 27, 43, 899, DateTimeKind.Local).AddTicks(9417) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 13, 21, 27, 43, 900, DateTimeKind.Local).AddTicks(213), new DateTime(2022, 1, 13, 21, 27, 43, 900, DateTimeKind.Local).AddTicks(218) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 13, 21, 27, 43, 901, DateTimeKind.Local).AddTicks(393), new DateTime(2022, 1, 13, 21, 27, 43, 901, DateTimeKind.Local).AddTicks(399) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 13, 21, 27, 43, 901, DateTimeKind.Local).AddTicks(402), new DateTime(2022, 1, 13, 21, 27, 43, 901, DateTimeKind.Local).AddTicks(403) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 13, 21, 27, 43, 901, DateTimeKind.Local).AddTicks(3312), new DateTime(2022, 1, 13, 21, 27, 43, 901, DateTimeKind.Local).AddTicks(3317) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 13, 21, 27, 43, 901, DateTimeKind.Local).AddTicks(3320), new DateTime(2022, 1, 13, 21, 27, 43, 901, DateTimeKind.Local).AddTicks(3321) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 13, 21, 27, 43, 901, DateTimeKind.Local).AddTicks(3322), new DateTime(2022, 1, 13, 21, 27, 43, 901, DateTimeKind.Local).AddTicks(3323) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 13, 21, 27, 43, 901, DateTimeKind.Local).AddTicks(3324), new DateTime(2022, 1, 13, 21, 27, 43, 901, DateTimeKind.Local).AddTicks(3325) });
        }
    }
}
