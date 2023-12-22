namespace Application.Dtos.LibraryManagement.Borrowings
{
    public class BorrowingAlertViewDto
    {
        public Guid CardId { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string WorkTitle { get; set; } = null!;
        public int DaysBorrowed { get; set; }
    }
}
