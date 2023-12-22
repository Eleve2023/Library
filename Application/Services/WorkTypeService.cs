using Application.Dtos.Ouvrages;
using AutoMapper;
using Domain.Entities.Works;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class WorkTypeService(IWorkTypeRepository<WorkTypeDto> commonRepository, IMapper mapper) : CommonService<WorkType, WorkTypeDto>(commonRepository, mapper)
    {
    }

}
