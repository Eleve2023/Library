using Application.Dtos.Persons;
using AutoMapper;
using Domain.Entities.Persons;
using Domain.Interfaces;

namespace Application.Services
{
    public class PersonService(IPersonRepository<PersonDto> commonRepository, IMapper mapper) : CommonService<Person, PersonDto>(commonRepository, mapper)
    {
    }

}
