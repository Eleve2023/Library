using Application.Dtos.LibraryManagement.Borrowings;
using Application.Helpe;
using Domain.Entities.LibraryManagement.Borrowings;
using Infrastructure.Data;

namespace WebApi.Services
{
    public class BorrowRuleRepository(AppDbContext appDbContext, MapperHelpe mapper) :
        CommonRepository<BorrowRule, BorrowRuleDto>(appDbContext, mapper), Domain.Interfaces.IBorrowRuleRepository<BorrowRuleDto>
    {

    }

}
