using Application.Dtos.LibraryManagement;
using AutoMapper;
using Domain.Entities.LibraryManagement;
using Domain.Interfaces;

namespace Application.Services
{
    public class LibraryCardService(ILibraryCardRepository<LibraryCardDto> commonRepository, IMapper mapper) : CommonService<LibraryCard, LibraryCardDto>(commonRepository, mapper)
    {
    }

}
