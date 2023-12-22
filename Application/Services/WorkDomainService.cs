using Application.Dtos.Ouvrages;
using AutoMapper;
using Domain.Entities.Works;
using Domain.Interfaces;

namespace Application.Services
{
    public class WorkDomainService(IWorkDomainRepository<WorkDomainDto> commonRepository, IMapper mapper) : CommonService<WorkDomain, WorkDomainDto>(commonRepository, mapper)
    {
    }

}
