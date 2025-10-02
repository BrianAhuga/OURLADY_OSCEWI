using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace APIServices.Migrations
{
    /// <inheritdoc />
    public partial class PupilsEnrollment : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PupilEnrollments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    ClassApplyingFor = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    FormerSchool = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    ParentGuardian = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    ParentEmail = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ParentPhone = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    AddressLine1 = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    AddressLine2 = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Country = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    HasOtherChildren = table.Column<bool>(type: "bit", nullable: false),
                    OtherChildrenDetails = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PupilEnrollments", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PupilEnrollments");
        }
    }
}
