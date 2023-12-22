using Application.Dtos.LibraryManagement.Borrowings;
using AutoMapper;
using Domain.Entities.LibraryManagement.Borrowings;
using Domain.Interfaces;

namespace Application.Services
{
    public class BorrowingAlertViewService(IBorrowingAlertViewRepository<BorrowingAlertViewDto> commonRepository, IMapper mapper) : CommonService<BorrowingAlertView, BorrowingAlertViewDto>(commonRepository, mapper)
    {
    }

}
