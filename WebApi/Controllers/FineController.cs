using Application.Dtos.LibraryManagement;
using Application.Services;
using Domain.Entities.LibraryManagement;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApi.Controllers
{
    [Route("api/Fine")]
    [ApiController]
    public class FineController(FineService fineService) : AppByIntController<Fine, FineDto>(fineService)
    {
    }

}
