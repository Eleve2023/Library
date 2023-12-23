using Application.Dtos.LibraryManagement;
using Application.Helpe;
using Domain.Entities.LibraryManagement;
using Infrastructure.Data;

namespace WebApi.Services
{
    public class FineRepository(AppDbContext appDbContext, MapperHelpe mapper) :
        CommonRepository<Fine, FineDto>(appDbContext, mapper), Domain.Interfaces.IFineRepository<FineDto>
    {

    }

}
