using Microsoft.AspNetCore.Mvc;
using TicketApp.Infrastructure.Repository;
using TicketApp.Core.Entities;
using TicketApp.TicketAppWebAPI.DTOs;
using TicketApp.Core.Interfaces;

namespace TicketApp.TicketAppWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BaseController<T> : ControllerBase where T : BaseEntity
    {
        private readonly IBaseRepository<T> _baseRepository;

        public BaseController(IBaseRepository<T> baseRepository)
        {
            _baseRepository = baseRepository;
        }


            [HttpGet]
            public async Task<ActionResult<IEnumerable<T>>> GetAll()
            {
                var items = await _baseRepository.GetAll();
                return Ok(items);
            }

            [HttpGet("{id}")]
            public async Task<ActionResult<T>> GetById(int id)
            {
                var item = await _baseRepository.GetById(id);
                if (item == null)
                {
                    return NotFound();
                }
                return Ok(item);
            }

            [HttpPost]
            public async Task<ActionResult<T>> Add([FromBody] T obj)
            {
                if (obj == null)
                {
                    return BadRequest();
                }
                var createdItem = await _baseRepository.Add(obj);
                return Ok(createdItem);
            // return CreatedAtAction(nameof(GetById), new { id = createdItem.Id }, createdItem);
        }

            [HttpPut("{id}")]   
            public async Task<ActionResult<T>> Update(int id, [FromBody] T obj)
            {
                if (obj == null || id == 0)
                {
                    return BadRequest();
                }
                var updatedItem = await _baseRepository.Update(obj);
                return Ok(updatedItem);
            }

            [HttpDelete("{id}")]
            public async Task<IActionResult> Delete(int id)
            {
                await _baseRepository.DeleteById(id);
                return NoContent();
            }
        }

}
