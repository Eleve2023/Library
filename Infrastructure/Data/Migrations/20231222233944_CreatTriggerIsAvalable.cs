using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class CreatTriggerIsAvalable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
CREATE TRIGGER UpdateIsAvailable ON Borrowing
AFTER INSERT, UPDATE
AS
BEGIN
    DECLARE @WorkCodeISBN varchar(15);
    DECLARE @IsAvailable bit;

    SELECT @WorkCodeISBN = WorkCodeISBN, @IsAvailable = CASE WHEN DateRestitution IS NULL THEN 0 ELSE 1 END
    FROM inserted;

    UPDATE Work
    SET IsAvailable = @IsAvailable
    WHERE CodeISBN = @WorkCodeISBN;
END;
");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DROP TRIGGER UpdateIsAvailable");
        }
    }
}
