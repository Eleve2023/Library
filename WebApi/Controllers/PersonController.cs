using Application.Dtos.Persons;
using Application.Services;
using Domain.Entities.Persons;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApi.Controllers
{
    [Route("api/Person")]
    [ApiController]
    public class PersonController(PersonService personService) : AppController<Person, PersonDto>(personService)
    {        
    }

}
