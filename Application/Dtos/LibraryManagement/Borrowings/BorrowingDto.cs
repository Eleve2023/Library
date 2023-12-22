using Application.Dtos.Ouvrages;
using Domain.Entities.Persons;
using Domain.Entities.Works;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Dtos.LibraryManagement.Borrowings
{
    public class BorrowingDto
    {
        public int Id { get; set; }
        public Guid LibraryCardId { get; set; }
        public LibraryCardDto LibraryCard { get; set; } = null!;
        public string WorkCodeISBN { get; set; } = null!;
        public Work Work { get; set; } = null!;
        public DateOnly BorrowingDate { get; set; }
        public DateOnly? DateRestitution { get; set; }
        public int BorrowRuleId { get; set; }
        public BorrowRuleDto BorrowRule { get; set; } = null!;
    }
}
