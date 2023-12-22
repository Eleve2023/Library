using Application.Dtos.LibraryManagement.Borrowings;
using Application.Services;
using Domain.Entities.LibraryManagement.Borrowings;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApi.Controllers
{
    [Route("api/Borrowing")]
    [ApiController]
    public class BorrowingController(BorrowingService borrowingService) : AppController<Borrowing, BorrowingDto>(borrowingService)
    {        
    }

}
