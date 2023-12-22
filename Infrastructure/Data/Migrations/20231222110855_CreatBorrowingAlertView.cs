using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class CreatBorrowingAlertView : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
CREATE VIEW BorrowingAlertView AS
SELECT 
    b.LibraryCardId AS CardId,
    p.FirstName,
    p.LastName,
    w.Title AS WorkTitle,
    DATEDIFF(day, b.BorrowingDate, GETDATE()) AS DaysBorrowed,
	  DATEDIFF(day, b.DateRestitution, GETDATE()) AS DaysAfterRestution,
	 ( d.ProhibitionToBorrow - DATEDIFF(day, b.DateRestitution, GETDATE())  ) AS DaysEndProhibition
FROM 
    Borrowing b
INNER JOIN 
    LibraryCard l ON b.LibraryCardId = l.Id
INNER JOIN 
    Person p ON l.PersonId = p.Id
INNER JOIN 
    Work w ON b.WorkCodeISBN = w.CodeISBN
INNER JOIN 
    BorrowRule d ON b.BorrowRuleId = d.Id
WHERE 
    (b.DateRestitution IS NULL AND DATEDIFF(day, b.BorrowingDate, GETDATE()) > d.LoanDuration) 
	OR (DATEDIFF(day, b.BorrowingDate, GETDATE()) + d.LoanDuration + d.DelayTolerated > DATEDIFF(day, b.BorrowingDate, b.DateRestitution) AND DATEDIFF(day, b.DateRestitution, GETDATE()) < d.ProhibitionToBorrow ) ;
");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DROP VIEW BorrowingAlertView");
        }
    }
}
