using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Mapster;
using TicketApp.Infrastructure.Repository;
using TicketApp.Core.Entities;
using TicketApp.TicketAppWebAPI.DTOs;
using TicketApp.Core.Interfaces;

namespace TicketApp.TicketAppWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingController : BaseController<Booking>
    {
        private readonly IBaseRepository<Booking> _baseRepository;
        private readonly IBookingRepository _bookingRepository;

        //constructor
        public BookingController(IBookingRepository bookingRepository,IBaseRepository<Booking> baseRepository) : base(baseRepository)
        {
            _bookingRepository = bookingRepository;
            _baseRepository = baseRepository;
        }

        [HttpGet]
        [Route("[action]/{id}")]
        public async Task<IActionResult> GetBookingsByTripScheduleId(int id)
        {
            var result = await _bookingRepository.GetBookingsByTripScheduleId( id);
            var response = result.Adapt<BookingDTO>();

            return Ok(response);
        }
      
    }
}
