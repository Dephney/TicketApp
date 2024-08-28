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
    public class TripStationController : BaseController<TripStation>
    {
        private readonly ITripStationRepository _tripStationRepository;
        private readonly IBaseRepository<TripStation> _baseRepository;
        public TripStationController(ITripStationRepository tripStationRepository, IBaseRepository<TripStation> baseRepository) : base(baseRepository)
        {
            _tripStationRepository = tripStationRepository;
            _baseRepository = baseRepository;
        }
       
        [HttpGet]
        [Route("[action]/{id}")]

        public async Task<IActionResult> GetTripStationsByTripId(int id)
        {
            var results = await _tripStationRepository.GetTripStationsByTripId(id); //results returned from this service might be an object or a collection - map the results correctly --NB!! NOT DONE
            var response = results.Adapt<List<TripStationDTO>>();

            return Ok(response);

            //// Check if results is a collection or a single object
            //if (results is IEnumerable<TripStation> tripStationCollection)
            //{
            //    // Map the collection to a list of DTOs
            //    var response = tripStationCollection.Adapt<List<TripStationDTO>>();
            //    return Ok(response);
            //}
            //else if (results is TripStation tripStationObject)
            //{
            //    // Map the single object to a DTO
            //    var response = tripStationObject.Adapt<TripStationDTO>();
            //    return Ok(response);
            //}

            //return BadRequest("Unexpected result type");
        }

        [HttpGet]
        [Route("[action]/{id}")]
        public async Task<IActionResult> GetTripStationNamesByTripId(int id)
        {
            var results = await _tripStationRepository.GetTripStationNamesByTripId(id); 
            var response = results.Adapt<List<StationNameDTO>>();

            return Ok(response);

        }
    }

}

