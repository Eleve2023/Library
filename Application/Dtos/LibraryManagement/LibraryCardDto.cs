using Application.Dtos.Persons;
using Domain.Entities.Persons;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        public Guid PersonId { get; set; }
        public PersonDto Person { get; set; } = null!;
    }
}
