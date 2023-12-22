using Application.Dtos.Ouvrages;
using Application.Helpe;
using Domain.Entities.Works;
using Infrastructure.Data;

namespace WebApi.Services
{
    public class WorkRepository(AppDbContext appDbContext, MapperHelpe mapper) : CommonRepository<Work, WorkDto>(appDbContext, mapper), Domain.Interfaces.IWorkRepository<WorkDto>
    {

    }

}
