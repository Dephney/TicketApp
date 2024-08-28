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
    public class TrainController : BaseController<Train>
    {
        private readonly ITrainRepository _trainRepository;
        private readonly IBaseRepository<Train> _baseRepository;
        public TrainController(ITrainRepository trainRepository, IBaseRepository<Train> baseRepository) : base(baseRepository)
        {
            _trainRepository = trainRepository;
            _baseRepository = baseRepository;
        }

        [HttpGet]
        [Route("[action]/{num}")]
        public async Task<IActionResult> GetTrainByNo(int num)
        {
            var result = await _trainRepository.GetTrainByNo(num);
            var response = result.Adapt<TrainDTO>();

            return Ok(response);
        }
    }
}
