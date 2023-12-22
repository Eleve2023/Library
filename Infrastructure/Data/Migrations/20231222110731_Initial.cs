using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BorrowRule",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LoanDuration = table.Column<int>(type: "int", nullable: false),
                    DelayTolerated = table.Column<int>(type: "int", nullable: false),
                    ProhibitionToBorrow = table.Column<int>(type: "int", nullable: false),
                    MaxBorrowing = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BorrowRule", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Person",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Statu = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Person", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WorkDomain",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkDomain", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WorkType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LibraryCard",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "(newid())"),
                    CreatedAt = table.Column<DateOnly>(type: "date", nullable: false),
                    ExpirationDate = table.Column<DateOnly>(type: "date", nullable: false),
                    PersonId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LibraryCard", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LibraryCard_Person_PersonId",
                        column: x => x.PersonId,
                        principalTable: "Person",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Work",
                columns: table => new
                {
                    CodeISBN = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Author = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DomainId = table.Column<int>(type: "int", nullable: false),
                    TypeId = table.Column<int>(type: "int", nullable: false),
                    IsAvailable = table.Column<bool>(type: "bit", nullable: false),
                    IsBorrowing = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Work", x => x.CodeISBN);
                    table.ForeignKey(
                        name: "FK_Work_WorkDomain_DomainId",
                        column: x => x.DomainId,
                        principalTable: "WorkDomain",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Work_WorkType_TypeId",
                        column: x => x.TypeId,
                        principalTable: "WorkType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Borrowing",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LibraryCardId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    WorkCodeISBN = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    BorrowingDate = table.Column<DateOnly>(type: "date", nullable: false),
                    DateRestitution = table.Column<DateOnly>(type: "date", nullable: true),
                    BorrowRuleId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Borrowing", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Borrowing_BorrowRule_BorrowRuleId",
                        column: x => x.BorrowRuleId,
                        principalTable: "BorrowRule",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Borrowing_LibraryCard_LibraryCardId",
                        column: x => x.LibraryCardId,
                        principalTable: "LibraryCard",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Borrowing_Work_WorkCodeISBN",
                        column: x => x.WorkCodeISBN,
                        principalTable: "Work",
                        principalColumn: "CodeISBN",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Borrowing_BorrowRuleId",
                table: "Borrowing",
                column: "BorrowRuleId");

            migrationBuilder.CreateIndex(
                name: "IX_Borrowing_LibraryCardId",
                table: "Borrowing",
                column: "LibraryCardId");

            migrationBuilder.CreateIndex(
                name: "IX_Borrowing_WorkCodeISBN",
                table: "Borrowing",
                column: "WorkCodeISBN");

            migrationBuilder.CreateIndex(
                name: "IX_LibraryCard_PersonId",
                table: "LibraryCard",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_Work_DomainId",
                table: "Work",
                column: "DomainId");

            migrationBuilder.CreateIndex(
                name: "IX_Work_TypeId",
                table: "Work",
                column: "TypeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Borrowing");

            migrationBuilder.DropTable(
                name: "BorrowRule");

            migrationBuilder.DropTable(
                name: "LibraryCard");

            migrationBuilder.DropTable(
                name: "Work");

            migrationBuilder.DropTable(
                name: "Person");

            migrationBuilder.DropTable(
                name: "WorkDomain");

            migrationBuilder.DropTable(
                name: "WorkType");
        }
    }
}
