using Application.Dtos.Ouvrages;
using Application.Services;
using Domain.Entities.Works;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApi.Controllers
{
    [Route("api/Work")]
    [ApiController]
    public class WorkController(WorkService workService) : AppByStringController<Work, WorkDto>(workService)
    {        

    }

}
