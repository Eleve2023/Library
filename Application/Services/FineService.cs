using Application.Dtos.LibraryManagement;
using AutoMapper;
using Domain.Entities.LibraryManagement;
using Domain.Interfaces;

namespace Application.Services
{
    public class FineService(IFineRepository<FineDto> commonRepository, IMapper mapper) : CommonService<Fine, FineDto>(commonRepository, mapper)
    {
        public override Task<object> AddAsync(FineDto modelDto)
        {
            // todo : gestion des amende
            return base.AddAsync(modelDto);
        }
    }

}
