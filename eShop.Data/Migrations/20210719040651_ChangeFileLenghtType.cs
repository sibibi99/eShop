using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eShop.Data.Migrations
{
    public partial class ChangeFileLenghtType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "32f95d61-53e3-4ec7-875b-8389e43b4441");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "086d0849-153e-4970-ab5e-bd48c1442ff1", "AQAAAAEAACcQAAAAEPfNSz4DqUo/ig+IMdJk1uYSuErQR8QciPumv9yf4iiRAz++znKa5PGN/YKAo52b0Q==" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 7, 19, 11, 6, 50, 298, DateTimeKind.Local).AddTicks(3860));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "842634fe-bb54-4277-bd00-5e846fd973e0");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e656d452-7b70-40a8-a814-ea653c74c20d", "AQAAAAEAACcQAAAAELmUA0TrcACPk/32diPMjBAm5NWJyZbXrj7fvjfKI2V4unWSZRkJaK8HweB8u2uEuA==" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 7, 19, 9, 3, 3, 533, DateTimeKind.Local).AddTicks(3600));
        }
    }
}
