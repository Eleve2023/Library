using Application.Dtos.LibraryManagement.Borrowings;
using AutoMapper;
using Domain.Entities.LibraryManagement.Borrowings;
using Domain.Interfaces;

namespace Application.Services
{
    public class BorrowRuleService(IBorrowRuleRepository<BorrowRuleDto> commonRepository, IMapper mapper) : CommonService<BorrowRule, BorrowRuleDto>(commonRepository, mapper)
    {
    }

}
