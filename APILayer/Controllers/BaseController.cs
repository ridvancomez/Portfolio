using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APILayer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [AllowAnonymous]
    public class BaseController<T> : ControllerBase
    {
        private readonly IGenericService<T> _genericService;
        public BaseController(IGenericService<T> genericService)
        {
            _genericService = genericService;
        }
        [HttpGet]
        public virtual async Task<IActionResult> GetList()
        {
            var result = await _genericService.GetList();

            if (result == null || result.Count == 0)
                return NotFound("Kayıt Bulunamadı");

            return Ok(result);
        }
        [HttpGet("{id}")]
        public virtual async Task<IActionResult> GetById(int id)
        {
            var result = await _genericService.GetById(id);
            if (result == null)
                return NotFound($"ID {id} ile eşleşen veri bulunamadı.");

            return Ok(result);
        }
        [HttpPost]
        public virtual async Task<IActionResult> Add(T entity)
        {
            await _genericService.Add(entity);
            return Ok();
        }
        [HttpPut]
        public virtual async Task<IActionResult> Update(T entity)
        {
            if(entity == null)
                return BadRequest("Güncellenecek veri bulunamadı.");

            await _genericService.Update(entity);
            return NoContent();
        }
        [HttpDelete("{id}")]
        public virtual async Task<IActionResult> Delete(int id)
        {
            if(id == 0)
                return BadRequest("Silinecek veri bulunamadı.");

            await _genericService.Delete(id);

            return NoContent();
        }
    }
}
