using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eShop.Data.Migrations
{
    public partial class list : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "3a5b68dc-251f-4cb5-a70c-c8a7e9702770");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f2dc078c-1654-4218-a4cb-95ac7e5bf8f5", "AQAAAAEAACcQAAAAEMh40CUdz8m9iRxRGQDoyjPby2VjfqWTLqGZSPf6+FTfeoGR2z0TQEwVMl+bMIBm8Q==" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 7, 19, 11, 7, 4, 441, DateTimeKind.Local).AddTicks(4430));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
