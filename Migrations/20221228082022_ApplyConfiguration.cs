using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SimpleEmployeeApp.Migrations
{
    public partial class ApplyConfiguration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "address", "dateOfBirth", "firstName", "lastName", "middleInitial", "socialSecurityNumber" },
                values: new object[] { 1, "3322 Davis Street Carnesville, GA 30521", new DateTime(1985, 9, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Peter", "Rowan", "E.", "671-24-6875" });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "address", "dateOfBirth", "firstName", "lastName", "middleInitial", "socialSecurityNumber" },
                values: new object[] { 2, "169 Breezewood Court Coolidge, KS 67836", new DateTime(1957, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Randall", "Hatfield", "W.", "513-12-4682" });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "address", "dateOfBirth", "firstName", "lastName", "middleInitial", "socialSecurityNumber" },
                values: new object[] { 3, "3455 Dancing Dove Lane New York, NY 10011", new DateTime(1991, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Casey", "Foster", "A.", "069-34-5134" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
