using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Lajada.Domain.Migrations
{
    public partial class m1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Personal_Information",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    MiddleName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Surname = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personal_Information", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Login",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Personal_Information_Id = table.Column<int>(type: "int", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Login", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Login_Personal_Information_Personal_Information_Id",
                        column: x => x.Personal_Information_Id,
                        principalTable: "Personal_Information",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Personal_Information",
                columns: new[] { "Id", "Address", "Age", "DateOfBirth", "FirstName", "Gender", "MiddleName", "Surname", "Title" },
                values: new object[] { 1, "Madaue City", 23, new DateTime(2000, 8, 17, 9, 22, 11, 0, DateTimeKind.Unspecified), "John", "Male", "Admin", "Doe", "Mr." });

            migrationBuilder.InsertData(
                table: "Login",
                columns: new[] { "Id", "Password", "Personal_Information_Id", "UserName" },
                values: new object[] { 1, "aB1?abc", 1, "ADMIN" });

            migrationBuilder.CreateIndex(
                name: "IX_Login_Personal_Information_Id",
                table: "Login",
                column: "Personal_Information_Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Login");

            migrationBuilder.DropTable(
                name: "Personal_Information");
        }
    }
}
