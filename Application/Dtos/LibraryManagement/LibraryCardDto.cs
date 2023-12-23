using Application.Dtos.Persons;
using Domain.Entities.LibraryManagement.Borrowings;
using Domain.Entities.LibraryManagement;
using Domain.Entities.Persons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Dtos.LibraryManagement
{
    public class LibraryCardDto
    {
        public Guid Id { get; set; }
        public DateOnly CreatedAt { get; set; }
        public DateOnly ExpirationDate { get; set; }
        public int PersonId { get; set; }
        public PersonDto? Person { get; set; } = null!;
    }
}
