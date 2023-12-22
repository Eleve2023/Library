using Domain.Entities.Persons;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.LibraryManagement
{
    public class LibraryCard
    {
        [Key] public Guid Id { get; set; }
        public DateOnly CreatedAt { get; set; }
        public DateOnly ExpirationDate { get; set; } = new DateOnly().AddYears(1);
        public int PersonId { get; set; }
        public Person Person { get; set; } = null!;
    }
}
