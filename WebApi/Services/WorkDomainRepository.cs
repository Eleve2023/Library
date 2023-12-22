using Application.Dtos.Ouvrages;
using Application.Helpe;
using Domain.Entities.Works;
using Infrastructure.Data;

namespace WebApi.Services
{
    public class WorkDomainRepository(AppDbContext appDbContext, MapperHelpe mapper) : CommonRepository<WorkDomain, WorkDomainDto>(appDbContext, mapper), Domain.Interfaces.IWorkDomainRepository<WorkDomainDto>
    {

    }

}
