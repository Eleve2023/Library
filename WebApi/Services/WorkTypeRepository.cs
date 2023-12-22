using Application.Dtos.Ouvrages;
using Application.Helpe;
using Domain.Entities.Works;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;

namespace WebApi.Services
{
    public class WorkTypeRepository(AppDbContext appDbContext, MapperHelpe mapper) :CommonRepository<WorkType, WorkTypeDto>(appDbContext, mapper) , Domain.Interfaces.IWorkTypeRepository<WorkTypeDto>
    {        
       
    }

}
