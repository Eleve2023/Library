using Application.Services;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    public class AppByIntController<TEntity, TModelDto>(CommonService<TEntity, TModelDto> commonService) : AppBaseController<TEntity, TModelDto>(commonService)
    {
        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public virtual async Task<TModelDto> Get(int id)
        {
            return await commonService.GetAsync(id);
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
