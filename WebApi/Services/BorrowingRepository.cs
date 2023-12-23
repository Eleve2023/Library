using Application.Dtos.LibraryManagement.Borrowings;
using Application.Helpe;
using Domain.Entities.LibraryManagement.Borrowings;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace WebApi.Services
{
    public class BorrowingRepository(AppDbContext appDbContext, MapperHelpe mapper) :
        CommonRepository<Borrowing, BorrowingDto>(appDbContext, mapper), Domain.Interfaces.IBorrowingRepository<BorrowingDto>
    {

    }

}
