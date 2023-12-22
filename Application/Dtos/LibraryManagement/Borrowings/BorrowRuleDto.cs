using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
    }
}
