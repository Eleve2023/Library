using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class NewRules : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "Value",
                table: "Work",
                type: "decimal(20,5)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "FineForDamage",
                table: "BorrowRule",
                type: "decimal(20,5)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "FinePerDayForLateReturn",
                table: "BorrowRule",
                type: "decimal(20,5)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "PercentageToAddForLostItem",
                table: "BorrowRule",
                type: "decimal(20,5)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.CreateTable(
                name: "Fine",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LibraryCardId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BorrowingId = table.Column<int>(type: "int", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(20,5)", nullable: false),
                    BorrowingId1 = table.Column<int>(type: "int", nullable: true),
                    LibraryCardId1 = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fine", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Fine_Borrowing_BorrowingId",
                        column: x => x.BorrowingId,
                        principalTable: "Borrowing",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Fine_Borrowing_BorrowingId1",
                        column: x => x.BorrowingId1,
                        principalTable: "Borrowing",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Fine_LibraryCard_LibraryCardId",
                        column: x => x.LibraryCardId,
                        principalTable: "LibraryCard",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Fine_LibraryCard_LibraryCardId1",
                        column: x => x.LibraryCardId1,
                        principalTable: "LibraryCard",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Fine_BorrowingId",
                table: "Fine",
                column: "BorrowingId");

            migrationBuilder.CreateIndex(
                name: "IX_Fine_BorrowingId1",
                table: "Fine",
                column: "BorrowingId1");

            migrationBuilder.CreateIndex(
                name: "IX_Fine_LibraryCardId",
                table: "Fine",
                column: "LibraryCardId");

            migrationBuilder.CreateIndex(
                name: "IX_Fine_LibraryCardId1",
                table: "Fine",
                column: "LibraryCardId1");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Fine");

            migrationBuilder.DropColumn(
                name: "Value",
                table: "Work");

            migrationBuilder.DropColumn(
                name: "FineForDamage",
                table: "BorrowRule");

            migrationBuilder.DropColumn(
                name: "FinePerDayForLateReturn",
                table: "BorrowRule");

            migrationBuilder.DropColumn(
                name: "PercentageToAddForLostItem",
                table: "BorrowRule");
        }
    }
}
