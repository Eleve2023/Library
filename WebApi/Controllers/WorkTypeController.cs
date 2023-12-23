using Application.Dtos.Ouvrages;
using Application.Services;
using Domain.Entities.Works;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApi.Controllers
{
    [Route("api/WorkType")]
    [ApiController]
    public class WorkTypeController(WorkTypeService workTypeService) : AppByIntController<WorkType, WorkTypeDto>(workTypeService)
    {
        // GET: api/<ValuesController>
        [HttpGet]
        public override async Task<IEnumerable<WorkTypeDto>> Get()
        {
            return await workTypeService.GetAsync();
        }
    }

}
