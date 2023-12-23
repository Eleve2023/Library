using Application.Dtos.Ouvrages;
using Application.Services;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    public class AppBaseController<TEntity, TModelDto>(CommonService<TEntity, TModelDto> commonService) : ControllerBase
    {
        protected readonly CommonService<TEntity, TModelDto> commonService = commonService;

        // GET: api/<ValuesController>
        [HttpGet]
        public virtual async Task<IEnumerable<TModelDto>> Get()
        {
            return await commonService.GetAsync();
        }     

        // POST api/<ValuesController>
        [HttpPost]
        public virtual async Task Post([FromBody] TModelDto workTypeDto)
        {
            await commonService.AddAsync(workTypeDto);
        }
        
    }
}
