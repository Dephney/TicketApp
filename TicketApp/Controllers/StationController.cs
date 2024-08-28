using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Mapster;
using TicketApp.Core.Interfaces;
using TicketApp.Core.Entities;
using TicketApp.TicketAppWebAPI.DTOs;

namespace TicketApp.TicketAppWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StationController : BaseController<Station>
    {
        private readonly IStationRepository _stationRepository;
        private readonly IBaseRepository<Station> _baseRepository;
        public StationController(IStationRepository stationRepository,IBaseRepository<Station> baseRepository) : base(baseRepository)
        {
            _stationRepository = stationRepository;
            _baseRepository = baseRepository;
        }
   
        [HttpGet]
        [Route("[action]/{search}")]
        public IActionResult SearchStation(string search)
        {
            var result = _stationRepository.SearchStation(search);

            return Ok(result);
        }
    }
}
