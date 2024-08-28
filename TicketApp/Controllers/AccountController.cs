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
    public class AccountController : BaseController<Account>
    {
        private readonly IBaseRepository<Account> _baseRepository;
        private readonly IAccountRepository _accountRepository;

        public AccountController(IAccountRepository accountRepository,IBaseRepository<Account> baseRepository) : base(baseRepository)
        {
            _baseRepository = baseRepository;
            _accountRepository = accountRepository;
        }

        [HttpGet]
        [Route("[action]/{id}")]   
        public async Task<IActionResult> GetAccountByIDNo(string id)
        {
            var result = await _accountRepository.GetAccountByIDNo(id);
            
            //if (result.)
            //{

            //}
            var response = result.Adapt<AccountDTO>();

            return Ok(response);
        }

        [HttpGet]
        [Route("[action]/{username}/{password}")]
        public async Task<IActionResult> GetAccountByUsernamePassword(string username,string password)
        {
         
            try
            {
                var result = await _accountRepository.GetAccountByUsernamePassword(username, password);
                var response = result.Adapt<AccountDTO>();

                if (response != null)
                {
                    return Ok(response);
                }
                else
                {
                    return NotFound("User not found or invalid credentials.");
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }

        }

       
    }
}
