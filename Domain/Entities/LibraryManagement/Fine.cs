using Domain.Entities.LibraryManagement.Borrowings;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.LibraryManagement
{
    // NOUVELLE CLASSE POUR GERER LES AMENDES
    public class Fine
    {
        [Key]
        public int Id { get; set; }
        public Guid LibraryCardId { get; set; }        
        public LibraryCard LibraryCard { get; set; } = null!;
        public int BorrowingId { get; set; }
        public Borrowing Borrowing { get; set; } = null!;
        [Column(TypeName = "decimal(20, 5)")]
        public decimal Amount { get; set; }
    }
}
