using Application.Dtos.Persons;
using Application.Helpe;
using Domain.Entities.Persons;
using Infrastructure.Data;

namespace WebApi.Services
{
    public class PersonRepository(AppDbContext appDbContext, MapperHelpe mapper) :
        CommonRepository<Person, PersonDto>(appDbContext, mapper), Domain.Interfaces.IPersonRepository<PersonDto>
    {

    }

}
