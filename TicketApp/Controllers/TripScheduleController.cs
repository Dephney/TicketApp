using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Mapster;
using TicketApp.Infrastructure.Repository;
using TicketApp.Core.Entities;
using TicketApp.TicketAppWebAPI.DTOs;
using Microsoft.AspNetCore.JsonPatch;
using TicketApp.Core.Interfaces;

namespace TicketApp.TicketAppWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TripScheduleController : BaseController<TripSchedule>
    {
        private readonly ITripScheduleRepository _tripScheduleRepository;
        private readonly IBaseRepository<TripSchedule> _baseRepository;
        public TripScheduleController(ITripScheduleRepository tripScheduleRepository, IBaseRepository<TripSchedule> baseRepository) : base(baseRepository)
        {
            _tripScheduleRepository = tripScheduleRepository;
            _baseRepository = baseRepository;
        }

        [HttpGet]
        [Route("[action]/{id}")]
        public async Task<IActionResult> GetTripScheduleDetailsByTripId(int id)
        {
            var result = await _tripScheduleRepository.GetTripScheduleDetailsByTripId(id);
            var response = result.Adapt<List<TripScheduleDetailDTO>>();

            return Ok(response);
        }

        [HttpGet]
        [Route("[action]/{id}")]
        public async Task<IActionResult> GetTripScheduleDetailsByTripScheduleId(int id)
        {
            var result = await _tripScheduleRepository.GetTripScheduleDetailsByTripScheduleId(id);
            var response = result.Adapt<TripScheduleDetailDTO>();

            return Ok(response);
        }

        [HttpPatch]
        [Route("{id}")]
        public async Task<IActionResult> UpdateTripSeatsNo(int id, JsonPatchDocument tripSchedule)
        {
            await _tripScheduleRepository.UpdateTripSeatsNo(id, tripSchedule);

            return Ok();
        }
    }
}
