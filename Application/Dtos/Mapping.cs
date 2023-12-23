using Application.Dtos.LibraryManagement;
using Application.Dtos.LibraryManagement.Borrowings;
using Application.Dtos.Ouvrages;
using Application.Dtos.Persons;
using AutoMapper;
using Domain.Entities.LibraryManagement;
using Domain.Entities.LibraryManagement.Borrowings;
using Domain.Entities.Persons;
using Domain.Entities.Works;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Dtos
{
    internal class Mapping : Profile
    {
        public Mapping()
        {
            CreateMap<Person, PersonDto>();
            CreateMap<PersonDto, Person>();

            CreateMap<WorkType, WorkTypeDto>();
            CreateMap<WorkTypeDto, WorkType>();

            CreateMap<WorkDomain, WorkDomainDto>();
            CreateMap<WorkDomainDto, WorkDomain>();

            CreateMap<Work, WorkDto>();
            CreateMap<WorkDto, Work>();

            CreateMap<LibraryCard, LibraryCardDto>();
            CreateMap<LibraryCardDto, LibraryCard>();
            
            CreateMap<Borrowing, BorrowingDto>();
            CreateMap<BorrowingDto, Borrowing>();
            
            CreateMap<BorrowRule, BorrowRuleDto>();
            CreateMap<BorrowRuleDto, BorrowRule>();
            
            CreateMap<BorrowingAlertView, BorrowingAlertViewDto>();
            CreateMap<BorrowingAlertViewDto, BorrowingAlertView>();

        }
    }
}
