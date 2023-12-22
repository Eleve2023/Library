using Application.Dtos.Ouvrages;
using AutoMapper;
using Domain.Entities.Works;
using Domain.Interfaces;

namespace Application.Services
{
    public class WorkService(IWorkRepository<WorkDto> commonRepository, IMapper mapper) : CommonService<Work, WorkDto>(commonRepository, mapper)
    {
    }

}
