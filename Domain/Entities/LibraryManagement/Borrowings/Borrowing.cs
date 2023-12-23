using Domain.Entities.LibraryManagement;
using Domain.Entities.Persons;
using Domain.Entities.Works;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.LibraryManagement.Borrowings
{
    public class Borrowing
    {
        public int Id { get; set; }
        public Guid LibraryCardId { get; set; }
        public LibraryCard LibraryCard { get; set; } = null!;
        public string WorkCodeISBN { get; set; } = null!;
        public Work Work { get; set; } = null!;
        public DateOnly BorrowingDate { get; set; }
        public DateOnly? DateRestitution { get; set; }
        public int BorrowRuleId { get; set; }
        // REGLE DE GESTION : Ajout de la règle d'emprunt
        public BorrowRule BorrowRule { get; set; } = null!;
        public virtual ICollection<Fine> Fines { get; set; } = Array.Empty<Fine>();
    }
}
