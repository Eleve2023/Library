using Application.Dtos.LibraryManagement.Borrowings;
using Application.Helpe;
using Domain.Entities.LibraryManagement.Borrowings;
using Infrastructure.Data;

namespace WebApi.Services
{
    public class BorrowingAlertViewRepository(AppDbContext appDbContext, MapperHelpe mapper) :
        CommonRepository<BorrowingAlertView, BorrowingAlertViewDto>(appDbContext, mapper), Domain.Interfaces.IBorrowingAlertViewRepository<BorrowingAlertViewDto>
    {

    }

}
