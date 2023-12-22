using Application.Dtos.Ouvrages;
using Application.Services;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    public class AppController<TEntity, TModelDto>(CommonService<TEntity, TModelDto> commonService) : ControllerBase
    {
        // GET: api/<ValuesController>
        [HttpGet]
        public virtual async Task<IEnumerable<TModelDto>> Get()
        {
            return await commonService.GetAsync();
        }

        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public virtual async Task<TModelDto> Get(int id)
        {
            return await commonService.GetAsync(id);
        }

        // POST api/<ValuesController>
        [HttpPost]
        public virtual async Task Post([FromBody] TModelDto workTypeDto)
        {
            await commonService.AddAsync(workTypeDto);
        }

        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public virtual async Task Put(int id, [FromBody] TModelDto workTypeDto)
        {
            await commonService.UpdateAsync(id, workTypeDto);
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public virtual async Task Delete(int id)
        {
            await commonService.DeleteAsync(id);
        }
    }
}
