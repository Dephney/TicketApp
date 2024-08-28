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
    public class PaymentController : BaseController<Payment>
    {
        private readonly IPaymentRepository _paymentRepository;
        private readonly IBaseRepository<Payment> _baseRepository;
        public PaymentController(IBaseRepository<Payment> baseRepository,IPaymentRepository paymentRepository) : base(baseRepository)
        {
            _paymentRepository = paymentRepository;
            _baseRepository = baseRepository;
        }

        
    }
}
