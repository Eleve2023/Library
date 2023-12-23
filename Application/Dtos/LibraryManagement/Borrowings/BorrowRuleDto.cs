using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Dtos.LibraryManagement.Borrowings
{
    public class BorrowRuleDto
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int LoanDuration { get; set; }
        public int DelayTolerated { get; set; }
        public int ProhibitionToBorrow { get; set; }
        public int MaxBorrowing { get; set; }
        [Column(TypeName = "decimal(20, 5)")]
        public decimal FinePerDayForLateReturn { get; set; }
        [Column(TypeName = "decimal(20, 5)")]
        public decimal FineForDamage { get; set; }
        [Column(TypeName = "decimal(20, 5)")]
        public decimal PercentageToAddForLostItem { get; set; }
    }
}
