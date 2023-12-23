using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Application.Dtos.LibraryManagement.Borrowings;

namespace Application.Dtos.LibraryManagement
{
    public class FineDto
    {
        [Key]
        public int Id { get; set; }
        public Guid LibraryCardId { get; set; }
        public LibraryCardDto? LibraryCard { get; set; } = null!;
        public int BorrowingId { get; set; }
        public BorrowingDto? Borrowing { get; set; } = null!;
        [Column(TypeName = "decimal(20, 5)")]
        public decimal Amount { get; set; }
    }
}
