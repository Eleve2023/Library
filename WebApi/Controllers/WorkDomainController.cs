using Application.Dtos.Ouvrages;
using Application.Services;
using Domain.Entities.Works;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApi.Controllers
{
    [Route("api/WorkDomain")]
    [ApiController]
    public class WorkDomainController(WorkDomainService workDomainService) : AppController<WorkDomain, WorkDomainDto>(workDomainService)
    {        
    }

}
