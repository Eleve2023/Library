using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.LibraryManagement.Borrowings
{
    
    public class BorrowingAlertView
    {
        public Guid CardId { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string WorkTitle { get; set; } = null!;
        public int DaysBorrowed { get; set; } 
    }
}
