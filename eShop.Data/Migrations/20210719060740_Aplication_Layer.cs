using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eShop.Data.Migrations
{
    public partial class Aplication_Layer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "2f35ca90-f25e-4a2c-9a2e-276f263ff722");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "d4068ecd-6190-4140-a1d2-c4e663206732", "AQAAAAEAACcQAAAAEHYkF4NHWWzgUtzv6Y/6e6lNeTthtANkDc6s5mW36fv1jYIbb5HvrTy5XJR9aXd+HA==" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 7, 19, 13, 7, 39, 118, DateTimeKind.Local).AddTicks(5510));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
