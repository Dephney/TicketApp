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
    public class TripPriceController : BaseController<TripPrice>
    {
        private readonly ITripPriceRepository _tripPriceRepository;
        private readonly IBaseRepository<TripPrice> _baseRepository;
        public TripPriceController(ITripPriceRepository tripPriceRepository, IBaseRepository<TripPrice> baseRepository) : base(baseRepository)
        {
            _tripPriceRepository = tripPriceRepository;
            _baseRepository = baseRepository;
        }

      
    }
}
