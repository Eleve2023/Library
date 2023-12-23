using Application.Dtos.LibraryManagement.Borrowings;
using Application.Services;
using Domain.Entities.LibraryManagement.Borrowings;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApi.Controllers
{
    [Route("api/BorrowRule")]
    [ApiController]
    public class BorrowRuleController(BorrowRuleService borrowRuleService) : AppByIntController<BorrowRule, BorrowRuleDto>(borrowRuleService)
    {        
    }

}
