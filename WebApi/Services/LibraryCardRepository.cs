using Application.Dtos.LibraryManagement;
using Application.Helpe;
using Domain.Entities.LibraryManagement;
using Infrastructure.Data;

namespace WebApi.Services
{
    public class LibraryCardRepository(AppDbContext appDbContext, MapperHelpe mapper) : 
        CommonRepository<LibraryCard, LibraryCardDto>(appDbContext, mapper), Domain.Interfaces.ILibraryCardRepository<LibraryCardDto>
    {

    }

}
