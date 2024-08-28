using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Mapster;
using TicketApp.Infrastructure.Repository;
using TicketApp.Core.Entities;
using TicketApp.TicketAppWebAPI.DTOs;
using Microsoft.AspNetCore.Http.HttpResults;
using TicketApp.Core.Interfaces;

namespace TicketApp.TicketAppWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TripController : BaseController<Trip>
    {
        private readonly ITripRepository _tripRepository;
        private readonly IBaseRepository<Trip> _baseRepository;
        public TripController(ITripRepository tripRepository, IBaseRepository<Trip> baseRepository) : base(baseRepository)
        {
            _tripRepository = tripRepository;
            _baseRepository = baseRepository;
        }

        [HttpGet]
        [Route("[action]/{departureStation}/{arrivalStation}")]
        public async Task<IActionResult> GetTripByStations(string departureStation, string arrivalStation)
        {
            var result = await _tripRepository.GetTripByStations(departureStation, arrivalStation);
            var response = result.Adapt<TripDTO>();

            return Ok(response);
        }

       
    }
}
